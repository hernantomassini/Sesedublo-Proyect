using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sesedublo_SLPL.Administrar_Pedidos
{
    class Producto
    {
        int cantidad;
        decimal precioCobrado;

        public Producto(int cantidad, decimal precioCobrado)
        {
            this.cantidad = cantidad;
            this.precioCobrado = precioCobrado;
        }

        public int getCantidad()
        {
            return cantidad;
        }

        public decimal getPrecioCobrado()
        {
            return precioCobrado;
        }

        public void setCantidad(int cantidad)
        {
            this.cantidad = cantidad;
        }

        public void setPrecioCobrado(decimal precio)
        {

            string precioS = Convert.ToString(precio);
            this.precioCobrado = precio;
            MessageBox.Show(Convert.ToString(precioCobrado));
        }
    }
}
