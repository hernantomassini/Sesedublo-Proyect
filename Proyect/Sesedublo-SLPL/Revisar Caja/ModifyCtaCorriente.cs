using MetroFramework.Forms;
using Sesedublo_SLPL;
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

namespace Sesedublo_reloaded.Revisar_Caja
{
    public partial class ModifyCtaCorriente : MetroForm
    {
        Validaciones val = new Validaciones();
        StringBuilder st = new StringBuilder();

        public ModifyCtaCorriente()
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
            Conexion.executeProcedure("agregarCtaCorriente", Conexion.generarArgumentos("_montoASumar", "_descripcion"), Convert.ToDecimal(Monto.Text), Motivo.Text);
            Conexion.closeConnection();
        }

        private void restarEfectivo()
        {
            Conexion.executeProcedure("restarCtaCorriente", Conexion.generarArgumentos("_montoARestar", "_descripcion"), Convert.ToDecimal(Monto.Text), Motivo.Text);
            Conexion.closeConnection();
        }

        private void AtrasTile_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AceptarTIle_Click(object sender, EventArgs e)
        {
            val.validarNoVacio(Monto, st);
            val.validarNoVacio(Motivo, st);

            if (st.Length > 0)
            {
                Funciones.imprimirMensajeDeError(st.ToString(), this);
                st = new StringBuilder();
            }
            else
            {
                if (Sumar.Checked)
                    agregarEfectivo();
                else
                    restarEfectivo();

                Monto.Clear();
                Motivo.Clear();
                Close();
            }
        }

        public void Clean()
        {
            Monto.Clear();
            Motivo.Clear();
            Sumar.Checked = true;
        }

        private void Cantidad_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            val.ingresarNumeroDecimal(e);
        }

        private void descripcion_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            val.ingresarNombre(e);
        }
    }
}
