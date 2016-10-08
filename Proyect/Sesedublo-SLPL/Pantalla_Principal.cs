﻿using Sesedublo_SLPL.Generales;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Sesedublo_SLPL
{
    public partial class Pantalla_Principal : Form
    {
        const int WM_SYSCOMMAND = 0x0112;
        const int SC_CLOSE = 0xF060;

        public Pantalla_Principal()
        {
            InitializeComponent();
            this.Closing += new CancelEventHandler(Principal_Closing);
        }

        private void Pantalla_Principal_Load(object sender, EventArgs e)
        {

        }

        protected override void WndProc(ref Message m)
        {
            if ((m.Msg == WM_SYSCOMMAND) && (m.WParam == (IntPtr)SC_CLOSE))
            {
                if (Funciones.imprimirMensajeDeAlerta("¿Realmente desea salir? Esta acción finalizará el programa") == DialogResult.Cancel)
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
            Manejador_Formularios.ABM_Pedidos.Show();
        }

        private void GoToStock_Click(object sender, EventArgs e)
        {
            Manejador_Formularios.ABM_Stock.Show();
        }

        private void GoToUsuarios_Click(object sender, EventArgs e)
        {
            Manejador_Formularios.ABM_Usuarios.Show();
        }

        private void GoToHistorialFacturas_Click(object sender, EventArgs e)
        {
            Manejador_Formularios.Historial_de_Facturas.Show();
        }

        private void GoToHistorialOperaciones_Click(object sender, EventArgs e)
        {
            Manejador_Formularios.Historial_de_Operaciones.Show();
        }

        private void GoToRevisarCaja_Click(object sender, EventArgs e)
        {
            Manejador_Formularios.Monto_Caja.Show();
        }
    }
}