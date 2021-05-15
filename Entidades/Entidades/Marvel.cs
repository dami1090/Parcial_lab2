using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Marvel
    {
        private static List<Personaje> listaPersonajes;
        static Marvel()
        {
            Marvel.listaPersonajes = new List<Personaje>();
        }
        /// <summary>
        /// Propiedad de solo escritura, para poder agregar personajes a mi lista de personajes.
        /// </summary>
        public static Personaje Personaje
        {
            set
            {
                Marvel.listaPersonajes = Marvel.listaPersonajes + (Personaje)value;
            }
        }
        /// <summary>
        /// Este metodo recorre toda la lista de pesonajes, y dependiendo el tipo de este mismo, le agrega el separador correspondiente.
        /// </summary>
        /// <returns>Un string de todos los personajes en la lista,con toda su info y con su separador</returns>
        public static string MostrarInformacion()
        {
            StringBuilder sb = new StringBuilder();

            foreach(Personaje p in Marvel.listaPersonajes)
            {
                if(p is Avenger)
                {
                    sb.AppendLine("****** AVENGER ******");
                }
                if (p is Enemigo)
                {
                    sb.AppendLine("****** ENEMIGO ******");
                }

                sb.AppendLine(p.ToString());
            }
            return sb.ToString();
        }
    }
}
