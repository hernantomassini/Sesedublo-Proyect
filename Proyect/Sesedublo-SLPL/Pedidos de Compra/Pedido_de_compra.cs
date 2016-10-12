using MetroFramework.Forms;
using Sesedublo_SLPL.Generales;
using System;
using System.ComponentModel;

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

        private void AgregarPedidoTile_Click(object sender, EventArgs e)
        {
            Manejador_Formularios.AddPedidoCompra.Clean();
            Manejador_Formularios.AddPedidoCompra.Show();
        }

        private void modificarPedidoTile_Click(object sender, EventArgs e)
        {

        }

        private void Pedido_de_compra_Load(object sender, EventArgs e)
        {

        }

        private void AtrasTile_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
