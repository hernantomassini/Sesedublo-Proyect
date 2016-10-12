using Enums;
using MetroFramework.Forms;
using MySql.Data.MySqlClient;
using Sesedublo_SLPL.Generales;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace Sesedublo_SLPL.Pedidos_de_Compra
{
    public partial class AddPedidoCompra : MetroForm
    {
        Dictionary<int, int> stockAEliminar = new Dictionary<int, int>();
        accionesABM flag = accionesABM.Crear;
        Validaciones val = new Validaciones();
        int id_pedidoLea = -1;

        public AddPedidoCompra()
        {
            InitializeComponent();
            this.getProductos();
            this.Closing += new CancelEventHandler(Avoid_Closing);
        }

        void Avoid_Closing(object sender, CancelEventArgs e)
        {
            this.Hide();
            e.Cancel = true;

            Manejador_Formularios.Pedido_de_compra.cargarDGV();
            Manejador_Formularios.Pedido_de_compra.Show();
        }

        public void Clean()
        {
            individualRadio.Checked = true;
            Nombre.Clear();
            Costo.Clear();
            Cantidad.Clear();
            Precio.Clear();
            UnidadesXBulto.Text = "";
            Utilidad.Clear();
            UnidadesXBulto.SelectedIndex = 0;
            dgvPedido.Rows.Clear();
            stockAEliminar.Clear();

        }

        public void getProductos()
        {
            MySqlDataAdapter da = Conexion.executeProcedureWithAdapter("obtenerLista", Conexion.generarArgumentos("_nombre"), buscarProducto.Text);
            DataTable tablaDeUsuarios = new DataTable("Clientes");
            da.Fill(tablaDeUsuarios);
            dgvProductos.DataSource = tablaDeUsuarios.DefaultView;
            dgvProductos.Columns[0].Width = 200;

            Conexion.closeConnection();
        }

        private void agregarBtn_Click(object sender, EventArgs e)
        {
            decimal utilidad = Convert.ToDecimal(Utilidad.Text);
            decimal costo = Convert.ToDecimal(Costo.Text);

            int cantXBulto = 0;
            decimal precio = costo + utilidad;

            string cantidad = Cantidad.Text + " unidades";

            if (!individualRadio.Checked)
            {
                cantXBulto = Convert.ToInt32(UnidadesXBulto.Text);
                precio = costo + cantXBulto * utilidad;
                cantidad = Cantidad.Text + " bultos de " + cantXBulto + " unidades";
            }

            dgvPedido.Rows.Add(cantXBulto, Nombre.Text, Costo.Text, precio, cantidad);
        }

        private void eliminarBtn_Click(object sender, EventArgs e)
        {
            DataGridViewRow filaDgv = dgvPedido.CurrentRow;

            if (!Validaciones.validarFilaMarcada(filaDgv, this))
            {
                return;
            }

            dgvPedido.Rows.Remove(filaDgv);
        }

        private void cargarDatos()
        {
            Funciones.limpiarDGV(dgvPedido);

            MySqlDataReader reader = Conexion.executeProcedureWithReader("obtenerItemsDeLea", Conexion.generarArgumentos("_id_pedidoLea"), id_pedidoLea);
            int cantXBulto;
            decimal precio;
            string cantidadString;
            int cantidad;

            while (reader.Read())
            {   
                cantXBulto = reader.GetInt32(0);
                cantidad = reader.GetInt32(5);

                if (cantXBulto == 0)
                {
                    //Individual

                    precio = reader.GetDecimal(3);
                    cantidadString = cantidad + " unidades";
                }
                else
                {
                    //Bulto
                    precio = reader.GetDecimal(4);
                    cantidadString = cantidad + " bultos de " + cantXBulto + " unidades";
                }

                dgvPedido.Rows.Add(cantXBulto, reader.GetString(1), reader.GetDecimal(2), precio, cantidadString);
                stockAEliminar.Add(reader.GetInt32(6), cantidad);
            }

            reader.Close();
            Conexion.closeConnection();
        }

        private void individualRadio_CheckedChanged(object sender, EventArgs e)
        {
            updatePrecio();

            if (individualRadio.Checked)
            {
                CostoLabel.Text = "Costo por unidad:";
                CantidadLbl.Text = "Cantidad de unidades:";
                PrecioLabel.Text = "Precio por unidad:";
                UnidadesXBultoLbl.Visible = false;
                UnidadesXBulto.Visible = false;
            }
            else
            {
                CostoLabel.Text = "Costo por bulto:";
                CantidadLbl.Text = "Cantidad de bultos:";
                PrecioLabel.Text = "Precio por bulto:";
                UnidadesXBultoLbl.Visible = true;
                UnidadesXBulto.Visible = true;
            }
        }

        private void Nombre_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            val.ingresarNombre(e);
        }

        private void Costo_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            val.ingresarNumeroDecimal(e);
        }

        private void Cantidad_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            val.ingresarNumero(e);
        }

        private void Precio_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            val.ingresarNumero(e);
        }

        private void buscadorProducto_TextChanged(object sender, EventArgs e)
        {
            this.getProductos();
            if (dgvProductos.Rows.Count == 1)
                Nombre.Text = this.dgvProductos.CurrentRow.Cells[0].Value.ToString();
        }

        private void dgvProductos_CellClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            Nombre.Text = this.dgvProductos.CurrentRow.Cells[0].Value.ToString();
        }

        private void titleAceptar_Click(object sender, EventArgs e)
        {
            if (dgvPedido.Rows.Count == 0)
            {
                Funciones.imprimirMensajeDeError("Debe ingresar al menos un producto.", this);
                return;
            }

            MySqlDataReader reader;

            int cantidad;

            if (flag == accionesABM.Modificar)
            {
                foreach (var registro in stockAEliminar) 
                {
                    int id_producto = registro.Key;
                    cantidad = registro.Value;

                    Conexion.executeProcedure("restaurarStockLea", Conexion.generarArgumentos("_id_producto", "_cantidad"), id_producto, cantidad);
                    Conexion.closeConnection();
                }

                Conexion.executeProcedure("borrarPedidoDeLea", Conexion.generarArgumentos("_id_pedidoLea"), id_pedidoLea);
                Conexion.closeConnection();
            }

            string nombre;
            decimal costo;
            decimal PVUnitario;
            decimal PVBulto;
            int cantXBulto;

            reader = Conexion.executeProcedureWithReader("crearPedidoDeLea", Conexion.generarArgumentos());
            reader.Read();

            int id_pedidoDeLea = reader.GetInt32(0);

            reader.Close();
            Conexion.closeConnection();

            foreach (DataGridViewRow row in dgvPedido.Rows)
            {
                cantXBulto = Convert.ToInt32(row.Cells[0].Value);
                nombre = Convert.ToString(row.Cells[1].Value);
                costo = Convert.ToDecimal(row.Cells[2].Value);
                cantidad = obtenerCantidadEnInt(Convert.ToString(row.Cells[4].Value));

                if(cantXBulto == 0)
                {
                    PVUnitario = Convert.ToDecimal(row.Cells[3].Value);
                    PVBulto = 0;
                }
                else
                {
                    PVBulto = Convert.ToDecimal(row.Cells[3].Value);
                    PVUnitario = Decimal.Round(PVBulto / cantXBulto, 2);
                }

                Conexion.executeProcedure("crearItemDeLea", Conexion.generarArgumentos("_id_pedidoLea", "_cantidad", "_cantidadXBulto", "_costo", "_nombre", "_PVUnitario", "_PVBulto"), id_pedidoDeLea, cantidad, cantXBulto, costo, nombre, PVUnitario, PVBulto);
                Conexion.closeConnection();
            }
            
            Close();
        }

        public void CrearPedido()
        {
            Clean();
            flag = accionesABM.Crear;
            Text = "Agregar pedido de compra";
        }


        public void modificarPedido(int id_pedidoLea)
        {
            this.id_pedidoLea = id_pedidoLea;

            Clean();
            flag = accionesABM.Modificar;
            cargarDatos();
            Text = "Modificar pedido de compra";
        }

        private void titleCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private int obtenerCantidadEnInt(string cantidad)
        {
            int large = cantidad.IndexOf(" ");
            return Convert.ToInt32(cantidad.Substring(0, large));
        }

        private void utilidad_TextChanged(object sender, EventArgs e)
        {
            updatePrecio();
        }

        private void updatePrecio()
        {
            decimal utilidad = 0;
            decimal costo = 0;
            int unidadesXBulto = 0;
            decimal resultado;

            if (Utilidad.Text != "")
                utilidad = Convert.ToDecimal(Utilidad.Text);

            if (Costo.Text != "")
                costo = Convert.ToDecimal(Costo.Text);

            if (UnidadesXBulto.Text != "")
                unidadesXBulto = Convert.ToInt32(UnidadesXBulto.Text);

            if (individualRadio.Checked)
                resultado = decimal.Round(costo + utilidad, 2);
            else
                resultado = decimal.Round(costo + utilidad * unidadesXBulto, 2);

            Precio.Text = Convert.ToString(resultado);
        }

        private void AddPedidoCompra_Load(object sender, EventArgs e)
        {

        }
    }
}