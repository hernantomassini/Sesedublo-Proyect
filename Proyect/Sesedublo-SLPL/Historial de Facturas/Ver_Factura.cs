﻿using MySql.Data.MySqlClient;
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
            this.SetBorderAndGridlineStyles();
            this.Closing += new CancelEventHandler(Avoid_Closing);

            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
            this.WindowState = FormWindowState.Maximized;
        }

        private void getData()
        {
            BarcodeLib.Barcode Codigo = new BarcodeLib.Barcode();
            Codigo.IncludeLabel = true;
            panel7.BackgroundImage = Codigo.Encode(BarcodeLib.TYPE.CODE128, "2503242523", Color.Black, Color.White, 131, 51);

            fechaAct.Text = "LUGAR Y FECHA: " + DateTime.Now.ToShortDateString().Replace('/','-');
            MySqlDataReader reader = Conexion.executeProcedureWithReader("obtenerCliente", Conexion.generarArgumentos("_id_cliente"), id_cliente);

            reader.Read();
            if (reader.HasRows)
            {
                if (reader.GetString(0) != "") { nombreLabel.Text = reader.GetString(0).ToUpper() + " -"; } else { nombreLabel.Text = ""; };
                if (reader.GetString(3) != "") { direccionLabel.Text = reader.GetString(5).ToUpper() + " - 0 "; } else { direccionLabel.Text = ""; };
                if (reader.GetString(0) != "") { codPostalComprador.Text = "1407-CAPITAL"; } else { codPostalComprador.Text = ""; };
                if (reader.GetString(1) != "") { label12.Text += " " + reader.GetString(1) ; }
                if (reader.GetString(2) != "") { label14.Text += " " + reader.GetString(2); }
                if (reader.GetString(0) != "") { codPostalComprador.Text = "1407-CAPITAL"; } else { codPostalComprador.Text = ""; };
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

            int cantidad = 17 - tablaDeFacturas.Rows.Count;
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
                    if(!String.IsNullOrEmpty(row.Cells[4].Value.ToString())){
                      valor += Convert.ToDecimal(row.Cells[4].Value);
                    };
                }
            }
            totalT.Text = Convert.ToString(valor);

            Conexion.closeConnection();

            facturaID.Text = "FACTURA N° 0001-" + Convert.ToString(id_factura);
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
    }
    
}
