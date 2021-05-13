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

        public static Personaje Personaje
        {
            set
            {
                Marvel.listaPersonajes = Marvel.listaPersonajes + (Personaje)value;
            }
        }

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
