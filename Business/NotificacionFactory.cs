using Entities;

namespace Business
{
    public class NotificacionFactory
    {
        public E_Notificacion Crear (string tipo, string destino, string mensaje)
        {
            E_Notificacion notificacion;

            if(tipo == "correo")
            {
                notificacion = new Correo();
            }
            else if(tipo == "sms")
            {
                notificacion= new SMS();
            }
            else if(tipo == "whatsapp")
            {
                notificacion = new Whatsapp();
            }
            else
            {
                throw new ArgumentException("Ese canal es inexistente");
            }
            notificacion.Destino = destino;
            notificacion.Mensaje = mensaje;
            return notificacion;
        }
    }
}
