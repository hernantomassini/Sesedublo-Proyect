﻿using MetroFramework.Forms;
using MySql.Data.MySqlClient;
using Sesedublo_SLPL.Generales;
using System;
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

            if (Funciones.imprimirMensajeDeAlerta("¿Estás seguro de borrar este pedido? Esta acción no se podrá deshacer.", this) == DialogResult.Cancel)
            {   
                return;
            }

            int id_pedido = Convert.ToInt32(filaDgv.Cells[0].Value);

            Conexion.executeProcedure("borrarPedido", Conexion.generarArgumentos("_id_pedido"), id_pedido);
            Conexion.closeConnection();

            cargarDGV();
        }

        private void modificarPedidoTile_Click(object sender, EventArgs e)
        {

        }

        private void AgregarPedidoTile_Click(object sender, EventArgs e)
        {
            Manejador_Formularios.AgregarPedido.Clean();
            Manejador_Formularios.AgregarPedido.Show();
            Close();
        }

        private void FacturarPedidoTile_Click(object sender, EventArgs e)
        {

        }

        private void ABM_Pedidos_Load(object sender, EventArgs e)
        {

        }

        public void cargarDGV()
        {
            Funciones.limpiarDGV(PedidosDGV);
            MySqlDataReader reader = Conexion.executeProcedureWithReader("obtenerPedidos", Conexion.generarArgumentos());
            
            while (reader.Read())
            {
                //ID Stock 0 - Nombre 1 - Costo 2 - Debe 3 - Lista strings 4
                PedidosDGV.Rows.Add(reader.GetInt32(0), reader.GetString(1), reader.GetDecimal(2), reader.GetDecimal(3), reader.GetString(4));
            }

            reader.Close();
            Conexion.closeConnection();
        }
    }
}
