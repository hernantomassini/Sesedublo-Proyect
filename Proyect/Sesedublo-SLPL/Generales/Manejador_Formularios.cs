using Sesedublo_SLPL.Administrar_Pedidos;
using Sesedublo_SLPL.Administrar_Productos;
using Sesedublo_SLPL.Administrar_Usuarios;
using Sesedublo_SLPL.Revisar_Cajans;
using Sesedublo_SLPL.Historial_de_Operacionesns;
using Sesedublo_SLPL.Historial_de_Facturasns;

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
               // Monto_Caja_Form.getData();
                return Monto_Caja_Form;
            }
        }
        
    }
}
