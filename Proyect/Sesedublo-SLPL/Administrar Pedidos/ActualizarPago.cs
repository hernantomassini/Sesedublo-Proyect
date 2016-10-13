using MetroFramework.Forms;
using MySql.Data.MySqlClient;
using Sesedublo_SLPL.Generales;
using System;
using System.ComponentModel;


namespace Sesedublo_SLPL.Administrar_Pedidos
{
    public partial class ActualizarPago : MetroForm
    {
        int id_pedido = -1;

        public ActualizarPago()
        {
            InitializeComponent();
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
            Conexion.executeProcedureWithReader("actualizarPago", Conexion.generarArgumentos("_id_pedido", "_total_a_pagar", "_cantidad_paga"), id_pedido, Convert.ToDecimal(cantidadAPagar.Text), Convert.ToDecimal(cantidadPagada.Text));
            Conexion.closeConnection();
            Manejador_Formularios.ABM_Pedidos.cargarDGV();
            Close();
        }

        private void CancelarTile_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
