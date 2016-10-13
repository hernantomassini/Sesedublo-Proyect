using MySql.Data.MySqlClient;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace Sesedublo_SLPL.Historial_de_Facturasns
{
    public partial class Ver_Factura : Form
    {
        int id_factura;
        int id_cliente;
        private PrintDocument printDocument1 = new PrintDocument();
        private PrintDocument printDocument2 = new PrintDocument();

        public Ver_Factura()
        {

            this.Controls.Add(printButton);
            InitializeComponent();
            this.Closing += new CancelEventHandler(Avoid_Closing);

            direccionLea.Text = "Elpidio Gonzales 9510";
            CPLea.Text = "C1416EFP CABA";
            TelLea.Text = "Tel/Fax 4639-5712";
            CUITLea.Text = "CUIT: 30-70850524-9";
            ingresosBrutos.Text = "INGRESOS BRUTOS: 901-070815-6";
            inicioActividad.Text = "INICIO ACTIVIDAD: 01-10-2003";
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
            oriOdup.Text = "DUPLICADO";
            printDocument2.PrintPage += new PrintPageEventHandler(printDocument2_PrintPage);
        }

        private void getData()
        {
            fechaAct.Text = "FECHA: " + DateTime.Now.ToShortDateString();
            MySqlDataReader reader = Conexion.executeProcedureWithReader("obtenerCliente", Conexion.generarArgumentos("_id_cliente"), id_cliente);

            reader.Read();
            if (reader.HasRows)
            {
                if (reader.GetString(4) != "") { direccionVen.Text = "DIRECCIÓN: " + reader.GetString(4); } else { direccionVen.Text = ""; };
                if (reader.GetString(5) != "") { localidadCl.Text = "LOCALIDAD: " + reader.GetString(5); } else { localidadCl.Text = ""; };
                if (reader.GetString(6) != "") { cuitV.Text = "CUIT: " + reader.GetString(6); } else { cuitV.Text = ""; };
                if (reader.GetString(7) != "") { RazonSocialComp.Text = "RAZÓN SOCIAL: " + reader.GetString(7); } else { RazonSocialComp.Text = ""; };
                id_usuarioCompr.Text = "Cod. vendedor: " + id_cliente;
            }
            reader.Close();

            fechaActualImp.Text = "FECHA DE IMPRESIÓN: " + DateTime.Now.ToShortDateString();
            fechaVencimiento.Text = "FECHA DE VENCIMIENTO: " + DateTime.Now.AddDays(29).ToShortDateString();
            Conexion.closeConnection();
        }


        void Avoid_Closing(object sender, CancelEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        public void meterId(int idFactura, int idCliente)
        {
            id_factura = idFactura;
            id_cliente = idCliente;
            getData();
            MySqlDataReader reader = Conexion.executeProcedureWithReader("obtenerFactura", Conexion.generarArgumentos("_id_factura"), id_factura);

            reader.Read();
            if (reader.HasRows)
            {
                if (reader.GetString(0) != "") { tipoFactura.Text = reader.GetString(0); };
                double iva = Convert.ToDouble(reader.GetDecimal(1)) * 0.21;
                if (tipoFactura.Text.Equals("A"))
                {
                    if (reader.GetString(1) != "") { subTotal.Text = Convert.ToString(reader.GetDecimal(1)); };
                    if (reader.GetString(1) != "") { subTotalPrec.Text = Convert.ToString(reader.GetDecimal(1)); }
                    ivaCalculado.Text = Convert.ToString(iva);

                    sub.Visible = true;
                    subTotal.Visible = true;
                    subTotalPrec.Visible = true;
                    IVA.Visible = true;
                    ivaCalculado.Visible = true;
                    label2.Visible = true;
                }
                else
                {
                    label2.Visible = false;
                    sub.Visible = false;
                    subTotal.Visible = false;
                    subTotalPrec.Visible = false;
                    IVA.Visible = false;
                    ivaCalculado.Visible = false;
                }

                totalT.Text = "TOTAL " + Convert.ToString(Convert.ToDecimal(iva) + reader.GetDecimal(1));

                oriOdup.Text = "ORIGINAL";
            }
            reader.Close();
            Conexion.closeConnection();

            MySqlDataAdapter da = Conexion.executeProcedureWithAdapter("obtenerItemsDeFactura", Conexion.generarArgumentos("_id_factura"), id_factura);
            DataTable tablaDeFacturas = new DataTable("Factura");
            da.Fill(tablaDeFacturas);
            dgvVerFactura.DataSource = tablaDeFacturas.DefaultView;

            dgvVerFactura.Columns[1].Width = 130;
            dgvVerFactura.Columns[3].Width = 130;
            dgvVerFactura.Columns[2].Width = 130;
            Conexion.closeConnection();

            facturaID.Text = "FACTURA N° 00001-" + Convert.ToString(id_factura);
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

        private void printDocument2_PrintPage(System.Object
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

            CaptureScreen();
            PrintPreviewDialog printPreviewDialog2;
            printPreviewDialog2 = new PrintPreviewDialog();
            printPreviewDialog2.Document = printDocument2;
            printPreviewDialog2.Show();

            printButton.Visible = true;
        }

        private void Ver_Factura_Load(object sender, EventArgs e)
        {

        }
    }
    
}
