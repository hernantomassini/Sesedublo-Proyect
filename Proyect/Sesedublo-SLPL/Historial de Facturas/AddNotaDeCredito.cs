using MetroFramework.Forms;
using MySql.Data.MySqlClient;
using Sesedublo_SLPL.Generales;
using System;
using System.ComponentModel;
using System.Data;
using System.Text;

namespace Sesedublo_SLPL.Historial_de_Facturasns
{
    public partial class AddNotaDeCredito : MetroForm
    {
        int id_factura = -1;
        Validaciones val = new Validaciones();
        StringBuilder st = new StringBuilder();

        public AddNotaDeCredito()
        {
            InitializeComponent();
            this.Closing += new CancelEventHandler(Avoid_Closing);
        }

        void Avoid_Closing(object sender, CancelEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void AddNotaDeCredito_Load(object sender, EventArgs e)
        {

        }

        public void agregarNotaCredito(int id_factura)
        {
            this.id_factura = id_factura;
        }

        public void getData()
        {
            MySqlDataAdapter da = Conexion.executeProcedureWithAdapter("obtenerItemsDeFactura", Conexion.generarArgumentos("_id_factura"), id_factura);
            DataTable tablaDeFacturas = new DataTable("Factura");
            da.Fill(tablaDeFacturas);
            dgvVerFactura.DataSource = tablaDeFacturas.DefaultView;

            Conexion.closeConnection();
        }


        private void titleCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void titleAceptar_Click(object sender, EventArgs e)
        {
            val.validarNoVacio(Cantidad,st);
            val.validarNoVacio(Motivo, st);

            if (st.Length > 0)
            {
                Funciones.imprimirMensajeDeError(st.ToString(), this);
                st = new StringBuilder();
            }
            else
            {
                 Conexion.executeProcedure("agregarNotaDeCredito", Conexion.generarArgumentos("_id_factura", "_cantidad", "_motivo"), id_factura, Convert.ToDecimal(Cantidad.Text), Motivo.Text);
                 Conexion.closeConnection();
                 Manejador_Formularios.VerRegistroFactura.cargarRegistro(id_factura);
                 this.Close();
            }
        }

    }
}
