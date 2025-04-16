using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;

namespace Proyecto_1.BackEnd
{
    public class Inventarios
    {
        // atributos de la tabla inventario en la base de datos
        public int inventario_id;
        public string inventario_nombre;
        public string inventario_descripcion;
        public string inventario_serie;
        public string inventario_color;
        public string inventario_fecha;
        public string inventario_tipo;
        public string inventario_observaciones;
        public int area_id;
        Conexion c;

        // Multiples constructores para facilitar el manejor de objetos y la creacion de frames
        public Inventarios()
        {
            c = new Conexion();
        }

        public Inventarios(int inventario_id)
        {
            this.inventario_id = inventario_id;
            c = new Conexion();
        }

        public Inventarios(string inventario_nombre, string inventario_descripcion, string inventario_serie, string inventario_color, string inventario_fecha, string inventario_tipo, string inventario_observaciones, int area_id)
        {
            this.inventario_nombre = inventario_nombre;
            this.inventario_descripcion = inventario_descripcion;
            this.inventario_serie = inventario_serie;
            this.inventario_color = inventario_color;
            this.inventario_fecha = inventario_fecha;
            this.inventario_tipo = inventario_tipo;
            this.inventario_observaciones = inventario_observaciones;
            this.area_id = area_id;
            c = new Conexion();
        }

        public Inventarios(int inventario_id, string inventario_nombre, string inventario_descripcion, string inventario_serie, string inventario_color, string inventario_fecha, string inventario_tipo, string inventario_observaciones, int area_id)
        {
            this.inventario_id = inventario_id;
            this.inventario_nombre = inventario_nombre;
            this.inventario_descripcion = inventario_descripcion;
            this.inventario_serie = inventario_serie;
            this.inventario_color = inventario_color;
            this.inventario_fecha = inventario_fecha;
            this.inventario_tipo = inventario_tipo;
            this.inventario_observaciones = inventario_observaciones;
            this.area_id = area_id;
            c = new Conexion();
        }

        // Metodos de seleccionar, añadir, eliminar y actualizar, todo usando transacciones
        public DataTable seleccionar()
        {
            DataTable dataTable = new DataTable();

            try
            {
                c.OpenConnection();

                string query = "SELECT inventario_id, inventario_nombre_corto, inventario_descripcion, inventario_serie, inventario_color, inventario_fecha_adquisicion, inventario_tipo_adquisicion, inventario_observaciones, area_id FROM inventario";
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

        public bool insertar(Inventarios i)
        {
            MySqlTransaction tran = null;
            try
            {
                c.OpenConnection();
                tran = c.GetConnection().BeginTransaction();
                MySqlConnection connection = c.GetConnection();
                string query = "insert into inventario(inventario_nombre_corto, inventario_descripcion, inventario_serie, inventario_color, inventario_fecha_adquisicion, inventario_tipo_adquisicion, inventario_observaciones, area_id) values (@nombre, @descripcion, @serie, @color, @fecha, @tipo, @observaciones, @area_id)";

                MySqlCommand cmd = new MySqlCommand(query, c.GetConnection());
                
                cmd.Parameters.AddWithValue("@nombre", i.inventario_nombre);
                cmd.Parameters.AddWithValue("@descripcion", i.inventario_descripcion);
                cmd.Parameters.AddWithValue("@serie", i.inventario_serie);
                cmd.Parameters.AddWithValue("@color", i.inventario_color);
                cmd.Parameters.AddWithValue("@fecha", i.inventario_fecha);
                cmd.Parameters.AddWithValue("@tipo", i.inventario_tipo);
                cmd.Parameters.AddWithValue("@observaciones", i.inventario_observaciones);
                cmd.Parameters.AddWithValue("@area_id", i.area_id);

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

        public bool eliminar(Inventarios i)
        {
            MySqlTransaction tran = null;
            bool res = true;
            string query = "delete from inventario where inventario_id = @id";

            try
            {
                c.OpenConnection();
                tran = c.GetConnection().BeginTransaction();
                using (MySqlCommand cmd = new MySqlCommand(query, c.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@id", i.inventario_id);
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

        public bool actualizar(Inventarios i)
        {
            MySqlTransaction tran = null;
            bool res = true;
            string query = "update inventario set inventario_nombre_corto = @nombre, inventario_descripcion = @descripcion, inventario_serie = @serie, inventario_color = @color, inventario_fecha_adquisicion = @fecha, inventario_tipo_adquisicion = @tipo, inventario_observaciones = @observaciones, area_id = @area_id where inventario_id = @id";

            try
            {
                c.OpenConnection();
                tran = c.GetConnection().BeginTransaction();
                using (MySqlCommand cmd = new MySqlCommand(query, c.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@id", i.inventario_id);
                    cmd.Parameters.AddWithValue("@nombre", i.inventario_nombre);
                    cmd.Parameters.AddWithValue("@descripcion", i.inventario_descripcion);
                    cmd.Parameters.AddWithValue("@serie", i.inventario_serie);
                    cmd.Parameters.AddWithValue("@color", i.inventario_color);
                    cmd.Parameters.AddWithValue("@fecha", i.inventario_fecha);
                    cmd.Parameters.AddWithValue("@tipo", i.inventario_tipo);
                    cmd.Parameters.AddWithValue("@observaciones", i.inventario_observaciones);
                    cmd.Parameters.AddWithValue("@area_id", i.area_id);

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
