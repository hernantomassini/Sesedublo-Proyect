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
        int id_cliente = -1;
        StringBuilder st = new StringBuilder();

        public AddPedidoCompra()
        {
            InitializeComponent();
            this.getProductos();
            Nombre.Text = dgvProductos.Rows[0].Cells[1].Value.ToString();
            dgvProductos.Columns[0].Visible = false;
            dgvProductos.Columns[6].Visible = false;
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

            costoIndividual.Clear();
            buscarProducto.Clear();
            Costo.Clear();
            Cantidad.Clear();
            Precio.Clear();
            UnidadesXBulto.Text = "";
            Utilidad.Clear();
            UnidadesXBulto.SelectedIndex = 0;
            dgvPedido.Rows.Clear();
            stockAEliminar.Clear();
        }

        public void Clean2()
        {
            individualRadio.Checked = true;

            costoIndividual.Clear();
            Costo.Clear();
            Cantidad.Clear();
            Utilidad.Clear();
            Precio.Clear();
            UnidadesXBulto.SelectedIndex = 0;
        }

        public void getProductos()
        {
            MySqlDataAdapter da = Conexion.executeProcedureWithAdapter("obtenerLista", Conexion.generarArgumentos("_nombre"), buscarProducto.Text);
            DataTable tablaDeUsuarios = new DataTable("Clientes");
            da.Fill(tablaDeUsuarios);
            dgvProductos.DataSource = tablaDeUsuarios.DefaultView;

            Conexion.closeConnection();
        }

        private void agregarBtn_Click(object sender, EventArgs e)
        {
            val.validarNoVacio(Nombre,st);
            val.validarNoVacio(Costo, st);
            val.validarNoVacio(Utilidad, st);
            val.validarNoVacio(Cantidad, st);

            if(!individualRadio.Checked)
                val.validarNoVacio(UnidadesXBulto, st);

            if (Cantidad.Text == "0")
            {
                Funciones.imprimirMensajeDeError("No puede agregar un producto con 0 unidades", this);
                return;
            }

            if (st.Length > 0)
            {
                Funciones.imprimirMensajeDeError(st.ToString(), this);
                st = new StringBuilder();
                return;
            }

            int cantXBulto = 0;
            decimal costo = Convert.ToDecimal(Costo.Text);
            decimal precioUnitario = Convert.ToDecimal(Precio.Text);
            decimal precioBulto = precioUnitario;
            string stringPrecioBulto = "-";
            string cantidad = Cantidad.Text + " unidades";
            decimal utilidad = Convert.ToDecimal(Utilidad.Text);
            int selectedRadio = obtenerRadioSeleccionado();

            if (!individualRadio.Checked)
            {
                cantXBulto = Convert.ToInt32(UnidadesXBulto.Text);
                cantidad = Cantidad.Text + " bultos de " + cantXBulto + " unidades";

                precioUnitario = decimal.Round(precioBulto / cantXBulto);
                stringPrecioBulto = precioBulto.ToString();
            }

            borrarProductoIfExists(Nombre.Text, cantXBulto);

            dgvPedido.Rows.Add(cantXBulto, Nombre.Text, costo, precioUnitario, stringPrecioBulto, cantidad, utilidad, selectedRadio);
            updateLabel();

            Clean2();
        }

        private void borrarProductoIfExists(string nombreProducto, int cantidadBulto)
        {
            string nombre;
            int cantXBulto;

            for (int i = 0; i < dgvPedido.Rows.Count; i++)
            {
                nombre = Convert.ToString(dgvPedido.Rows[i].Cells[1].Value);

                if (nombreProducto.Equals(nombre))
                {
                    cantXBulto = obtenerCantBulto(Convert.ToString(dgvPedido.Rows[i].Cells[5].Value));

                    if(cantidadBulto == cantXBulto)
                    {
                        dgvPedido.Rows.RemoveAt(i);
                        i--;
                    }
                }
            }
        }

        private void eliminarBtn_Click(object sender, EventArgs e)
        {
            DataGridViewRow filaDgv = dgvPedido.CurrentRow;

            if (!Validaciones.validarFilaMarcada(filaDgv, this))
            {
                return;
            }

            dgvPedido.Rows.Remove(filaDgv);
            updateLabel();
        }

        private void cargarDatos()
        {
            Funciones.limpiarDGV(dgvPedido);

            string query = "SELECT vendedor FROM PedidosDeLea WHERE id_pedido = " + id_pedidoLea;

            MySqlDataReader reader = Conexion.ejecutarQuery(query);

            reader.Read();

            id_cliente = reader.GetInt32(0);

            reader.Close();
            Conexion.closeConnection();

            reader = Conexion.executeProcedureWithReader("obtenerItemsDeLea", Conexion.generarArgumentos("_id_pedidoLea"), id_pedidoLea);

            int cantXBulto;
            string nombre;
            decimal costo;
            decimal PVUnitario;
            decimal PVBulto;
            int cantidad;
            int id_producto;
            int radioSelected = 0;

            string cantidadString;
            decimal utilidad = 0;

            while (reader.Read())
            {
                cantXBulto = reader.GetInt32(0);
                nombre = reader.GetString(1);
                costo = reader.GetDecimal(2);
                PVUnitario = reader.GetDecimal(3);
                PVBulto = reader.GetDecimal(4);
                cantidad = reader.GetInt32(5);
                id_producto = reader.GetInt32(6);
                radioSelected = reader.GetInt32(7);

                cantidadString = cantidad + " unidades";
                utilidad = PVUnitario - costo;

                if (radioSelected == 2)
                {
                    utilidad = Decimal.Round((PVBulto - costo) / cantXBulto, 2);
                    cantidadString = cantidad + " bultos de " + cantXBulto + " unidades";
                }

                if (radioSelected == 3)
                {
                    utilidad = PVBulto - costo;
                    cantidadString = cantidad + " bultos de " + cantXBulto + " unidades";
                }

                dgvPedido.Rows.Add(cantXBulto, nombre, costo, PVUnitario, PVBulto, cantidadString, utilidad, radioSelected);

                if (stockAEliminar.ContainsKey(id_producto))
                {
                    stockAEliminar[id_producto] += cantidad;
                }
                else
                {
                    stockAEliminar.Add(id_producto, cantidad);
                }
            }

            reader.Close();
            Conexion.closeConnection();
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
            getProductos();
            if (dgvProductos.Rows.Count == 1)
            {
                cargarElementoDeGrilla();
            }
        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cargarElementoDeGrilla();
        }

        private void cargarElementoDeGrilla()
        {
            Nombre.Text = dgvProductos.CurrentRow.Cells[1].Value.ToString();
            string tipo = dgvProductos.CurrentRow.Cells[2].Value.ToString();

            if (tipo == "N/E")
            {
                return;
            }

            decimal costo = Convert.ToDecimal(dgvProductos.CurrentRow.Cells[3].Value) / 100;
            int radioSelected = Convert.ToInt32(dgvProductos.CurrentRow.Cells[6].Value);

            seleccionarRadioCorrespondiente(radioSelected);

            Costo.Text = Convert.ToString(costo);
            Cantidad.Text = "0";

            decimal precio = 0;
            decimal utilidad = 0;

            if (individualRadio.Checked)
            {
                precio = Convert.ToDecimal(dgvProductos.CurrentRow.Cells[4].Value) / 100;
                utilidad = precio - costo;
            }

            if (bultoxBotellaRadio.Checked)
            {
                int cantBotellasBulto = Convert.ToInt32(dgvProductos.CurrentRow.Cells[2].Value);

                precio = Convert.ToDecimal(dgvProductos.CurrentRow.Cells[5].Value) / 100;
                utilidad = (precio - costo) / cantBotellasBulto;

                UnidadesXBulto.Text = cantBotellasBulto.ToString();

            }

            if (bultoCuadradoRadio.Checked)
            {
                int cantBotellasBulto = Convert.ToInt32(dgvProductos.CurrentRow.Cells[2].Value);

                precio = Convert.ToDecimal(dgvProductos.CurrentRow.Cells[5].Value) / 100;
                utilidad = precio - costo;

                UnidadesXBulto.Text = cantBotellasBulto.ToString();
            }

            Utilidad.Text = Convert.ToString(utilidad);

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
            int radioSelected;

            reader = Conexion.executeProcedureWithReader("crearPedidoDeLea", Conexion.generarArgumentos("_costo","_id_vendedor"), obtenerCostoDelDGV(), id_cliente);
            reader.Read();

            int id_pedidoDeLea = reader.GetInt32(0);

            reader.Close();
            Conexion.closeConnection();

            foreach (DataGridViewRow row in dgvPedido.Rows)
            {
                cantXBulto = Convert.ToInt32(row.Cells[0].Value);
                nombre = Convert.ToString(row.Cells[1].Value);
                costo = Convert.ToDecimal(row.Cells[2].Value);
                cantidad = obtenerCantidadEnInt(Convert.ToString(row.Cells[5].Value));
                radioSelected = Convert.ToInt32(row.Cells[7].Value);

                PVUnitario = Convert.ToDecimal(row.Cells[3].Value);
                PVBulto = 0;

                if (radioSelected != 1)
                {
                    PVBulto = Convert.ToDecimal(row.Cells[4].Value);
                    PVUnitario = Decimal.Round(PVBulto / cantXBulto, 2);
                }

                Conexion.executeProcedure("crearItemDeLea", Conexion.generarArgumentos("_id_pedidoLea", "_cantidad", "_cantidadXBulto", "_costo", "_nombre", "_PVUnitario", "_PVBulto", "_radioSelected"), id_pedidoDeLea, cantidad, cantXBulto, costo, nombre, PVUnitario, PVBulto, radioSelected);
                Conexion.closeConnection();
            }
            
            Close();
        }


        private decimal obtenerCostoDelDGV()
        {
            decimal sum = 0;
            decimal costoPorUnidad;
            int cantUnidades;

            for (int i = 0; i < dgvPedido.Rows.Count; i++)
            {
                costoPorUnidad = Convert.ToDecimal(dgvPedido.Rows[i].Cells[2].Value);
                cantUnidades = obtenerCantidadEnInt(dgvPedido.Rows[i].Cells[5].Value.ToString());

                sum += costoPorUnidad * cantUnidades;
            }

            return sum;
        }

        public void CrearPedido(int id_cliente)
        {
            this.id_cliente = id_cliente;
            Nombre.Text = this.dgvProductos.Rows[0].Cells[1].Value.ToString();
            Clean();

            flag = accionesABM.Crear;
            Text = "Agregar pedido de compra";

            updateLabel();
        }


        public void modificarPedido(int id_pedidoLea)
        {
            this.id_pedidoLea = id_pedidoLea;
            Nombre.Text = this.dgvProductos.Rows[0].Cells[1].Value.ToString();
            Clean();

            flag = accionesABM.Modificar;
            Text = "Modificar pedido de compra";

            cargarDatos();
            updateLabel();
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
            if (Costo.Text == "" || Utilidad.Text == "")
                return;

            decimal costo = Convert.ToDecimal(Costo.Text);
            decimal utilidad = Convert.ToDecimal(Utilidad.Text);

            if (individualRadio.Checked)
            {
                Precio.Text = Convert.ToString(costo + utilidad);
                return;
            }

            if (UnidadesXBulto.Text == "")
                return;

            int botellasPorBulto = Convert.ToInt32(UnidadesXBulto.Text);

            if (bultoxBotellaRadio.Checked)
            {
                Precio.Text = Convert.ToString(costo + utilidad * botellasPorBulto);

                decimal costoUnitario = decimal.Round(costo / botellasPorBulto, 2);
                costoIndividual.Text = Convert.ToString(costoUnitario);
            }
            else
            {
                Precio.Text = Convert.ToString(costo + utilidad);

                decimal costoUnitario = decimal.Round(costo / botellasPorBulto, 2);
                costoIndividual.Text = Convert.ToString(costoUnitario);
            }
        }

        private void AddPedidoCompra_Load(object sender, EventArgs e)
        {

        }

        private void nuevoProducto_Click(object sender, EventArgs e)
        {
            Manejador_Formularios.Producto_Nuevo.Clean();
            Manejador_Formularios.Producto_Nuevo.Show();
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            Manejador_Formularios.ABM_Stock.cargarDGV();
            Manejador_Formularios.ABM_Stock.Clean();
            Manejador_Formularios.ABM_Stock.Show();
        }

        private void UnidadesXBulto_SelectedIndexChanged(object sender, EventArgs e)
        {
            updatePrecio();
        }

        private void updateLabel()
        {
            decimal costoTotal = obtenerCostoDelDGV();
            costoSumatoriaLabel.Text = "Costo Total: " + costoTotal;
        }

        private void individualRadio_CheckedChanged(object sender, EventArgs e)
        {
            updatePrecio();

            if (individualRadio.Checked)
            {
                CostoLabel.Text = "Costo por unidad:";
                CantidadLbl.Text = "Cantidad de unidades:";
                UtilidadLabel.Text = "Utilidad por unidad:";
                PrecioLabel.Text = "Precio por unidad:";
                CostoIndividualLabel.Visible = false;
                costoIndividual.Visible = false;
                UnidadesXBultoLbl.Visible = false;
                UnidadesXBulto.Visible = false;
                unidadesObligatorio.Visible = false;
            }
        }

        private void bultoxBotellaRadio_CheckedChanged(object sender, EventArgs e)
        {
            updatePrecio();

            if (bultoxBotellaRadio.Checked)
            {
                CostoLabel.Text = "Costo por bulto:";
                CantidadLbl.Text = "Cantidad de bultos:";
                UtilidadLabel.Text = "Utilidad por botella:";
                PrecioLabel.Text = "Precio por bulto:";
                CostoIndividualLabel.Visible = true;
                costoIndividual.Visible = true;
                UnidadesXBultoLbl.Visible = true;
                UnidadesXBulto.Visible = true;
                unidadesObligatorio.Visible = true;
            }
        }

        private void bultoCuadradoRadio_CheckedChanged(object sender, EventArgs e)
        {
            updatePrecio();

            if (bultoCuadradoRadio.Checked)
            {
                CostoLabel.Text = "Costo por bulto:";
                CantidadLbl.Text = "Cantidad de bultos:";
                UtilidadLabel.Text = "Utilidad por bulto:";
                PrecioLabel.Text = "Precio por bulto:";
                CostoIndividualLabel.Visible = true;
                costoIndividual.Visible = true;
                UnidadesXBultoLbl.Visible = true;
                UnidadesXBulto.Visible = true;
                unidadesObligatorio.Visible = true;
            }
        }

        private int obtenerRadioSeleccionado()
        {
            if (individualRadio.Checked)
                return 1;

            if (bultoxBotellaRadio.Checked)
                return 2;
            else

                return 3;
        }

        private void seleccionarRadioCorrespondiente(int radioSelected)
        {
            if (radioSelected == 1)
            {
                individualRadio.Checked = true;
                return;
            }

            if (radioSelected == 2)
                bultoxBotellaRadio.Checked = true;
            else
                bultoCuadradoRadio.Checked = true;
        }

        private void dgvPedido_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaDgv = dgvPedido.CurrentRow;

            string nombre = filaDgv.Cells[1].Value.ToString();
            decimal costo = Convert.ToDecimal(filaDgv.Cells[2].Value);
            decimal utilidad = Convert.ToDecimal(filaDgv.Cells[6].Value);
            int selectedRadio = Convert.ToInt32(filaDgv.Cells[7].Value);
            int cantidad = obtenerCantidadEnInt(Convert.ToString(filaDgv.Cells[5].Value));

            seleccionarRadioCorrespondiente(selectedRadio);

            if (selectedRadio != 1)
            {
                int cantBotellasBulto = obtenerCantBulto(filaDgv.Cells[5].Value.ToString());
                UnidadesXBulto.Text = Convert.ToString(cantBotellasBulto);
            }

            Nombre.Text = nombre;
            Costo.Text = Convert.ToString(costo);
            Cantidad.Text = Convert.ToString(cantidad);
            Utilidad.Text = Convert.ToString(utilidad);
        }

        private int obtenerCantBulto(string cantidadString)
        {
            int pos1;
            int pos2;

            pos1 = cantidadString.IndexOf(" ", 0);
            pos2 = cantidadString.IndexOf(" ", pos1 + 1);
            pos1 = cantidadString.IndexOf(" ", pos2 + 1);
            pos2 = cantidadString.IndexOf(" ", pos1 + 1);
            return Convert.ToInt32(cantidadString.Substring(pos1, pos2 - pos1));
        }
    }
}