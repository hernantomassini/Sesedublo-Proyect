
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
            MySqlDataReader reader = Conexion.executeProcedureWithReader("cargarPedidoCompras", Conexion.generarArgumentos("_nombre"),nombre.Text);

            while (reader.Read())
            {
                PedidosDGV.Rows.Add(reader.GetInt32(0),reader.GetString(1), reader.GetDateTime(2).ToShortDateString(), reader.GetString(3), reader.GetDecimal(4), reader.GetString(5), reader.GetString(6));
            }

            this.PedidosDGV.Columns[2].Width = 300;
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
            

            if(Convert.ToString(filaDgv.Cells[6].Value) == "SI")
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

            if (filaDgv.Cells[5].Value.ToString() == "SI")
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

            if (filaDgv.Cells[6].Value.ToString() == "SI")
            {
                Funciones.imprimirMensajeDeError("Ya se cargo el stock de este pedido.", this);
                return;
            }

            if (Funciones.imprimirMensajeDeAlerta("¿Estás seguro de cargar el stock de este pedido?", this) == DialogResult.Cancel)
            {
                return;
            }

            int id_pedidoLea = Convert.ToInt32(filaDgv.Cells[0].Value);
            int tipo = 0;
            Conexion.executeProcedure("cargarStockPedidoLea", Conexion.generarArgumentos("_id_pedido", "_tipo"), id_pedidoLea, tipo);
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

        private void nombre_TextChanged(object sender, EventArgs e)
        {
            this.cargarDGV();
        }

        private void PedidosDGV_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow Myrow in PedidosDGV.Rows)
            {            //Here 2 cell is target value and 1 cell is Volume
                if (Convert.ToString(Myrow.Cells[5].Value) == "SI")// Or your condition 
                {
                    Myrow.Cells[5].Style.BackColor = System.Drawing.Color.Green;
                }
                else
                {
                    Myrow.Cells[5].Style.BackColor = System.Drawing.Color.Red;

                }

                if (Convert.ToString(Myrow.Cells[6].Value) == "SI")// Or your condition 
                {
                    Myrow.Cells[6].Style.BackColor = System.Drawing.Color.Green;
                }
                else
                {
                    Myrow.Cells[6].Style.BackColor = System.Drawing.Color.Red;

                }

                Myrow.Cells[6].Style.ForeColor = System.Drawing.Color.White;
                Myrow.Cells[5].Style.ForeColor = System.Drawing.Color.White;
            }

            foreach (DataGridViewRow Myrow in PedidosDGV.Rows)
            {            //Here 2 cell is target value and 1 cell is Volume
                Myrow.Cells[0].Style.BackColor = System.Drawing.Color.OrangeRed;
                Myrow.Cells[0].Style.ForeColor = System.Drawing.Color.White;
            }

            PedidosDGV.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            PedidosDGV.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void titleCancelar_Click(object sender, EventArgs e)
        {
            DataGridViewRow filaMarcada = PedidosDGV.CurrentRow;

            if (filaMarcada.Cells[6].Value.ToString() == "SI")
            {
                Funciones.imprimirMensajeDeError("Ya se cargo el stock de este pedido, no puede eliminarse", this);
                return;
            }

            if (filaMarcada.Cells[5].Value.ToString() == "SI")
            {
                Funciones.imprimirMensajeDeError("El siguiente pedido ya ha sido pagado, no puede eliminarse", this);
                return;
            }

            if (!this.validarFilaMarcada(filaMarcada, this))
            {
                return;
            }

            if (Funciones.imprimirMensajeDeAlerta("¿Estás seguro de borrar a este Pedido de Compra? Esta acción no se podrá deshacer.", this) == DialogResult.Cancel)
            {
                return;
            }

            int id_pedido = Convert.ToInt32(PedidosDGV.SelectedCells[0].Value);

            string query = " UPDATE PedidosDeLea SET deleted = 1 where id_pedido=" + id_pedido;

            Conexion.ejecutarNonQuery(query);
            Conexion.closeConnection();
            Funciones.imprimirMensajeDeAviso("Se elimino el pedido nro #" + id_pedido, this);
            this.cargarDGV();
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
    }
}
