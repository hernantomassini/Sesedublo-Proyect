using MySql.Data.MySqlClient;
using Sesedublo_SLPL.Generales;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Sesedublo_SLPL.Administrar_Productos
{
    public partial class ABM_Stock : Form
    {
        public ABM_Stock()
        {
            InitializeComponent();
            this.Closing += new CancelEventHandler(Avoid_Closing);
        }

        void Avoid_Closing(object sender, CancelEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void AgregarProductoStockBtn_Click(object sender, EventArgs e)
        {
            Manejador_Formularios.AddProducto.AgregarProducto();
            Manejador_Formularios.AddProducto.Show();
        }

        private void modificarProductoStockBtn_Click(object sender, EventArgs e)
        {
            DataGridViewRow filaDgv = StockDGV.CurrentRow;

            if (!Validaciones.validarFilaMarcada(filaDgv))
            {
                return;
            }

            int id_stock = Convert.ToInt32(filaDgv.Cells[0].Value);

            Manejador_Formularios.AddProducto.ModificarProducto(id_stock);
            Manejador_Formularios.AddProducto.Show();
        }

        private void EliminarProductoStockBtn_Click(object sender, EventArgs e)
        {
            DataGridViewRow filaDgv = StockDGV.CurrentRow;

            if (!Validaciones.validarFilaMarcada(filaDgv))
            {
                return;
            }

            if (Funciones.imprimirMensajeDeAlerta("¿Está segura de borrar este producto? Esta acción no se podrá deshacer.") == DialogResult.Cancel)
            {
                return;
            }

            int id_stock = Convert.ToInt32(filaDgv.Cells[0].Value);

            Conexion.executeProcedure("borrarStock", Conexion.generarArgumentos("_id_stock"), id_stock);
            Conexion.closeConnection();

            cargarDGV();
        }

        public void cargarDGV()
        {
            MySqlDataReader reader = Conexion.executeProcedureWithReader("obtenerStock", Conexion.generarArgumentos());

            while(reader.Read())
            {
                reader.Close();
                Conexion.closeConnection();
                return;
            }

            reader.Close();
            Conexion.closeConnection();
        }

        private void AtrasButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
