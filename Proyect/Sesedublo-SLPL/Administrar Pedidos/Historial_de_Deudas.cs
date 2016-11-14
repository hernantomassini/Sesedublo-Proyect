using MetroFramework.Forms;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sesedublo_SLPL.Administrar_Pedidos
{
    public partial class Historial_de_Deudas : MetroForm 
    {
        public Historial_de_Deudas()
        {
            InitializeComponent();
            this.Closing += new CancelEventHandler(Avoid_Closing);
            cargarDGV();

        }

        public void cargarDGV()
        {
            MySqlDataAdapter da = Conexion.executeProcedureWithAdapter("cargarDeudas", Conexion.generarArgumentos());
            DataTable tablaDeUsuarios = new DataTable("Clientes");
            da.Fill(tablaDeUsuarios);
            deudasDGV.DataSource = tablaDeUsuarios.DefaultView;
            Conexion.closeConnection();
        }

        private void AtrasTile_Click(object sender, EventArgs e)
        {
            this.Close();
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
        }
    }
}
