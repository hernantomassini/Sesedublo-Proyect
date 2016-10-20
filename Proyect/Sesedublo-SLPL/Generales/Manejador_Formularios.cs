using Sesedublo_SLPL.Administrar_Pedidos;
using Sesedublo_SLPL.Administrar_Productos;
using Sesedublo_SLPL.Administrar_Usuarios;
using Sesedublo_SLPL.Revisar_Cajans;
using Sesedublo_SLPL.Historial_de_Operacionesns;
using Sesedublo_SLPL.Historial_de_Facturasns;
using Sesedublo_SLPL.Administrar_Stock;
using Sesedublo_SLPL.Revisar_Caja;
using Sesedublo_SLPL.Pedidos_de_Compra;
using Sesedublo_SLPL.Productos;

namespace Sesedublo_SLPL.Generales
{
    public class Manejador_Formularios
    {
        /* Ejemplo de como usar el manejadorFormularios

        Para llamar a un formulario (si existe lo retorna , si no existe lo crea)
         this.Hide(); //Oculta la pantalla en la que estoy
         ManejadorFormularios.TipoDeUsuario.Show(); // me retorna el objeto formulario 
         */
        private static Pantalla_Principal PantallaPrincipal_Form;
        public static Pantalla_Principal PantallaPrincipal
        {
            get
            {
                if (PantallaPrincipal_Form == null)
                {
                    PantallaPrincipal_Form = new Pantalla_Principal();
                }
                
                return PantallaPrincipal_Form;
            }
        }

        private static ABM_Pedidos ABM_Pedidos_Form;
        public static ABM_Pedidos ABM_Pedidos
        {
            get
            {
                if (ABM_Pedidos_Form == null)
                {
                    ABM_Pedidos_Form = new ABM_Pedidos();
                }
                //ABM_Pedidos_Form.getData();
                return ABM_Pedidos_Form;
            }
        }

        private static ABM_Usuarios ABM_Usuarios_Form;
        public static ABM_Usuarios ABM_Usuarios
        {
            get
            {
                if (ABM_Usuarios_Form == null)
                {
                    ABM_Usuarios_Form = new ABM_Usuarios();
                }
                //ABM_Usuarios_Form.getData();
                return ABM_Usuarios_Form;
            }
        }

        private static ABM_Stock ABM_Stock_Form;
        public static ABM_Stock ABM_Stock
        {
            get
            {
                if (ABM_Stock_Form == null)
                {
                    ABM_Stock_Form = new ABM_Stock();
                }
                //ABM_Stock_Form.getData();
                return ABM_Stock_Form;
            }
        }

        private static Historial_de_Facturas Historial_de_Facturas_Form;
        public static Historial_de_Facturas Historial_de_Facturas
        {
            get
            {
                if (Historial_de_Facturas_Form == null)
                {
                    Historial_de_Facturas_Form = new Historial_de_Facturas();
                }
                //Historial_de_Facturas_Form.getData();
                return Historial_de_Facturas_Form;
            }
        }

        private static Ver_Factura Ver_Factura_Form;
        public static Ver_Factura Ver_Factura
        {
            get
            {
                if (Ver_Factura_Form == null)
                {
                    Ver_Factura_Form = new Ver_Factura();
                }
                //Historial_de_Facturas_Form.getData();
                return Ver_Factura_Form;
            }
        }

        private static Historial_de_Operaciones Historial_de_Operaciones_Form;
        public static Historial_de_Operaciones Historial_de_Operaciones
        {
            get
            {
                if (Historial_de_Operaciones_Form == null)
                {
                    Historial_de_Operaciones_Form = new Historial_de_Operaciones();
                }
               // Historial_de_Operaciones_Form.getData();
                return Historial_de_Operaciones_Form;
            }
        }

        private static Monto_Caja Monto_Caja_Form;
        public static Monto_Caja Monto_Caja
        {
            get
            {
                if (Monto_Caja_Form == null)
                {
                    Monto_Caja_Form = new Monto_Caja();
                }
                Monto_Caja_Form.updatearLabels();
                return Monto_Caja_Form;
            }
        }

        private static AddProducto AddProducto_Form;
        public static AddProducto AddProducto
        {
            get
            {
                if (AddProducto_Form == null)
                {
                    AddProducto_Form = new AddProducto();
                }
                return AddProducto_Form;
            }
        }

        private static Agregar_Cliente Agregar_Cliente_Form;
        public static Agregar_Cliente Agregar_Cliente
        {
            get
            {
                if (Agregar_Cliente_Form == null)
                {
                    Agregar_Cliente_Form = new Agregar_Cliente();
                }
                return Agregar_Cliente_Form;
            }
        }

        private static ModifyCash ModifyCash_Form;
        public static ModifyCash ModifyCash
        {
            get
            {
                if (ModifyCash_Form == null)
                {
                    ModifyCash_Form = new ModifyCash();
                }
                return ModifyCash_Form;
            }
        }

        private static AgregarPedido AgregarPedido_Form;
        public static AgregarPedido AgregarPedido
        {
            get
            {
                if (AgregarPedido_Form == null)
                {
                    AgregarPedido_Form = new AgregarPedido();
                }
                return AgregarPedido_Form;
            }
        }

        private static AddProductoAPedido AddProductoAPedido_Form;
        public static AddProductoAPedido AddProductoAPedido
        {
            get
            {
                if (AddProductoAPedido_Form == null)
                {
                    AddProductoAPedido_Form = new AddProductoAPedido();
                }
                return AddProductoAPedido_Form;
            }
        }

        private static AddPedidoCompra AddPedidoCompra_Form;
        public static AddPedidoCompra AddPedidoCompra
        {
            get
            {
                if (AddPedidoCompra_Form == null)
                {
                    AddPedidoCompra_Form = new AddPedidoCompra();
                }
                return AddPedidoCompra_Form;
            }
        }

        private static Pedido_de_compra Pedido_de_compra_Form;
        public static Pedido_de_compra Pedido_de_compra
        {
            get
            {
                if (Pedido_de_compra_Form == null)
                {
                    Pedido_de_compra_Form = new Pedido_de_compra();
                }
                return Pedido_de_compra_Form;
            }
        }


        private static GenerarFactura GenerarFactura_Form;
        public static GenerarFactura GenerarFactura
        {
            get
            {
                if (GenerarFactura_Form == null)
                {
                    GenerarFactura_Form = new GenerarFactura();
                }
                return GenerarFactura_Form;
            }
        }

        private static ActualizarPago ActualizarPago_Form;
        public static ActualizarPago ActualizarPago
        {
            get
            {
                if (ActualizarPago_Form == null)
                {
                    ActualizarPago_Form = new ActualizarPago();
                }
                return ActualizarPago_Form;
            }
        }

        private static AddNotaDeCredito AddNotaDeCredito_Form;
        public static AddNotaDeCredito AddNotaDeCredito
        {
            get
            {
                if (AddNotaDeCredito_Form == null)
                {
                    AddNotaDeCredito_Form = new AddNotaDeCredito();
                }
                return AddNotaDeCredito_Form;
            }
        }

        private static VerRegistroFactura VerRegistroFactura_Form;
        public static VerRegistroFactura VerRegistroFactura
        {
            get
            {
                if (VerRegistroFactura_Form == null)
                {
                    VerRegistroFactura_Form = new VerRegistroFactura();
                }
                return VerRegistroFactura_Form;
            }
        }



        private static Lista_de_Productos Lista_de_Productos_Form;
        public static Lista_de_Productos Lista_de_Productos
        {
            get
            {
                if (Lista_de_Productos_Form == null)
                {
                    Lista_de_Productos_Form = new Lista_de_Productos();
                }
                return Lista_de_Productos_Form;
            }
        }

        private static Producto_Nuevo Producto_Nuevo_Form;
        public static Producto_Nuevo Producto_Nuevo
        {
            get
            {
                if (Producto_Nuevo_Form == null)
                {
                    Producto_Nuevo_Form = new Producto_Nuevo();
                }
                return Producto_Nuevo_Form;
            }
        }

        private static Ver_Remito Ver_Remito_Form;
        public static Ver_Remito Ver_Remito
        {
            get
            {
                if (Ver_Remito_Form == null)
                {
                    Ver_Remito_Form = new Ver_Remito();
                }
                return Ver_Remito_Form;
            }
        }

        private static Ver_Factura_Dup Ver_Factura_Dup_Form;
        public static Ver_Factura_Dup Ver_Factura_Dup
        {
            get
            {
                if (Ver_Factura_Dup_Form == null)
                {
                    Ver_Factura_Dup_Form = new Ver_Factura_Dup();
                }
                return Ver_Factura_Dup_Form;
            }
        }

        private static Elegir_Proveedor Elegir_Proveedor_Form;
        public static Elegir_Proveedor Elegir_Proveedor
        {
            get
            {
                if (Elegir_Proveedor_Form == null)
                {
                    Elegir_Proveedor_Form = new Elegir_Proveedor();
                }
                return Elegir_Proveedor_Form;
            }
        }

        private static MostrarPedidoCompra MostrarPedidoCompra_Form;
        public static MostrarPedidoCompra MostrarPedidoCompra
        {
            get
            {
                if (MostrarPedidoCompra_Form == null)
                {
                    MostrarPedidoCompra_Form = new MostrarPedidoCompra();
                }
                return MostrarPedidoCompra_Form;
            }
        }

    }
}