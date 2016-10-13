using MetroFramework.Forms;
using System;
using System.ComponentModel;

namespace Sesedublo_SLPL.Historial_de_Facturasns
{
    public partial class AddNotaDeCredito : MetroForm
    {
        int id_factura = -1;

        public AddNotaDeCredito()
        {
            InitializeComponent();
            this.Closing += new CancelEventHandler(Avoid_Closing);
        }

        void Avoid_Closing(object sender, CancelEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void AddNotaDeCredito_Load(object sender, EventArgs e)
        {

        }

        public void agregarNotaCredito(int id_factura)
        {
            this.id_factura = id_factura;
        }

        private void CancelarTile_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AceptarTile_Click(object sender, EventArgs e)
        {

        }
    }
}
