using Google.Protobuf.WellKnownTypes;
using Not.Backend;
using Org.BouncyCastle.Asn1.X509;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_1.FrontEnd.Notify.MENU_USUARIO.Notificacion_User;
using MaterialSkin.Controls;
using Proyecto_1.BackEnd;

namespace Proyecto_1.FrontEnd.Notify.MENU_USUARIO
{
    public partial class MENU_USER : MaterialForm
    {
        Notificacion n = new Notificacion();
        Usuario u = new Usuario();
        public MENU_USER()
        {
            InitializeComponent();
            lbl_bienvenue.Text = "Bienvenido ";
        }

        public MENU_USER(Not.Backend.Usuario u)
        {
            InitializeComponent();
            this.u = u;
            lbl_bienvenue.Text = "Bienvenido " + u.usuario;
        }

        private void MENU_USER_Load(object sender, EventArgs e)
        {
            try
            {
                dgv_not_impor.DataSource = n.mostrar_not_importantes();
            }
            catch
            {
                MessageBox.Show("No se pudo cargar la tabla...");
            }

        }

        private void btn_notificacion_Click(object sender, EventArgs e)
        {
            UserNot un = new UserNot(u);
            un.Show();
            this.Hide();
        }

        private void btn_secciones_Click(object sender, EventArgs e)
        {

        }
    }
}
