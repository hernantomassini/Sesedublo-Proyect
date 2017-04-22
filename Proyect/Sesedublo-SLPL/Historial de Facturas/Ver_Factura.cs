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
    public partial class Ver_Factura : Form
    {
        int id_factura;
        int id_cliente;
        private PrintDocument printDocument1 = new PrintDocument();

        public Ver_Factura()
        {

            this.Controls.Add(printButton);
            InitializeComponent(); this.Closing += new CancelEventHandler(Avoid_Closing);
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
            this.SetBorderAndGridlineStyles();
        }

        private void getData()
        {
            BarcodeLib.Barcode Codigo = new BarcodeLib.Barcode();
            Codigo.IncludeLabel = true;
            panel7.BackgroundImage = Codigo.Encode(BarcodeLib.TYPE.CODE128, "2503242523", Color.Black, Color.White, 131, 51);
            this.label24.Text = Conexion.tipo; 
            MySqlDataReader reader = Conexion.executeProcedureWithReader("obtenerClienteParaFactura", Conexion.generarArgumentos("_id_cliente"), id_cliente);

            reader.Read();
            if (reader.HasRows)
            {
                if (reader.GetString(0) != "") { nombreLabel.Text = reader.GetString(0).ToUpper(); }
                if (reader.GetString(1) != "") { direccionLabel.Text = "DIRECCION: " + reader.GetString(1).ToUpper(); }
                if (reader.GetString(3) != "") { label12.Text = "CONTACTO: " + reader.GetString(3).ToUpper(); }
                if (reader.GetString(2) != "") { label14.Text = "TEL.: " + reader.GetString(2).ToUpper(); }
                if (reader.GetString(4) != "") { cuilComprador.Text = "CUIL: " + reader.GetString(4).ToUpper(); }
                if (reader.GetString(5) != "") { localidadLbl.Text = "LOCALIDAD: " + reader.GetString(5).ToUpper(); }
                
            }
            reader.Close();
            Conexion.closeConnection();

            fechaActualImp.Text = "FECHA DE IMPRESIÓN: " + DateTime.Now.ToShortDateString();
            fechaVencimiento.Text = "FECHA DE VENCIMIENTO: " + DateTime.Now.AddDays(180).ToShortDateString();

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

                fechaAct.Text = "LUGAR Y FECHA: " + reader.GetDateTime(2).ToShortDateString().Replace('/', '-');

                if (reader.GetString(0) != "") { tipoFactura.Text = reader.GetString(0); };
                decimal iva = decimal.Round(Convert.ToDecimal(Convert.ToDouble(reader.GetDecimal(1)) - Convert.ToDouble(reader.GetDecimal(1)) / 1.21), 2);
                if (tipoFactura.Text.Equals("A"))
                {
                    if (reader.GetString(1) != "") { subTotal.Text = Convert.ToString(decimal.Round(reader.GetDecimal(1) / Convert.ToDecimal(1.21), 2)); };
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

            int cantidad = 15 - tablaDeFacturas.Rows.Count;
            for (int i = 0; i <= cantidad; i++)
            {
                DataRow fila = tablaDeFacturas.NewRow();
                tablaDeFacturas.Rows.Add(fila);
            }

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
                    if (!String.IsNullOrEmpty(row.Cells[4].Value.ToString()))
                    {
                        valor += Convert.ToDecimal(row.Cells[4].Value);
                    };
                }
            }
            totalT.Text = Convert.ToString(valor);

            Conexion.closeConnection();

            facturaID.Text = "FAC. N° 0001-" + Convert.ToString(id_factura);
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
            metroTile1.Visible = false;

            CaptureScreen();
            PrintPreviewDialog printPreviewDialog1;
            printPreviewDialog1 = new PrintPreviewDialog();
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.Show();
            printButton.Visible = true;
            metroTile1.Visible = true;

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
        }

        public static Bitmap TakeDialogScreenshot(Form window)
        {
            var b = new Bitmap(window.Width, window.Height);
            window.DrawToBitmap(b, new Rectangle(0, 0, window.Width, window.Height));

            Point p = window.PointToScreen(Point.Empty);

            Bitmap target = new Bitmap(window.ClientSize.Width, window.ClientSize.Height);
            using (Graphics g = Graphics.FromImage(target))
            {
                g.DrawImage(b, 0, 0,
                            new Rectangle(p.X - window.Location.X, p.Y - window.Location.Y,
                                          target.Width, target.Height),
                           GraphicsUnit.Pixel);
            }
            b.Dispose();
            return target;
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            printButton.Visible = false;
            metroTile1.Visible = false;

            Bitmap bitmap = TakeDialogScreenshot(this);
            SaveFileDialog saveDialog = new SaveFileDialog();

            printButton.Visible = true;
            metroTile1.Visible = true;

            saveDialog.FileName = facturaID.Text + "-ORIGINAL";
            saveDialog.DefaultExt = "jpg";
            saveDialog.Filter = "JPG images (*.jpg)|*.jpg";

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                var fileName = saveDialog.FileName;
                bitmap.Save(fileName, System.Drawing.Imaging.ImageFormat.Jpeg);
            }

        }
    }
}
