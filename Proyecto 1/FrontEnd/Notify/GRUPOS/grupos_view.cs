using MaterialSkin.Controls;
using Not.Backend;
using Proyecto_1.BackEnd;
using Proyecto_1.FrontEnd.Area;
using Proyecto_1.FrontEnd.Notify.MainMenu;
using System;
using System.Numerics;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Proyecto_1.FrontEnd.Notify.GRUPOS
{
    public partial class grupos_view : MaterialForm
    {
        Grupo g;
        bool modo = false;
        int llave = 0;
        public grupos_view()
        {
            InitializeComponent();
        }

        public grupos_view(Grupo g)
        {
            InitializeComponent();
            txb_nombre.Text = g.nombre;
            txb_desc.Text = g.descripcion;
            modo = true;
            llave = g.id;
        }

        private void grupos_view_Load(object sender, EventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Menu_Admin x = new Menu_Admin(3);
            this.Hide();
            x.Show();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            string val = validar();

            if(val == "Válido")
            {
                Grupo x = new Grupo(llave, txb_nombre.Text, txb_desc.Text);
                if (!modo)
                {
                    // Intentamos realizar la insersion
                    if (x.crear_grupo(x)) MessageBox.Show("Insersión Exitosa!");
                    else MessageBox.Show("Ha ocurrido un error. No se ha realizado la insersión.");
                }
                else
                {
                    // Intentamos realizar la actualización
                    if (x.actualizar_grupo(x)) MessageBox.Show("Actualización Exitosa!");
                    else MessageBox.Show("Ha ocurrido un error. No se ha realizado la actualización.");
                }

                // Volvemos a la pagina de areas
                Menu_Admin m = new Menu_Admin(3);
                m.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(val);
            }
        }

        private string validar()
        {
            // Validaciones de llenado de datos
            if (txb_nombre.Text.Length == 0 && txb_desc.Text.Length == 0) return "Debe llenar todos los campos.";
            if (txb_nombre.Text.Length == 0) return "Debe llenar el campo 'Nombre'.";
            if (txb_desc.Text.Length == 0) return "Debe llenar el campo 'Descripción'.";

            // Validaciones de formato
            if (!Regex.Match(txb_nombre.Text, @"^[a-zA-ZáéíóúÁÉÍÓÚñÑ\s]+$").Success) return "El nombre solo debe contener letras, espacios, tildes y ñ.";

            return "Válido";
        }
    }
}
