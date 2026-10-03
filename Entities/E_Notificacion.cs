namespace Entities
{
    public class E_Notificacion
    {
        public string Destino { get; set; }

        public string Mensaje { get; set; }
    }

    public class Correo : E_Notificacion { }
    public class SMS : E_Notificacion { }
    public class Whatsapp : E_Notificacion { }

}
