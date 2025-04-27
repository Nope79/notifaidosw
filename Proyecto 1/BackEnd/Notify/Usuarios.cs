using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using Org.BouncyCastle.Crypto;
using Proyecto_1.BackEnd;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Not.Backend
{
    public class Usuario
    {

        public int id;
        public string usuario;
        public string password;
        public string nombre;
        public string correo;
        public int id_admin;
        //public int id_grupo;
        Conexion c = new Conexion();

        public Usuario()
        {

        }

        public Usuario(int id, string usuario, string password, string nombre, string correo, int id_admin)
        {
            this.id = id;
            this.usuario = usuario;
            this.password = password;
            this.nombre = nombre;
            this.correo = correo;
            this.id_admin = id_admin;
        }

        public Usuario(int id, string usuario)
        {
            this.id = id;
            this.usuario = usuario;
        }

        public bool crear_seccion()
        {
            return false;
        }

        public bool eliminar_seccion()
        {
            return false;
        }

        public bool actualizar_seccion()
        {
            return false;
        }

        public bool silenciar_notificacion()
        {

            return false;
        }

        public bool activar_notificacion()
        {

            return false;
        }

        public bool silenciar_seccion()
        {
            return false;
        }

        public bool activar_seccion()
        {
            return false;
        }

        public bool silenciar_grupo()
        {
            return false;
        }

        public bool activar_grupo()
        {
            return false;
        }

        public DataTable mostrar_usuarios()
        {
            DataTable dataTable = new DataTable();

            try
            {
                c.OpenConnection();

                string query = "select * from usuario";
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

        public bool crear_usuario(Usuario u)
        {
            MySqlTransaction tran = null;
            try
            {
                c.OpenConnection();

                tran = c.GetConnection().BeginTransaction();

                MySqlConnection connection = c.GetConnection();
                string query = "insert into usuario(usuario, password, nombre, correo, ida) values (@user, sha2(@pass, 512), @nombre, @correo, @id_a)";

                MySqlCommand cmd = new MySqlCommand(query, c.GetConnection());

                cmd.Parameters.AddWithValue("@user", u.usuario);
                cmd.Parameters.AddWithValue("@pass", u.password);
                cmd.Parameters.AddWithValue("@nombre", u.nombre);
                cmd.Parameters.AddWithValue("@correo", u.correo);
                cmd.Parameters.AddWithValue("@id_a", u.id_admin);

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

        public bool eliminar_usuario(Usuario u)
        {
            MySqlTransaction tran = null;
            bool res = true;
            string query = "delete from usuario where idu = @id";

            try
            {
                c.OpenConnection();
                tran = c.GetConnection().BeginTransaction();
                using (MySqlCommand cmd = new MySqlCommand(query, c.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@id", u.id);
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

        public bool actualizar_usuario(Usuario u)
        {
            MySqlTransaction tran = null;
            bool res = true;
            string query = "update usuario set usuario = @user, password = sha2(@pass, 512), nombre = @nombre, correo = @correo where idu = @id";

            try
            {
                c.OpenConnection();
                tran = c.GetConnection().BeginTransaction();
                using (MySqlCommand cmd = new MySqlCommand(query, c.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@user", u.usuario);
                    cmd.Parameters.AddWithValue("@pass", u.password);
                    cmd.Parameters.AddWithValue("@nombre", u.nombre);
                    cmd.Parameters.AddWithValue("@correo", u.correo);
                    cmd.Parameters.AddWithValue("@id", u.id);

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
