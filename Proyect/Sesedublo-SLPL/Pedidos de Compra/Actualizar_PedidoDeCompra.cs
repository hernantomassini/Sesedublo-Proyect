using MetroFramework.Forms;
using MySql.Data.MySqlClient;
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
    public partial class Actualizar_PedidoDeCompra : MetroForm
    {
        int id_pedidoDeLea;
        Validaciones val = new Validaciones();

        public Actualizar_PedidoDeCompra()
        {
            InitializeComponent();
            Caja.Checked = true;
            this.Closing += new CancelEventHandler(Avoid_Closing);
        }

        void Avoid_Closing(object sender, CancelEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }
        private void titleCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cantidadAPagar_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            val.ingresarNumeroDecimal(e);
        }

        private void cantidadPagada_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            val.ingresarNumeroDecimal(e);
        }

        private void titleAceptar_Click(object sender, EventArgs e)
        {
            int pagadoTot = 0;
            int cajaOcc = 0;
            if (pagadoCheck.Checked)
            {
                pagadoTot = 1;
            }

            if (Caja.Checked)
                cajaOcc = 0;
            else
                cajaOcc = 1;

            if (Convert.ToDecimal(cantidadPagada.Text) > Convert.ToDecimal(cantidadAPagar.Text))
            {
                Funciones.imprimirMensajeDeError("La cantidad que paga el cliente debe ser menor a la que debe", this);
                return;
            }

            Conexion.executeProcedureWithReader("actualizarPagoDeLea", Conexion.generarArgumentos("_id_pedido", "_total_a_pagar", "_cantidad_paga", "_pagadoTot","_cajaOcc"), id_pedidoDeLea, Convert.ToDecimal(cantidadAPagar.Text), Convert.ToDecimal(cantidadPagada.Text), pagadoTot, cajaOcc);
            Conexion.closeConnection();
            Manejador_Formularios.Pedido_de_compra.cargarDGV();
            Close();
        }

        internal void cargarDatos(int id_pedidoLea)
        {
            id_pedidoDeLea = id_pedidoLea;
            cantidadAPagar.Enabled = false;
            pagadoCheck.Checked = false;

            MySqlDataReader reader = Conexion.executeProcedureWithReader("cargarDatosActualizarPagoDeLea", Conexion.generarArgumentos("_id_pedido"), id_pedidoDeLea);
            reader.Read();

            cantidadAPagar.Text = reader.GetString(0);
            cantidadPagada.Text = reader.GetString(1);

            reader.Close();
            Conexion.closeConnection();
        }
    }
}
