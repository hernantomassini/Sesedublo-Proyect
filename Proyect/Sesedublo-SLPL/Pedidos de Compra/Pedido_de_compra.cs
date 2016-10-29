
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
    public partial class Pedido_de_compra : MetroForm
    {
        Funciones fun = new Funciones();
        public Pedido_de_compra()
        {
            InitializeComponent();
            this.Closing += new CancelEventHandler(Avoid_Closing);
        }

        void Avoid_Closing(object sender, CancelEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        public void cargarDGV()
        {
            Funciones.limpiarDGV(PedidosDGV);
            MySqlDataReader reader = Conexion.executeProcedureWithReader("cargarPedidoCompras", Conexion.generarArgumentos());

            while (reader.Read())
            {
                PedidosDGV.Rows.Add(reader.GetInt32(0),reader.GetString(1), reader.GetDateTime(2).ToShortDateString(), reader.GetString(3), reader.GetDecimal(4), reader.GetString(5), reader.GetString(6));
            }

            reader.Close();
            Conexion.closeConnection();
        }

        private void AgregarPedidoTile_Click(object sender, EventArgs e)
        {
            Manejador_Formularios.Elegir_Proveedor.Clean();
            Manejador_Formularios.Elegir_Proveedor.getData();
            Manejador_Formularios.Elegir_Proveedor.Show();
        }

        private void modificarPedidoTile_Click(object sender, EventArgs e)
        {
            modificarPedido();
        }

        private void Pedido_de_compra_Load(object sender, EventArgs e)
        {

        }

        private void AtrasTile_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PedidosDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            modificarPedido();
        }

        private void modificarPedido()
        {
            DataGridViewRow filaDgv = PedidosDGV.CurrentRow;

            int id_pedido = Convert.ToInt32(filaDgv.Cells[0].Value);
            

            if(Convert.ToString(filaDgv.Cells[6].Value) == "Si")
            {
                Manejador_Formularios.MostrarPedidoCompra.mostrarPedido(id_pedido);
                Manejador_Formularios.MostrarPedidoCompra.Show();
            }
            else
            {
                Manejador_Formularios.AddPedidoCompra.modificarPedido(id_pedido);
                Manejador_Formularios.AddPedidoCompra.Show();
            }


            Close();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            DataGridViewRow filaDgv = PedidosDGV.CurrentRow;

            if (!Validaciones.validarFilaMarcada(filaDgv, this))
            {
                return;
            }

            if (filaDgv.Cells[5].Value.ToString() == "Si")
            {
                Funciones.imprimirMensajeDeError("El siguiente pedido ya ha sido pagado", this);
                return;
            }

            if (Funciones.imprimirMensajeDeAlerta("¿Estás seguro de pagar este pedido?", this) == DialogResult.Cancel)
            {
                return;
            }

            int id_pedidoLea = Convert.ToInt32(filaDgv.Cells[0].Value);
            Conexion.executeProcedure("cobrarPedidoDeLea", Conexion.generarArgumentos("_id_pedido"), id_pedidoLea);
            Conexion.closeConnection();

            this.cargarDGV();
        }

        private void CargarStockTile_Click(object sender, EventArgs e)
        {
            DataGridViewRow filaDgv = PedidosDGV.CurrentRow;

            if (!Validaciones.validarFilaMarcada(filaDgv, this))
            {
                return;
            }

            if (filaDgv.Cells[6].Value.ToString() == "Si")
            {
                Funciones.imprimirMensajeDeError("Ya se cargo el stock de este pedido.", this);
                return;
            }

            if (Funciones.imprimirMensajeDeAlerta("¿Estás seguro de cargar el stock de este pedido?", this) == DialogResult.Cancel)
            {
                return;
            }

            int id_pedidoLea = Convert.ToInt32(filaDgv.Cells[0].Value);
            Conexion.executeProcedure("cargarStockPedidoLea", Conexion.generarArgumentos("_id_pedido"), id_pedidoLea);
            Conexion.closeConnection();

            this.cargarDGV();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            try
            {
                Document doc = new Document(PageSize.A4.Rotate(), 10, 10, 10, 10);

                string filename = this.Text + ".pdf";
                FileStream file = new FileStream(filename, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
                PdfWriter.GetInstance(doc, file);
                doc.Open();
                fun.GenerarDocumento(doc, this.PedidosDGV);
                doc.Close();
                Process.Start(filename);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
