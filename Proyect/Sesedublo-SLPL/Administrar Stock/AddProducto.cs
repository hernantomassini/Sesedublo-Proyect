using Enums;
using MetroFramework.Forms;
using MySql.Data.MySqlClient;
using Sesedublo_SLPL.Generales;
using System;
using System.ComponentModel;
using System.Data;
using System.Text;

namespace Sesedublo_SLPL.Administrar_Stock
{
    public partial class AddProducto : MetroForm
    {
        int id_stock = -1;
        Validaciones val = new Validaciones();
        StringBuilder st = new StringBuilder();

        public AddProducto()
        {
            InitializeComponent();
            this.getProductos();
            dgvProductos.Columns[0].Visible = false;
            dgvProductos.Columns[6].Visible = false;
            this.Closing += new CancelEventHandler(Avoid_Closing);
        }

        void Avoid_Closing(object sender, CancelEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
            Manejador_Formularios.ABM_Stock.cargarDGV();
            Manejador_Formularios.ABM_Stock.Show();
        }

        private void AddProducto_Load(object sender, EventArgs e)
        {

        }


        public void AgregarProducto()
        {
            getProductos();
            Nombre.Text = dgvProductos.Rows[0].Cells[1].Value.ToString();
            Clean();
        }

        public void ModificarProducto(int id_stock)
        {
            this.id_stock = id_stock;
            Clean();
            cargarDatos();
        }

        private void cargarDatos()
        {
            MySqlDataReader reader = Conexion.executeProcedureWithReader("obtenerProducto", Conexion.generarArgumentos("_id_stock"), id_stock);
            reader.Read();

            decimal costo = reader.GetDecimal(3);
            int radioSelected = reader.GetInt32(6);
            int cantBotellasBulto = reader.GetInt32(1);

            seleccionarRadioCorrespondiente(radioSelected);

            Nombre.Text = reader.GetString(2);
            Costo.Text = Convert.ToString(costo);
            Cantidad.Text = Convert.ToString(reader.GetInt32(0));
            UnidadesXBulto.Text = Convert.ToString(cantBotellasBulto);

            decimal precio = 0;
            decimal utilidad = 0;

            if (individualRadio.Checked)
            {
                precio = reader.GetDecimal(4);
                utilidad = precio - costo;
            }

            if (bultoxBotellaRadio.Checked)
            {
                precio = reader.GetDecimal(5);
                utilidad = Decimal.Round((precio - costo) / cantBotellasBulto, 2);
            }

            if(bultoCuadradoRadio.Checked)
            {
                precio = reader.GetDecimal(5);
                utilidad = precio - costo;
            }

            Utilidad.Text = Convert.ToString(utilidad);

            reader.Close();
            Conexion.closeConnection();
        }

        private void seleccionarRadioCorrespondiente(int radioSelected)
        {
            if (radioSelected == 1)
            { 
                individualRadio.Checked = true;
                return;
            }

            if (radioSelected == 2)
                bultoxBotellaRadio.Checked = true;
            else
                bultoCuadradoRadio.Checked = true;
        }

        public void getProductos()
        {
            MySqlDataAdapter da = Conexion.executeProcedureWithAdapter("obtenerLista", Conexion.generarArgumentos("_nombre"), buscarProducto.Text);
            DataTable tablaDeUsuarios = new DataTable("Clientes");
            da.Fill(tablaDeUsuarios);
            dgvProductos.DataSource = tablaDeUsuarios.DefaultView;

            Conexion.closeConnection();
        }

        private void Clean()
        {
            individualRadio.Checked = true;

            costoIndividual.Clear();
            buscarProducto.Clear();
            Cantidad.Clear();
            UnidadesXBulto.SelectedIndex = 0;
            Precio.Clear();
            Costo.Clear();
            Utilidad.Clear();
        }

        private void AtrasBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AgregarProductoBtn_Click(object sender, EventArgs e)
        {
            val.validarNoVacio(Nombre,st);
            val.validarNoVacio(Costo, st);
            val.validarNoVacio(Utilidad, st);
            val.validarNoVacio(Cantidad, st);

            if (bultoxBotellaRadio.Checked)
                val.validarNoVacio(UnidadesXBulto, st);

            if (st.Length > 0)
            {
                Funciones.imprimirMensajeDeError(st.ToString(), this);
                st = new StringBuilder();
            }
            else
            {
                int cantXBulto = 0;
                decimal costo = Convert.ToDecimal(Costo.Text);
                decimal utilidad = Convert.ToDecimal(Utilidad.Text);

                decimal precioPorUnidad = Convert.ToDecimal(Precio.Text);
                decimal precioPorBulto = 0;


                if (!individualRadio.Checked)
                {
                    cantXBulto = Convert.ToInt32(UnidadesXBulto.Text);

                    if (cantXBulto == 0) { 
                        Funciones.imprimirMensajeDeError("Las cantidad de botellas de un bulto no pueden ser 0.", this);
                        return;
                    }

                    precioPorBulto = precioPorUnidad;
                    precioPorUnidad = decimal.Round(precioPorBulto / cantXBulto, 2);
                }

                int radioSelected = obtenerRadioSeleccionado();

                Conexion.executeProcedure("agregarStock", Conexion.generarArgumentos("_cantidad", "_cantidadXBulto", "_costo", "_nombre", "_PVUnitario", "_PVBulto", "_radioSelected"), Convert.ToInt32(Cantidad.Text), cantXBulto, costo, Nombre.Text, precioPorUnidad, precioPorBulto, radioSelected);
                Conexion.closeConnection();
                Close();
            }
        }

        private void Costo_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            val.ingresarNumeroDecimal(e);
        }

        private void Cantidad_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            val.ingresarNumeroConRaya(e);
        }

        private void Precio_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            val.ingresarNumeroDecimal(e);
        }

        private void buscadorProducto_TextChanged(object sender, EventArgs e)
        {
            getProductos();
            if (dgvProductos.Rows.Count == 1)
            {
                cargarElementoDeGrilla();
            }
        }

        private void dgvProductos_CellClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            cargarElementoDeGrilla();
        }

        private void cargarElementoDeGrilla()
        {
            Nombre.Text = dgvProductos.CurrentRow.Cells[1].Value.ToString();
            string tipo = dgvProductos.CurrentRow.Cells[2].Value.ToString();

            if (tipo == "N/E")
            {
                return;
            }

            decimal costo = Convert.ToDecimal(dgvProductos.CurrentRow.Cells[3].Value) / 100;
            int radioSelected = Convert.ToInt32(dgvProductos.CurrentRow.Cells[6].Value);

            seleccionarRadioCorrespondiente(radioSelected);

            Costo.Text = Convert.ToString(costo);
            Cantidad.Text = "0";

            decimal precio = 0;
            decimal utilidad = 0;

            if (individualRadio.Checked)
            {
                precio = Convert.ToDecimal(dgvProductos.CurrentRow.Cells[4].Value) / 100;
                utilidad = precio - costo;
            }

            if (bultoxBotellaRadio.Checked)
            {
                int cantBotellasBulto = Convert.ToInt32(dgvProductos.CurrentRow.Cells[2].Value);

                precio = Convert.ToDecimal(dgvProductos.CurrentRow.Cells[5].Value) / 100;
                utilidad = (precio - costo) / cantBotellasBulto;

                UnidadesXBulto.Text = cantBotellasBulto.ToString();

            }

            if (bultoCuadradoRadio.Checked)
            {
                int cantBotellasBulto = Convert.ToInt32(dgvProductos.CurrentRow.Cells[2].Value);

                precio = Convert.ToDecimal(dgvProductos.CurrentRow.Cells[5].Value) / 100;
                utilidad = precio - costo;

                UnidadesXBulto.Text = cantBotellasBulto.ToString();
            }

            Utilidad.Text = Convert.ToString(utilidad);
        }

        private void nuevoProducto_Click(object sender, EventArgs e)
        {
            Manejador_Formularios.Producto_Nuevo.Clean();
            Manejador_Formularios.Producto_Nuevo.Show();
        }

        private void Utilidad_TextChanged(object sender, EventArgs e)
        {
            updatePrecio();
        }

        private void Costo_TextChanged(object sender, EventArgs e)
        {
            updatePrecio();
        }

        private void updatePrecio()
        {
            if(bultoxBotellaRadio.Checked)
            { 
                if (costoIndividual.Text == "" || costoIndividual.Text == ",")
                    return;
            }
            else
            { 
                if (Costo.Text == ""  || Costo.Text == ",")
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

            if(bultoxBotellaRadio.Checked)
            {
                decimal costoUnitario = Convert.ToDecimal(costoIndividual.Text);
                decimal costoBulto = decimal.Round(costoUnitario * botellasPorBulto, 2);
                Costo.Text = Convert.ToString(costoBulto);

                Precio.Text = Convert.ToString(costoUnitario + utilidad * botellasPorBulto);
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

        private void UnidadesXBulto_SelectedIndexChanged(object sender, EventArgs e)
        {
            updatePrecio();
        }

        private void UnidadesXBulto_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            updatePrecio();
        }

        private void individualRadio_CheckedChanged(object sender, EventArgs e)
        {
            updatePrecio();

            if (individualRadio.Checked)
            {
                CostoLabel.Text = "Costo por unidad:";
                CantidadLbl.Text = "Cantidad de unidades:";
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

        private void bultoxBotellaRadio_CheckedChanged(object sender, EventArgs e)
        {
            updatePrecio();

            if (bultoxBotellaRadio.Checked)
            {
                CostoLabel.Text = "Costo por bulto:";
                CantidadLbl.Text = "Cantidad de bultos:";
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
                CantidadLbl.Text = "Cantidad de bultos:";
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

        private int obtenerRadioSeleccionado()
        {
            if (individualRadio.Checked)
                return 1;

            if (bultoxBotellaRadio.Checked)
                return 2;
            else

            return 3;
        }

        private void costoIndividual_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            val.ingresarNumeroDecimal(e);
        }

        private void costoIndividual_TextChanged(object sender, EventArgs e)
        {
            updatePrecio();
        }
    }
}