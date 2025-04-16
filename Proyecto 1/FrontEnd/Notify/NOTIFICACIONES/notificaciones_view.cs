using MaterialSkin.Controls;
using Mysqlx.Cursor;
using Not.Backend;
using Org.BouncyCastle.Asn1.X500;
using Org.BouncyCastle.Crypto;
using Proyecto_1.BackEnd;
using Proyecto_1.FrontEnd.Area;
using Proyecto_1.FrontEnd.Notify.MainMenu;
using System;
using System.Numerics;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Proyecto_1.FrontEnd.Notify.NOTIFICACIONES
{
    public partial class notificaciones_view : MaterialForm
    {
        Notificacion n;
        bool modo = false;
        int llave = 0;

        public notificaciones_view()
        {
            InitializeComponent();
        }

        public notificaciones_view(Notificacion n)
        {
            InitializeComponent();
            txb_rem.Text = n.remitente;
            txb_rec.Text = n.receptor;
            txb_desc.Text = n.descripcion;
            txb_pri.Text = n.tipo;
            modo = true;
            llave = n.id;
        }

        private void notificaciones_view_Load(object sender, EventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Menu_Admin x = new Menu_Admin(1);
            this.Hide();
            x.Show();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            string val = validar();
            if (val == "Válido")
            {
                Notificacion x = new Notificacion(llave, txb_rem.Text, txb_rec.Text, txb_desc.Text, txb_pri.Text);

                if (!modo)
                {
                    // Intentamos realizar la insersion
                    if (x.crear_notificacion(x)) MessageBox.Show("Insersión Exitosa!");
                    else MessageBox.Show("Ha ocurrido un error. No se ha realizado la insersión.");
                }
                else
                {
                    // Intentamos realizar la actualización
                    if (x.actualizar_notificacion(x)) MessageBox.Show("Actualización Exitosa!");
                    else MessageBox.Show("Ha ocurrido un error. No se ha realizado la actualización.");
                }

                // Volvemos a la pagina de areas
                Menu_Admin m = new Menu_Admin(1);
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

            if (txb_rem.Text.Length == 0 && txb_rec.Text.Length == 0 && txb_desc.Text.Length == 0 && txb_pri.Text.Length == 0) return "Debe llenar todos los campos.";
            if (txb_rem.Text.Length == 0) return "Debe llenar el campo 'Remitente'.";
            if (txb_rec.Text.Length == 0) return "Debe llenar el campo 'Destinatario'.";
            if (txb_desc.Text.Length == 0) return "Debe llenar el campo 'Mensaje'.";
            if (txb_pri.Text.Length == 0) return "Debe llenar el campo 'Prioridad'.";

            return "Válido";
        }
    }
}
