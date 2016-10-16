using Enums;
using MetroFramework.Forms;
using MySql.Data.MySqlClient;
using Sesedublo_SLPL.Generales;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Sesedublo_SLPL.Pedidos_de_Compra
{
    public partial class AddPedidoCompra : MetroForm
    {
        Dictionary<int, int> stockAEliminar = new Dictionary<int, int>();
        accionesABM flag = accionesABM.Crear;
        Validaciones val = new Validaciones();
        int id_pedidoLea = -1;
        StringBuilder st = new StringBuilder();

        public AddPedidoCompra()
        {
            InitializeComponent();
            this.getProductos();
            Nombre.Text = dgvProductos.Rows[0].Cells[0].Value.ToString();
            dgvProductos.Columns[0].Visible = false;
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

            buscarProducto.Clear();
            Nombre.Clear();
            Costo.Clear();
            Cantidad.Clear();
            Precio.Clear();
            UnidadesXBulto.Text = "";
            Utilidad.Clear();
            UnidadesXBulto.SelectedIndex = 0;
            dgvPedido.Rows.Clear();
            stockAEliminar.Clear();

            if (dgvProductos.Rows.Count != 0)
                Nombre.Text = this.dgvProductos.Rows[0].Cells[0].Value.ToString();

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
            val.validarNoVacio(Nombre,st);
            val.validarNoVacio(Costo, st);
            val.validarNoVacio(Utilidad, st);
            val.validarNoVacio(Cantidad, st);

            if(bultoRadio.Checked)
                val.validarNoVacio(UnidadesXBulto, st);

            if (st.Length > 0)
            {
                Funciones.imprimirMensajeDeError(st.ToString(), this);
                st = new StringBuilder();
                return;
            }

            int esUnBulto = 0;
            decimal utilidad = Convert.ToDecimal(Utilidad.Text);
            decimal costo = Convert.ToDecimal(Costo.Text);

            int cantXBulto = 0;
            decimal precio = costo + utilidad;

            string cantidad = Cantidad.Text + " unidades";

            if (!individualRadio.Checked)
            {
                cantXBulto = Convert.ToInt32(UnidadesXBulto.Text);
                cantidad = Cantidad.Text + " bultos de " + cantXBulto + " unidades";
                esUnBulto = 1;
            }

            dgvPedido.Rows.Add(cantXBulto, Nombre.Text, costo, precio, cantidad, utilidad, esUnBulto);
        }

        private void eliminarBtn_Click(object sender, EventArgs e)
        {
            DataGridViewRow filaDgv = dgvPedido.CurrentRow;

            if (!Validaciones.validarFilaMarcada(filaDgv, this))
            {
                return;
            }

            decimal costoDeleteado = Convert.ToDecimal(filaDgv.Cells[2].Value);
            int cantidadDeleteada = obtenerCantidadEnInt(Convert.ToString(filaDgv.Cells[4].Value));

            dgvPedido.Rows.Remove(filaDgv);
        }

        private void cargarDatos()
        {
            Funciones.limpiarDGV(dgvPedido);

            string query = "SELECT costo FROM PedidosDeLea WHERE id_pedido = " + id_pedidoLea;

            MySqlDataReader reader = Conexion.ejecutarQuery(query);

            reader.Read();

            reader.Close();
            Conexion.closeConnection();

            reader = Conexion.executeProcedureWithReader("obtenerItemsDeLea", Conexion.generarArgumentos("_id_pedidoLea"), id_pedidoLea);


            int cantXBulto;
            int esUnBulto = 0;
            decimal precio;
            decimal utilidad = 0;
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
                    utilidad = precio - reader.GetDecimal(2);
                }
                else
                {
                    //Bulto
                    precio = reader.GetDecimal(4);
                    cantidadString = cantidad + " bultos de " + cantXBulto + " unidades";
                    esUnBulto = 1;
                    utilidad = decimal.Round((precio - reader.GetDecimal(2))/ cantXBulto, 2);
                }

                dgvPedido.Rows.Add(cantXBulto, reader.GetString(1), reader.GetDecimal(2), precio, cantidadString, utilidad, esUnBulto);
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
                UnidadesXBulto.SelectedIndex = 0;
            }
        }

        private void Nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.ingresarNombre(e);
        }

        private void Costo_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.ingresarNumeroDecimal(e);
        }

        private void Cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.ingresarNumero(e);
        }

        private void Precio_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.ingresarNumero(e);
        }

        private void buscadorProducto_TextChanged(object sender, EventArgs e)
        {
            this.getProductos();
            if (dgvProductos.Rows.Count == 1)
            {
                Nombre.Text = this.dgvProductos.CurrentRow.Cells[0].Value.ToString();

                if (this.dgvProductos.CurrentRow.Cells[1].Value.ToString() != "N/E")
                {
                    Cantidad.Text = "0";
                    if (this.dgvProductos.CurrentRow.Cells[1].Value.ToString() != "Individual")
                    {
                        UnidadesXBulto.Text = this.dgvProductos.CurrentRow.Cells[1].Value.ToString();
                        bultoRadio.Checked = true;
                    }
                    else
                    {
                        individualRadio.Checked = true;
                    }

                    decimal utilidad = Convert.ToDecimal(this.dgvProductos.CurrentRow.Cells[3].Value) - Convert.ToDecimal(this.dgvProductos.CurrentRow.Cells[2].Value);
                    Costo.Text = this.dgvProductos.CurrentRow.Cells[2].Value.ToString();
                    Utilidad.Text = Convert.ToString(utilidad);
                    Precio.Text = this.dgvProductos.CurrentRow.Cells[3].Value.ToString();
                }
            }
        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Clean();
            Nombre.Text = dgvProductos.CurrentRow.Cells[1].Value.ToString();
            string tipo = dgvProductos.CurrentRow.Cells[2].Value.ToString();

            if (tipo == "N/E")
            {
                Clean2();
                return;
            }

            decimal costo = Convert.ToDecimal(dgvProductos.CurrentRow.Cells[3].Value) / 100;
            decimal precio = Convert.ToDecimal(dgvProductos.CurrentRow.Cells[4].Value) / 100;

            individualRadio.Checked = true;

            if (tipo != "Individual")
            {
                bultoRadio.Checked = true;
                UnidadesXBulto.Text = dgvProductos.CurrentRow.Cells[1].Value.ToString();

                precio = Convert.ToDecimal(dgvProductos.CurrentRow.Cells[5].Value);
            }

            Cantidad.Text = "0";
            Costo.Text = Convert.ToString(costo);
            Precio.Text = Convert.ToString(precio);

            decimal utilidad = precio - costo;

            Utilidad.Text = Convert.ToString(utilidad);
        }

        public void Clean2()
        {
            Utilidad.Clear();
            Cantidad.Clear();
            Precio.Clear();
            Costo.Clear();
            UnidadesXBulto.SelectedIndex = 0;
            individualRadio.Checked = true;
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

            reader = Conexion.executeProcedureWithReader("crearPedidoDeLea", Conexion.generarArgumentos("_costo"), obtenerCostoDelDGV());
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

        private decimal obtenerCostoDelDGV()
        {
            decimal sum = 0;

            for (int i = 0; i < dgvPedido.Rows.Count; i++)
            {
                sum += Convert.ToInt32(dgvPedido.Rows[i].Cells[2].Value);
            }

            return sum;
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

            resultado = decimal.Round(costo + utilidad, 2);

            Precio.Text = Convert.ToString(resultado);
        }

        private void AddPedidoCompra_Load(object sender, EventArgs e)
        {

        }

        private void nuevoProducto_Click(object sender, EventArgs e)
        {
            Manejador_Formularios.Producto_Nuevo.Clean();
            Manejador_Formularios.Producto_Nuevo.Show();
        }

        private void dgvPedido_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaDgv = dgvPedido.CurrentRow;

            if (filaDgv == null)
                return;

            int esUnBulto = Convert.ToInt32(filaDgv.Cells[6].Value);
            decimal costo = Convert.ToDecimal(filaDgv.Cells[2].Value);
            decimal utilidad = Convert.ToDecimal(filaDgv.Cells[5].Value);

            if(esUnBulto == 1)
            {
                string cantidadString = Convert.ToString(filaDgv.Cells[4].Value);
                int posI = cantidadString.IndexOf(" ") + 1;

                cantidadString = cantidadString.Substring(posI);
                posI = cantidadString.IndexOf(" ") + 1;

                cantidadString = cantidadString.Substring(posI);
                posI = cantidadString.IndexOf(" ") + 1;
                cantidadString = cantidadString.Substring(posI);

                int cantXBulto = obtenerCantidadEnInt(cantidadString);
            }

                filaDgv.Cells[3].Value = utilidad + costo;
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            Manejador_Formularios.ABM_Stock.cargarDGV();
            Manejador_Formularios.ABM_Stock.Clean();
            Manejador_Formularios.ABM_Stock.Show();
        }
    }
}