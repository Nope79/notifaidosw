using MySql.Data.MySqlClient;
using Mysqlx.Cursor;
using Org.BouncyCastle.Asn1.X500;
using Org.BouncyCastle.Crypto;
using Proyecto_1.BackEnd;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Not.Backend
{
    public class Notificacion
    {
        public int id;
        public string tipo;
        public string remitente;
        public string receptor;
        public string descripcion;
        public string fecha;
        public bool prioridad;
        Conexion c = new Conexion();

        public Notificacion()
        {

        }

        public Notificacion(int id, string remitente, string receptor, string desc, string tipo)
        {
            this.id = id;
            this.remitente = remitente;
            this.receptor = receptor;
            this.descripcion = desc;
            this.tipo = tipo;
        }

        public string mostrar_info()
        {

            return null;
        }

        public DataTable mostrar_not()
        {
            DataTable dataTable = new DataTable();

            try
            {
                c.OpenConnection();

                string query = "select * from notificacion";
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

        public DataTable mostrar_not_usuario(Usuario u)
        {
            DataTable dataTable = new DataTable();

            try
            {
                c.OpenConnection();

                string username = u.usuario;
                string query = "select idn as ID, tipo as TIPO, remitente as REMITENTE, descripcion as DESCRIPCIÓN, fecha as FECHA from notificacion where receptor = " + '"' + username + '"' + " order by fecha desc";
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

        public List<NotificacionJson> ConvertirDataTableALista(DataTable dt, Usuario u)
        {
            List<NotificacionJson> listaNotificaciones = new List<NotificacionJson>();

            foreach (DataRow row in dt.Rows)
            {
                NotificacionJson notificacion = new NotificacionJson
                {
                    ID = Convert.ToInt32(row["id"]),
                    TIPO = row["tipo"].ToString(),
                    REMITENTE = row["remitente"].ToString(),
                    DESCRIPCIÓN = row["descripción"].ToString(),
                    FECHA = row["fecha"].ToString(),
                    ESTADO = true
                };

                listaNotificaciones.Add(notificacion);
            }

            return listaNotificaciones;
        }


        public DataTable mostrar_not_importantes()
        {
            DataTable dataTable = new DataTable();

            try
            {
                c.OpenConnection();

                string query = "select remitente as REMITENTE, descripcion as DESCRIPCIÓN, fecha as FECHA from notificacion where tipo = 'Importante' order by fecha desc";
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

        public bool crear_notificacion(Notificacion n)
        {
            MySqlTransaction tran = null;
            try
            {
                c.OpenConnection();

                tran = c.GetConnection().BeginTransaction();

                MySqlConnection connection = c.GetConnection();
                string query = "insert into notificacion (tipo, remitente, receptor, descripcion, ida) values (@tipo, @rem, @rec, @desc, @id_a)";

                MySqlCommand cmd = new MySqlCommand(query, c.GetConnection());

                cmd.Parameters.AddWithValue("@tipo", n.tipo);
                cmd.Parameters.AddWithValue("@rem", n.remitente);
                cmd.Parameters.AddWithValue("@rec", n.receptor);
                cmd.Parameters.AddWithValue("@desc", n.descripcion);
                cmd.Parameters.AddWithValue("@id_a", 1);

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

        public bool eliminar_notificacion(Notificacion n)
        {
            MySqlTransaction tran = null;
            bool res = true;
            string query = "delete from notificacion where idn = @id";

            try
            {
                c.OpenConnection();
                tran = c.GetConnection().BeginTransaction();
                using (MySqlCommand cmd = new MySqlCommand(query, c.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@id", n.id);
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

        public bool actualizar_notificacion(Notificacion n)
        {
            MySqlTransaction tran = null;
            bool res = true;
            string query = "update notificacion set tipo = @tipo, remitente = @rem, receptor = @rec, descripcion = @desc where idn = @id";

            try
            {

                c.OpenConnection();
                tran = c.GetConnection().BeginTransaction();
                using (MySqlCommand cmd = new MySqlCommand(query, c.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@tipo", n.tipo);
                    cmd.Parameters.AddWithValue("@rem", n.remitente);
                    cmd.Parameters.AddWithValue("@rec", n.receptor);
                    cmd.Parameters.AddWithValue("@desc", n.descripcion);
                    cmd.Parameters.AddWithValue("@id", n.id);

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
