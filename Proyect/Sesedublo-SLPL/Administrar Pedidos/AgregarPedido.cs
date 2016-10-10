using System;
using MetroFramework.Forms;
using System.ComponentModel;
using MySql.Data.MySqlClient;
using System.Data;
using Sesedublo_SLPL.Generales;
using System.Windows.Forms;

namespace Sesedublo_SLPL.Administrar_Pedidos
{
    public partial class AgregarPedido : MetroForm
    {
        public AgregarPedido()
        {
            InitializeComponent();
            this.Closing += new CancelEventHandler(Avoid_Closing);
            cargarDGVUsuarios();
        }

        void Avoid_Closing(object sender, CancelEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
            Manejador_Formularios.ABM_Pedidos.Show();
        }

        private void AtrasTile_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void nombre_TextChanged(object sender, EventArgs e)
        {
            cargarDGVUsuarios();
        }

        private void apellido_TextChanged(object sender, EventArgs e)
        {
            cargarDGVUsuarios();
        }

        private void direccion_TextChanged(object sender, EventArgs e)
        {
            cargarDGVUsuarios();
        }

        private void cargarDGVUsuarios()
        {
            MySqlDataAdapter da = Conexion.executeProcedureWithAdapter("cargarGrillaClientes", Conexion.generarArgumentos("_nombre", "_apellido", "_direccion"), nombre.Text, apellido.Text, direccion.Text);
            DataTable tablaDeUsuarios = new DataTable("Clientes");
            da.Fill(tablaDeUsuarios);
            ClienteDGV.DataSource = tablaDeUsuarios.DefaultView;
            ClienteDGV.Columns[0].Visible = false;

            Conexion.closeConnection();
        }

        private void SiguienteTile_Click(object sender, EventArgs e)
        {
            DataGridViewRow filaDgv = ClienteDGV.CurrentRow;

            if (!Validaciones.validarFilaMarcada(filaDgv, this))
            {
                return;
            }

            int id_cliente = Convert.ToInt32(filaDgv.Cells[0].Value);

            Manejador_Formularios.AddProductoAPedido.crearPedido(id_cliente);
            Manejador_Formularios.AddProductoAPedido.Show();
            Hide();
        }

        public void Clean()
        {
            nombre.Clear();
            apellido.Clear();
            direccion.Clear();
        }

        private void AgregarPedido_Load(object sender, EventArgs e)
        {

        }
    }
}
