using MetroFramework.Forms;
using MySql.Data.MySqlClient;
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

namespace Sesedublo_SLPL.Historial_de_Facturasns
{
    public partial class Ver_Factura : Form
    {
        int id_factura;
        int id_cliente;
        private PrintDocument printDocument1 = new PrintDocument();

        public Ver_Factura()
        {
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
            this.Controls.Add(printButton);
            InitializeComponent();

            facturaID.Text = "FACTURA N° 00001-" + Convert.ToString(id_factura);
            direccionLea.Text = "Elpidio Gonzales 9510";
            CPLea.Text = "C1416EFP CABA";
            TelLea.Text = "Tel/Fax 4639-5712";
            fechaAct.Text = "FECHA: " + Convert.ToString(DateTime.Now);
            tipoFactura.Text = "A";
            CUITLea.Text = "CUIT: 30-70850524-9";
            ingresosBrutos.Text = "INGRESOS BRUTOS: 901-070815-6";
            inicioActividad.Text = "INICIO ACTIVIDAD: 01-10-2003";
            id_cliente = 1;
            MySqlDataReader reader = Conexion.executeProcedureWithReader("obtenerCliente", Conexion.generarArgumentos("_id_cliente"), id_cliente);

            reader.Read();
            if (reader.HasRows)
            {
                if (!reader[4].Equals(DBNull.Value) || reader.GetString(4) != "") { direccionVen.Text = "DIRECCIÓN: " + reader.GetString(4); } else { direccionVen.Text = ""; };
                if (!reader[5].Equals(DBNull.Value) || reader.GetString(5) != "") { localidadCl.Text = "LOCALIDAD: " + reader.GetString(5); } else { localidadCl.Text = ""; };
                if (!reader[6].Equals(DBNull.Value) || reader.GetString(6) != "") { cuitV.Text = "CUIT: " + reader.GetString(6); } else { cuitV.Text = ""; };
                if (!reader[7].Equals(DBNull.Value) || reader.GetString(7) != "") { RazonSocialComp.Text = "RAZÓN SOCIAL: " + reader.GetString(7); } else { RazonSocialComp.Text = ""; };
                id_usuarioCompr.Text = "Cod. vendedor: " + id_cliente;
            }
            reader.Close();

            fechaActualImp.Text = Convert.ToString(DateTime.Now);
            fechaVencimiento.Text = Convert.ToString(DateTime.Now.AddDays(29));
            Conexion.closeConnection();
            
        }

        public void meterId(int idFactura, int idCliente)
        {
            id_factura = idFactura;
            id_cliente = idCliente;
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

            oriOdup.Text = "ORIGINAL";

            printButton.Visible = false;
            CaptureScreen();
            PrintPreviewDialog printPreviewDialog1;
            printPreviewDialog1 = new PrintPreviewDialog();
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.Show();

            oriOdup.Text = "DUPLICADO";

            CaptureScreen();
            PrintPreviewDialog printPreviewDialog2;
            printPreviewDialog2 = new PrintPreviewDialog();
            printPreviewDialog2.Document = printDocument1;
            printPreviewDialog2.Show();

            printButton.Visible = true;
        }
    }
    
}
