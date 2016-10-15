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
            MySqlDataAdapter da = Conexion.executeProcedureWithAdapter("obtenerItemsDeFacturaSinNC", Conexion.generarArgumentos("_id_factura"), id_factura);
            DataTable tablaDeFacturas = new DataTable("Factura");
            da.Fill(tablaDeFacturas);
            dgvVerFactura.DataSource = tablaDeFacturas.DefaultView;

            Nombre.Text = dgvVerFactura.Rows[0].Cells[1].Value.ToString();
            dgvVerFactura.Columns[0].Visible = false;
            Cantidad.Clear();
            Motivo.Clear();
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
                int cantidad = Convert.ToInt32(Cantidad.Text);
                if( cantidad > Convert.ToInt32(this.dgvVerFactura.CurrentRow.Cells[2].Value) ){
                Funciones.imprimirMensajeDeError("No se puede realizar una nota de credito mayor a los items que posee sin nota de credito", this);
                return;
                }
                decimal monto = 0;
                decimal precioBultovich = Convert.ToDecimal(this.dgvVerFactura.CurrentRow.Cells[4].Value);
                if (precioBultovich > 0)
                {
                    monto = Convert.ToDecimal(Cantidad.Text) * precioBultovich;
                }
                else
                {
                    monto = Convert.ToDecimal(Cantidad.Text) * Convert.ToDecimal(this.dgvVerFactura.CurrentRow.Cells[3].Value);

                }
                Conexion.executeProcedure("agregarNotaDeCredito", Conexion.generarArgumentos("_id_factura", "_cantidad", "_motivo"), id_factura, Math.Floor(decimal.Round(monto, 2)), Motivo.Text);
                 Conexion.closeConnection();
                 Manejador_Formularios.VerRegistroFactura.cargarRegistro(id_factura);
                
                int id_producto = Convert.ToInt32(this.dgvVerFactura.CurrentRow.Cells[0].Value);

                 Conexion.executeProcedure("agregarCantidad", Conexion.generarArgumentos("_id_producto", "_cantidad", "_id_factura"), id_producto, Convert.ToInt32(Cantidad.Text), id_factura);
                 Conexion.closeConnection();
                 this.Close();
            }
        }

        private void dgvVerFactura_CellContentClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            Nombre.Text = dgvVerFactura.CurrentRow.Cells[1].Value.ToString();
        }

        private void dgvVerFactura_CellClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            Nombre.Text = dgvVerFactura.CurrentRow.Cells[1].Value.ToString();
        }

    }
}
