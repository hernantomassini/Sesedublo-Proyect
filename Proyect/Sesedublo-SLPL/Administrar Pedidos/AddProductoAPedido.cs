using System;
using MetroFramework.Forms;
using System.ComponentModel;

namespace Sesedublo_SLPL.Administrar_Pedidos
{
    public partial class AddProductoAPedido : MetroForm
    {
        public AddProductoAPedido()
        {
            InitializeComponent();
            this.Closing += new CancelEventHandler(Avoid_Closing);
        }

        void Avoid_Closing(object sender, CancelEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void AddProductoAPedido_Load(object sender, EventArgs e)
        {

        }
    }
}
