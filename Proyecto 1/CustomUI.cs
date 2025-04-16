using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C
{
    public static class CustomUI
    {
        public static void LoadDefaultStyle(Form actualForm)
        {

            Color primary = System.Drawing.Color.Beige;
            Color secondary = System.Drawing.Color.MediumPurple;

            actualForm.BackColor = secondary;
            foreach (Control control in actualForm.Controls)
            {
                if (control is Button)
                {
                    ((Button)control).BackColor = primary;
                    ((Button)control).ForeColor = secondary;
                    ((Button)control).FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                }
                else if (control is CheckBox)
                {

                }
                else if (control is RadioButton)
                {

                }
                else if (control is TextBox)
                {
                    ((TextBox)control).BackColor = primary;
                    ((TextBox)control).BorderStyle = System.Windows.Forms.BorderStyle.None;
                    ((TextBox)control).Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                    ((TextBox)control).ForeColor = secondary;
                }
                else if (control is Label)
                {
                    ((Label)control).FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    ((Label)control).ForeColor = primary;
                }
                // Agrega más tipos de controles si es necesario
            }
        }
    }
}