using MaterialSkin;
using MaterialSkin.Controls;

namespace Proyecto_1
{
    internal class MaterialUI
    {
        public static void LoadMaterial(MaterialForm actualForm)
        {
            // crear material theme manager y añadir el form a gestionar
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;

            // configurar el esquema de colores
            materialSkinManager.ColorScheme = new ColorScheme(

                Primary.Purple400, Primary.Purple500,
                Primary.Purple500, Accent.Purple100,
                TextShade.BLACK
             );

            materialSkinManager.AddFormToManage(actualForm);
            //materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;

            
        }
    }
}
