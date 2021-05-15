using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Enemigo : Personaje
    {
        private string objetivo;
        /// <summary>
        /// Propiedad de solo lectura, devuelve string con el cnombre del Personaje Enemigo y una frase.
        /// </summary>
        public override string Nombre
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine($"Soy {this.nombre} y los voy a hacer puré");
                return sb.ToString();
            }
        }
        public Enemigo(string nombre, List<EHabilidades> hab, string objetivo) : base(nombre, hab)
        {
            this.objetivo = objetivo;
        }
        /// <summary>
        /// Sobreescribo el metodo para devolver nombre + info de la clase personaje + objetivo del Personaje Enemigo
        /// </summary>
        /// <returns>Devuelve un string con toda la data del Personaje Enemigo</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.Nombre}");
            sb.Append(base.ToString());
            sb.AppendLine($"Objetivo: {this.objetivo}");
            

            return sb.ToString();
        }
    }
}
