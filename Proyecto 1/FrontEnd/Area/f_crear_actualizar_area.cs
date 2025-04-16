using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using MaterialSkin.Controls;
using Proyecto_1.BackEnd;

namespace Proyecto_1.FrontEnd.Area
{
    public partial class f_crear_actualizar_area : MaterialForm
    {
        bool modo = false; // modo crear es false, modo actualizar es true.
        int llave = 0; // clave del area

        // Distintos constructores dependiendo de la accion que se quiera realizar, crear o actualizar
        public f_crear_actualizar_area()
        {
            InitializeComponent();
        }

        public f_crear_actualizar_area(Areas a)
        {
            InitializeComponent();  
            txb_area_nombre.Text = a.area_nombre.ToString();
            txb_area_ubicacion.Text = a.area_ubicacion.ToString();
            modo = true;
            llave = a.area_id;
        }

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            // Volvemos a la pagina de areas
            f_area a = new f_area();
            a.Show();
            this.Hide();
        }

        private void f_crear_actualizar_area_Load(object sender, EventArgs e)
        {

        }

        // Metodo para validar los datos
        private string validar()
        {
            // Validaciones de llenado de datos
            if (txb_area_nombre.Text.Length == 0 && txb_area_ubicacion.Text.Length == 0) return "Debe llenar todos los campos.";
            if (txb_area_nombre.Text.Length == 0) return "Debe llenar el campo 'Nombre'.";
            if (txb_area_ubicacion.Text.Length == 0) return "Debe llenar el campo 'Ubicación'.";

            // Validaciones de formato
            if (!Regex.Match(txb_area_nombre.Text, @"^[a-zA-ZáéíóúÁÉÍÓÚñÑ\s]+$").Success) return "El nombre solo debe contener letras, espacios, tildes y ñ.";
            if (!Regex.Match(txb_area_ubicacion.Text, @"^[0-9a-zA-ZáéíóúÁÉÍÓÚñÑ\s]+$").Success) return "La ubicación solo debe contener letras, números, espacios, tildes y ñ.";

            return "Válido";
        }

        // Al presionar el boton guardar, dependiendo del modo (crear o actualizar), se crea o actualiza con los metodos del objeto
        private void btn_guardar_Click_1(object sender, EventArgs e)
        {
            string validacion = validar();

            if (validacion == "Válido")
            {
                Areas a = new Areas(llave, txb_area_nombre.Text, txb_area_ubicacion.Text);
                if (!modo)
                {
                    // Intentamos realizar la insersion
                    if (a.insertar(a)) MessageBox.Show("Insersión Exitosa!");
                    else MessageBox.Show("Ha ocurrido un error. No se ha realizado la insersión.");
                }
                else
                {
                    // Intentamos realizar la actualización
                    if (a.actualizar(a)) MessageBox.Show("Actualización Exitosa!");
                    else MessageBox.Show("Ha ocurrido un error. No se ha realizado la actualización.");
                }

                // Volvemos a la pagina de areas
                f_area f_Area = new f_area();
                f_Area.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(validacion);
                txb_area_nombre.Focus();
            }
        }

        // Eventos para que al dar enter, sea mas comodo realizar el llenado de datos
        ////////////////////////////////////////////////////////////////////////////////////
        private void txb_area_nombre_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txb_area_ubicacion.Focus();
            }
        }

        private void txb_area_ubicacion_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_guardar.Focus();
            }
        }

        private void txb_area_nombre_Click(object sender, EventArgs e)
        {

        }
        ////////////////////////////////////////////////////////////////////////////////////
    }
}
