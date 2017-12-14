using MetroFramework.Forms;
using MySql.Data.MySqlClient;
using Sesedublo_SLPL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sesedublo_reloaded.Pedidos_de_Compra
{
    public partial class Historial_de_Deudas_Compras : MetroForm
    {
        public Historial_de_Deudas_Compras()
        {
            InitializeComponent();
            this.Closing += new CancelEventHandler(Avoid_Closing);
            cargarDGV();
        }

        public void cargarDGV()
        {
            MySqlDataAdapter da = Conexion.executeProcedureWithAdapter("cargarDeudasDeCompra", Conexion.generarArgumentos("_nombre"), nombre.Text);
            DataTable tablaDeUsuarios = new DataTable("Clientes");
            da.Fill(tablaDeUsuarios);
            deudasDGV.DataSource = tablaDeUsuarios.DefaultView;
            Conexion.closeConnection();
            this.updateMontoDeudas();

        }

        public void updateMontoDeudas()
        {
            MySqlDataReader reader = Conexion.executeProcedureWithReader("obtenerMontoEnDeudasDeCompra", Conexion.generarArgumentos());
            reader.Read();
            decimal montoEnEfectivo;

            if (!reader[0].Equals(DBNull.Value)) {
                montoEnEfectivo = decimal.Round(reader.GetDecimal(0), 2);
            }
            else
            {
                montoEnEfectivo = 0;
            }

            reader.Close();
            Conexion.closeConnection();

            this.deuda.Text = "Deuda Total: " + montoEnEfectivo;
        }

        void Avoid_Closing(object sender, CancelEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void deudasDGV_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow Myrow in deudasDGV.Rows)
            {            //Here 2 cell is target value and 1 cell is Volume
                if (Convert.ToString(Myrow.Cells[3].Value) == "SI")// Or your condition 
                {
                    Myrow.Cells[3].Style.BackColor = System.Drawing.Color.Green;
                }
                else
                {
                    Myrow.Cells[3].Style.BackColor = System.Drawing.Color.Red;

                }

                Myrow.Cells[3].Style.ForeColor = System.Drawing.Color.White;
                Myrow.Cells[0].Style.ForeColor = System.Drawing.Color.Black;
                Myrow.Cells[2].Style.ForeColor = System.Drawing.Color.Black;
            }
            deudasDGV.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            deudasDGV.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void AtrasTile_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nombre_TextChanged_1(object sender, EventArgs e)
        {
            this.cargarDGV();
        }
    }
}
