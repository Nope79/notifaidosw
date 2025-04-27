﻿using MaterialSkin.Controls;
using Not.Backend;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_1.FrontEnd.Notify.MENU_USUARIO.Seccion_User;

namespace Proyecto_1.FrontEnd.Notify.MENU_USUARIO.Seccion_User
{
    public partial class SecNot : MaterialForm
    {
        Usuario u;
        public SecNot(Usuario u)
        {
            this.u = u;
            InitializeComponent();
            menu_lbl.Text = "Aquí están tus secciones " + u.usuario;
        }

        private void SecNot_Load(object sender, EventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            MENU_USER m = new MENU_USER(u);
            m.Show();
            this.Hide();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            seccion_mod sm = new seccion_mod(u, 1);
            sm.Show();
            this.Hide();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            seccion_mod sm = new seccion_mod(u, 2);
            sm.Show();
            this.Hide();
        }
    }
}
