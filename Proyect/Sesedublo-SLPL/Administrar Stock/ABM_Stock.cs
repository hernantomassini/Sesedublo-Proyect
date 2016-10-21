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

namespace Sesedublo_SLPL.Administrar_Productos
{
    public partial class ABM_Stock : MetroForm
    {
        Funciones fun = new Funciones();
        Validaciones val = new Validaciones();
        public ABM_Stock()
        {
            InitializeComponent();
            this.Closing += new CancelEventHandler(Avoid_Closing);
            cargarDGV();
        }

        void Avoid_Closing(object sender, CancelEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void AgregarProductoStockBtn_Click(object sender, EventArgs e)
        {
            Manejador_Formularios.AddProducto.AgregarProducto();
            Manejador_Formularios.AddProducto.Show();
        }

        private void modificarProductoStockBtn_Click(object sender, EventArgs e)
        {
            DataGridViewRow filaDgv = StockDGV.CurrentRow;

            if (!Validaciones.validarFilaMarcada(filaDgv,this))
            {
                return;
            }

            int id_stock = Convert.ToInt32(filaDgv.Cells[0].Value);

            Manejador_Formularios.AddProducto.ModificarProducto(id_stock);
            Manejador_Formularios.AddProducto.Show();
        }

        private void EliminarProductoStockBtn_Click(object sender, EventArgs e)
        {
            DataGridViewRow filaDgv = StockDGV.CurrentRow;

            if (!Validaciones.validarFilaMarcada(filaDgv, this))
            {
                return;
            }

            if (Funciones.imprimirMensajeDeAlerta("¿Estás seguro de borrar este producto? Esta acción no se podrá deshacer.", this) == DialogResult.Cancel)
            {
                return;
            }

            int id_stock = Convert.ToInt32(filaDgv.Cells[0].Value);

            Conexion.executeProcedure("borrarStock", Conexion.generarArgumentos("_id_stock"), id_stock);
            Conexion.closeConnection();

            cargarDGV();
        }

        public void cargarDGV()
        {
            Funciones.limpiarDGV(StockDGV);
            MySqlDataReader reader = Conexion.executeProcedureWithReader("obtenerStock", Conexion.generarArgumentos("_nombre"), nombre.Text);
            string cantidad;
            int cantXBulto;

            while(reader.Read())
            {
                cantXBulto = reader.GetInt32(2);

                if (cantXBulto == 0)
                    cantidad = reader.GetString(1) + " unidades";
                else
                    cantidad = reader.GetString(1) + " bultos de " + cantXBulto + " unidades";

                //ID Stock 0 - Cantidad 1 - Nombre 3 - Costo unitario 4 - Costo total x - PVU 5 - PVB 6 
                StockDGV.Rows.Add(reader.GetInt32(0), cantidad, reader.GetString(3), reader.GetDecimal(4), reader.GetDecimal(4) * reader.GetDecimal(1), reader.GetDecimal(5), reader.GetDecimal(6));
            }

            reader.Close();
            Conexion.closeConnection();
        }

        private void nombre_TextChanged(object sender, EventArgs e)
        {
            this.cargarDGV();
        }

        private void AtrasButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void Clean()
        {
            nombre.Clear();
        }

        private void ABM_Stock_Load(object sender, EventArgs e)
        {

        }

        private void StockDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaDgv = StockDGV.CurrentRow;

            int id_stock = Convert.ToInt32(filaDgv.Cells[0].Value);

            Manejador_Formularios.AddProducto.ModificarProducto(id_stock);
            Manejador_Formularios.AddProducto.Show();
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
                fun.GenerarDocumento(doc, this.metroGrid1);
                doc.Close();
                Process.Start(filename);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void cargarDGVMetro()
        {
            MySqlDataAdapter da = Conexion.executeProcedureWithAdapter("obtenerStock", Conexion.generarArgumentos("_nombre"), nombre.Text);
            DataTable tablaDeUsuarios = new DataTable("Clientes");
            da.Fill(tablaDeUsuarios);
            metroGrid1.DataSource = tablaDeUsuarios.DefaultView;
            metroGrid1.Columns[0].Visible = false;

            Conexion.closeConnection();
        }



    }
}
