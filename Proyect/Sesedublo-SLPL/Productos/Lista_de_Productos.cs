using iTextSharp.text;
using iTextSharp.text.pdf;
using MetroFramework.Forms;
using MySql.Data.MySqlClient;
using Sesedublo_SLPL.Generales;
using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace Sesedublo_SLPL.Productos
{
    public partial class Lista_de_Productos : MetroForm
    {
        Funciones fun = new Funciones();

        public Lista_de_Productos()
        {
            InitializeComponent();
            this.Closing += new CancelEventHandler(Avoid_Closing);
        }

        public void getData()
        {
            MySqlDataAdapter da = Conexion.executeProcedureWithAdapter("obtenerLista", Conexion.generarArgumentos("_nombre"), nombre.Text);
            DataTable tablaDeUsuarios = new DataTable("Clientes");
            da.Fill(tablaDeUsuarios);
            dgvProductos.DataSource = tablaDeUsuarios.DefaultView;
            dgvProductos.Columns[0].Visible = false;
            dgvProductos.Columns[6].Visible = false;

            Conexion.closeConnection();
        }

                  

        void Avoid_Closing(object sender, CancelEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void titleAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void titleAgregarCliente_Click(object sender, EventArgs e)
        {
            Manejador_Formularios.Producto_Nuevo.Clean();
            Manejador_Formularios.Producto_Nuevo.Show();
        }

        private void nombre_TextChanged(object sender, EventArgs e)
        {
            MySqlDataAdapter da = Conexion.executeProcedureWithAdapter("obtenerLista", Conexion.generarArgumentos("_nombre"), nombre.Text);
            DataTable tablaDeUsuarios = new DataTable("Clientes");
            da.Fill(tablaDeUsuarios);
            dgvProductos.DataSource = tablaDeUsuarios.DefaultView;

            Conexion.closeConnection();
        }

        private void Lista_de_Productos_Load(object sender, EventArgs e)
        {

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            try
            {
                Document doc = new Document(PageSize.A4.Rotate(), 10, 10, 10, 10);

                string filename = this.Text + ".pdf";
                FileStream file = new FileStream(filename, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
                PdfWriter.GetInstance(doc, file);
                doc.Open();
                fun.GenerarDocumento(doc, this.dgvProductos);
                doc.Close();
                Process.Start(filename);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvProductos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dgvProductos.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvProductos.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvProductos.Columns[1].Width = 250;
        }

        private void titleCancelar_Click(object sender, EventArgs e)
        {
            DataGridViewRow filaMarcada = dgvProductos.CurrentRow;

            if (!this.validarFilaMarcada(filaMarcada, this))
            {
                return;
            }

            if (Funciones.imprimirMensajeDeAlerta("¿Estás seguro de borrar a este Producto? Esta acción no se podrá deshacer.", this) == DialogResult.Cancel)
            {
                return;
            }

            int id_producto = Convert.ToInt32(dgvProductos.SelectedCells[0].Value);

            string query = " UPDATE ListaDeProductos SET deleted = 1 where id_listPro=" + id_producto;


            string nombre = Convert.ToString(dgvProductos.SelectedCells[1].Value);

            Conexion.ejecutarNonQuery(query);
            Conexion.closeConnection();
            Funciones.imprimirMensajeDeAviso("Se elimino al producto " + nombre, this);
            this.getData();
        }

        private bool validarFilaMarcada(DataGridViewRow filaMarcada, MetroForm form)
        {
            if (filaMarcada == null)
            {
                Funciones.imprimirMensajeDeError("Debe seleccionar un producto para dicha acción.", form);
                return false;
            }

            return true;
        }

        private void dgvProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewRow filaMarcada = dgvProductos.CurrentRow;

            if (!this.validarFilaMarcada(filaMarcada, this))
            {
                return;
            }

            int id_producto = Convert.ToInt32(dgvProductos.SelectedCells[0].Value);
            string producto = Convert.ToString(dgvProductos.SelectedCells[1].Value);

            Manejador_Formularios.Modificar_Nombre.Clean();
            Manejador_Formularios.Modificar_Nombre.Show();
            Manejador_Formularios.Modificar_Nombre.modificarProducto(id_producto, producto);
        }
    }
}
