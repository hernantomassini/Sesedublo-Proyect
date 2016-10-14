﻿using Enums;
using MetroFramework.Forms;
using MySql.Data.MySqlClient;
using Sesedublo_SLPL.Generales;
using System;
using System.ComponentModel;
using System.Data;
using System.Text;

namespace Sesedublo_SLPL.Administrar_Stock
{
    public partial class AddProducto : MetroForm
    {
        accionesABM flag = accionesABM.Crear;
        int id_stock = -1;
        Validaciones val = new Validaciones();
        StringBuilder st = new StringBuilder();

        public AddProducto()
        {
            InitializeComponent();
            this.getProductos();
            Nombre.Text = dgvProductos.Rows[0].Cells[0].Value.ToString();
            this.Closing += new CancelEventHandler(Avoid_Closing);
        }

        void Avoid_Closing(object sender, CancelEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
            Manejador_Formularios.ABM_Stock.cargarDGV();
            Manejador_Formularios.ABM_Stock.Show();
        }

        private void AddProducto_Load(object sender, EventArgs e)
        {

        }


        public void AgregarProducto()
        {
            Clean();
            flag = accionesABM.Crear;
            Nombre.Text = dgvProductos.Rows[0].Cells[0].Value.ToString();
        }

        public void ModificarProducto(int id_stock)
        {
            Clean();
            flag = accionesABM.Modificar;
            this.id_stock = id_stock;
            cargarDatos();
        }

        private void cargarDatos()
        {
            MySqlDataReader reader = Conexion.executeProcedureWithReader("obtenerProducto", Conexion.generarArgumentos("_id_stock"), id_stock);
            reader.Read();

            int cantXBulto = reader.GetInt32(1);
            decimal costo = Convert.ToDecimal(reader.GetDecimal(3));

            if (cantXBulto == 0)
            { 
                //Individual
                individualRadio.Checked = true;
                decimal PVUnitario = reader.GetDecimal(4);
                Utilidad.Text = Convert.ToString(PVUnitario - costo);
            }
            else
            {
                //Bulto
                bultoRadio.Checked = true;
                decimal PVBulto = reader.GetDecimal(5);
                Utilidad.Text = Convert.ToString(Decimal.Round((PVBulto - costo) / cantXBulto, 2));
            }

            Nombre.Text = reader.GetString(2);
            Cantidad.Text = reader.GetString(0);
            UnidadesXBulto.Text = Convert.ToString(cantXBulto);
            Costo.Text = Convert.ToString(costo);

            reader.Close();
            Conexion.closeConnection();
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

        private void Clean()
        {
            individualRadio.Checked = true;

            buscarProducto.Clear();
            Cantidad.Clear();
            UnidadesXBulto.SelectedIndex = 0;
            Nombre.Clear();
            Costo.Clear();
            Utilidad.Clear();
        }

        private void AtrasBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AgregarProductoBtn_Click(object sender, EventArgs e)
        {

            val.validarNoVacio(Nombre,st);
            val.validarNoVacio(Costo, st);
            val.validarNoVacio(Utilidad, st);
            val.validarNoVacio(Cantidad, st);

            if (bultoRadio.Checked)
                val.validarNoVacio(UnidadesXBulto, st);

            if (st.Length > 0)
            {
                Funciones.imprimirMensajeDeError(st.ToString(), this);
                st = new StringBuilder();
            }
            else
            {

                int cantXBulto = Convert.ToInt32(UnidadesXBulto.Text);
                decimal costo = Convert.ToDecimal(Costo.Text);
                decimal utilidad = Convert.ToDecimal(Utilidad.Text);

                decimal precioPorUnidad = costo + utilidad;
                decimal precioPorBulto = precioPorUnidad;

                if (individualRadio.Checked)
                {
                    cantXBulto = 0;
                    precioPorBulto = 0;
                }
                else
                {

                    precioPorBulto = Convert.ToDecimal(Precio.Text);
                    precioPorUnidad = decimal.Round(precioPorBulto / cantXBulto, 2);
                }


                if (flag == accionesABM.Crear)
                {

                    Conexion.executeProcedure("agregarStock", Conexion.generarArgumentos("_cantidad", "_cantidadXBulto", "_costo", "_nombre", "_PVUnitario", "_PVBulto"), Convert.ToInt32(Cantidad.Text), cantXBulto, costo, Nombre.Text, precioPorUnidad, precioPorBulto);
                    Conexion.closeConnection();
                    Conexion.executeProcedure("restarEfectivo", Conexion.generarArgumentos("_montoARestar", "_descripcion"), costo, "Compra de productos " + Nombre.Text + "de " + Cantidad.Text + " unidades");
                }
                else
                {
                    Conexion.executeProcedure("modificarStock", Conexion.generarArgumentos("_id_stock", "_cantidad", "_cantidadXBulto", "_costo", "_nombre", "_PVUnitario", "_PVBulto"), id_stock, Convert.ToInt32(Cantidad.Text), cantXBulto, costo, Nombre.Text, precioPorUnidad, precioPorBulto);
                }
                Conexion.closeConnection();
                Close();
            }
        }

        private void individualRadio_CheckedChanged(object sender, EventArgs e)
        {
            if(individualRadio.Checked)
            {
                CostoLabel.Text = "Costo por unidad:";
                CantidadLbl.Text = "Cantidad de unidades:";
                UnidadesXBultoLbl.Visible = false;
                UnidadesXBulto.Visible = false;
            }
            else
            {
                CostoLabel.Text = "Costo por bulto:";
                CantidadLbl.Text = "Cantidad de bultos:";
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
            if(dgvProductos.Rows.Count == 1)
                Nombre.Text = this.dgvProductos.CurrentRow.Cells[0].Value.ToString();
        }

        private void dgvProductos_CellClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            Nombre.Text = this.dgvProductos.CurrentRow.Cells[0].Value.ToString();
        }

        private void nuevoProducto_Click(object sender, EventArgs e)
        {
            Manejador_Formularios.NuevoProducto.Show();
        }

        private void Utilidad_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Costo.Text))
            {
                if (!String.IsNullOrEmpty(Utilidad.Text))
                {
                    Precio.Text = Convert.ToString(Convert.ToDecimal(Utilidad.Text));
                }
            }
            else
            {
                if (!String.IsNullOrEmpty(Utilidad.Text))
                {
                    Precio.Text = Convert.ToString(Convert.ToDecimal(Utilidad.Text) + Convert.ToDecimal(Costo.Text));

                    if (!individualRadio.Checked)
                    {
                        Precio.Text = Convert.ToString(Convert.ToDecimal(Costo.Text) + Convert.ToDecimal(Utilidad.Text) * Convert.ToDecimal(UnidadesXBulto.Text));
                    }
                }
            } 
        }

        private void Costo_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Utilidad.Text))
            {
                if (!String.IsNullOrEmpty(Costo.Text))
                {
                    Precio.Text = Convert.ToString(Convert.ToDecimal(Costo.Text));
                }
            }
            else
            {
                if (!String.IsNullOrEmpty(Costo.Text))
                {
                    Precio.Text = Convert.ToString(Convert.ToDecimal(Utilidad.Text) + Convert.ToDecimal(Costo.Text));

                    if (!individualRadio.Checked)
                    {
                        Precio.Text = Convert.ToString(Convert.ToDecimal(Costo.Text) + Convert.ToDecimal(Utilidad.Text) * Convert.ToDecimal(UnidadesXBulto.Text));
                    }
                    
                }
            } 
        }
    }
}