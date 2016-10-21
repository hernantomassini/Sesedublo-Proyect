using iTextSharp.text;
using iTextSharp.text.pdf;
using MetroFramework;
using MetroFramework.Forms;
using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Windows.Forms;

namespace Sesedublo_SLPL
{
    class Funciones
    {
        private static int id_user_logeado = -1;
        private static int id_rol_userLogeado = -1;
        private static string connectionString = null;

        public static string obtenerServer()
        {
            return ConfigurationManager.AppSettings["server"];
        }

        public static string obtenerUsuario()
        {
            return ConfigurationManager.AppSettings["user"];
        }

        public static string obtenerPass()
        {
            return ConfigurationManager.AppSettings["password"];
        }

        public static string obtenerDB()
        {
            return ConfigurationManager.AppSettings["DB"];
        }

        public static DialogResult imprimirMensajeDeAlerta(string descripcionAlerta, MetroForm form)
        {
            return (MetroMessageBox.Show(form,descripcionAlerta, "Alerta", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning));
        }

        public static void imprimirMensajeDeError(string descripcionError, MetroForm form)
        {
            MetroMessageBox.Show(form,descripcionError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void imprimirMensajeDeAviso(string descripcionAviso, MetroForm form)
        {
            MetroMessageBox.Show(form, descripcionAviso, "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void limpiarDGV(DataGridView dgv)
        {
            dgv.Rows.Clear();
        }

        public static void limpiarCLB(CheckedListBox clb)
        {
            clb.Items.Clear();
        }

        public static void tirarException()
        {
            throw new NotImplementedException();
        }

        public static int getId_user_logeado()
        {
            return id_user_logeado;
        }

        public static int getId_Rol_usuarioLogeado()
        {
            return id_rol_userLogeado;
        }

        public static void setId_user_logeado(int id_user)
        {
            id_user_logeado = id_user;
        }

        public static void setId_Rol_usuarioLogeado(int id_rol)
        {
            id_rol_userLogeado = id_rol;
        }

        public static string getStringConnection()
        {
            if (connectionString == null)
            {

                MySqlConnectionStringBuilder conexionBuilder = new MySqlConnectionStringBuilder();
                conexionBuilder.Server = Funciones.obtenerServer();
                conexionBuilder.UserID = Funciones.obtenerUsuario();
                conexionBuilder.Password = Funciones.obtenerPass();
                conexionBuilder.Database = Funciones.obtenerDB();

                connectionString = conexionBuilder.ToString();
            }

            return connectionString;
        }

        public void GenerarDocumento(Document document, DataGridView dataGridView1)
        {

            //se crea un objeto PdfTable con el numero de columnas del
            PdfPTable datatable = new PdfPTable(dataGridView1.ColumnCount);
            //asignamos algunas propiedades para el diseño del pdf 
            datatable.DefaultCell.Padding = 3;
            float[] headerwidths = GetTamañoColumnas(dataGridView1);
            datatable.SetWidths(headerwidths);
            datatable.WidthPercentage = 100;
            datatable.DefaultCell.BorderWidth = 2;
            datatable.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER;
            //SE GENERA EL ENCABEZADO DE LA TABLA EN EL PDF 
            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                datatable.AddCell(dataGridView1.Columns[i].HeaderText);
            }
            datatable.HeaderRows = 1; datatable.DefaultCell.BorderWidth = 1;
            //SE GENERA EL CUERPO DEL PDF 
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    datatable.AddCell(dataGridView1[j, i].Value.ToString());
                }
                datatable.CompleteRow();
            }
            //SE AGREGAR LA PDFPTABLE AL DOCUMENTO 
            document.Add(datatable);
        }

        //Función que obtiene los tamaños de las columnas del grid 
        public float[] GetTamañoColumnas(DataGridView dg)
        {
            float[] values = new float[dg.ColumnCount];
            for (int i = 0; i < dg.ColumnCount; i++)
            {
                values[i] = (float)dg.Columns[i].Width;
            }
            return values;
        }
    }
}
