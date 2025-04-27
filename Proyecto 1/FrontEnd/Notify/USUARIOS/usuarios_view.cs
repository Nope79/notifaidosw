using MaterialSkin.Controls;
using Not.Backend;
using Proyecto_1.BackEnd;
using Proyecto_1.FrontEnd.Notify.MainMenu;
using System;
using System.Numerics;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Proyecto_1.FrontEnd.Notify.USUARIOS
{
    public partial class usuarios_view : MaterialForm
    {
        Usuario u;
        bool modo = false;
        int llave = 0;

        public usuarios_view()
        {
            InitializeComponent();
        }

        public usuarios_view(Usuario u)
        {
            InitializeComponent();

            txb_nombre.Text = u.nombre;
            txb_usuario.Text = u.usuario;
            txb_pass.Text = u.password;
            txb_correo.Text = u.correo;
            modo = true;
            llave = u.id;
        }

        private void usuarios_view_Load(object sender, EventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Menu_Admin x = new Menu_Admin(2);
            this.Hide();
            x.Show();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            string val = validar();
            if (val == "Válido")
            {
                Usuario x = new Usuario(llave, txb_usuario.Text, txb_pass.Text, txb_nombre.Text, txb_correo.Text, 1);
                if (!modo)
                {
                    // Intentamos realizar la insersion
                    if (x.crear_usuario(x)) MessageBox.Show("Insersión Exitosa!");
                    else MessageBox.Show("Ha ocurrido un error. No se ha realizado la insersión.");
                }
                else
                {
                    // Intentamos realizar la actualización
                    if (x.actualizar_usuario(x)) MessageBox.Show("Actualización Exitosa!");
                    else MessageBox.Show("Ha ocurrido un error. No se ha realizado la actualización.");
                }

                // Volvemos a la pagina de areas
                Menu_Admin m = new Menu_Admin(2);
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
            if (txb_nombre.Text.Length == 0 && txb_usuario.Text.Length == 0 && txb_pass.Text.Length == 0 && txb_correo.Text.Length == 0) return "Debe llenar todos los campos.";
            if (txb_nombre.Text.Length == 0) return "Debe llenar el campo 'Nombre'";
            if (txb_usuario.Text.Length == 0) return "Debe llenar el campo 'Usuario'";
            if (txb_pass.Text.Length == 0) return "Debe llenar el campo 'Contraseña'";
            if (txb_correo.Text.Length == 0) return "Debe llenar el campo 'Correo'";

            // Validaciones de formato
            if (!Regex.Match(txb_nombre.Text, @"^[a-zA-ZáéíóúÁÉÍÓÚñÑ\s]+$").Success) return "El nombre solo debe contener letras, espacios, tildes y ñ.";
            if (!Regex.Match(txb_pass.Text, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$").Success) return "La contraseña debe tener al menos 8 caracteres, incluir mayúsculas, minúsculas, números y caracteres especiales.";
            if (!Regex.Match(txb_correo.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$").Success) return "El correo no tiene un formato válido.";
            
            return "Válido";
        }

        private void lbl_correo_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
