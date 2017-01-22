using MetroFramework.Forms;
using MySql.Data.MySqlClient;
using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace Sesedublo_SLPL.Historial_de_Facturasns
{
    public partial class VerRegistroFactura : MetroForm
    {
        int id_factura = -1;
        public VerRegistroFactura()
        {
            InitializeComponent();
            this.Closing += new CancelEventHandler(Avoid_Closing);
        }

        void Avoid_Closing(object sender, CancelEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void VerRegistroFactura_Load(object sender, EventArgs e)
        {

        }

        public void cargarRegistro(int _id_factura)
        {
            //TODO - Cargar DGV con los datos de las notas de credito valor - motivo
            this.id_factura = _id_factura;

            MySqlDataAdapter da = Conexion.executeProcedureWithAdapter("cargarNotasDeCredito", Conexion.generarArgumentos("_id_factura"), id_factura);
            DataTable tablaDeNotasDeCredito = new DataTable("NotasDeCredito");
            da.Fill(tablaDeNotasDeCredito);
            registrosDGV.DataSource = tablaDeNotasDeCredito.DefaultView;
            registrosDGV.Columns[0].Visible = false;
            Conexion.closeConnection();

        }

        private void CerrarTile_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void registrosDGV_CellFormatting(object sender, System.Windows.Forms.DataGridViewCellFormattingEventArgs e)
        {
            registrosDGV.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            registrosDGV.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
    }
}
