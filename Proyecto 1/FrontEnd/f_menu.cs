using MaterialSkin.Controls;
using Proyecto_1.FrontEnd;
using Proyecto_1.FrontEnd.Area;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Proyecto_1
{
    public partial class f_menu : MaterialForm
    {
        public f_menu()
        {
            InitializeComponent();
        }
        private void Menu_Load(object sender, EventArgs e)
        {

        }

        // Se cambia el label de la presentacion al ser clickeado, con los valores guardados en un arreglo usando random y el modulo, se centra
        private void lbl_presentacion_Click_1(object sender, EventArgs e)
        {
            var rand = new Random();
            string[] valores = { "¡Bienvenido al Sistema!", "¡Este es el Menú Principal!", "¡Bienvenido :D!!!", "¡Hola y Bienvenido!" };
            lbl_presentacion.Text = valores[rand.Next() % 4];

            int xPos = (panel1.Size.Width - panel1.Location.X) / 2;

            lbl_presentacion.Location = new Point(xPos, lbl_presentacion.Location.Y);
        }

        // Pasar al frame del inventario
        private void btn_inventario_Click_1(object sender, EventArgs e)
        {
            f_inventario i = new f_inventario();
            i.Show();
            this.Hide();
        }

        // Pasar al frame del area
        private void btn_area_Click_1(object sender, EventArgs e)
        {
            f_area a = new f_area();
            a.Show();
            this.Hide();
        }
    }
}
