using Enums;
using MySql.Data.MySqlClient;
using Sesedublo_SLPL.Generales;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Sesedublo_SLPL.Administrar_Stock
{
    public partial class AddProducto : Form
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

            CantidadIndividual.Text = reader.GetString(0);
            CantidadBultos.Text = reader.GetString(1);
            UnidadesXBulto.Text = reader.GetString(2);
            Nombre.Text = reader.GetString(3);
            Costo.Text = reader.GetString(4);
            PVunitario.Text = reader.GetString(5);
            PVBulto.Text = reader.GetString(6);

            reader.Close();
            Conexion.closeConnection();
        }

        private void Clean()
        {
            CantidadIndividual.Clear();
            CantidadBultos.Clear();
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
            if(flag == accionesABM.Crear)
            {
                Conexion.executeProcedure("agregarStock", Conexion.generarArgumentos("_stockInidividual", "_stockBultos", "_cantidadXBulto", "_costo" , "_nombre", "_PVUnitario", "_PVBulto"), Convert.ToInt32(CantidadIndividual.Text), Convert.ToInt32(CantidadBultos.Text), Convert.ToInt32(UnidadesXBulto.Text), Convert.ToDecimal(Costo.Text), Nombre.Text, Convert.ToDecimal(PVunitario.Text), Convert.ToDecimal(PVBulto.Text));
                Conexion.closeConnection();
            }
            else
            {
                Conexion.executeProcedure("modificarStock", Conexion.generarArgumentos("_id_stock", "_stockInidividual", "_stockBultos", "_cantidadXBulto", "_costo", "_nombre", "_PVUnitario", "_PVBulto"), id_stock, Convert.ToInt32(CantidadIndividual.Text), Convert.ToInt32(CantidadBultos.Text), Convert.ToInt32(UnidadesXBulto.Text), Convert.ToDecimal(Costo.Text), Nombre.Text, Convert.ToDecimal(PVunitario.Text), Convert.ToDecimal(PVBulto.Text));
                Conexion.closeConnection();
            }

            Close();
        }
    }
}
