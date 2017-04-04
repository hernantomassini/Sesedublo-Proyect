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
        Dictionary<int, Producto> productosAVender = new Dictionary<int, Producto>();
        Dictionary<int, Producto> productosARestockear = new Dictionary<int, Producto>();
        accionesABM flag = accionesABM.Crear;
        int id_pedido = -1;
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
            this.id_pedido = -1;
            sumatoriaMoney = 0;

            updateLabelMoney();
            Clean();
            cargarDGV();
            flag = accionesABM.Crear;
        }

        public void modificarPedido(int id_pedido)
        {
  

            this.id_cliente = -1;
            this.id_pedido = id_pedido;
            sumatoriaMoney = 0;
            updateLabelMoney();

            Clean();

            flag = accionesABM.Modificar;
            CargarItems();
            cargarDGV();
        }

        private void CargarItems()
        {
            MySqlDataReader reader;

            reader = Conexion.executeProcedureWithReader("obtenerDatosDeUnPedido", Conexion.generarArgumentos("_id_pedido"), id_pedido);
            reader.Read();

            cantidadPagada.Text = reader.GetString(0);
            montoAPagarDelPedido.Text = reader.GetString(1);
            sumatoriaMoney = reader.GetDecimal(1);
            updateLabelMoney();
            this.id_cliente = reader.GetInt32(2);

            reader.Close();
            Conexion.closeConnection();

            reader = Conexion.executeProcedureWithReader("obtenerItems", Conexion.generarArgumentos("_id_pedido"), id_pedido);

            Producto producto1;
            Producto producto2;

            while (reader.Read())
            {
                producto1 = new Producto(reader.GetInt32(1), reader.GetDecimal(2));
                //producto2 = new Producto(reader.GetInt32(1), reader.GetDecimal(2) / reader.GetInt32(1));
                producto2 = new Producto(reader.GetInt32(1), reader.GetDecimal(2));
                productosARestockear.Add(reader.GetInt32(0), producto2);
                productosAVender.Add(reader.GetInt32(0), producto1);
            }

            reader.Close();
            Conexion.closeConnection();

            foreach (var registro in productosAVender)
            {
                reader = Conexion.executeProcedureWithReader("obtenerInfoItems", Conexion.generarArgumentos("_id_producto"), registro.Key);
                reader.Read();

                int cantidad = registro.Value.getCantidad();
                int cantXBulto = reader.GetInt32(4);
                decimal precio = registro.Value.getPrecioCobrado();
                string precioString;

                if(cantXBulto == 0)
                {
                    precioString = cantidad + " unidades";

                }
                else
                {
                    precioString = cantidad + " bultos de " + cantXBulto + " unidades";
                }


                //IDStock - Cantidad - Nombre - Precio
                ItemsDGV.Rows.Add(reader.GetInt32(0), precioString, reader.GetString(1), precio * cantidad);

                reader.Close();
                Conexion.closeConnection();
            }
        }

        private void FinalizarTile_Click(object sender, EventArgs e)
        {
            if(!validarFinalizar())
            {
                return;
            }

            if (Convert.ToDecimal(cantidadPagada.Text) > Convert.ToDecimal(montoAPagarDelPedido.Text))
            {
                Funciones.imprimirMensajeDeError("Está haciendo que el cliente pague un monto mayor al que debe", this);
            }
            else
            {
                MySqlDataReader reader;

                if (flag == accionesABM.Modificar)
                {
                    foreach (var registro in productosARestockear)
                    {
                        int id_stock = registro.Key;
                        int cantidad = registro.Value.getCantidad();

                        Conexion.executeProcedure("updatearStock", Conexion.generarArgumentos("_id_stock", "_cantidad"), id_stock, cantidad);
                        Conexion.closeConnection();
                    }

                    Conexion.executeProcedure("borrarPedido", Conexion.generarArgumentos("_id_pedido"), this.id_pedido);
                    Conexion.closeConnection();
                }

                //Crear pedido y actualizar Caja:
                reader = Conexion.executeProcedureWithReader("crearPedido", Conexion.generarArgumentos("_id_comprador", "_pagadoHastaElMomento", "_precio"), id_cliente, Convert.ToDecimal(cantidadPagada.Text), Convert.ToDecimal(montoAPagarDelPedido.Text));
                reader.Read();

                int id_pedido = reader.GetInt32(0);

                reader.Close();
                Conexion.closeConnection();

                //Agregar productos al pedido y disminuir stock de todos los productos involucrados:
                foreach (var registro in productosAVender)
                {
                    Conexion.executeProcedure("agregarItemAPedido", Conexion.generarArgumentos("_id_pedido", "_id_producto", "_cantidad", "_valorDelItem"), id_pedido, registro.Key, registro.Value.getCantidad(), registro.Value.getPrecioCobrado());
                    Conexion.closeConnection();
                }


                Conexion.executeProcedure("registrarPedido", Conexion.generarArgumentos("_id_pedido", "_precio", "_id_comprador"), id_pedido, Convert.ToDecimal(montoAPagarDelPedido.Text), id_cliente);
                Conexion.closeConnection();

                Funciones.imprimirMensajeDeAviso("Se realizó el pedido correctamente", this);

                Manejador_Formularios.ABM_Pedidos.cargarDGV();
                Manejador_Formularios.ABM_Pedidos.Show();

                this.id_pedido = -1;
                this.id_cliente = -1;
                flag = accionesABM.Crear;
                Close();
            }
        }

        public void cargarDGV()
        {
            Funciones.limpiarDGV(ProductosDGV);
            MySqlDataReader reader = Conexion.executeProcedureWithReader("obtenerStockPedido", Conexion.generarArgumentos("_nombre"), Nombre.Text);

            int id_stock;
            string cantidad;
            int cantXBulto;
            decimal precio;

            while (reader.Read())
            {
                id_stock = reader.GetInt32(0);

                cantXBulto = reader.GetInt32(2);

                if (cantXBulto == 0)
                {
                    //Significa que el producto es individual!
                    cantidad = obtenerCantidadReal(id_stock, reader.GetInt32(1)) + " unidades";
                    precio = obtenerPrecioReal(id_stock, reader.GetDecimal(5));
                }
                else
                {
                    //El producto es un Bulto!
                    cantidad = obtenerCantidadReal(id_stock, reader.GetInt32(1)) + " bultos de " + cantXBulto + " unidades";
                    precio = obtenerPrecioReal(id_stock, reader.GetDecimal(6));
                }

                //ID Stock 0 - Nombre 3
                ProductosDGV.Rows.Add(reader.GetInt32(0), cantidad, reader.GetString(3), precio);
            }

            reader.Close();
            Conexion.closeConnection();
            montoAPagarDelPedido.Enabled = false;
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
            {
                Producto unProducto = new Producto(cantidad, precioUnitario);
                productosAVender.Add(id_stock, unProducto);
            }
            else
                productosAVender[id_stock].setCantidad(productosAVender[id_stock].getCantidad() + cantidad); 

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

            productosAVender[id_stock].setCantidad(productosAVender[id_stock].getCantidad() - cantidadABorrar);
            // (productosARestockear[id_stock].getCantidad() + cantidadABorrar);

            cargarDGV();
            ItemsDGV.Rows.Remove(filaDgv);
            sumatoriaMoney -= precio;
            updateLabelMoney();
        }

        private int obtenerCantidadReal(int id_stock, int cantEnDB)
        {

            if (productosAVender.ContainsKey(id_stock))
                if (flag == accionesABM.Modificar && productosARestockear.ContainsKey(id_stock))
                    return cantEnDB - productosAVender[id_stock].getCantidad() + productosARestockear[id_stock].getCantidad();
                else
                    return cantEnDB - productosAVender[id_stock].getCantidad();

            return cantEnDB;
        }

        private decimal obtenerPrecioReal(int id_stock, decimal precioEnTablaDeProductos)
        {
            if (flag == accionesABM.Modificar && productosARestockear.ContainsKey(id_stock))
                return productosARestockear[id_stock].getPrecioCobrado();
            else
                return precioEnTablaDeProductos;
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

        private void montoAPagarDelPedido_TextChanged(object sender, EventArgs e)
        {

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
            productosAVender.Clear();
            productosARestockear.Clear();
            ItemsDGV.Rows.Clear();
            cantidadPagada.Clear();
            cantidadPagada.Text = "0";
        }

        private void AtrasTile_Click(object sender, EventArgs e)
        {
            if (accionesABM.Crear == flag)
            {
                Manejador_Formularios.AgregarPedido.Show();
            }
            else
            {
                Manejador_Formularios.ABM_Pedidos.Show();
            }
            Close();
        }

        private void ProductosDGV_CellClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            Cantidad.Focus();
        }

        private void AddProductoAPedido_Load(object sender, EventArgs e)
        {

        }


        Validaciones val = new Validaciones();
        private void Nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.ingresarNombre(e);
        }

        private void Cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.ingresarNumero(e);
        }

        private void montoAPagarDelPedido_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.ingresarNumeroDecimal(e);
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            Manejador_Formularios.ABM_Stock.cargarDGV();
            Manejador_Formularios.ABM_Stock.Clean();
            Manejador_Formularios.ABM_Stock.Show();
        }

        private void ProductosDGV_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            ProductosDGV.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ProductosDGV.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void ItemsDGV_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            ItemsDGV.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ItemsDGV.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void ItemsDGV_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            sumatoriaMoney = 0;
            foreach (DataGridViewRow Myrow in ItemsDGV.Rows)
            {
                string[] partes = Myrow.Cells[1].Value.ToString().Split(' ');
                string subcadena = partes[0];
                int cantidadP = Convert.ToInt32(subcadena);
                decimal precioP = Convert.ToDecimal(Myrow.Cells[3].Value.ToString());

                sumatoriaMoney += precioP;

                int id_stock = Convert.ToInt32(Myrow.Cells[0].Value);
                decimal precioUnitario = Convert.ToDecimal(Myrow.Cells[3].Value) / cantidadP;

                productosAVender[id_stock].setCantidad(productosAVender[id_stock].getCantidad());
                productosAVender[id_stock].setPrecioCobrado(precioUnitario);

            }
            MontoACobrarLabel.Text = "El valor del pedido es de " + sumatoriaMoney;
            montoAPagarDelPedido.Text = Convert.ToString(sumatoriaMoney);
        }
    }
}
