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

namespace Sesedublo_SLPL.Productos
{
    public partial class Producto_Nuevo : MetroForm
    {
        Validaciones val = new Validaciones();
        StringBuilder st = new StringBuilder();
        public Producto_Nuevo()
        {
            InitializeComponent();
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
            val.validarNoVacio(Costo, st);
            val.validarNoVacio(Utilidad, st);

            if (bultoRadio.Checked)
                val.validarNoVacio(UnidadesXBulto, st);

            if (st.Length > 0)
            {
                Funciones.imprimirMensajeDeError(st.ToString(), this);
                st = new StringBuilder();
            }
            else
            {
                string query = "SELECT 1 FROM ListaDeProductos WHERE descripcion = '" + Nombre.Text + "'";

                MySqlDataReader reader = Conexion.ejecutarQuery(query);

                if (reader.HasRows)
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
                Manejador_Formularios.AddPedidoCompra.getProductos();
                Manejador_Formularios.AddProducto.getProductos();

                int cantXBulto = Convert.ToInt32(UnidadesXBulto.Text);
                decimal costo = Convert.ToDecimal(Costo.Text);
                decimal utilidad = Convert.ToDecimal(Utilidad.Text);

                decimal precioPorUnidad = costo + utilidad;
                decimal precioPorBulto = precioPorUnidad;

                if (individualRadio.Checked)
                {
                    cantXBulto = 0;
                    precioPorBulto = 0;
                }
                else
                {
                    precioPorBulto = Convert.ToDecimal(Precio.Text);
                    precioPorUnidad = decimal.Round(precioPorBulto / cantXBulto, 2);
                }

                Conexion.executeProcedure("agregarStock", Conexion.generarArgumentos("_cantidad", "_cantidadXBulto", "_costo", "_nombre", "_PVUnitario", "_PVBulto"), 0, cantXBulto, costo, Nombre.Text, precioPorUnidad, precioPorBulto);
                Conexion.closeConnection();
                Close();
            }
        }

        private void titleCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void individualRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (individualRadio.Checked)
            {
                CostoLabel.Text = "Costo por unidad:";
                UnidadesXBultoLbl.Visible = false;
                UnidadesXBulto.Visible = false;
            }
            else
            {
                CostoLabel.Text = "Costo por bulto:";
                UnidadesXBultoLbl.Visible = true;
                UnidadesXBulto.Visible = true;
            }
        }

        private void Costo_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            val.ingresarNumeroDecimal(e);
        }

        private void Precio_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            val.ingresarNumero(e);
        }

        private void Costo_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Utilidad.Text))
            {
                if (!String.IsNullOrEmpty(Costo.Text))
                {
                    Precio.Text = Convert.ToString(Convert.ToDecimal(Costo.Text));
                }
            }
            else
            {
                if (!String.IsNullOrEmpty(Costo.Text))
                {
                    Precio.Text = Convert.ToString(Convert.ToDecimal(Utilidad.Text) + Convert.ToDecimal(Costo.Text));

                    if (!individualRadio.Checked)
                    {
                        Precio.Text = Convert.ToString(Convert.ToDecimal(Costo.Text) + Convert.ToDecimal(Utilidad.Text) * Convert.ToDecimal(UnidadesXBulto.Text));
                    }

                }
            }
        }

        private void Utilidad_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Costo.Text))
            {
                if (!String.IsNullOrEmpty(Utilidad.Text))
                {
                    Precio.Text = Convert.ToString(Convert.ToDecimal(Utilidad.Text));
                }
            }
            else
            {
                if (!String.IsNullOrEmpty(Utilidad.Text))
                {
                    Precio.Text = Convert.ToString(Convert.ToDecimal(Utilidad.Text) + Convert.ToDecimal(Costo.Text));

                    if (!individualRadio.Checked)
                    {
                        Precio.Text = Convert.ToString(Convert.ToDecimal(Costo.Text) + Convert.ToDecimal(Utilidad.Text));
                    }
                }
            }
        }

        public void Clean()
        {
            individualRadio.Checked = true;

            UnidadesXBulto.SelectedIndex = 0;
            Precio.Clear();
            Nombre.Clear();
            Costo.Clear();
            Utilidad.Clear();
        }

        private void Utilidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.ingresarNumeroDecimal(e);
        }
    }
}
