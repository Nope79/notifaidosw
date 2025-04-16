using System;
using System.Windows.Forms;
using Proyecto_1.FrontEnd;
using Proyecto_1.FrontEnd.Area;
using Proyecto_1.FrontEnd.Inventario;
using Proyecto_1.FrontEnd.Notify;
using Proyecto_1.FrontEnd.Notify.MainMenu;

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
            Application.Run(new FrontEnd.Notify.MainMenu.Menu_Admin(1));
        }
    }
}
