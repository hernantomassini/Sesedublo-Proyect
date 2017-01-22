using iTextSharp.text;
using iTextSharp.text.pdf;
using MetroFramework.Forms;
using MySql.Data.MySqlClient;
using Sesedublo_SLPL.Generales;
using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace Sesedublo_SLPL.Historial_de_Facturasns
{
    public partial class Historial_de_Facturas : MetroForm
    {

        Validaciones val = new Validaciones();
        Funciones fun = new Funciones();

        public Historial_de_Facturas()
        {
            InitializeComponent();
            this.Closing += new CancelEventHandler(Avoid_Closing);
            this.getData();
        }

        private void Historial_de_Facturas_Load(object sender, EventArgs e)
        {

        }

        void Avoid_Closing(object sender, CancelEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void titleDetalleFactura_Click(object sender, EventArgs e)
        {
            DataGridViewRow filaMarcada = dgvFacturas.CurrentRow;

            if (!this.validarFilaMarcada(filaMarcada, this))
            {
                return;
            }

            int idFactura = Convert.ToInt32(dgvFacturas.SelectedCells[0].Value);
            int idCliente = Convert.ToInt32(dgvFacturas.SelectedCells[1].Value);
            Manejador_Formularios.Ver_Factura.meterId(idFactura, idCliente);
            Manejador_Formularios.Ver_Factura.Show();
            this.Hide();
        }

        private bool validarFilaMarcada(DataGridViewRow filaMarcada, MetroForm form)
        {
            if (filaMarcada == null)
            {
                Funciones.imprimirMensajeDeError("Debe seleccionar un cliente para dicha acción.", form);
                return false;
            }

            return true;
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        public void getData()
        {
            MySqlDataAdapter da = Conexion.executeProcedureWithAdapter("cargarGrillaFacturas", Conexion.generarArgumentos("_nombre", "_apellido", "_descripcion"), nombre.Text, apellido.Text, descripcion.Text);
            DataTable tablaDeUsuarios = new DataTable("Clientes");
            da.Fill(tablaDeUsuarios);
            dgvFacturas.DataSource = tablaDeUsuarios.DefaultView;
            dgvFacturas.Columns[1].Visible = false;

            Conexion.closeConnection();
        }

        private void nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.ingresarNombre(e);
        }

        private void apellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.ingresarNumero(e);
        }

        private void RegistroTile_Click(object sender, EventArgs e)
        {
            DataGridViewRow filaDgv = dgvFacturas.CurrentRow;

            if (!Validaciones.validarFilaMarcada(filaDgv, this))
            {
                return;
            }

            int id_factura = Convert.ToInt32(filaDgv.Cells[0].Value);
            Manejador_Formularios.VerRegistroFactura.cargarRegistro(id_factura);
            Manejador_Formularios.VerRegistroFactura.Show();
        }

        private void AddNotaCreditoTile_Click(object sender, EventArgs e)
        {
            DataGridViewRow filaDgv = dgvFacturas.CurrentRow;

            if (!Validaciones.validarFilaMarcada(filaDgv, this))
            {
                return;
            }

            int id_factura = Convert.ToInt32(filaDgv.Cells[0].Value);

            Manejador_Formularios.AddNotaDeCredito.agregarNotaCredito(id_factura);
            Manejador_Formularios.AddNotaDeCredito.getData();
            Manejador_Formularios.AddNotaDeCredito.Show();
        }

        private void nombre_TextChanged(object sender, EventArgs e)
        {
            this.getData();
        }

        private void apellido_TextChanged(object sender, EventArgs e)
        {
            this.getData();
        }

        private void descripcion_TextChanged(object sender, EventArgs e)
        {
            this.getData();
        }

        private void dgvFacturas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int idFactura = Convert.ToInt32(dgvFacturas.SelectedCells[0].Value);
            int idCliente = Convert.ToInt32(dgvFacturas.SelectedCells[1].Value);
            Manejador_Formularios.Ver_Remito.meterId(idFactura, idCliente);
            Manejador_Formularios.Ver_Factura_Dup.meterId(idFactura, idCliente);
            Manejador_Formularios.Ver_Factura_Dup.Show();
            Manejador_Formularios.Ver_Factura.meterId(idFactura, idCliente);
            Manejador_Formularios.Ver_Factura.Show();
            Manejador_Formularios.Ver_Remito.Show();
            this.Hide();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            try
            {
                Document doc = new Document(PageSize.A4.Rotate(), 10, 10, 10, 10);

                string filename = this.Text + ".pdf";
                FileStream file = new FileStream(filename, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
                PdfWriter.GetInstance(doc, file);
                doc.Open();
                fun.GenerarDocumento(doc, this.dgvFacturas);
                doc.Close();
                Process.Start(filename);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FacturasDGV_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow Myrow in dgvFacturas.Rows)
            {            //Here 2 cell is target value and 1 cell is Volume
                Myrow.Cells[0].Style.BackColor = System.Drawing.Color.White;
                Myrow.Cells[0].Style.ForeColor = System.Drawing.Color.Black;
                Myrow.Cells[7].Style.BackColor = System.Drawing.Color.White;
                Myrow.Cells[7].Style.ForeColor = System.Drawing.Color.Black;
            }
        }
    }
}
