using System;
using MetroFramework.Forms;
using System.ComponentModel;
using MySql.Data.MySqlClient;
using System.Data;
using Enums;
using Sesedublo_SLPL.Generales;
using System.Windows.Forms;

namespace Sesedublo_SLPL.Administrar_Pedidos
{
    public partial class AgregarPedido : MetroForm
    {
        accionesABM flag = accionesABM.Crear;
        int id_pedido = -1;

        public AgregarPedido()
        {
            InitializeComponent();
            this.Closing += new CancelEventHandler(Avoid_Closing);
            cargarDGVS();
        }

        void Avoid_Closing(object sender, CancelEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void AgregarPedido_Load(object sender, EventArgs e)
        {

        }

        private void AtrasTile_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AceptarTile_Click(object sender, EventArgs e)
        {

        }

        private void nombre_TextChanged(object sender, EventArgs e)
        {
            this.cargarDGVUsuarios();
        }

        private void apellido_TextChanged(object sender, EventArgs e)
        {
            this.cargarDGVUsuarios();
        }

        public void crearPedido()
        {
            flag = accionesABM.Crear;
        }

        private void direccion_TextChanged(object sender, EventArgs e)
        {
            this.cargarDGVUsuarios();
        }

        public void cargarDGVS()
        {
            cargarDGVUsuarios();
            cargarDGVStock();
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

        private void cargarDGVStock()
        {

        }

        private void AgregarProductoTile_Click(object sender, EventArgs e)
        {
            Manejador_Formularios.AddProductoAPedido.cargarDGV();
            Manejador_Formularios.AddProductoAPedido.Show();
            Close();
        }

        private void BorrarProductoTile_Click(object sender, EventArgs e)
        {
            DataGridViewRow filaDgv = ItemsDGV.CurrentRow;

            if (!Validaciones.validarFilaMarcada(filaDgv, this))
            {
                return;
            }

            if (Funciones.imprimirMensajeDeAlerta("¿Estás seguro de borrar este producto? Esta acción no se podrá deshacer.", this) == DialogResult.Cancel)
            {
                return;
            }

            //TODO - PROBAR.
            ItemsDGV.Rows.Remove(filaDgv);
        }
    }
}
