using MetroFramework.Forms;
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

namespace Sesedublo_SLPL.Productos
{
    public partial class Modificar_Nombre : MetroForm
    {
        int id_producto;
        public Modificar_Nombre()
        {
            InitializeComponent();
        }

        private void titleCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void titleAceptar_Click(object sender, EventArgs e)
        {
            string query = " UPDATE ListaDeProductos SET descripcion = '" + Nombre.Text + "' where id_listPro=" + id_producto;
            string query1 = " UPDATE Productos SET nombre = '" + Nombre.Text + "' where nombre=(SELECT descripcion FROM ListaDeProductos WHERE id_listPro =" + id_producto + ")";

            Conexion.ejecutarNonQuery(query1);
            Conexion.closeConnection();

            Conexion.ejecutarNonQuery(query);
            Conexion.closeConnection();

            Funciones.imprimirMensajeDeAviso("Se modifico el nombre del producto a " + Nombre.Text, this);
            Manejador_Formularios.Lista_de_Productos.getData();
            this.Close();
        }

        public void Clean()
        {
            this.Nombre.Text = "";
        }

        internal void modificarProducto(int id, String nombre)
        {
            id_producto = id;
            Nombre.Text = nombre;

        }
    }
}
