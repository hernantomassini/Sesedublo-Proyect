using MetroFramework.Forms;
using MySql.Data.MySqlClient;
using Sesedublo_SLPL.Generales;
using System;
using System.ComponentModel;

namespace Sesedublo_SLPL.Revisar_Cajans
{
    public partial class Monto_Caja : MetroForm
    {
        public Monto_Caja()
        {
            InitializeComponent();
            this.Closing += new CancelEventHandler(Avoid_Closing);
        }

        void Avoid_Closing(object sender, CancelEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void Monto_Caja_Load(object sender, EventArgs e)
        {

        }

        private void AtrasTile_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void updatearLabels()
        {
            updateMontoEfectivo();
            updateMontoProductos();
            updateMontoCtaCorriente();
        }

        public void updateMontoEfectivo()
        {
            MySqlDataReader reader = Conexion.executeProcedureWithReader("obtenerMontoEnEfectivo", Conexion.generarArgumentos());
            reader.Read();

            decimal montoEnEfectivo = decimal.Round(reader.GetDecimal(0), 2);

            reader.Close();
            Conexion.closeConnection();

            EfectivoLabel.Text = "Usted posee " + montoEnEfectivo + "$ en efectivo.";
        }

        public void updateMontoCtaCorriente()
        {
            MySqlDataReader reader = Conexion.executeProcedureWithReader("obtenerMontoCtaCorriente", Conexion.generarArgumentos());
            reader.Read();

            decimal montoEnCuentaCorriente = decimal.Round(reader.GetDecimal(0), 2);

            reader.Close();
            Conexion.closeConnection();

            metroLabel1.Text = "Usted posee " + montoEnCuentaCorriente + "$ en cta. corriente";
        }

        private void updateMontoProductos()
        {
            MySqlDataReader reader = Conexion.executeProcedureWithReader("obtenerMontoEnProductos", Conexion.generarArgumentos());
            reader.Read();

            decimal montoEnProductos;

            if (reader.IsDBNull(0))
                montoEnProductos = 0;
            else
                montoEnProductos = decimal.Round(reader.GetDecimal(0), 2);

            reader.Close();
            Conexion.closeConnection();

            MercaderiaLabel.Text = "Usted posee " + montoEnProductos + "$ en productos.";
        }

        private void ModificarEfectivo_Click(object sender, EventArgs e)
        {
            Manejador_Formularios.ModifyCash.Clean();
            Manejador_Formularios.ModifyCash.Show();
            Close();
        }

        private void splitContainer1_Panel1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {

        }

        private void ctaCorrienteTile_Click(object sender, EventArgs e)
        {
            Manejador_Formularios.ModifyCtaCorriente.Clean();
            Manejador_Formularios.ModifyCtaCorriente.Show();
            Close();
        }
    }
}
