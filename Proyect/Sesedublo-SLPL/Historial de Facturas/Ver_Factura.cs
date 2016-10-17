using MySql.Data.MySqlClient;
using Sesedublo_SLPL.Generales;
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
        }

        private void getData()
        {
            BarcodeLib.Barcode Codigo = new BarcodeLib.Barcode();
            Codigo.IncludeLabel = true;
            panel7.BackgroundImage = Codigo.Encode(BarcodeLib.TYPE.CODE128, "2503242523", Color.Black, Color.White, 131, 51);
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
            fechaVencimiento.Text = "FECHA DE VENCIMIENTO: " + DateTime.Now.AddDays(180).ToShortDateString();
            Conexion.closeConnection();
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
            MySqlDataReader reader = Conexion.executeProcedureWithReader("obtenerFactura", Conexion.generarArgumentos("_id_factura"), id_factura);

            reader.Read();
            if (reader.HasRows)
            {
                if (reader.GetString(0) != "") { tipoFactura.Text = reader.GetString(0); };
                decimal iva = decimal.Round(Convert.ToDecimal(Convert.ToDouble(reader.GetDecimal(1)) - Convert.ToDouble(reader.GetDecimal(1)) / 1.21),2);
                if (tipoFactura.Text.Equals("A"))
                {
                    if (reader.GetString(1) != "") { subTotal.Text = Convert.ToString(decimal.Round(reader.GetDecimal(1) / Convert.ToDecimal(1.21),2)); };
                    if (reader.GetString(1) != "") { subTotalPrec.Text = Convert.ToString(decimal.Round(reader.GetDecimal(1) / Convert.ToDecimal(1.21), 2)); }
                    ivaCalculado.Text = Convert.ToString(decimal.Round(iva, 2));

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

                oriOdup.Text = "ORIGINAL";
            }
            reader.Close();
            Conexion.closeConnection();

            MySqlDataAdapter da = Conexion.executeProcedureWithAdapter("obtenerItemsDeFactura", Conexion.generarArgumentos("_id_factura"), id_factura);
            DataTable tablaDeFacturas = new DataTable("Factura");
            da.Fill(tablaDeFacturas);
            dgvVerFactura.DataSource = tablaDeFacturas.DefaultView;


            decimal valor = 0;
            foreach (DataGridViewRow row in dgvVerFactura.Rows)
            {
                if (row.Cells[0].Value.ToString() == "Nota de credito")
                {
                    valor -= Convert.ToDecimal(row.Cells[4].Value);
                }
                else
                {
                    valor += Convert.ToDecimal(row.Cells[4].Value);
                }
            }
            totalT.Text = "TOTAL " + Convert.ToString(valor);

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

        private void Ver_Factura_Load(object sender, EventArgs e)
        {

        }
    }
    
}
