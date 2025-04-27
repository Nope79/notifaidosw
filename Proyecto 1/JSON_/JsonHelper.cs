using Newtonsoft.Json;
using System.IO;
using System.Collections.Generic;
using System.Xml;
using System.ComponentModel;

public class JsonHelper
{
    public static List<NotificacionJson> CargarNotificacionesJson(string archivoJson)
    {
        List<NotificacionJson> notificaciones = new List<NotificacionJson>();

        if (File.Exists(archivoJson))
        {
            string json = File.ReadAllText(archivoJson);
            notificaciones = JsonConvert.DeserializeObject<List<NotificacionJson>>(json);
        }
        else
        {
            File.WriteAllText(archivoJson, "[]");
        }

        return notificaciones;
    }

    public static void GuardarNotificacionesJson(List<NotificacionJson> notificaciones, string archivoJson)
    {
        string nuevoJson = Newtonsoft.Json.JsonConvert.SerializeObject(notificaciones, Newtonsoft.Json.Formatting.Indented);
        File.WriteAllText(archivoJson, nuevoJson);
    }

    public static BindingList<NotificacionJson> ConvertirAListaDeBindingList(List<NotificacionJson> listaNotificaciones)
    {
        return new BindingList<NotificacionJson>(listaNotificaciones);
    }
}
