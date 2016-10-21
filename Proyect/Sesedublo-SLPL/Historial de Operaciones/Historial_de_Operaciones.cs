using iTextSharp.text;
using iTextSharp.text.pdf;
using MetroFramework.Forms;
using MySql.Data.MySqlClient;
using Sesedublo_SLPL.Generales;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sesedublo_SLPL.Historial_de_Operacionesns
{
    public partial class Historial_de_Operaciones : MetroForm
    {
        Funciones fun = new Funciones();

        public Historial_de_Operaciones()
        {
            InitializeComponent();
            this.Closing += new CancelEventHandler(Avoid_Closing);
            this.getData();
        }

        void Avoid_Closing(object sender, CancelEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void Historial_de_Operaciones_Load(object sender, EventArgs e)
        {

        }

        public void getData()
        {
            MySqlDataAdapter da = Conexion.executeProcedureWithAdapter("cargarGrillaDeOperaciones", Conexion.generarArgumentos("_operacion", "_descripcion"), operacion.Text, descripcion.Text);
            DataTable tablaDeUsuarios = new DataTable("Clientes");
            da.Fill(tablaDeUsuarios);
            dgvOperaciones.DataSource = tablaDeUsuarios.DefaultView;

            Conexion.closeConnection();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void operacion_TextChanged(object sender, EventArgs e)
        {
            this.getData();
        }

        private void descripcion_TextChanged(object sender, EventArgs e)
        {
            this.getData();
        }


        Validaciones val = new Validaciones();
        private void operacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.ingresarNombre(e);
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            try
            {
                Document doc = new Document(PageSize.A4.Rotate(), 10, 10, 10, 10);

                string filename = this.Text + ".pdf";
                FileStream file = new FileStream(filename, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
                PdfWriter.GetInstance(doc, file);
                doc.Open();
                fun.GenerarDocumento(doc, this.dgvOperaciones);
                doc.Close();
                Process.Start(filename);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
