namespace Entities
{
    public class E_Notificacion
    {
        public string Destino { get; set; }

        public string Mensaje { get; set; }

        public virtual void ValidarDatos()
        {
            throw new ArgumentException("Canal Desconocido");
        }
    }

    public class Correo : E_Notificacion
    {
        public override void ValidarDatos()
        {
            if (!Destino.Contains("@") || !Destino.Contains("."))
            {
                throw new ArgumentException("El destino es invalido");
            }
        }
    }
    public class SMS : E_Notificacion
    {
        public override void ValidarDatos()
        {
            if (Destino.Count() != 10)
            {
                throw new ArgumentException("El numero ingresado es invalido");
            }
            if(Mensaje.Count() > 160)
            {
                throw new ArgumentException("El mensaje no puede ser mayor a 160 caracteres");
            }
        }
    }
    public class Whatsapp : E_Notificacion
    {
        public override void ValidarDatos()
        {
            if (Destino.Count() != 10)
            {
                throw new ArgumentException("El numero ingresado es invalido");
            }
            if (Mensaje.Count() > 1000)
            {
                throw new ArgumentException("El mensaje no puede ser mayor a 160 caracteres");
            }
        }
    }
}
