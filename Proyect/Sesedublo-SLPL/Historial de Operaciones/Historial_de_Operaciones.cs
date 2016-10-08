using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sesedublo_SLPL.Historial_de_Operacionesns
{
    public partial class Historial_de_Operaciones : Form
    {
        public Historial_de_Operaciones()
        {
            InitializeComponent();
            this.Closing += new CancelEventHandler(Avoid_Closing);
        }

        void Avoid_Closing(object sender, CancelEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void Historial_de_Operaciones_Load(object sender, EventArgs e)
        {

        }
    }
}
