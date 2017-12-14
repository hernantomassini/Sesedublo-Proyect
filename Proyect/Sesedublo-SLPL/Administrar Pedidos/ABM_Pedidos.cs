﻿
using iTextSharp.text;
using iTextSharp.text.pdf;
using MetroFramework.Forms;
using MySql.Data.MySqlClient;
using Sesedublo_SLPL.Generales;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Sesedublo_SLPL.Administrar_Pedidos
{
    public partial class ABM_Pedidos : MetroForm
    {
        Funciones fun = new Funciones();
        Validaciones val = new Validaciones();

        public ABM_Pedidos()
        {
            InitializeComponent();
            this.Closing += new CancelEventHandler(Avoid_Closing);
            cargarDGV();
        }

        void Avoid_Closing(object sender, CancelEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void AtrasTile_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void EliminarPedidoTile_Click(object sender, EventArgs e)
        {
            DataGridViewRow filaDgv = PedidosDGV.CurrentRow;

            if (!Validaciones.validarFilaMarcada(filaDgv, this))
            {
                return;
            }

            if (Convert.ToString(filaDgv.Cells[5].Value) == "SI")
            {
                Funciones.imprimirMensajeDeError("No puede eliminar un pedido ya facturado, que no fue del todo cobrado", this);
                return;
            }

            decimal precioP = Convert.ToDecimal(filaDgv.Cells[8].Value);
            decimal debeP = Convert.ToDecimal(filaDgv.Cells[3].Value);

            if (Decimal.Compare(debeP, precioP) != 0)
            {
                Funciones.imprimirMensajeDeError("No se puede eliminar un pedido que ya ha sido empezado a pagarse, contacte a su administrador", this);
                return;
            }

            if (Funciones.imprimirMensajeDeAlerta("¿Estás seguro de borrar este pedido? Esta acción no se podrá deshacer.", this) == DialogResult.Cancel)
            {
                return;
            }

            int id_pedido = Convert.ToInt32(filaDgv.Cells[0].Value);

            MySqlDataReader reader = Conexion.executeProcedureWithReader("obtenerItems", Conexion.generarArgumentos("_id_pedido"), id_pedido);
            Dictionary<int, int> stockAReincorporar = new Dictionary<int, int>();

            while (reader.Read())
            {
                stockAReincorporar.Add(reader.GetInt32(0), reader.GetInt32(1));
            }

            reader.Close();
            Conexion.closeConnection();

            foreach (var registro in stockAReincorporar)
            {
                Conexion.executeProcedure("updatearStock", Conexion.generarArgumentos("_id_stock", "_cantidad"), registro.Key, registro.Value);
                Conexion.closeConnection();
            }

            Conexion.executeProcedure("borrarPedido", Conexion.generarArgumentos("_id_pedido"), id_pedido);
            Conexion.closeConnection();

            cargarDGV();
        }

        private void modificarPedidoTile_Click(object sender, EventArgs e)
        {
            DataGridViewRow filaDgv = PedidosDGV.CurrentRow;

            if (!Validaciones.validarFilaMarcada(filaDgv, this))
            {
                return;
            }

            if (Convert.ToString(filaDgv.Cells[5].Value) == "SI")
            {
                Funciones.imprimirMensajeDeError("No puede modificar un pedido que ya ha sido facturado, sólo modificar su monto del debe", this);
                return;
            }

            decimal precioP = Convert.ToDecimal(filaDgv.Cells[8].Value);
            decimal debeP = Convert.ToDecimal(filaDgv.Cells[3].Value);

            //if (Decimal.Compare(debeP, precioP) != 0)
            //{
            //    Funciones.imprimirMensajeDeError("No se puede modificar un pedido que ya ha sido empezado a pagarse, contacte a su administrador", this);
            //    return;
            //}

            int id_pedido = Convert.ToInt32(filaDgv.Cells[0].Value);

            Manejador_Formularios.AddProductoAPedido.modificarPedido(id_pedido);
            Manejador_Formularios.AddProductoAPedido.Show();
            Close();
        }

        private void AgregarPedidoTile_Click(object sender, EventArgs e)
        {
            Manejador_Formularios.AgregarPedido.Clean();
            Manejador_Formularios.AgregarPedido.Show();
            Manejador_Formularios.AgregarPedido.cargarDGVUsuarios();
            Close();
        }

        private void FacturarPedidoTile_Click(object sender, EventArgs e)
        {
            DataGridViewRow filaDgv = PedidosDGV.CurrentRow;

            if (!Validaciones.validarFilaMarcada(filaDgv, this))
            {
                return;
            }

            if (Convert.ToString(filaDgv.Cells[5].Value) == "SI")
            {
                Funciones.imprimirMensajeDeError("El siguiente pedido ya ha sido facturada", this);
                return;
            }

            if (Funciones.imprimirMensajeDeAlerta("¿Estás seguro de generar la factura?", this) == DialogResult.Cancel)
            {
                return;
            }


            int id_pedido = Convert.ToInt32(filaDgv.Cells[0].Value);

            Manejador_Formularios.GenerarFactura.crearFactura(id_pedido);
            Manejador_Formularios.GenerarFactura.Show();
        }

        private void ABM_Pedidos_Load(object sender, EventArgs e)
        {

        }

        public void Clean()
        {
            nombre.Clear();
        }

        public void cargarDGV()
        {
            Funciones.limpiarDGV(PedidosDGV);
            MySqlDataReader reader = Conexion.executeProcedureWithReader("obtenerPedidos", Conexion.generarArgumentos("_nombre", "_id_pedido", "_id_factura"), nombre.Text, id_pedido.Text, metroTextBox1.Text);

            while (reader.Read())
            {
                String id_pedido_valor;


                if (reader[6].Equals(DBNull.Value))
                {
                    id_pedido_valor = "No tiene";
                }
                else
                {
                    id_pedido_valor = Convert.ToString(reader.GetInt32(6));
                }
                //ID Stock 0 - Nombre 1 - Costo 2 - Debe 3 - Lista strings 4 - facturada 5 - numero de factura 6
                PedidosDGV.Rows.Add(reader.GetInt32(0), reader.GetString(1), reader.GetDecimal(2), reader.GetDecimal(3), reader.GetString(4), this.verSiONo(reader.GetInt32(5)), this.verSiONoDec(reader.GetInt32(3)), id_pedido_valor, reader.GetDecimal(7));
            }
            reader.Close();
            Conexion.closeConnection();
            PedidosDGV.Columns[4].Width = 300;
        }

        private string verSiONo(int valor)
        {
            if (valor == 1)
            {
                return "SI";
            }
            else
            {
                return "NO";
            }
        }

        private string verSiONoDec(int valor)
        {
            if (valor == 0)
            {
                return "SI";
            }
            else
            {
                return "NO";
            }
        }

        private void ActualizarPagoTile_Click(object sender, EventArgs e)
        {
            DataGridViewRow filaDgv = PedidosDGV.CurrentRow;

            if (!Validaciones.validarFilaMarcada(filaDgv, this))
            {
                return;
            }

            if (Convert.ToInt32(filaDgv.Cells[3].Value) == 0)
            {
                Funciones.imprimirMensajeDeError("El cliente ya pagó todo lo acordado según lo que puso previamente", this);
            }
            else
            {

                int id_pedido = Convert.ToInt32(filaDgv.Cells[0].Value);

                Manejador_Formularios.ActualizarPago.cargarDatos(id_pedido);
                Manejador_Formularios.ActualizarPago.Show();
            }

        }

        private void PedidosDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewRow filaDgv = PedidosDGV.CurrentRow;

            if (!Validaciones.validarFilaMarcada(filaDgv, this))
            {
                return;
            }

            if (Convert.ToString(filaDgv.Cells[5].Value) == "SI")
            {
                Funciones.imprimirMensajeDeError("No puede modificar un pedido que ya ha sido facturado, sólo modificar su monto del debe", this);
                return;
            }

            decimal precioP = Convert.ToDecimal(filaDgv.Cells[8].Value);
            decimal debeP = Convert.ToDecimal(filaDgv.Cells[3].Value);

            //if (Decimal.Compare(debeP, precioP) != 0)
            //{
            //    Funciones.imprimirMensajeDeError("No se puede modificar un pedido que ya ha sido empezado a pagarse, contacte a su administrador", this);
            //    return;
            //}

            int id_pedido = Convert.ToInt32(filaDgv.Cells[0].Value);

            Manejador_Formularios.AddProductoAPedido.modificarPedido(id_pedido);
            Manejador_Formularios.AddProductoAPedido.Show();
            Close();
        }

        private void nombre_TextChanged(object sender, EventArgs e)
        {
            this.cargarDGV();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            try
            {
                Document doc = new Document(PageSize.A4.Rotate(), 10, 10, 10, 10);

                string filename = this.Text + ".pdf";
                FileStream file = new FileStream(filename, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
                PdfWriter.GetInstance(doc, file);
                doc.Open();
                fun.GenerarDocumento(doc, this.PedidosDGV);
                doc.Close();
                Process.Start(filename);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void PedidosDGV_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow Myrow in PedidosDGV.Rows)
            {            //Here 2 cell is target value and 1 cell is Volume
                if (Convert.ToString(Myrow.Cells[5].Value) == "SI")// Or your condition 
                {
                    Myrow.Cells[5].Style.BackColor = System.Drawing.Color.Green;
                }
                else
                {
                    Myrow.Cells[5].Style.BackColor = System.Drawing.Color.Red;

                }

                if (Convert.ToString(Myrow.Cells[6].Value) == "SI")// Or your condition 
                {
                    Myrow.Cells[6].Style.BackColor = System.Drawing.Color.Green;
                }
                else
                {
                    Myrow.Cells[6].Style.BackColor = System.Drawing.Color.Red;

                }

                Myrow.Cells[6].Style.ForeColor = System.Drawing.Color.White;
                Myrow.Cells[5].Style.ForeColor = System.Drawing.Color.White;

                Myrow.Cells[0].Style.BackColor = System.Drawing.Color.OrangeRed;
                Myrow.Cells[0].Style.ForeColor = System.Drawing.Color.White;
                Myrow.Cells[7].Style.BackColor = System.Drawing.Color.Orange;
                Myrow.Cells[7].Style.ForeColor = System.Drawing.Color.White;
            }

            PedidosDGV.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            PedidosDGV.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            PedidosDGV.Columns[4].Width = 120;
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            Manejador_Formularios.Historial_de_Deudas.cargarDGV();
            Manejador_Formularios.Historial_de_Deudas.Show();
        }

        private void descripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.ingresarNumero(e);
        }

        private void metroTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.ingresarNumero(e);
        }

        private void id_pedido_TextChanged(object sender, EventArgs e)
        {
            this.cargarDGV();
        }

        private void metroTextBox1_TextChanged(object sender, EventArgs e)
        {
            this.cargarDGV();
        }
    }
}
