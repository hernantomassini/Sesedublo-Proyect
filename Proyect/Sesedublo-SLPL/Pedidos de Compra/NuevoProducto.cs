using MetroFramework.Forms;
using MySql.Data.MySqlClient;
using Sesedublo_SLPL.Generales;
using System;
using System.ComponentModel;
using System.Text;

namespace Sesedublo_SLPL.Pedidos_de_Compra
{
    public partial class NuevoProducto : MetroForm
    {
        Validaciones val = new Validaciones();
        StringBuilder st = new StringBuilder();
        public NuevoProducto()
        {
            InitializeComponent();
            this.Closing += new CancelEventHandler(Avoid_Closing);
        }

        private void titleCancelar_Click(object sender, EventArgs e)
        {
            this.Closing += new CancelEventHandler(Avoid_Closing);
        }

        void Avoid_Closing(object sender, CancelEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void titleAceptar_Click(object sender, EventArgs e)
        {
            val.validarNoVacio(Nombre, st);

            if (st.Length > 0)
            {
                Funciones.imprimirMensajeDeError(st.ToString(), this);
                st = new StringBuilder();
                return;
            }

            string query = "SELECT 1 FROM ListaDeProductos WHERE descripcion = '" + Nombre.Text + "'";

            MySqlDataReader reader = Conexion.ejecutarQuery(query);

            if(reader.HasRows)
            {
                Funciones.imprimirMensajeDeError("El producto que se quiere ingresar ya existe.", this);
                Conexion.closeConnection();
                reader.Close();
                return;
            }

            Conexion.closeConnection();
            reader.Close();

            Conexion.executeProcedure("agregarNuevoProducto", Conexion.generarArgumentos("_nombre"), Nombre.Text);
            Conexion.closeConnection();
            Nombre.Clear();
            Manejador_Formularios.AddPedidoCompra.getProductos();
            this.Hide();

        }

        private void NuevoProducto_Load(object sender, EventArgs e)
        {

        }
    }
}
