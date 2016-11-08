using Enums;
using MetroFramework.Forms;
using MySql.Data.MySqlClient;
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

namespace Sesedublo_SLPL.Administrar_Usuarios
{
    public partial class ABM_Usuarios : MetroForm
    {

        Validaciones val = new Validaciones();
        public ABM_Usuarios()
        {
            InitializeComponent();
            this.Closing += new CancelEventHandler(Avoid_Closing);
            this.getData();
        }

        void Avoid_Closing(object sender, CancelEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void titleAgregarCliente_Click(object sender, EventArgs e)
        {
            Manejador_Formularios.Agregar_Cliente.agregarCliente();
            Manejador_Formularios.Agregar_Cliente.Show();
        }

        private bool validarFilaMarcada(DataGridViewRow filaMarcada, MetroForm form)
        {
            if (filaMarcada == null)
            {
                Funciones.imprimirMensajeDeError("Debe seleccionar un cliente para dicha acción.",form);
                return false;
            }

            return true;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            DataGridViewRow filaMarcada = dgvClientes.CurrentRow;

            if (!this.validarFilaMarcada(filaMarcada,this))
            {
                return;
            }

            int idCliente = Convert.ToInt32(dgvClientes.SelectedCells[0].Value);
            Manejador_Formularios.Agregar_Cliente.modificarCliente(idCliente);
            Manejador_Formularios.Agregar_Cliente.Show();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DataGridViewRow filaMarcada = dgvClientes.CurrentRow;

            if (!this.validarFilaMarcada(filaMarcada,this))
            {
                return;
            }

            if (Funciones.imprimirMensajeDeAlerta("¿Estás seguro de borrar a este Cliente? Esta acción no se podrá deshacer.", this) == DialogResult.Cancel)
            {
                return;
            }

            int id_cliente = Convert.ToInt32(dgvClientes.SelectedCells[0].Value);

            string query = " UPDATE Clientes SET deleted = 1 where id_cliente=" + id_cliente;


            string nombre = Convert.ToString(dgvClientes.SelectedCells[1].Value);
            string apellido = Convert.ToString(dgvClientes.SelectedCells[2].Value);

            Conexion.ejecutarNonQuery(query);
            Conexion.closeConnection();
            Funciones.imprimirMensajeDeAviso("Se elimino al usuario " + apellido + ", " + nombre, this);
            this.getData();
        }

        private void nombre_TextChanged(object sender, EventArgs e)
        {
            this.getData();
        }

        private void apellido_TextChanged(object sender, EventArgs e)
        {
            this.getData();
        }

        private void direccion_TextChanged(object sender, EventArgs e)
        {
            this.getData();
        }


        public void getData()
        {
            MySqlDataAdapter da = Conexion.executeProcedureWithAdapter("cargarGrillaClientes", Conexion.generarArgumentos("_nombre", "_apellido", "_direccion"), nombre.Text, apellido.Text, direccion.Text);
            DataTable tablaDeUsuarios = new DataTable("Clientes");
            da.Fill(tablaDeUsuarios);
            dgvClientes.DataSource = tablaDeUsuarios.DefaultView;
            dgvClientes.Columns[0].Visible = false;

            Conexion.closeConnection();
        }

        private void BotonAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ABM_Usuarios_Load(object sender, EventArgs e)
        {

        }

        private void nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.ingresarNombre(e);
        }

        private void apellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.ingresarNombre(e);
        }

        private void dgvClientes_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int idCliente = Convert.ToInt32(dgvClientes.SelectedCells[0].Value);
            Manejador_Formularios.Agregar_Cliente.modificarCliente(idCliente);
            Manejador_Formularios.Agregar_Cliente.Show();
        }
    }
}
