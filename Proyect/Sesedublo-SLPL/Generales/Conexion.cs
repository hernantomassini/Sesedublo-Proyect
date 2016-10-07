using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace Proyecto_Honda
{
    sealed class Conexion
    {
        private static MySqlConnection connection = new MySqlConnection(Funciones.getStringConnection());

        //[Hernán]: Suelo usar cuando necesito ejecutar un store procedure que actualice la DB, o que realice alguna acción que no devuelva datos.
        public static void executeProcedure(string procedure, List<string> args, params object[] values)
        {
            connection.Open();

            MySqlDataReader dr;
            MySqlCommand cm = new MySqlCommand(procedure, connection);
            cm.CommandTimeout = 2000;
            cm.CommandType = CommandType.StoredProcedure;
            if (_validateArgumentsAndParameters(args, values))
            {
                _loadSqlCommand(args, cm, values);
            }
            dr = cm.ExecuteReader();
            dr.Close();
        }

        public static MySqlDataReader executeProcedureWithReader(string procedure, List<string> args, params object[] values)
        {
            connection.Open();

            MySqlDataReader dr;
            MySqlCommand cm = new MySqlCommand(procedure, connection);
            cm.CommandType = CommandType.StoredProcedure;
            if (_validateArgumentsAndParameters(args, values))
            {
                _loadSqlCommand(args, cm, values);
            }
            dr = cm.ExecuteReader();
            return dr;
        }

        //[Gonza]: Esto llena el DataGridView directamente, sin hacerle modificación alguna mirar ejemplo en ABMUsuarios.
        public static MySqlDataAdapter executeProcedureWithAdapter(string procedure, List<string> args, params object[] values)
        {
            connection.Open();

            MySqlDataAdapter dr = new MySqlDataAdapter(procedure, connection);
            dr.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
            if (_validateArgumentsAndParameters(args, values))
            {
                _loadSqlAdapterCommand(args, dr, values);
            }
            return dr;
        }

        //[Hernán]: Suelo usar esto cuando necesito obtener datos mediante una query simple, que no presente complejidad.
        public static MySqlDataReader ejecutarQuery(string query)
        {
            connection.Open();

            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataReader reader = command.ExecuteReader();
            return reader;
        }

        public static MySqlDataAdapter ejecutarQueryAdapter(string query)
        {
            connection.Open();

            MySqlDataAdapter dr = new MySqlDataAdapter(query, connection);
            return dr;
        }


        //[Hernán]: Personalmente, no uso esto nunca.
        public static int ejecutarNonQuery(string query)
        {
            connection.Open();

            MySqlCommand command = new MySqlCommand(query, connection);
            int rowCount = command.ExecuteNonQuery();
            return rowCount;
        }

        public static void closeConnection()
        {
            connection.Close();
        }

        //No tocar.
        private static bool _validateArgumentsAndParameters(List<string> args, params object[] values)
        {
            if (args != null && values != null)
            {
                if (args.Count != values.Length)
                {
                    throw new ApplicationException();
                }
                return true;
            }
            return false;
        }

        //No tocar.
        private static void _loadSqlCommand(List<string> args, MySqlCommand cm, params object[] values)
        {
            for (int i = 0; i < args.Count; i++)
            {
                cm.Parameters.AddWithValue(args[i], values[i]);
            }
        }

        public MySqlDataAdapter crearNuevoAdapter(string cmd)
        {
            connection.Open();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd, connection);

            return da;
        }

        private static void _loadSqlAdapterCommand(List<string> args, MySqlDataAdapter cm, params object[] values)
        {
            for (int i = 0; i < args.Count; i++)
            {
                cm.SelectCommand.Parameters.AddWithValue(args[i], values[i]);
            }
        }

        //No tocar.
        public static List<string> generarArgumentos(params object[] parametros)
        {
            List<string> lista = new List<string>();
            for (int i = 0; i < parametros.Length; i++)
            {
                lista.Add(parametros[i].ToString());
            }
            return lista;
        }

        public DataTable ejecutarQueryG(string query)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandTimeout = 800;
            connection.Open();
            cmd.Connection = connection;
            cmd.CommandText = query;

            MySqlDataAdapter da = new MySqlDataAdapter(query, connection);
            DataTable tabla = new DataTable();
            tabla.Locale = System.Globalization.CultureInfo.InvariantCulture;
            da.Fill(tabla);

            return tabla;
        }

        public bool darEscalarG(MySqlCommand cmd)
        {
            connection.Open();
            cmd.Connection = connection;
            if (cmd.ExecuteScalar() != null)
            {
                Conexion.closeConnection();
                return true;
            }
            else
            {
                Conexion.closeConnection();
                return false;
            }
        }
    }
}

