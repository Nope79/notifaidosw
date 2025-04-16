using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Proyecto_1.BackEnd
{
    public class Conexion
    {
        private MySqlConnection connection;
        private readonly string connectionString;
        public Conexion()
        {
            connectionString = "server=localhost; user id = root; password =P3rR012.;database=ing; port=3306;";
            connection = new MySqlConnection(connectionString);
        }

        // Metodo para abrir la conexion
        public void OpenConnection()
        {
            try
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        // Metodo para cerrar la conexion
        public void CloseConnection()
        {
            try
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                    // connection.Dispose(); si le dejo esto, hay problemas al borrar, jeje
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        // Getter de la conexion
        public MySqlConnection GetConnection()
        {
            return connection;
        }
    }
}
