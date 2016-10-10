using Enums;
using MetroFramework.Forms;
using MySql.Data.MySqlClient;
using Sesedublo_SLPL.Generales;
using System;
using System.ComponentModel;

namespace Sesedublo_SLPL.Administrar_Stock
{
    public partial class AddProducto : MetroForm
    {
        accionesABM flag = accionesABM.Crear;
        int id_stock = -1;

        public AddProducto()
        {
            InitializeComponent();
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
            Clean();
            flag = accionesABM.Crear;
        }

        public void ModificarProducto(int id_stock)
        {
            Clean();
            flag = accionesABM.Modificar;
            this.id_stock = id_stock;
            cargarDatos();
        }

        private void cargarDatos()
        {
            MySqlDataReader reader = Conexion.executeProcedureWithReader("obtenerProducto", Conexion.generarArgumentos("_id_stock"), id_stock);
            reader.Read();

            int cantXBulto = reader.GetInt32(1);

            if (cantXBulto == 0)
                individualRadio.Checked = true;
            else
                bultoRadio.Checked = true;

            Nombre.Text = reader.GetString(2);
            Cantidad.Text = reader.GetString(0);
            UnidadesXBulto.Text = cantXBulto.ToString();
            Costo.Text = reader.GetString(3);
            Precio.Text = reader.GetString(4);

            reader.Close();
            Conexion.closeConnection();
        }

        private void Clean()
        {
            individualRadio.Checked = true;

            Cantidad.Clear();
            UnidadesXBulto.SelectedIndex = 0;
            Nombre.Clear();
            Costo.Clear();
            Precio.Clear();
        }

        private void AtrasBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AgregarProductoBtn_Click(object sender, EventArgs e)
        {
            int cantXBulto = Convert.ToInt32(UnidadesXBulto.Text);
            decimal precioPorUnidad = Convert.ToDecimal(Precio.Text);
            decimal precioPorBulto = precioPorUnidad;

            if (individualRadio.Checked)
            { 
                cantXBulto = 0;
                precioPorBulto = 0;
            }
            else
            {
                precioPorUnidad = decimal.Round(precioPorBulto / cantXBulto, 2);
            }
                

            if (flag == accionesABM.Crear)            
                Conexion.executeProcedure("agregarStock", Conexion.generarArgumentos("_cantidad", "_cantidadXBulto", "_costo" , "_nombre", "_PVUnitario", "_PVBulto"), Convert.ToInt32(Cantidad.Text), cantXBulto, Convert.ToDecimal(Costo.Text), Nombre.Text, precioPorUnidad, precioPorBulto);
            else
                Conexion.executeProcedure("modificarStock", Conexion.generarArgumentos("_id_stock", "_cantidad", "_cantidadXBulto", "_costo", "_nombre", "_PVUnitario", "_PVBulto"), id_stock, Convert.ToInt32(Cantidad.Text), cantXBulto, Convert.ToDecimal(Costo.Text), Nombre.Text, precioPorUnidad, precioPorBulto);

            Conexion.closeConnection();
            Close();
        }

        private void individualRadio_CheckedChanged(object sender, EventArgs e)
        {
            if(individualRadio.Checked)
            {
                CantidadLbl.Text = "Cantidad de unidades:";
                PrecioLabel.Text = "Precio por unidad:";
                UnidadesXBultoLbl.Visible = false;
                UnidadesXBulto.Visible = false;
            }
            else
            {
                CantidadLbl.Text = "Cantidad de bultos:";
                PrecioLabel.Text = "Precio por bulto:";
                UnidadesXBultoLbl.Visible = true;
                UnidadesXBulto.Visible = true;
            }
        }
    }
}