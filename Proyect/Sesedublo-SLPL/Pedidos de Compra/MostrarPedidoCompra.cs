using iTextSharp.text;
using iTextSharp.text.pdf;
using MetroFramework.Forms;
using MySql.Data.MySqlClient;
using Sesedublo_SLPL.Generales;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace Sesedublo_SLPL.Pedidos_de_Compra
{
    public partial class MostrarPedidoCompra : MetroForm
    {
        Funciones fun = new Funciones();

        public MostrarPedidoCompra()
        {
            InitializeComponent();
            this.Closing += new CancelEventHandler(Avoid_Closing);
        }

        void Avoid_Closing(object sender, CancelEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
            Manejador_Formularios.Pedido_de_compra.Show();
        }

        public void mostrarPedido(int id_pedido)
        {
            Clean();

            cargarDatos(id_pedido);
            updateLabel();
        }

        private void updateLabel()
        {
            decimal costoTotal = obtenerCostoDelDGV();
            costoSumatoriaLabel.Text = "Costo Total: " + costoTotal;
        }

        public void Clean()
        {
            dgvPedido.Rows.Clear();
        }

        private decimal obtenerCostoDelDGV()
        {
            decimal sum = 0;
            decimal costoPorUnidad;
            int cantUnidades;

            for (int i = 0; i < dgvPedido.Rows.Count; i++)
            {
                costoPorUnidad = Convert.ToDecimal(dgvPedido.Rows[i].Cells[2].Value);
                cantUnidades = obtenerCantidadEnInt(dgvPedido.Rows[i].Cells[5].Value.ToString());

                sum += costoPorUnidad * cantUnidades;
            }

            return sum;
        }

        private int obtenerCantidadEnInt(string cantidad)
        {
            int large = cantidad.IndexOf(" ");
            return Convert.ToInt32(cantidad.Substring(0, large));
        }

        private void cargarDatos(int id_pedidoLea)
        {
            Funciones.limpiarDGV(dgvPedido);

            MySqlDataReader reader = Conexion.executeProcedureWithReader("obtenerItemsDeLea", Conexion.generarArgumentos("_id_pedidoLea"), id_pedidoLea);

            int cantXBulto;
            string nombre;
            decimal costo;
            decimal PVUnitario;
            decimal PVBulto;
            int cantidad;
            int radioSelected = 0;

            string cantidadString;
            decimal utilidad = 0;

            while (reader.Read())
            {
                cantXBulto = reader.GetInt32(0);
                nombre = reader.GetString(1);
                costo = reader.GetDecimal(2);
                PVUnitario = reader.GetDecimal(3);
                PVBulto = reader.GetDecimal(4);
                cantidad = reader.GetInt32(5);
                radioSelected = reader.GetInt32(6);

                cantidadString = cantidad + " unidades";
                utilidad = PVUnitario - costo;

                if (radioSelected == 2)
                {
                    utilidad = Decimal.Round((PVBulto - (costo / cantXBulto)) / cantXBulto, 2);
                    cantidadString = cantidad + " bultos de " + cantXBulto + " unidades";

                    //Utilidad = (PrecioBulto - costoUnitario) / cantBotellas
                    //12 = (169 - 25) / 12
                }

                if (radioSelected == 3)
                {
                    utilidad = PVBulto - costo;
                    cantidadString = cantidad + " bultos de " + cantXBulto + " unidades";
                }

                dgvPedido.Rows.Add(cantXBulto, nombre, costo, PVUnitario, PVBulto, cantidadString, utilidad, radioSelected);
            }

            reader.Close();
            Conexion.closeConnection();
        }

        private void MostrarPedidoCompra_Load(object sender, EventArgs e)
        {

        }

        private void CerrarTile_Click(object sender, EventArgs e)
        {
            Close();
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
                fun.GenerarDocumento(doc, this.dgvPedido);
                doc.Close();
                Process.Start(filename);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvPedido_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dgvPedido.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPedido.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
    }
}
