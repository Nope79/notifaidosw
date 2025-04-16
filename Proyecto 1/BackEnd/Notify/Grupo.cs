using MySql.Data.MySqlClient;
using Proyecto_1.BackEnd;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Not.Backend
{
    public class Grupo
    {

        public int id;
        public int numero_usuarios;
        public int id_admin;
        public string nombre;
        public string descripcion;
        Conexion c = new Conexion();
        public Grupo()
        {

        }

        public Grupo(int id, string nombre, string descripcion)
        {
            this.id = id;
            this.nombre = nombre;
            this.descripcion = descripcion;
        }

        public string ver_usuarios()
        {
            return null;
        }

        public DataTable mostrar_grupos()
        {
            DataTable dataTable = new DataTable();

            try
            {
                c.OpenConnection();

                string query = "select * from grupo";
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
                Console.WriteLine(ex);
            }
            finally
            {
                c.CloseConnection();
            }

            return dataTable;
        }

        public bool crear_grupo(Grupo g)
        {
            MySqlTransaction tran = null;
            try
            {
                c.OpenConnection();

                tran = c.GetConnection().BeginTransaction();

                MySqlConnection connection = c.GetConnection();
                string query = "insert into grupo (numerousuarios, nombre, descripcion, ida) values (0, @nombre, @descripcion, @id_a)";

                MySqlCommand cmd = new MySqlCommand(query, c.GetConnection());

                // insert into grupo (numerousuarios, nombre, descripcion, ida) values

                cmd.Parameters.AddWithValue("@nombre", g.nombre);
                cmd.Parameters.AddWithValue("@descripcion", g.descripcion);
                cmd.Parameters.AddWithValue("@id_a", g.id_admin);

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

        public bool eliminar_grupo(Grupo g)
        {
            MySqlTransaction tran = null;
            bool res = true;
            string query = "delete from grupo where idg = @id";

            try
            {
                c.OpenConnection();
                tran = c.GetConnection().BeginTransaction();
                using (MySqlCommand cmd = new MySqlCommand(query, c.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@id", g.id);
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

        public bool actualizar_grupo(Grupo g)
        {
            MySqlTransaction tran = null;
            bool res = true;
            string query = "update grupo set nombre = @nombre, descripcion = @descripcion where idg = @id";

            try
            {
                c.OpenConnection();
                tran = c.GetConnection().BeginTransaction();
                using (MySqlCommand cmd = new MySqlCommand(query, c.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@nombre", g.nombre);
                    cmd.Parameters.AddWithValue("@descripcion", g.descripcion);
                    cmd.Parameters.AddWithValue("@id", g.id);

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
    }
}
