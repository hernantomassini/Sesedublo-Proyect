using MetroFramework.Forms;
using MySql.Data.MySqlClient;
using Sesedublo_SLPL.Generales;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Sesedublo_SLPL.Administrar_Productos
{
    public partial class ABM_Stock : MetroForm
    {
        public ABM_Stock()
        {
            InitializeComponent();
            this.Closing += new CancelEventHandler(Avoid_Closing);
            cargarDGV();
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

            if (!Validaciones.validarFilaMarcada(filaDgv,this))
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

            if (!Validaciones.validarFilaMarcada(filaDgv,this))
            {
                return;
            }

            if (Funciones.imprimirMensajeDeAlerta("¿Estás seguro de borrar este producto? Esta acción no se podrá deshacer.", this) == DialogResult.Cancel)
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
            Funciones.limpiarDGV(StockDGV);
            MySqlDataReader reader = Conexion.executeProcedureWithReader("obtenerStock", Conexion.generarArgumentos());

            while(reader.Read())
            {   
                //ID Stock 0 - Cant. individual 1 - Cant. Bultos 2 - Cant. X Bulto 3 - Nombre 4 - Costo 5 - PVU 6 - PVB 7
                StockDGV.Rows.Add(reader.GetInt32(0), reader.GetInt32(1), reader.GetInt32(2), reader.GetInt32(3), reader.GetString(4), reader.GetDecimal(5), reader.GetDecimal(6), reader.GetDecimal(7));
            }

            reader.Close();
            Conexion.closeConnection();
        }

        private void AtrasButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ABM_Stock_Load(object sender, EventArgs e)
        {

        }
    }
}
