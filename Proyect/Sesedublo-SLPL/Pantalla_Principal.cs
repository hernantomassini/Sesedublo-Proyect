using MetroFramework.Forms;
using Sesedublo_SLPL.Generales;
using System;
using System.ComponentModel;
using System.Globalization;
using System.Windows.Forms;

namespace Sesedublo_SLPL
{
    public partial class Pantalla_Principal : MetroForm
    {
        const int WM_SYSCOMMAND = 0x0112;
        const int SC_CLOSE = 0xF060;

        public Pantalla_Principal()
        {
            InitializeComponent();
            this.Closing += new CancelEventHandler(Principal_Closing);
            timer1.Enabled = true;
        }

        private void Pantalla_Principal_Load(object sender, EventArgs e)
        {

        }

        protected override void WndProc(ref Message m)
        {
            if ((m.Msg == WM_SYSCOMMAND) && (m.WParam == (IntPtr)SC_CLOSE))
            {
                if (Funciones.imprimirMensajeDeAlerta("¿Realmente desea salir? Esta acción finalizará el programa",this) == DialogResult.Cancel)
                {
                    return;
                }
            }

            base.WndProc(ref m);
        }

        void Principal_Closing(object sender, CancelEventArgs e)
        {
            Application.Exit();
            e.Cancel = true;
        }

        private void GoToPedidos_Click(object sender, EventArgs e)
        {

            //Manejador_Formularios.ABM_Pedidos.getData();
            Manejador_Formularios.ABM_Pedidos.Show();
        }

        private void GoToStock_Click(object sender, EventArgs e)
        {
            Manejador_Formularios.ABM_Stock.cargarDGV();
            Manejador_Formularios.AddProducto.getProductos();
            Manejador_Formularios.ABM_Stock.Clean();
            Manejador_Formularios.ABM_Stock.Show();
        }

        private void GoToUsuarios_Click(object sender, EventArgs e)
        {
            Manejador_Formularios.ABM_Usuarios.getData();
            Manejador_Formularios.ABM_Usuarios.Show();
        }

        private void GoToHistorialFacturas_Click(object sender, EventArgs e)
        {
            Manejador_Formularios.Historial_de_Facturas.getData();
            Manejador_Formularios.Historial_de_Facturas.Show();
        }

        private void GoToHistorialOperaciones_Click(object sender, EventArgs e)
        {
            Manejador_Formularios.Historial_de_Operaciones.getData();
            Manejador_Formularios.Historial_de_Operaciones.Show();
        }

        private void GoToRevisarCaja_Click(object sender, EventArgs e)
        {
            Manejador_Formularios.Monto_Caja.updatearLabels();
            Manejador_Formularios.Monto_Caja.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            CultureInfo ci = new CultureInfo("Es-Es");

            TextInfo myTI = new CultureInfo("Es-Es", false).TextInfo;
            label1.Text = myTI.ToTitleCase(ci.DateTimeFormat.GetDayName(DateTime.Now.DayOfWeek)) + DateTime.Now.ToString(" dd ") + "de " + DateTime.Now.ToString("MMMM") + " de " + DateTime.Now.ToString("yyyy") ;
            label2.Text = DateTime.Now.ToString("H:mm");
        }

        private void metroTile7_Click(object sender, EventArgs e)
        {
            Manejador_Formularios.Pedido_de_compra.cargarDGV();
            Manejador_Formularios.Pedido_de_compra.Show();
        }

        private void metroTile8_Click(object sender, EventArgs e)
        {
            Manejador_Formularios.Lista_de_Productos.getData();
            Manejador_Formularios.Lista_de_Productos.Show();
        }


    }
}
