using MetroFramework.Forms;
using Sesedublo_SLPL.Generales;
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
        Validaciones val = new Validaciones();
        StringBuilder st = new StringBuilder();
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
            val.validarNoVacio(Nombre, st);

            if (st.Length > 0)
            {
                Funciones.imprimirMensajeDeError(st.ToString(), this);
                st = new StringBuilder();
            }
            else
            {
                Conexion.executeProcedure("agregarNuevoProducto", Conexion.generarArgumentos("_nombre"), Nombre.Text);
                Conexion.closeConnection();
                Nombre.Clear();
                this.Hide();
            }
        }
    }
}
