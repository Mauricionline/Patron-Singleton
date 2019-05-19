using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_Singleton
{
    public class Singleton
    {
        /// <summary>
        /// Creo la instancia de la clase Singleton 
        /// </summary>
        private static Singleton instance = null;

        private string mensaje;

        /// <summary>
        /// genero el constructor en privado para que no se la pueda instaciar
        /// en otro lugar que no sea la misma clase
        /// </summary>
        private Singleton()
        {

        }

        /// <summary>
        /// Propiedad que me permitira generar la instancia de la clase
        /// -si no existe una instacia de la clase la creara
        /// -si ya existe una instacia de la clase devolvera la misma instancia
        /// </summary>
        public static Singleton Intance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Singleton();
                }
                    return instance;                
            }
        }

        public string Mensaje { get => this.mensaje; set => this.mensaje = value; }


        /// <summary>
        /// Este metodo solo lo cree para demostrar que la clase se intancio
        /// </summary>
        /// <returns></returns>

    }
}
