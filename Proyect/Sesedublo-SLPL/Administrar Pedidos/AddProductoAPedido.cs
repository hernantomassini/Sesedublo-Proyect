using System;
using MetroFramework.Forms;
using System.ComponentModel;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Windows.Forms;
using Sesedublo_SLPL.Generales;
using Enums;

namespace Sesedublo_SLPL.Administrar_Pedidos
{
    public partial class AddProductoAPedido : MetroForm
    {
        Dictionary<int, int> productosAVender = new Dictionary<int, int>();
        accionesABM flag = accionesABM.Crear;
        int id_cliente = -1;
        decimal sumatoriaMoney = 0;

        public AddProductoAPedido()
        {
            InitializeComponent();
            this.Closing += new CancelEventHandler(Avoid_Closing);
        }

        void Avoid_Closing(object sender, CancelEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        public void crearPedido(int id_cliente)
        {
            this.id_cliente = id_cliente;
            sumatoriaMoney = 0;
            updateLabelMoney();
            Clean();
            cargarDGV();
            flag = accionesABM.Crear;
        }

        private void updateLabelMoney()
        {
            MontoACobrarLabel.Text = "El valor del pedido es de " + sumatoriaMoney;
            montoAPagarDelPedido.Text = Convert.ToString(sumatoriaMoney);
        }

        private void Clean()
        {
            Nombre.Clear();
            Cantidad.Clear();
        }

        private void AtrasTile_Click(object sender, EventArgs e)
        {
            Manejador_Formularios.AgregarPedido.Show();
            Close();
        }

        private void FinalizarTile_Click(object sender, EventArgs e)
        {
            if(!validarFinalizar())
            {
                return;
            }

            //Crear pedido y actualizar Caja:
            MySqlDataReader reader = Conexion.executeProcedureWithReader("crearPedido", Conexion.generarArgumentos("_id_comprador", "_pagadoHastaElMomento", "_precio"), id_cliente, Convert.ToDecimal(cantidadPagada.Text), Convert.ToDecimal(montoAPagarDelPedido.Text));
            reader.Read();

            int id_pedido = reader.GetInt32(0);

            reader.Close();
            Conexion.closeConnection();

            //Agregar productos al pedido y disminuir stock de todos los productos involucrados:
            foreach (var registro in productosAVender)
            {
                Conexion.executeProcedure("agregarItemAPedido", Conexion.generarArgumentos("_id_pedido", "_id_producto", "_cantidad"), id_pedido, registro.Key, registro.Value);
                Conexion.closeConnection();
            }

            Funciones.imprimirMensajeDeAviso("Se realizó el pedido correctamente", this);
            Close();
        }

        public void cargarDGV()
        {
            Funciones.limpiarDGV(ProductosDGV);
            MySqlDataReader reader = Conexion.executeProcedureWithReader("obtenerStock", Conexion.generarArgumentos("_nombre"), Nombre.Text);

            string cantidad;
            int cantXBulto;
            decimal precio;

            while (reader.Read())
            {
                cantXBulto = reader.GetInt32(2);

                if (cantXBulto == 0)
                {
                    //Significa que el producto es individual!
                    cantidad = obtenerCantidadReal(reader.GetInt32(0), reader.GetInt32(1)) + " unidades";
                    precio = reader.GetDecimal(5);
                }
                else
                {
                    //El producto es un Bulto!
                    cantidad = obtenerCantidadReal(reader.GetInt32(0), reader.GetInt32(1)) + " bultos de " + cantXBulto + " unidades";
                    precio = reader.GetDecimal(6);
                }

                //ID Stock 0 - Nombre 3
                ProductosDGV.Rows.Add(reader.GetInt32(0), cantidad, reader.GetString(3), precio);
            }

            reader.Close();
            Conexion.closeConnection();
        }

        private void AgregarTile_Click(object sender, EventArgs e)
        {
            DataGridViewRow filaDgv = ProductosDGV.CurrentRow;

            if (!Validaciones.validarFilaMarcada(filaDgv, this))
            {
                return;
            }

            if (Cantidad.Text == "")
            {
                Funciones.imprimirMensajeDeError("Debe ingresar una cantidad", this);
                Cantidad.Focus();
                return;
            }

            int cantidad = Convert.ToInt32(Cantidad.Text);
            int cantidadEnStock = obtenerCantidadEnInt(Convert.ToString(filaDgv.Cells[1].Value));

            if (!validarCantidades(cantidad, cantidadEnStock))
            {
                return;
            }

            int id_stock = Convert.ToInt32(filaDgv.Cells[0].Value);
            string nombre = Convert.ToString(filaDgv.Cells[2].Value);
            decimal precioUnitario = Convert.ToDecimal(filaDgv.Cells[3].Value);
            string cantidadEnString = obtenerCantidadEnString(cantidad, Convert.ToString(filaDgv.Cells[1].Value));

            ItemsDGV.Rows.Add(id_stock, cantidadEnString, nombre, precioUnitario * cantidad);
            sumatoriaMoney += precioUnitario * cantidad;
            updateLabelMoney();

            if (!productosAVender.ContainsKey(id_stock))
                productosAVender.Add(id_stock, cantidad);
            else
                productosAVender[id_stock] = productosAVender[id_stock] + cantidad;

            Cantidad.Clear();
            Cantidad.Focus();
            cargarDGV();
        }

        private void BorrarTile_Click(object sender, EventArgs e)
        {
            DataGridViewRow filaDgv = ItemsDGV.CurrentRow;

            if (!Validaciones.validarFilaMarcada(filaDgv, this))
            {
                return;
            }

            int id_stock = Convert.ToInt32(filaDgv.Cells[0].Value);
            int cantidadABorrar = obtenerCantidadEnInt(Convert.ToString(filaDgv.Cells[1].Value));
            decimal precio = Convert.ToInt32(filaDgv.Cells[3].Value);

            productosAVender[id_stock] = productosAVender[id_stock] - cantidadABorrar;

            cargarDGV();
            ItemsDGV.Rows.Remove(filaDgv);
            sumatoriaMoney -= precio;
            updateLabelMoney();
        }

        private int obtenerCantidadReal(int id_stock, int cantEnDB)
        {
            if (productosAVender.ContainsKey(id_stock))
                return cantEnDB - productosAVender[id_stock];
            else
                return cantEnDB;
        }

        private int obtenerCantidadEnInt(string cantidad)
        {
            int large = cantidad.IndexOf(" ");
            return Convert.ToInt32(cantidad.Substring(0, large));
        }
    
        private string obtenerCantidadEnString(int cantidad, string preCantidad)
        {
            int large = preCantidad.IndexOf(" ");
            return cantidad + preCantidad.Substring(large);
        }

        private void nombre_TextChanged(object sender, EventArgs e)
        {
            this.cargarDGV();
        }

        private bool validarCantidades(int cantidad, int cantidadEnStock)
        {
            if (cantidad < 1)
            {
                Funciones.imprimirMensajeDeError("La cantidad debe ser mayor a 0.", this);
                return false;
            }

            if (cantidad > cantidadEnStock)
            {
                Funciones.imprimirMensajeDeAviso("Se está superando el stock que se encuentra registrado en el programa.", this);
            }

            return true;
        }

        private bool validarFinalizar()
        {
            if (ItemsDGV.Rows.Count == 0)
            {
                Funciones.imprimirMensajeDeError("Debe ingresar algún producto que el cliente quiera comprar.", this);
                return false;
            }

            if (montoAPagarDelPedido.Text == "")
            {
                Funciones.imprimirMensajeDeError("Debe ingresar cuando deberá pagar el cliente.", this);
                return false;
            }

            if (Convert.ToDecimal(montoAPagarDelPedido.Text) < 0)
            {
                Funciones.imprimirMensajeDeError("La cantidad que deberá pagar el cliente no puede ser negativa.", this);
                return false;
            }

            if(cantidadPagada.Text == "")
            {
                Funciones.imprimirMensajeDeError("Debe ingresar la cantidad que deja paga el cliente. (Puede ser 0)", this);
                return false;
            }

            if (Convert.ToDecimal(cantidadPagada.Text) < 0)
            {
                Funciones.imprimirMensajeDeError("La cantidad que deja paga el cliente no puede ser negativa.", this);
                return false;
            }

            return true;
        }

        private void AddProductoAPedido_Load(object sender, EventArgs e)
        {

        }
    }
}
