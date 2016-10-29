using MetroFramework.Forms;
using MySql.Data.MySqlClient;
using Sesedublo_SLPL.Generales;
using System;
using System.ComponentModel;
using System.Text;
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

            if (bultoxBotellaRadio.Checked)
            { 
                val.validarNoVacio(UnidadesXBulto, st);
                val.validarNoCero(UnidadesXBulto, st);
            }

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

                int cantXBulto = 0;
                decimal costo = Convert.ToDecimal(Costo.Text);
                decimal utilidad = Convert.ToDecimal(Utilidad.Text);

                decimal precioPorUnidad = Convert.ToDecimal(Precio.Text);
                decimal precioPorBulto = 0;


                if (!individualRadio.Checked)
                {
                    cantXBulto = Convert.ToInt32(UnidadesXBulto.Text);
                    precioPorBulto = precioPorUnidad;
                    precioPorUnidad = decimal.Round(precioPorBulto / cantXBulto, 2);
                }

                int radioSelected = obtenerRadioSeleccionado();

                Conexion.executeProcedure("agregarStock", Conexion.generarArgumentos("_cantidad", "_cantidadXBulto", "_costo", "_nombre", "_PVUnitario", "_PVBulto", "_radioSelected"), 0, cantXBulto, costo, Nombre.Text, precioPorUnidad, precioPorBulto, radioSelected);
                Conexion.closeConnection();

                Manejador_Formularios.AddPedidoCompra.getProductos();
                Manejador_Formularios.AddProducto.getProductos();
                Manejador_Formularios.Lista_de_Productos.getData();
                Close();
            }
        }

        private int obtenerRadioSeleccionado()
        {
            if (individualRadio.Checked)
                return 1;

            if (bultoxBotellaRadio.Checked)
                return 2;
            else

                return 3;
        }

        private void titleCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Costo_TextChanged(object sender, EventArgs e)
        {
            updatePrecio();
        }

        private void Utilidad_TextChanged(object sender, EventArgs e)
        {
            updatePrecio();
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

        private void updatePrecio()
        {
            if (bultoxBotellaRadio.Checked)
            {
                if (costoIndividual.Text == "" || costoIndividual.Text == ",")
                    return;
            }
            else
            {
                if (Costo.Text == "" || Costo.Text == ",")
                    return;
            }

            if (Utilidad.Text == "," || Utilidad.Text == "")
                return;

            decimal utilidad = Convert.ToDecimal(Utilidad.Text);

            if (individualRadio.Checked)
            {
                decimal costo = Convert.ToDecimal(Costo.Text);

                Precio.Text = Convert.ToString(costo + utilidad);
                return;
            }

            if (UnidadesXBulto.Text == "")
                return;

            int botellasPorBulto = Convert.ToInt32(UnidadesXBulto.Text);

            if (bultoxBotellaRadio.Checked)
            {
                decimal costoUnitario = Convert.ToDecimal(costoIndividual.Text);
                decimal costoBulto = decimal.Round(costoUnitario * botellasPorBulto, 2);
                Costo.Text = Convert.ToString(costoBulto);

                Precio.Text = Convert.ToString((costoUnitario + utilidad) * botellasPorBulto);
            }
            else
            {
                decimal costo = Convert.ToDecimal(Costo.Text);

                Precio.Text = Convert.ToString(costo + utilidad);

                if (botellasPorBulto == 0)
                    return;

                decimal costoUnitario = decimal.Round(costo / botellasPorBulto, 2);
                costoIndividual.Text = Convert.ToString(costoUnitario);
            }
        }

        private void Producto_Nuevo_Load(object sender, EventArgs e)
        {

        }

        private void UnidadesXBulto_SelectedIndexChanged(object sender, EventArgs e)
        {
            updatePrecio();
        }


        private void individualRadio_CheckedChanged(object sender, EventArgs e)
        {
            updatePrecio();

            if (individualRadio.Checked)
            {
                CostoLabel.Text = "Costo por unidad:";
                UtilidadLabel.Text = "Utilidad por unidad:";
                PrecioLabel.Text = "Precio por unidad:";
                CostoIndividualLabel.Visible = false;
                costoIndividual.Visible = false;
                UnidadesXBultoLbl.Visible = false;
                UnidadesXBulto.Visible = false;
                unidadesObligatorio.Visible = false;


                costoIndividualObligatory.Visible = false;
                costoSegunRadioObligatory.Visible = true;
            }
        }

        private void bultoRadio_CheckedChanged(object sender, EventArgs e)
        {
            updatePrecio();

            if (bultoxBotellaRadio.Checked)
            {
                CostoLabel.Text = "Costo por bulto:";
                UtilidadLabel.Text = "Utilidad por botella:";
                PrecioLabel.Text = "Precio por bulto:";
                costoIndividualObligatory.Visible = true;
                costoSegunRadioObligatory.Visible = false;

                CostoIndividualLabel.Visible = true;
                costoIndividual.Visible = true;
                UnidadesXBultoLbl.Visible = true;
                UnidadesXBulto.Visible = true;
                unidadesObligatorio.Visible = true;
            }
        }

        private void bultoCuadradoRadio_CheckedChanged(object sender, EventArgs e)
        {
            updatePrecio();

            if (bultoCuadradoRadio.Checked)
            {
                CostoLabel.Text = "Costo por bulto:";
                UtilidadLabel.Text = "Utilidad por bulto:";
                PrecioLabel.Text = "Precio por bulto:";
                CostoIndividualLabel.Visible = true;
                costoIndividual.Visible = true;
                UnidadesXBultoLbl.Visible = true;
                UnidadesXBulto.Visible = true;
                unidadesObligatorio.Visible = true;

                costoIndividualObligatory.Visible = false;
                costoSegunRadioObligatory.Visible = true;
            }
        }

        private void Utilidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.ingresarNumeroDecimal(e);
        }

        private void Costo_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            val.ingresarNumeroDecimal(e);
        }

        private void Precio_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            val.ingresarNumero(e);
        }

        private void costoIndividual_TextChanged(object sender, EventArgs e)
        {
            updatePrecio();
        }
    }
}
