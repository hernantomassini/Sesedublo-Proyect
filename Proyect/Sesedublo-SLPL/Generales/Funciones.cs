using MetroFramework;
using MetroFramework.Forms;
using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Windows.Forms;

namespace Sesedublo_SLPL
{
    class Funciones
    {
        private static int id_user_logeado = -1;
        private static int id_rol_userLogeado = -1;
        private static string connectionString = null;

        public static string obtenerServer()
        {
            return ConfigurationManager.AppSettings["server"];
        }

        public static string obtenerUsuario()
        {
            return ConfigurationManager.AppSettings["user"];
        }

        public static string obtenerPass()
        {
            return ConfigurationManager.AppSettings["password"];
        }

        public static string obtenerDB()
        {
            return ConfigurationManager.AppSettings["DB"];
        }

        public static DialogResult imprimirMensajeDeAlerta(string descripcionAlerta, MetroForm form)
        {
            return (MetroMessageBox.Show(form,descripcionAlerta, "Alerta", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning));
        }

        public static void imprimirMensajeDeError(string descripcionError, MetroForm form)
        {
            MetroMessageBox.Show(form,descripcionError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void imprimirMensajeDeAviso(string descripcionAviso, MetroForm form)
        {
            MetroMessageBox.Show(form, descripcionAviso, "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void limpiarDGV(DataGridView dgv)
        {
            dgv.Rows.Clear();
        }

        public static void limpiarCLB(CheckedListBox clb)
        {
            clb.Items.Clear();
        }

        public static void tirarException()
        {
            throw new NotImplementedException();
        }

        public static int getId_user_logeado()
        {
            return id_user_logeado;
        }

        public static int getId_Rol_usuarioLogeado()
        {
            return id_rol_userLogeado;
        }

        public static void setId_user_logeado(int id_user)
        {
            id_user_logeado = id_user;
        }

        public static void setId_Rol_usuarioLogeado(int id_rol)
        {
            id_rol_userLogeado = id_rol;
        }

        public static string getStringConnection()
        {
            if (connectionString == null)
            {

                MySqlConnectionStringBuilder conexionBuilder = new MySqlConnectionStringBuilder();
                conexionBuilder.Server = Funciones.obtenerServer();
                conexionBuilder.UserID = Funciones.obtenerUsuario();
                conexionBuilder.Password = Funciones.obtenerPass();
                conexionBuilder.Database = Funciones.obtenerDB();

                connectionString = conexionBuilder.ToString();
            }

            return connectionString;
        }
    }
}
