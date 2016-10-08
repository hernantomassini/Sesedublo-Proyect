using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sesedublo_SLPL.Administrar_Pedidos
{
    public partial class ABM_Pedidos : MetroForm
    {
        public ABM_Pedidos()
        {
            InitializeComponent();
            this.Closing += new CancelEventHandler(Avoid_Closing);
        }

        void Avoid_Closing(object sender, CancelEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void AtrasTile_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void EliminarPedidoTile_Click(object sender, EventArgs e)
        {
        }

        private void modificarPedidoTile_Click(object sender, EventArgs e)
        {

        }

        private void AgregarPedidoTile_Click(object sender, EventArgs e)
        {

        }

        private void FacturarPedidoTile_Click(object sender, EventArgs e)
        {

        }
    }
}
