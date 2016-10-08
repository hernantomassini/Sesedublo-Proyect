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
    public partial class Agregar_Cliente : MetroForm
    {
        accionesABM flag = accionesABM.Crear;
        int id_cliente = -1;

        public Agregar_Cliente()
        {
            InitializeComponent();
            this.Closing += new CancelEventHandler(Avoid_Closing);
        }

        void Avoid_Closing(object sender, CancelEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
            Manejador_Formularios.ABM_Usuarios.getData();
            Manejador_Formularios.ABM_Usuarios.Show();
        }

        public void agregarCliente()
        {
            Clean();
            flag = accionesABM.Crear;
        }

        public void modificarCliente(int id_clie)
        {
            Clean();
            flag = accionesABM.Modificar;
            this.id_cliente = id_clie;
            llenarDatos();
        }

        private void llenarDatos()
        {
            MySqlDataReader reader = Conexion.executeProcedureWithReader("obtenerCliente", Conexion.generarArgumentos("_id_cliente"), id_cliente);

            reader.Read();

            Nombre.Text = reader.GetString(0);
            Apellido.Text = reader.GetString(1);
            Mail.Text = reader.GetString(2);
            Telefono.Text = reader.GetString(3);
            Direccion.Text = reader.GetString(4);

            reader.Close();
            Conexion.closeConnection();
        }

        private void Clean()
        {
            Nombre.Clear();
            Apellido.Clear();
            Telefono.Clear();
            Direccion.Clear();
            Mail.Clear();
        }

        private void titleCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void titleAceptar_Click(object sender, EventArgs e)
        {
            if (flag == accionesABM.Crear)
            {
                Conexion.executeProcedure("agregarCliente", Conexion.generarArgumentos("_nombre","_apellido","_mail","_direccion","_telefono"), Nombre.Text, Apellido.Text, Mail.Text, Direccion.Text, Telefono.Text);
                Conexion.closeConnection();
            }
            else
            {
                Conexion.executeProcedure("modificarCliente", Conexion.generarArgumentos("_id_cliente","_nombre", "_apellido", "_mail", "_direccion", "_telefono"),id_cliente ,Nombre.Text, Apellido.Text, Mail.Text, Direccion.Text, Telefono.Text);
                Conexion.closeConnection();
            }

            Close();
        }
    }
}
