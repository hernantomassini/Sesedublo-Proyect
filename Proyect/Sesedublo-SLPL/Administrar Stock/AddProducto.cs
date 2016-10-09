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
            PVunitario.Text = reader.GetString(4);
            PVBulto.Text = reader.GetString(5);

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
            PVunitario.Clear();
            PVBulto.Clear();
        }

        private void AtrasBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AgregarProductoBtn_Click(object sender, EventArgs e)
        {
            int cantXBulto = Convert.ToInt32(UnidadesXBulto.Text);

            if (individualRadio.Checked)
                cantXBulto = 0;

            if (flag == accionesABM.Crear)            
                Conexion.executeProcedure("agregarStock", Conexion.generarArgumentos("_cantidad", "_cantidadXBulto", "_costo" , "_nombre", "_PVUnitario", "_PVBulto"), Convert.ToInt32(Cantidad.Text), cantXBulto, Convert.ToDecimal(Costo.Text), Nombre.Text, Convert.ToDecimal(PVunitario.Text), Convert.ToDecimal(PVBulto.Text));
            else
                Conexion.executeProcedure("modificarStock", Conexion.generarArgumentos("_id_stock", "_cantidad", "_cantidadXBulto", "_costo", "_nombre", "_PVUnitario", "_PVBulto"), id_stock, Convert.ToInt32(Cantidad.Text), cantXBulto, Convert.ToDecimal(Costo.Text), Nombre.Text, Convert.ToDecimal(PVunitario.Text), Convert.ToDecimal(PVBulto.Text));

            Conexion.closeConnection();
            Close();
        }

        private void individualRadio_CheckedChanged(object sender, EventArgs e)
        {
            if(individualRadio.Checked)
            {
                label7.Visible = false;
                UnidadesXBulto.Visible = false;
                PVunitario.Enabled = true;
                PVBulto.Enabled = false;
            }
            else
            {
                label7.Visible = true;
                UnidadesXBulto.Visible = true;
                PVunitario.Enabled = false;
                PVBulto.Enabled = true;
            }
        }

        private void UnidadesXBulto_SelectedIndexChanged(object sender, EventArgs e)
        {
            updatePrecioUnitario();
        }

        private void PVBulto_TextChanged(object sender, EventArgs e)
        {
            updatePrecioUnitario();
        }

        private void updatePrecioUnitario()
        {
            decimal PrecioBulto;
            int unidadesPorBulto;

            if (PVBulto.Text == "")
                PrecioBulto = 0;
            else
                PrecioBulto = Convert.ToDecimal(PVBulto.Text);

            if (UnidadesXBulto.Text == "")
                unidadesPorBulto = 1;
            else
                unidadesPorBulto = Convert.ToInt32(UnidadesXBulto.Text);

            decimal resultado = decimal.Round(PrecioBulto / unidadesPorBulto, 2);
            PVunitario.Text = resultado.ToString();
        }
    }
}