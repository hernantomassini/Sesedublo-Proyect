using MySql.Data.MySqlClient;
using Sesedublo_SLPL.Generales;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sesedublo_SLPL
{
    public partial class Ver_Remito : Form
    {
        
         int id_factura;
        int id_cliente;
        private PrintDocument printDocument1 = new PrintDocument();

        public Ver_Remito()
        {
            this.Controls.Add(printButton);
            InitializeComponent();
            this.Closing += new CancelEventHandler(Avoid_Closing);
            this.SetBorderAndGridlineStyles();
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
        }

         void Avoid_Closing(object sender, CancelEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
            Manejador_Formularios.Historial_de_Facturas.Show();
        }

         public void meterId(int idFactura, int idCliente)
         {
             id_factura = idFactura;
             id_cliente = idCliente;
             getData();
             MySqlDataAdapter da = Conexion.executeProcedureWithAdapter("obtenerItemsDeRemito", Conexion.generarArgumentos("_id_factura"), id_factura);
             DataTable tablaDeFacturas = new DataTable("Factura");
             da.Fill(tablaDeFacturas);

             Conexion.closeConnection();

             facturaID.Text = "REM. N° 0001-" + Convert.ToString(id_factura);

             int cantidad = 17 - tablaDeFacturas.Rows.Count;
             for (int i = 0; i <= cantidad; i++)
             {
                 DataRow fila = tablaDeFacturas.NewRow();
                 tablaDeFacturas.Rows.Add(fila);
             }

             dgvVerFactura.DataSource = tablaDeFacturas.DefaultView;
         }

         public void getData()
         {
             fechaAct.Text = "LUGAR Y FECHA: " + DateTime.Now.ToShortDateString().Replace('/', '-');
             MySqlDataReader reader = Conexion.executeProcedureWithReader("obtenerCliente", Conexion.generarArgumentos("_id_cliente"), id_cliente);

             reader.Read();
             if (reader.HasRows)
             {
                 if (reader.GetString(0) != "") { nombreLabel.Text = reader.GetString(0).ToUpper() + " -"; } else { nombreLabel.Text = ""; };
                 if (reader.GetString(3) != "") { direccionLabel.Text = reader.GetString(5).ToUpper() + " - 0 "; } else { direccionLabel.Text = ""; };
                 if (reader.GetString(0) != "") { codPostalComprador.Text = "1407-CAPITAL"; } else { codPostalComprador.Text = ""; };
                 if (reader.GetString(1) != "") { label12.Text += " " + reader.GetString(1); }
                 if (reader.GetString(2) != "") { label8.Text += " " + reader.GetString(2); }
             }
             reader.Close();
             Conexion.closeConnection();
         }

         [System.Runtime.InteropServices.DllImport("gdi32.dll")]
         public static extern long BitBlt(IntPtr hdcDest,
         int nXDest, int nYDest, int nWidth, int nHeight,
         IntPtr hdcSrc, int nXSrc, int nYSrc, int dwRop);
         private Bitmap memoryImage;
         private void CaptureScreen()
         {
             Graphics mygraphics = this.CreateGraphics();
             Size s = this.Size;
             memoryImage = new Bitmap(s.Width, s.Height,
             mygraphics);
             Graphics memoryGraphics = Graphics.FromImage(
             memoryImage);
             IntPtr dc1 = mygraphics.GetHdc();
             IntPtr dc2 = memoryGraphics.GetHdc();
             BitBlt(dc2, 0, 0, this.ClientRectangle.Width,
             this.ClientRectangle.Height, dc1, 0, 0,
             13369376);
             mygraphics.ReleaseHdc(dc1);
             memoryGraphics.ReleaseHdc(dc2);
         }

         private void printDocument1_PrintPage(System.Object
         sender, System.Drawing.Printing.PrintPageEventArgs e)
         {
             e.Graphics.DrawImage(memoryImage, 0, 0);
         }

         private void printButton_Click(System.Object sender,
         System.EventArgs e)
         {
             printButton.Visible = false;
             CaptureScreen();
             PrintPreviewDialog printPreviewDialog1;
             printPreviewDialog1 = new PrintPreviewDialog();
             printPreviewDialog1.Document = printDocument1;
             printPreviewDialog1.Show();
             printButton.Visible = true;
         }

         private void SetBorderAndGridlineStyles()
         {
             this.dgvVerFactura.GridColor = Color.Black;
             this.dgvVerFactura.BorderStyle = BorderStyle.FixedSingle;
             this.dgvVerFactura.CellBorderStyle =
                 DataGridViewCellBorderStyle.Single;
             this.dgvVerFactura.RowHeadersBorderStyle =
                 DataGridViewHeaderBorderStyle.Single;
             this.dgvVerFactura.ColumnHeadersBorderStyle =
                 DataGridViewHeaderBorderStyle.Single;
             dgvVerFactura.CurrentCell = null;
         }

    }
}
