using System;
using MetroFramework.Forms;
using System.ComponentModel;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Windows.Forms;
using Sesedublo_SLPL.Generales;

namespace Sesedublo_SLPL.Administrar_Pedidos
{
    public partial class AddProductoAPedido : MetroForm
    {
        Dictionary<int, int> productosAVender = new Dictionary<int, int>();

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

        private void CancelarTile_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FinalizarTile_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void cargarDGV()
        {
            Funciones.limpiarDGV(ProductosDGV);
            MySqlDataReader reader = Conexion.executeProcedureWithReader("obtenerStock", Conexion.generarArgumentos("_nombre"), nombre.Text);

            string cantidad;
            int cantXBulto;
            decimal precio;

            while (reader.Read())
            {
                cantXBulto = reader.GetInt32(2);

                if (cantXBulto == 0)
                { 
                    //Significa que el producto es individual!
                    cantidad = obtenerCantidadReal(reader.GetInt32(0), reader.GetInt32(1)) + " unidades";
                    precio = reader.GetDecimal(5);
                }
                else
                {
                    //El producto es un Bulto!
                    cantidad = obtenerCantidadReal(reader.GetInt32(0), reader.GetInt32(1)) + " bultos de " + cantXBulto + " unidades";
                    precio = reader.GetDecimal(6);
                }

                 //ID Stock 0 - Nombre 3
                 ProductosDGV.Rows.Add(reader.GetInt32(0), cantidad, reader.GetString(3), precio);
            }

            reader.Close();
            Conexion.closeConnection();
        }

        private int obtenerCantidadReal(int idStock, int cantEnDB)
        {
            /* int cantidadAVender;

             openWith.Add("txt", "notepad.exe");
             openWith.Add("bmp", "paint.exe");
             openWith.Add("dib", "paint.exe");
             openWith.Add("rtf", "wordpad.exe");

             return (cantEnDB - cantidadAVender);*/
            return cantEnDB;
        }

        private void AgregarTile_Click(object sender, EventArgs e)
        {

        }

        private void nombre_TextChanged(object sender, EventArgs e)
        {
            this.cargarDGV();
        }

        private void BorrarTile_Click(object sender, EventArgs e)
        {
            DataGridViewRow filaDgv = ProductosDGV.CurrentRow;

            if (!Validaciones.validarFilaMarcada(filaDgv, this))
            {
                return;
            }

            ProductosDGV.Rows.Remove(filaDgv);
        }
    }
}
