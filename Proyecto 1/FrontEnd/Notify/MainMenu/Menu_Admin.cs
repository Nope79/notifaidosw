using MaterialSkin.Controls;
using System;
using Not.Backend;
using System.Windows.Forms;
using Proyecto_1.FrontEnd.Notify.NOTIFICACIONES;
using Proyecto_1.FrontEnd.Notify.USUARIOS;
using Proyecto_1.FrontEnd.Notify.GRUPOS;

namespace Proyecto_1.FrontEnd.Notify.MainMenu
{
    public partial class Menu_Admin : MaterialForm
    {
        Notificacion n = new Notificacion();
        Usuario u = new Usuario();
        Grupo g = new Grupo();
        int opcion;
        public Menu_Admin(int opcion)
        {
            this.opcion = opcion;
            InitializeComponent();

            // not, usuario, grupo
            if (opcion == 1)
            {
                menu_lbl.Text = "NOTIFICACIONES";
            }
            else if (opcion == 2)
            {
                menu_lbl.Text = "USUARIOS";
            }
            else
            {
                menu_lbl.Text = "GRUPOS";
            }
        }

        // Select
        private void menu_Load(object sender, EventArgs e)
        {
            try
            {
                if (opcion == 1) dgv_main.DataSource = n.mostrar_not();
                else if (opcion == 2) dgv_main.DataSource = u.mostrar_usuarios();
                else dgv_main.DataSource = g.mostrar_grupos();
            }
            catch
            {
                MessageBox.Show("No se pudo cargar pleb");
            }
            
        }

        private void dgv_main_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // noti
            if (opcion == 1)
            {
                try
                {
                    if (e.RowIndex >= 0 && e.RowIndex < dgv_main.Rows.Count)
                    {
                        DataGridViewRow selectedRow = dgv_main.Rows[e.RowIndex];

                        this.n.id = Convert.ToInt32(selectedRow.Cells[0].Value);
                        this.n.tipo = selectedRow.Cells[1].Value.ToString();
                        this.n.remitente = selectedRow.Cells[2].Value.ToString();
                        this.n.receptor = selectedRow.Cells[3].Value.ToString();
                        this.n.descripcion = selectedRow.Cells[4].Value.ToString();

                        btn_delete.Enabled = true;
                        btn_update.Enabled = true;
                    }
                    else
                    {
                        btn_delete.Enabled = false;
                        btn_update.Enabled = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            // usuarios
            else if (opcion == 2)
            {
                try
                {
                    if (e.RowIndex >= 0 && e.RowIndex < dgv_main.Rows.Count)
                    {
                        DataGridViewRow selectedRow = dgv_main.Rows[e.RowIndex];

                        this.u.id = Convert.ToInt32(selectedRow.Cells[0].Value);
                        this.u.usuario = selectedRow.Cells[1].Value.ToString();
                        this.u.password = selectedRow.Cells[2].Value.ToString();
                        this.u.nombre = selectedRow.Cells[3].Value.ToString();
                        this.u.correo = selectedRow.Cells[4].Value.ToString();
                        
                        btn_delete.Enabled = true;
                        btn_update.Enabled = true;
                    }
                    else
                    {
                        btn_delete.Enabled = false;
                        btn_update.Enabled = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            // grupos
            else
            {
                try
                {
                    if (e.RowIndex >= 0 && e.RowIndex < dgv_main.Rows.Count)
                    {
                        DataGridViewRow selectedRow = dgv_main.Rows[e.RowIndex];

                        this.g.id = Convert.ToInt32(selectedRow.Cells[0].Value);
                        this.g.numero_usuarios = Convert.ToInt32(selectedRow.Cells[1].Value);
                        this.g.nombre = selectedRow.Cells[2].Value.ToString();
                        this.g.descripcion = selectedRow.Cells[3].Value.ToString();

                        btn_delete.Enabled = true;
                        btn_update.Enabled = true;
                    }
                    else
                    {
                        btn_delete.Enabled = false;
                        btn_update.Enabled = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            // not, usuario, grupo
            if (opcion == 1)
            {
                notificaciones_view x = new notificaciones_view();
                x.Show();
                this.Hide();
            }
            else if (opcion == 2)
            {
                usuarios_view x = new usuarios_view();
                x.Show();
                this.Hide();
            }
            else
            {
                grupos_view x = new grupos_view();
                x.Show();
                this.Hide();
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            // not, usuario, grupo
            if (opcion == 1)
            {
                notificaciones_view x = new notificaciones_view(n);
                x.Show();
                this.Hide();
            }
            else if (opcion == 2)
            {
                usuarios_view x = new usuarios_view(u);
                x.Show();
                this.Hide();
            }
            else
            {
                grupos_view x = new grupos_view(g);
                x.Show();
                this.Hide();
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            // not, usuario, grupo
            if (opcion == 1)
            {
                if (n.eliminar_notificacion(n)) MessageBox.Show("Elemento borrado exitosamente.");
                else MessageBox.Show("No se ha podido eliminar el elemento.");
                menu_Load(null, null);
            }
            else if (opcion == 2)
            {
                if (u.eliminar_usuario(u)) MessageBox.Show("Elemento borrado exitosamente.");
                else MessageBox.Show("No se ha podido eliminar el elemento.");
                menu_Load(null, null);

            }
            else
            {
                if (g.eliminar_grupo(g)) MessageBox.Show("Elemento borrado exitosamente.");
                else MessageBox.Show("No se ha podido eliminar el elemento.");
                menu_Load(null, null);
            }
        }

        private void btn_notificacion_Click(object sender, EventArgs e)
        {
            Menu_Admin m = new Menu_Admin(1);
            m.Show();
            this.Hide();
        }

        private void btn_usuarios_Click(object sender, EventArgs e)
        {
            Menu_Admin m = new Menu_Admin(2);
            m.Show();
            this.Hide();
        }

        private void btn_grupos_Click(object sender, EventArgs e)
        {
            Menu_Admin m = new Menu_Admin(3);
            m.Show();
            this.Hide();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            // aqui se regresaría al login xd
        }

        private void dgv_main_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
