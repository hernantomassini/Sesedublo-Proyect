using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sesedublo_SLPL.Administrar_Stock
{
    public partial class AddProducto : Form
    {
        public object Manejador_Formulario { get; private set; }

        public AddProducto()
        {
            InitializeComponent();
            this.Closing += new CancelEventHandler(Avoid_Closing);
        }

        void Avoid_Closing(object sender, CancelEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void AddProducto_Load(object sender, EventArgs e)
        {

        }

        internal void AgregarProducto()
        {
            throw new NotImplementedException();
        }

        internal void ModificarProducto(int id_stock)
        {
            throw new NotImplementedException();
        }

        private void AtrasBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
