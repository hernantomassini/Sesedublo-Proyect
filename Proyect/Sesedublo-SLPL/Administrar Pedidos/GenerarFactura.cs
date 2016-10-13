using MetroFramework.Forms;
using Sesedublo_SLPL.Generales;
using System;
using System.ComponentModel;

namespace Sesedublo_SLPL.Administrar_Pedidos
{
    public partial class GenerarFactura : MetroForm
    {
        int id_pedido = -1;

        public GenerarFactura()
        {
            InitializeComponent();
            this.Closing += new CancelEventHandler(Avoid_Closing);
            startUp();
        }

        void Avoid_Closing(object sender, CancelEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void GenerarFactura_Load(object sender, EventArgs e)
        {

        }

        public void crearFactura(int id_pedido)
        {
            this.id_pedido = id_pedido;
        }

        private void startUp()
        {
            tipoDeFactura.SelectedIndex = 0;
        }

        private void AceptarTile_Click(object sender, EventArgs e)
        {
            Conexion.executeProcedure("generarFactura", Conexion.generarArgumentos("_id_pedido", "_tipoFactura"), id_pedido, tipoDeFactura.Text);
            Conexion.closeConnection();

            //Si se descomenta esta línea, va a aparecer la ventana transparente random!
            //Funciones.imprimirMensajeDeAviso("La factura se generó correctamente.", this);
            Manejador_Formularios.ABM_Pedidos.cargarDGV();
            Close();

        }

        private void AtrasTile_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
