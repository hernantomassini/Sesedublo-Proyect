using MetroFramework.Forms;
using MySql.Data.MySqlClient;
using Sesedublo_SLPL.Generales;
using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace Sesedublo_SLPL.Historial_de_Facturasns
{
    public partial class Historial_de_Facturas : MetroForm
    {

        Validaciones val = new Validaciones();
        public Historial_de_Facturas()
        {
            InitializeComponent();
            this.Closing += new CancelEventHandler(Avoid_Closing);
            this.getData();
        }

        private void Historial_de_Facturas_Load(object sender, EventArgs e)
        {

        }

        void Avoid_Closing(object sender, CancelEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void titleDetalleFactura_Click(object sender, EventArgs e)
        {
            DataGridViewRow filaMarcada = dgvFacturas.CurrentRow;

            if (!this.validarFilaMarcada(filaMarcada, this))
            {
                return;
            }

            int idFactura = Convert.ToInt32(dgvFacturas.SelectedCells[0].Value);
            int idCliente = Convert.ToInt32(dgvFacturas.SelectedCells[1].Value);
            Manejador_Formularios.Ver_Factura.meterId(idFactura, idCliente);
            Manejador_Formularios.Ver_Factura.Show();
            this.Hide();
        }

        private bool validarFilaMarcada(DataGridViewRow filaMarcada, MetroForm form)
        {
            if (filaMarcada == null)
            {
                Funciones.imprimirMensajeDeError("Debe seleccionar un cliente para dicha acción.", form);
                return false;
            }

            return true;
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        public void getData()
        {
            MySqlDataAdapter da = Conexion.executeProcedureWithAdapter("cargarGrillaFacturas", Conexion.generarArgumentos("_nombre", "_apellido", "_descripcion", "_direccion"), nombre.Text, apellido.Text, descripcion.Text, direccion.Text);
            DataTable tablaDeUsuarios = new DataTable("Clientes");
            da.Fill(tablaDeUsuarios);
            dgvFacturas.DataSource = tablaDeUsuarios.DefaultView;
            dgvFacturas.Columns[0].Visible = false;
            dgvFacturas.Columns[1].Visible = false;

            Conexion.closeConnection();
        }

        private void nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.ingresarNombre(e);
        }

        private void apellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.ingresarNombre(e);
        }
        
    }
}
