using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Avenger : Personaje
    {
        private EEquipamiento equipamiento;
        /// <summary>
        /// Propiedad de solo lectura, devuelve string con el cnombre del Avenger y una frase.
        /// </summary>
        public override string Nombre
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine($"Mi nombre es {this.nombre} y si no puedo y si no puedo proteger la tierra, la vengaré");
                return sb.ToString();
            }
        }
        public Avenger(string nombre, List<EHabilidades> hab, EEquipamiento equipo) : base(nombre, hab)
        {
            this.equipamiento = equipo;
        }
        /// <summary>
        /// Sobreescribo el metodo para devolver nombre + info de la clase personaje + equipamiento del Personaje Avenger
        /// </summary>
        /// <returns>Devuelve un string con toda la data del Personaje Avenger</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.Nombre}");
            sb.Append(base.ToString());
            sb.AppendLine($"Equipamiento principal: {this.equipamiento}");
            

            return sb.ToString();
        }

    }
}
