using Entities;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Business
{
    public class B_Notificacion
    {
        private readonly NotificacionFactory factory;

        public B_Notificacion(NotificacionFactory factor)
        {
            factory = factor;
        }

        public E_Notificacion Procesar (string tipo, string destino, string mensaje)
        {
            ValidarDatos(destino, mensaje);
            return factory.Crear(tipo, destino, mensaje);
        }

        public void ValidarDatos(string destino, string mensaje)
        {
            if(string.IsNullOrWhiteSpace(destino))
            {
                throw new ArgumentException("El destino no puede estar vacio")
            }
            if (string.IsNullOrWhiteSpace(mensaje))
            {
                throw new ArgumentException("El mensaje no puede estar vacio");
            }
        }
    }
}
