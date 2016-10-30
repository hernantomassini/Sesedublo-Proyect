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
    }
}
