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
        Validaciones val = new Validaciones();
        StringBuilder st = new StringBuilder();

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
        }

        public void agregarCliente()
        {
            Clean();
            this.Text = "Nuevo Cliente";
            flag = accionesABM.Crear;
        }

        public void modificarCliente(int id_clie)
        {
            Clean();
            this.Text = "Modificar Cliente";
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
            Localidad.Text = reader.GetString(5);
            CUIT.Text = reader.GetString(6);
            RazonSocial.Text = reader.GetString(7);

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
            Localidad.Clear();
            CUIT.Clear();
            RazonSocial.Clear();
        }

        private void titleCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void titleAceptar_Click(object sender, EventArgs e)
        {
            
           val.validarNoVacio(Nombre,st);
            val.validarNoVacio(Direccion, st);
            val.validarNoVacio(Telefono, st);

            if (st.Length > 0)
            {
                Funciones.imprimirMensajeDeError(st.ToString(), this);
                st = new StringBuilder();
            }
            else
            {
                if (flag == accionesABM.Crear)
                {
                    Conexion.executeProcedure("agregarCliente", Conexion.generarArgumentos("_nombre", "_apellido", "_mail", "_direccion", "_telefono", "_localidad", "_cuit", "_razonSocial"), Nombre.Text, Apellido.Text, Mail.Text, Direccion.Text, Telefono.Text, Localidad.Text, CUIT.Text, RazonSocial.Text);
                    Conexion.closeConnection();
                    Manejador_Formularios.AgregarPedido.cargarDGVUsuarios();
                }
                else
                {
                    Conexion.executeProcedure("modificarCliente", Conexion.generarArgumentos("_id_cliente", "_nombre", "_apellido", "_mail", "_direccion", "_telefono", "_localidad", "_cuit", "_razonSocial"), id_cliente, Nombre.Text, Apellido.Text, Mail.Text, Direccion.Text, Telefono.Text, Localidad.Text, CUIT.Text, RazonSocial.Text);
                    Conexion.closeConnection();
                }

                Close();
            }
        }

        private void Nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.ingresarNombre(e);
        }

        private void Apellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.ingresarNombre(e);
        }

        private void Mail_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.ingresarMail(e);
        }

        private void Telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.ingresarNumero(e);
        }

        private void Localidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.ingresarNombre(e);
        }

        private void CUIT_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.ingresarNumeroConRaya(e);
        }

        private void RazonSocial_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.ingresarNombre(e);
        }
    }
}
