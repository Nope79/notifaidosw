using System;
using System.Windows.Forms;
using Not.Backend;
using Proyecto_1.FrontEnd;
using Proyecto_1.FrontEnd.Notify;
using Proyecto_1.FrontEnd.Notify.MainMenu;
using Proyecto_1.FrontEnd.Notify.MENU_USUARIO;

namespace Proyecto_1
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MENU_USER(new Usuario(1, "Juan"))); 
        }
    }
}
