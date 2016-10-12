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

namespace Sesedublo_SLPL.Pedidos_de_Compra
{
    public partial class NuevoProducto : MetroForm
    {
        public NuevoProducto()
        {
            InitializeComponent();
        }

        private void titleCancelar_Click(object sender, EventArgs e)
        {
            this.Closing += new CancelEventHandler(Avoid_Closing);
        }

        void Avoid_Closing(object sender, CancelEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void titleAceptar_Click(object sender, EventArgs e)
        {
            Conexion.executeProcedure("agregarNuevoProducto", Conexion.generarArgumentos("_nombre"),buscarProducto.Text);
            Conexion.closeConnection();
            this.Hide();
        }
    }
}
