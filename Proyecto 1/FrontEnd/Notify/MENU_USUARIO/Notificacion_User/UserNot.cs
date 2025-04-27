using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using Not.Backend;
using Proyecto_1.BackEnd;

namespace Proyecto_1.FrontEnd.Notify.MENU_USUARIO.Notificacion_User
{
    public partial class UserNot : MaterialForm
    {
        Notificacion n = new Notificacion();
        Usuario u = new Usuario();
        int op = 1;
        string rutaArchivoJson;
        public UserNot(Usuario u)
        {
            this.u = u;
            InitializeComponent();
            rutaArchivoJson = @"C:\Users\nopes\Downloads\Notify\main\Proyecto 1\JSON_\NotificacionesUsuario\" + u.usuario + ".json";
        }

        private void btn_notificacion_Click(object sender, EventArgs e)
        {
            op = 1;
            UserNot_Load(null, null);
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            MENU_USER m = new MENU_USER(u);
            m.Show();
            this.Hide();
        }

        private void UserNot_Load(object sender, EventArgs e)
        {
            try
            {
                if (op == 1)
                {
                    lbl_bienvenue.Text = "Aquí están tus notificaciones generales " + u.usuario;

                    List<NotificacionJson> notificacionesJsonExistentes = JsonHelper.CargarNotificacionesJson(rutaArchivoJson);

                    DataTable notificacionesDesdeBD = n.mostrar_not_usuario(u);
                    List<NotificacionJson> notificacionesDesdeBDConvertidas = n.ConvertirDataTableALista(notificacionesDesdeBD, u);

                    foreach (var notiNueva in notificacionesDesdeBDConvertidas)
                    {
                        if (!notificacionesJsonExistentes.Any(n => n.DESCRIPCIÓN == notiNueva.DESCRIPCIÓN && n.FECHA == notiNueva.FECHA))
                        {
                            notificacionesJsonExistentes.Add(notiNueva);
                        }
                    }

                    notificacionesJsonExistentes.OrderByDescending(n => n.FECHA);
                    JsonHelper.GuardarNotificacionesJson(notificacionesJsonExistentes, rutaArchivoJson);

                    BindingList<NotificacionJson> bindingList = new BindingList<NotificacionJson>(notificacionesJsonExistentes);
                    dgv_not_impor.DataSource = bindingList;

                }
                else
                {
                    List<NotificacionJson> listaNotificaciones = JsonHelper.CargarNotificacionesJson(rutaArchivoJson);
                    BindingList<NotificacionJson> bindingList;

                    if (op == 2)
                    {
                        lbl_bienvenue.Text = "Aquí están tus notificaciones visibles " + u.usuario;
                        var notificacionesFiltradas = listaNotificaciones.Where(n => n.ESTADO == true).OrderByDescending(n => n.FECHA).ToList();
                        bindingList = new BindingList<NotificacionJson>(notificacionesFiltradas);
                    }
                    else
                    {
                        lbl_bienvenue.Text = "Aquí están tus notificaciones ocultas " + u.usuario;
                        var notificacionesFiltradas = listaNotificaciones.Where(n => n.ESTADO == false).OrderByDescending(n => n.FECHA).ToList();
                        bindingList = new BindingList<NotificacionJson>(notificacionesFiltradas);
                    }

                    dgv_not_impor.DataSource = bindingList;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se ha podido cargar la información correctamente...");
            }
        }

        private void dgv_not_impor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgv_not_impor.Columns["Estado"].Index && e.RowIndex >= 0)
            {
                var notificacionSeleccionada = dgv_not_impor.Rows[e.RowIndex].DataBoundItem as NotificacionJson;

                if (notificacionSeleccionada != null)
                {
                    notificacionSeleccionada.ESTADO = !notificacionSeleccionada.ESTADO;

                    List<NotificacionJson> listaNotificaciones = JsonHelper.CargarNotificacionesJson(rutaArchivoJson);

                    var notificacionExistente = listaNotificaciones.FirstOrDefault(n => n.ID == notificacionSeleccionada.ID);
                    if (notificacionExistente != null)
                    {
                        notificacionExistente.ESTADO = notificacionSeleccionada.ESTADO;
                    }

                    JsonHelper.GuardarNotificacionesJson(listaNotificaciones, rutaArchivoJson);

                    UserNot_Load(null, null);
                }
            }
        }

        private void btn_activas_Click(object sender, EventArgs e)
        {
            op = 2;
            UserNot_Load(null, null);
        }

        private void btn_ocultas_Click(object sender, EventArgs e)
        {
            op = 3;
            UserNot_Load(null, null);
        }
    }
}
