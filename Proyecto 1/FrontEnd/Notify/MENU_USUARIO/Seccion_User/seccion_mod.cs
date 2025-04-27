using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_1.BackEnd;
using Not.Backend;

namespace Proyecto_1.FrontEnd.Notify.MENU_USUARIO.Seccion_User
{
    public partial class seccion_mod : MaterialForm
    {
        Usuario u;
        int modo;
        public seccion_mod(Usuario u, int modo)
        {
            InitializeComponent();
            this.modo = modo;
            this.u = u;
        }

        private void seccion_mod_Load(object sender, EventArgs e)
        {
            MENU_USER mn = new MENU_USER(u);
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            SecNot sn = new SecNot(u);
            sn.Show();
            this.Hide();
        }
    }
}
