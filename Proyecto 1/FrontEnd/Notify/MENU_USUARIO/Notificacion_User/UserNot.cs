using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using Not.Backend;
using Proyecto_1.BackEnd;

namespace Proyecto_1.FrontEnd.Notify.MENU_USUARIO.Notificacion_User
{
    public partial class UserNot : MaterialForm
    {
        Notificacion n = new Notificacion();
        Usuario u = new Usuario();
        int op = 1;
        public UserNot(Usuario u)
        {
            this.u = u;
            InitializeComponent();
            Text = "Notificaciones de " + u.usuario;
        }

        private void btn_notificacion_Click(object sender, EventArgs e)
        {
            op = 1;
            UserNot_Load(null, null);
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            MENU_USER m = new MENU_USER(new Usuario(1, "Juan"));
            m.Show();
            this.Hide();
        }

        private void UserNot_Load(object sender, EventArgs e)
        {
            try
            {
                if (op == 1)
                {
                    MessageBox.Show(u.usuario);
                    dgv_not_impor.DataSource = n.mostrar_not_usuario(u);
                    lbl_bienvenue.Text = "Aqui están tus notificaciones generales " + u.usuario;
                }
                else if (op == 2)
                {
                    lbl_bienvenue.Text = "Aqui están tus notificaciones visibles " + u.usuario;
                }
                else
                {
                    lbl_bienvenue.Text = "Aqui están tus notificaciones ocultas " + u.usuario;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se ha podido cargar la información en la tabla correctamente...");
            }
        }

        private void btn_activas_Click(object sender, EventArgs e)
        {
            op = 2;
            UserNot_Load(null, null);
        }

        private void btn_ocultas_Click(object sender, EventArgs e)
        {
            op = 3;
            UserNot_Load(null, null);
        }
    }
}
