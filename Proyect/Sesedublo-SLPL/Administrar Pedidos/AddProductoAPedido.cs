using System;
using MetroFramework.Forms;
using System.ComponentModel;
using MySql.Data.MySqlClient;

namespace Sesedublo_SLPL.Administrar_Pedidos
{
    public partial class AddProductoAPedido : MetroForm
    {
        public AddProductoAPedido()
        {
            InitializeComponent();
            this.Closing += new CancelEventHandler(Avoid_Closing);
        }

        void Avoid_Closing(object sender, CancelEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void AddProductoAPedido_Load(object sender, EventArgs e)
        {

        }

        private void AtrasTile_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AceptarTile_Click(object sender, EventArgs e)
        {

        }

        public void cargarDGV()
        {
            Funciones.limpiarDGV(ProductosDGV);
            MySqlDataReader reader = Conexion.executeProcedureWithReader("obtenerStock", Conexion.generarArgumentos());

            string cantidad;
            int cantXBulto;
            decimal precio;

            while (reader.Read())
            {
                cantXBulto = reader.GetInt32(2);

                if (cantXBulto == 0)
                { 
                    //Significa que el producto es individual!
                    cantidad = reader.GetString(1);
                    precio = reader.GetDecimal(5);
                }
                else
                {
                    //El producto es un Bulto!
                    cantidad = reader.GetString(1) + " bultos de " + cantXBulto + " unidades";
                    precio = reader.GetDecimal(6);
                }

                 //ID Stock 0 - Nombre 3
                 ProductosDGV.Rows.Add(reader.GetInt32(0), cantidad, reader.GetString(3), precio);
            }

            reader.Close();
            Conexion.closeConnection();
        }
    }
}
