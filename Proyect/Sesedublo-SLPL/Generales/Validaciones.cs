using MetroFramework.Forms;
using System;
using System.Text;
using System.Windows.Forms;

namespace Sesedublo_SLPL.Generales
{
    public class Validaciones
    {
        Conexion conn = new Conexion();

        public bool validarNoVacio(Control control, StringBuilder mensajeValidacion)
        {
            if (string.IsNullOrEmpty(control.Text))
            {
                mensajeValidacion.AppendLine(string.Format(" El campo {0} no puede estar en blanco.", control.Name));
                return false;
            }
            return true;
        }

        public static bool validarFilaMarcada(DataGridViewRow filaDgv, MetroForm form)
        {
            if (filaDgv == null)
            {
                Funciones.imprimirMensajeDeError("No hay ninguna fila seleccionada.",form);
                return false;
            }
            return true;
        }

        public void ingresarNumeroDecimal(KeyPressEventArgs e)
        {
            {
                String Aceptados = "," + Convert.ToChar(8);

                if (Aceptados.Contains("" + e.KeyChar) || char.IsDigit(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
        }

        public void ingresarMail(KeyPressEventArgs e)
        {
            {
                String Aceptados = "_.,@-" + Convert.ToChar(8);

                if (Aceptados.Contains("" + e.KeyChar) || char.IsLetter(e.KeyChar) || char.IsDigit(e.KeyChar) || e.KeyChar == ' ')
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
        }

        public void ingresarNumero(KeyPressEventArgs e)
        {
            {
                if (char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back)
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
        }


        public void ingresarNumeroConRaya(KeyPressEventArgs e)
        {
            {
                String Aceptados = "-" + Convert.ToChar(8);

                if (char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || Aceptados.Contains("" + e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
        }


        public void ingresarNombre(System.Windows.Forms.KeyPressEventArgs e)
        {
            {
                String Aceptados = " " + Convert.ToChar(8);
                if (char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || Aceptados.Contains("" + e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
        }

        //public void validarEmail(Control mail, StringBuilder mensajeValidacion)
        //{
        //    StringBuilder query = new StringBuilder();
        //    query.AppendFormat("SELECT * FROM Usuarios u WHERE u.mail='{0}'", mail.Text);
        //    if (conn.ejecutarQueryG(query.ToString()).Rows.Count > 0)
        //    {
        //        mensajeValidacion.AppendLine(string.Format(" El email {0} ya existe.", mail.Text));
        //    };
        //}

        //public void validarLegajo(Control legajo, StringBuilder mensajeValidacion)
        //{
        //    StringBuilder query = new StringBuilder();
        //    query.AppendFormat("SELECT * FROM EmpleadosHonda eh WHERE eh.legajo={0}", legajo.Text);
        //    if (conn.ejecutarQueryG(query.ToString()).Rows.Count > 0)
        //    {
        //        mensajeValidacion.AppendLine(string.Format(" El legajo {0} ya existe.", legajo.Text));
        //    };
        //}

        //public void validarCeCo(Control CeCo, StringBuilder mensajeValidacion)
        //{
        //    StringBuilder query = new StringBuilder();
        //    query.AppendFormat("SELECT * FROM Usuario u WHERE u.CeCo={0}", CeCo.Text);
        //    if (conn.ejecutarQueryG(query.ToString()).Rows.Count > 0)
        //    {
        //        mensajeValidacion.AppendLine(string.Format(" El CeCo {0} ya existe.", CeCo.Text));
        //    };
        //}


       /* public void validarFormaMail(Control mail, StringBuilder mensajeValidacion)
        {
            StringBuilder query = new StringBuilder();
            query.AppendFormat("IF('{0}' NOT LIKE  \"%@%\" OR '{0}' NOT LIKE \"%.com%\") SELECT * FROM Usuarios", mail.Text);
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandTimeout = 800;
            cmd.CommandText = query.ToString();
            if (conn.darEscalarG(cmd))
            {
                mensajeValidacion.AppendLine(string.Format(" El email {0} tiene un formato invalido", mail.Text));
            };
        }
        */
    }
}
