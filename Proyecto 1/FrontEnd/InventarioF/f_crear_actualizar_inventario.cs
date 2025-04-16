using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using MaterialSkin.Controls;
using Proyecto_1.BackEnd;

namespace Proyecto_1.FrontEnd.Inventario
{
    public partial class f_crear_actualizar_inventario : MaterialForm
    {
        bool modo = false; // modo crear es false, modo actualizar es true.
        int llave = 0; // clave del inventario

        // Constructores para cargar el form, reutilizandolo de forma inteligente
        public f_crear_actualizar_inventario()
        {
            InitializeComponent();
        }
        public f_crear_actualizar_inventario(Inventarios i)
        {
            InitializeComponent();

            txb_inventario_nombre.Text = i.inventario_nombre.ToString();
            txb_inventario_descripcion.Text = i.inventario_descripcion.ToString();
            txb_inventario_serie.Text = i.inventario_serie.ToString();
            lbl_inventario_color.Text = i.inventario_color.ToString();
            dtp_inventario_fecha.Text = i.inventario_fecha.ToString();
            lbl_inventario_tipo.Text = i.inventario_tipo.ToString();
            txb_inventario_observaciones.Text = i.inventario_observaciones.ToString();
            txb_area_id.Text = i.area_id.ToString();
            modo = true;
            llave = i.inventario_id;
        }

        // Metodo para realizar las validaciones
        private string validar()
        {
            try
            {
                // Validar llenado de campos
                if (txb_inventario_nombre.Text.Length == 0) return "Debe llenar el campo 'Nombre'.";
                if (txb_inventario_descripcion.Text.Length == 0) return "Debe llenar el campo 'Descripcion'.";
                if (txb_inventario_serie.Text.Length == 0) return "Debe llenar el campo 'Serie'.";
                if (lbx_inventario_color.Text.Length == 0) return "Debe elegir un valor en el campo 'Color'.";
                if (lbx_inventario_tipo.Text.Length == 0) return "Debe elegir un valor en el campo 'Tipo de adquisicion'.";
                if (txb_inventario_observaciones.Text.Length == 0) return "Debe llenar el campo 'Observaciones'.";
                if (txb_area_id.Text.Length == 0) return "Debe llenar el campo 'Id del area'.";

                // Validaciones de formato
                if (!Regex.Match(txb_inventario_nombre.Text, @"^[a-zA-ZáéíóúÁÉÍÓÚñÑ\s]+$").Success) return "El nombre solo debe contener letras, espacios, tildes y ñ.";
                if (!Regex.Match(txb_inventario_descripcion.Text, @"^[0-9a-zA-ZáéíóúÁÉÍÓÚñÑ\s]+$").Success) return "La descripcion solo debe contener letras, números, espacios, tildes y ñ.";
                if (!Regex.Match(txb_inventario_serie.Text, @"^[0-9a-zA-]+$").Success) return "La serie solo puede contener numeros y letras.";
                if (!Regex.Match(txb_inventario_observaciones.Text, @"^[0-9a-zA-ZáéíóúÁÉÍÓÚñÑ\s]+$").Success) return "Las observaciones solo debe contener letras, números, espacios, tildes y ñ.";
                if (!Regex.Match(txb_area_id.Text, @"^[0-9]+$").Success) return "La serie solo puede contener numeros.";

                // Validar existencia de area
                Areas a = new Areas();
                if (!a.buscar_id(int.Parse(txb_area_id.Text.ToString()))) return "Ingrese un id existente.";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return "Válido";
        }

        private void f_crear_actualizar_inventario_Load(object sender, EventArgs e)
        {
            Inventarios i = new Inventarios();
        }

        private void txb_area_id_TextChanged(object sender, EventArgs e)
        {

        }

        // Se carga el form de inventario
        private void btn_regresar_Click(object sender, EventArgs e)
        {
            f_inventario f = new f_inventario();
            f.Show();
            this.Hide();
        }

        private void lbx_area_id_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_guardar_Click_1(object sender, EventArgs e)
        {
            // Se convierte la fecha para guardarla mas tarde
            string aux = dtp_inventario_fecha.Value.ToString();
            string fecha = aux.Substring(6, 4) + "-" + aux.Substring(3, 2) + "-" + aux.Substring(0, 2);

            // Se realiza la validacion
            string validacion = validar();

            if (validacion == "Válido")
            {
                Inventarios i = new Inventarios(llave, txb_inventario_nombre.Text, txb_inventario_descripcion.Text, txb_inventario_serie.Text, lbx_inventario_color.Text, fecha, lbx_inventario_tipo.Text, txb_inventario_observaciones.Text, int.Parse(txb_area_id.Text));

                if (!modo)
                {
                    // Intentamos realizar la insersion
                    if (i.insertar(i)) MessageBox.Show("Insersión Exitosa!");
                    else MessageBox.Show("Ha ocurrido un error. No se ha realizado la insersión.");
                }
                else
                {
                    // Intentamos realizar la actualización
                    if (i.actualizar(i)) MessageBox.Show("Actualización Exitosa!");
                    else MessageBox.Show("Ha ocurrido un error. No se ha realizado la actualización.");
                }

                // Volvemos a la pagina de inventario independientemente de si se hizo o no la insercion/actualizacion

                f_inventario fi = new f_inventario();
                fi.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(validacion);
                txb_inventario_nombre.Focus();
            }
        }

        // Eventos para que al dar click, se avance de forma mas comoda entre los componentes a llenar
        /////////////////////////////////////////////////////////////////////////////////////////////////
        private void txb_inventario_nombre_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txb_area_id.Focus();
            }
        }

        private void txb_area_id_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dtp_inventario_fecha.Focus();
            }
        }
        private void dtp_inventario_fecha_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txb_inventario_serie.Focus();
            }
        }

        private void txb_inventario_serie_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txb_inventario_descripcion.Focus();
            }
        }

        private void txb_inventario_descripcion_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txb_inventario_observaciones.Focus();
            }
        }

        private void txb_inventario_observaciones_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                lbx_inventario_tipo.Focus();
            }
        }

        private void lbx_inventario_tipo_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                lbx_inventario_color.Focus();
            }
        }

        private void lbx_inventario_color_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_guardar.Focus();
            }
        }
        /////////////////////////////////////////////////////////////////////////////////////////////////

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
