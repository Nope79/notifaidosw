using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Proyecto_1.BackEnd
{
    public class Areas
    {
        // atributos de la tabla area en la base de datos
        public int area_id;
        public string area_nombre;
        public string area_ubicacion;
        Conexion c = new Conexion();

        // Se tienen distintos constructores para facilitarnos el trabajo a la hora de cargar distintas vistas, ese es su principal funcion
        public Areas()
        {
        }

        public Areas(int area_id)
        {
            this.area_id = area_id;
        }

        public Areas(string area_nombre, string area_ubicacion)
        {
            this.area_nombre = area_nombre;
            this.area_ubicacion = area_ubicacion;
        }

        public Areas(int area_id, string area_nombre, string area_ubicacion)
        {
            this.area_id = area_id;
            this.area_nombre = area_nombre;
            this.area_ubicacion = area_ubicacion;
        }

        // Metodos de seleccionar, añadir, eliminar y actualizar, todo usando transacciones
        public DataTable seleccionar()
        {
            DataTable dataTable = new DataTable();

            try
            {
                c.OpenConnection();

                string query = "SELECT area_id, area_nombre, area_ubicacion FROM areas";
                using (MySqlCommand command = new MySqlCommand(query, c.GetConnection()))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }
            catch (Exception ex)
            {
                //Console.WriteLine(ex);
            }
            finally
            {
                c.CloseConnection();
            }

            return dataTable;
        }

        public bool insertar(Areas a)
        {
            MySqlTransaction tran = null;
            try
            {
                c.OpenConnection();
                
                tran = c.GetConnection().BeginTransaction();

                MySqlConnection connection = c.GetConnection();
                string query = "insert into areas(area_nombre, area_ubicacion) values (@nombre, @ubicacion)";
                
                MySqlCommand cmd = new MySqlCommand(query, c.GetConnection());

                cmd.Parameters.AddWithValue("@nombre", a.area_nombre);
                cmd.Parameters.AddWithValue("@ubicacion", a.area_ubicacion);
                
                cmd.ExecuteNonQuery();
                tran.Commit();
                
                return true;
            }
            catch (Exception ex)
            {
                if (tran != null)
                {
                    tran.Rollback();
                }
                //MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                c.CloseConnection();
            }
        }

        public bool eliminar(Areas a)
        {
            MySqlTransaction tran = null;
            bool res = true;
            string query = "delete from areas where area_id = @id";

            try
            {
                c.OpenConnection();
                tran = c.GetConnection().BeginTransaction();
                using (MySqlCommand cmd = new MySqlCommand(query, c.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@id", a.area_id);
                    int filas = cmd.ExecuteNonQuery();
                    res = filas > 0;
                }
                tran.Commit();
            }
            catch (Exception ex)
            {
                if (tran != null)
                {
                    tran.Rollback();
                }
                //MessageBox.Show(ex.Message);
                res = false;
            }
            finally
            {
                c.CloseConnection();
            }

            return res;
        }

        public bool actualizar(Areas a)
        {
            MySqlTransaction tran = null;
            bool res = true;
            string query = "update areas set area_nombre = @nombre, area_ubicacion = @ubicacion where area_id = @id";

            try
            {
                c.OpenConnection();
                tran = c.GetConnection().BeginTransaction();
                using (MySqlCommand cmd = new MySqlCommand(query, c.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@id", a.area_id);
                    cmd.Parameters.AddWithValue("@nombre", a.area_nombre);
                    cmd.Parameters.AddWithValue("@ubicacion", a.area_ubicacion);
                    int filas = cmd.ExecuteNonQuery();
                    res = filas > 0;
                }
                tran.Commit();
            }
            catch (Exception ex)
            {
                if (tran != null)
                {
                    tran.Rollback();
                }
                //MessageBox.Show(ex.Message);
                res = false;
            }
            finally
            {
                c.CloseConnection();
            }

            return res;
        }

        // Buscamos un id para verificar que una area existe y poder hacer una insersión o actualización en inventario
        public bool buscar_id(int id)
        {
            bool u = false;
            string query = "select area_id from areas where area_id = @id";

            try
            {
                c.OpenConnection();

                using (MySqlCommand cmd = new MySqlCommand(query, c.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@id", id);

                    var resultado = cmd.ExecuteScalar();
                    if (resultado != null)
                    {
                        u = true;
                    }
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
            finally
            {
                c.CloseConnection();
            }

            return u;
        }
    }
}
