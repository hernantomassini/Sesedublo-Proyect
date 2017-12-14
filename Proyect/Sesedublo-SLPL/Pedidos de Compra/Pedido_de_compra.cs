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
            MySqlDataReader reader = Conexion.executeProcedureWithReader("cargarPedidoCompras", Conexion.generarArgumentos("_nombre"), nombre.Text);

            while (reader.Read())
            {
                PedidosDGV.Rows.Add(reader.GetInt32(0), reader.GetString(1), reader.GetDateTime(2).ToShortDateString(), reader.GetString(3), reader.GetDecimal(4), reader.GetDecimal(5), this.verSiONoDec(reader.GetInt32(5)), reader.GetString(6));
            }

            this.PedidosDGV.Columns[2].Width = 300;
            reader.Close();
            Conexion.closeConnection();
        }

        private object verSiONoDec(int valor)
        {
            if (valor == 0)
            {
                return "SI";
            }
            else
            {
                return "NO";
            }
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

            decimal precioP = Convert.ToDecimal(filaDgv.Cells[4].Value);
            decimal debeP = Convert.ToDecimal(filaDgv.Cells[5].Value);

            if (Convert.ToString(filaDgv.Cells[7].Value) == "SI")
            {
                Manejador_Formularios.MostrarPedidoCompra.mostrarPedido(id_pedido);
                Manejador_Formularios.MostrarPedidoCompra.Show();
            }
            else
            {

                if (Convert.ToString(filaDgv.Cells[7].Value) == "SI")
                {
                    Funciones.imprimirMensajeDeError("No se puede modificar un pedido de compra que ya ha sido pasado a stock", this);
                    return;
                }

                if (Decimal.Compare(debeP, precioP) != 0)
                {
                    Funciones.imprimirMensajeDeError("No se puede modificar un pedido de compra que ya ha sido empezado a pagarse, contacte a su administrador", this);
                    return;
                }

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

            if (Convert.ToInt32(filaDgv.Cells[5].Value) == 0)
            {
                Funciones.imprimirMensajeDeError("Se le pagó al proveedor todo lo acordado según lo que puso previamente", this);
            }
            else
            {
                int id_pedidoLea = Convert.ToInt32(filaDgv.Cells[0].Value);

                Manejador_Formularios.Actualizar_PedidoDeCompra.cargarDatos(id_pedidoLea);
                Manejador_Formularios.Actualizar_PedidoDeCompra.Show();

                this.cargarDGV();
            }
        }

        private void CargarStockTile_Click(object sender, EventArgs e)
        {
            DataGridViewRow filaDgv = PedidosDGV.CurrentRow;

            if (!Validaciones.validarFilaMarcada(filaDgv, this))
            {
                return;
            }

            if (filaDgv.Cells[7].Value.ToString() == "SI")
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
                if (Convert.ToString(Myrow.Cells[6].Value) == "SI")// Or your condition 
                {
                    Myrow.Cells[6].Style.BackColor = System.Drawing.Color.Green;
                }
                else
                {
                    Myrow.Cells[6].Style.BackColor = System.Drawing.Color.Red;

                }

                if (Convert.ToString(Myrow.Cells[7].Value) == "SI")// Or your condition 
                {
                    Myrow.Cells[7].Style.BackColor = System.Drawing.Color.Green;
                }
                else
                {
                    Myrow.Cells[7].Style.BackColor = System.Drawing.Color.Red;

                }

                Myrow.Cells[7].Style.ForeColor = System.Drawing.Color.White;
                Myrow.Cells[6].Style.ForeColor = System.Drawing.Color.White;
            }

            PedidosDGV.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            PedidosDGV.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            foreach (DataGridViewRow Myrow in PedidosDGV.Rows)
            {            //Here 2 cell is target value and 1 cell is Volume
                Myrow.Cells[0].Style.BackColor = System.Drawing.Color.OrangeRed;
                Myrow.Cells[0].Style.ForeColor = System.Drawing.Color.White;
            }
        }

        private void titleCancelar_Click(object sender, EventArgs e)
        {
            DataGridViewRow filaMarcada = PedidosDGV.CurrentRow;

            if (filaMarcada.Cells[7].Value.ToString() == "SI")
            {
                Funciones.imprimirMensajeDeError("Ya se cargo el stock de este pedido de compra, no puede eliminarse", this);
                return;
            }

            if (filaMarcada.Cells[6].Value.ToString() == "SI")
            {
                Funciones.imprimirMensajeDeError("El siguiente pedido de compra ya ha sido pagado, no puede eliminarse", this);
                return;
            }

            if (!this.validarFilaMarcada(filaMarcada, this))
            {
                return;
            }

            if (Decimal.Compare(Convert.ToInt32(filaMarcada.Cells[5].Value), Convert.ToDecimal(filaMarcada.Cells[4].Value)) != 0)
            {
                Funciones.imprimirMensajeDeError("Se le empezó a pagar al proveedor lo acordado, contacte al administrador para borrar este pedido", this);
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

        private void metroTile3_Click(object sender, EventArgs e)
        {
            Manejador_Formularios.Historial_de_Deudas_Compras.cargarDGV();
            Manejador_Formularios.Historial_de_Deudas_Compras.Show();
        }
    }
}
