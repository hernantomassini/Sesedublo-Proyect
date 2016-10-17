using MetroFramework.Forms;
using MySql.Data.MySqlClient;
using Sesedublo_SLPL.Generales;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sesedublo_SLPL
{
    public partial class Elegir_Proveedor : MetroForm
    {
        public Elegir_Proveedor()
        {
            InitializeComponent();
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            Manejador_Formularios.Agregar_Cliente.agregarCliente();
            Manejador_Formularios.Agregar_Cliente.Show();
        }

        public void getData()
        {
            MySqlDataAdapter da = Conexion.executeProcedureWithAdapter("cargarGrillaClientes", Conexion.generarArgumentos("_nombre", "_apellido", "_direccion"), nombre.Text, "", "");
            DataTable tablaDeUsuarios = new DataTable("Clientes");
            da.Fill(tablaDeUsuarios);
            ClienteDGV.DataSource = tablaDeUsuarios.DefaultView;
            ClienteDGV.Columns[0].Visible = false;

            Conexion.closeConnection();
        }

        private void nombre_TextChanged(object sender, EventArgs e)
        {
            this.getData();
        }

        public void Clean()
        {
            nombre.Clear();
        }

        private void AtrasTile_Click(object sender, EventArgs e)
        {
            Manejador_Formularios.Pedido_de_compra.Show();
            this.Close();
        }

        private void SiguienteTile_Click(object sender, EventArgs e)
        {
            DataGridViewRow filaDgv = ClienteDGV.CurrentRow;

            if (!Validaciones.validarFilaMarcada(filaDgv, this))
            {
                return;
            }

            int id_cliente = Convert.ToInt32(filaDgv.Cells[0].Value);

            Manejador_Formularios.AddPedidoCompra.CrearPedido(id_cliente);
            Manejador_Formularios.AddPedidoCompra.Show();
            Hide();
        }

        private void Elegir_Proveedor_Load(object sender, EventArgs e)
        {

        }
    }
}
