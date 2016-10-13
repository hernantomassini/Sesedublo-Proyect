using MetroFramework.Forms;
using System;
using System.ComponentModel;

namespace Sesedublo_SLPL.Historial_de_Facturasns
{
    public partial class VerRegistroFactura : MetroForm
    {
        public VerRegistroFactura()
        {
            InitializeComponent();
            this.Closing += new CancelEventHandler(Avoid_Closing);
        }

        void Avoid_Closing(object sender, CancelEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void VerRegistroFactura_Load(object sender, EventArgs e)
        {

        }

        public void cargarRegistro(int id_factura)
        {
            //TODO - Cargar DGV con los datos de las notas de credito valor - motivo
        }

        private void CerrarTile_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
