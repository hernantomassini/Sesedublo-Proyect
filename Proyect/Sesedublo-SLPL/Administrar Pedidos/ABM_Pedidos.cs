using MetroFramework.Forms;
using MySql.Data.MySqlClient;
using Sesedublo_SLPL.Generales;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace Sesedublo_SLPL.Administrar_Pedidos
{
    public partial class ABM_Pedidos : MetroForm
    {
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

            if (Convert.ToInt32(filaDgv.Cells[5].Value) == 1)
            {
                Funciones.imprimirMensajeDeError("No puede eliminar un pedido ya facturado, que no fue del todo cobrado", this);
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

            if(Convert.ToInt32(filaDgv.Cells[5].Value) == 1)
            {
                Funciones.imprimirMensajeDeError("No puede modificar un pedido que ya ha sido facturado, sólo modificar su monto del debe", this);
                return;
            }

            int id_pedido = Convert.ToInt32(filaDgv.Cells[0].Value);

            Manejador_Formularios.AddProductoAPedido.modificarPedido(id_pedido);
            Manejador_Formularios.AddProductoAPedido.Show();
            Close();
        }

        private void AgregarPedidoTile_Click(object sender, EventArgs e)
        {
            Manejador_Formularios.AgregarPedido.Clean();
            Manejador_Formularios.AgregarPedido.Show();
            Close();
        }

        private void FacturarPedidoTile_Click(object sender, EventArgs e)
        {
            DataGridViewRow filaDgv = PedidosDGV.CurrentRow;

            if (!Validaciones.validarFilaMarcada(filaDgv, this))
            {
                return;
            }

            if (Convert.ToInt32(filaDgv.Cells[5].Value) == 1)
            {
                Funciones.imprimirMensajeDeError("La siguiente factura ya ha sido facturada", this);
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

        public void cargarDGV()
        {
            Funciones.limpiarDGV(PedidosDGV);
            MySqlDataReader reader = Conexion.executeProcedureWithReader("obtenerPedidos", Conexion.generarArgumentos("_nombre"),nombre.Text);
            
            while (reader.Read())
            {
                //ID Stock 0 - Nombre 1 - Costo 2 - Debe 3 - Lista strings 4 - facturada 5
                PedidosDGV.Rows.Add(reader.GetInt32(0), reader.GetString(1), reader.GetDecimal(2), reader.GetDecimal(3), reader.GetString(4), reader.GetInt32(5));
            }

            PedidosDGV.Columns[5].Visible = false;
            reader.Close();
            Conexion.closeConnection();
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
            if (Convert.ToInt32(filaDgv.Cells[5].Value) == 1)
            {
                Funciones.imprimirMensajeDeError("No puede modificar un pedido que ya ha sido facturado, sólo modificar su monto del debe", this);
                return;
            }

            int id_pedido = Convert.ToInt32(filaDgv.Cells[0].Value);

            Manejador_Formularios.AddProductoAPedido.modificarPedido(id_pedido);
            Manejador_Formularios.AddProductoAPedido.Show();
            Close();
        }

        private void nombre_TextChanged(object sender, EventArgs e)
        {
            this.cargarDGV();
        }
    }
}
