using System;
using System.ComponentModel;
using MetroFramework.Forms;
using Sesedublo_SLPL.Generales;

namespace Sesedublo_SLPL.Revisar_Caja
{
    public partial class ModifyCash : MetroForm
    {
        public ModifyCash()
        {
            InitializeComponent();
            this.Closing += new CancelEventHandler(Avoid_Closing);
        }

        void Avoid_Closing(object sender, CancelEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
            Manejador_Formularios.Monto_Caja.Show();
        }

        private void ModifyCash_Load(object sender, EventArgs e)
        {

        }

        private void agregarEfectivo()
        {
            Conexion.executeProcedure("agregarEfectivo", Conexion.generarArgumentos("_montoASumar", "_descripcion"), Convert.ToDecimal(Cantidad.Text), descripcion.Text);
            Conexion.closeConnection();
        }

        private void restarEfectivo()
        {
            Conexion.executeProcedure("restarEfectivo", Conexion.generarArgumentos("_montoARestar", "_descripcion"), Convert.ToDecimal(Cantidad.Text), descripcion.Text);
            Conexion.closeConnection();
        }

        private void AtrasTile_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AceptarTIle_Click(object sender, EventArgs e)
        {
            if (Sumar.Checked)
                agregarEfectivo();
            else
                restarEfectivo();

            Close();
        }

        public void Clean()
        {
            Cantidad.Clear();
        }
    }
}