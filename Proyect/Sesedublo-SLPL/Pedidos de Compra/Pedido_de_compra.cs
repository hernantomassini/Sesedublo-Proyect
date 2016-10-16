using MetroFramework.Forms;
using MySql.Data.MySqlClient;
using Sesedublo_SLPL.Generales;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Sesedublo_SLPL.Pedidos_de_Compra
{
    public partial class Pedido_de_compra : MetroForm
    {
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
                PedidosDGV.Rows.Add(reader.GetInt32(0), reader.GetDateTime(1).ToShortDateString(), reader.GetString(2), reader.GetDecimal(3));
            }

            reader.Close();
            Conexion.closeConnection();
        }

        private void AgregarPedidoTile_Click(object sender, EventArgs e)
        {
            Manejador_Formularios.AddPedidoCompra.CrearPedido();
            Manejador_Formularios.AddPedidoCompra.Show();
        }

        private void modificarPedidoTile_Click(object sender, EventArgs e)
        {
            DataGridViewRow filaDgv = PedidosDGV.CurrentRow;

            if (!Validaciones.validarFilaMarcada(filaDgv, this))
            {
                return;
            }

            int id_pedidoLea = Convert.ToInt32(filaDgv.Cells[0].Value);

            Manejador_Formularios.AddPedidoCompra.modificarPedido(id_pedidoLea);
            Manejador_Formularios.AddPedidoCompra.Show();
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
            DataGridViewRow filaDgv = PedidosDGV.CurrentRow;
            if (Convert.ToInt32(filaDgv.Cells[5].Value) == 1)
            {
                Funciones.imprimirMensajeDeError("No puede modificar un pedido que ya ha sido facturado, sólo modificar su monto del debe", this);
                return;
            }

            int id_pedido = Convert.ToInt32(filaDgv.Cells[0].Value);

            Manejador_Formularios.AddProductoAPedido.modificarPedido(id_pedido);
            Manejador_Formularios.AddProductoAPedido.Show();
            Close();
        }
    }
}
