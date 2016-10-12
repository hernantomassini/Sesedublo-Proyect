using Enums;
using MetroFramework.Forms;
using MySql.Data.MySqlClient;
using Sesedublo_SLPL.Generales;
using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace Sesedublo_SLPL.Pedidos_de_Compra
{
    public partial class AddPedidoCompra : MetroForm
    {
        accionesABM flag = accionesABM.Crear;
        Validaciones val = new Validaciones();

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
            //MySqlDataReader reader = Conexion.executeProcedureWithReader("obtenerProducto", Conexion.generarArgumentos("_id_stock"), id_stock);
            //reader.Read();

            //int cantXBulto = reader.GetInt32(1);
            //decimal costo = Convert.ToDecimal(reader.GetDecimal(3));

            //if (cantXBulto == 0)
            //{
            //    //Individual
            //    individualRadio.Checked = true;
            //    decimal PVUnitario = reader.GetDecimal(4);
            //    Utilidad.Text = Convert.ToString(PVUnitario - costo);
            //}
            //else
            //{
            //    //Bulto
            //    bultoRadio.Checked = true;
            //    decimal PVBulto = reader.GetDecimal(5);
            //    Utilidad.Text = Convert.ToString(Decimal.Round((PVBulto - costo) / cantXBulto, 2));
            //}

            //Nombre.Text = reader.GetString(2);
            //Cantidad.Text = reader.GetString(0);
            //UnidadesXBulto.Text = Convert.ToString(cantXBulto);
            //Costo.Text = Convert.ToString(costo);

            //reader.Close();
            //Conexion.closeConnection();
        }

        private void individualRadio_CheckedChanged(object sender, EventArgs e)
        {
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
            int cantXBulto;
            string nombre;
            decimal costo;
            int cantidad;
            decimal PVUnitario;
            decimal PVBulto;

            if (flag == accionesABM.Crear) {

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
            }
            else
            {
                Funciones.tirarException();
            }

            Close();
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

        private void AddPedidoCompra_Load(object sender, EventArgs e)
        {

        }
    }
}