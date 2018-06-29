using MetroFramework.Forms;
using MySql.Data.MySqlClient;
using Sesedublo_SLPL.Generales;
using System;
using System.ComponentModel;


namespace Sesedublo_SLPL.Administrar_Pedidos
{
    public partial class ActualizarPago : MetroForm
    {
        Validaciones val = new Validaciones();
        int id_pedido = -1;

        public ActualizarPago()
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

        public void cargarDatos(int id_pedido)
        {
            this.id_pedido = id_pedido;
            cantidadAPagar.Enabled = false;
            pagadoCheck.Checked = false;

            MySqlDataReader reader = Conexion.executeProcedureWithReader("cargarDatosActualizarPago", Conexion.generarArgumentos("_id_pedido"), id_pedido);
            reader.Read();

            cantidadAPagar.Text = reader.GetString(0);
            cantidadPagada.Text = reader.GetString(1);

            reader.Close();
            Conexion.closeConnection();
        }

        private void ActualizarPago_Load(object sender, EventArgs e)
        {

        }

        private void AceptarTile_Click(object sender, EventArgs e)
        {
            int pagadoTot = 0;
            int cajaOcc = 0;
            if(pagadoCheck.Checked){
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

            Conexion.executeProcedureWithReader("actualizarPago", Conexion.generarArgumentos("_id_pedido", "_total_a_pagar", "_cantidad_paga","_pagadoTot","_cajaOcc"), id_pedido, Convert.ToDecimal(cantidadAPagar.Text), Convert.ToDecimal(cantidadPagada.Text), pagadoTot, cajaOcc);
            Conexion.closeConnection();
            Manejador_Formularios.ABM_Pedidos.cargarDGV();
            Close();
        }

        private void CancelarTile_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cantidadAPagar_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            val.ingresarNumeroDecimal(e);
        }

        private void cantidadPagada_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
        }
    }
}
