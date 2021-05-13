using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Personaje
    {
        private List<EHabilidades> listaHabilidades;
        protected string nombre;

        private string ListaHabilidades
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                foreach (EHabilidades h in this.listaHabilidades)
                {
                    sb.AppendLine(h.ToString());
                }
                return sb.ToString();
            }
        }
        public abstract string Nombre
        {
            get;
        }

        private Personaje()
        {
            this.listaHabilidades = new List<EHabilidades>();
        }
        public Personaje(string nombre, List<EHabilidades> habilidades) : this()
        {
            this.listaHabilidades = habilidades;
            this.nombre = nombre;
        }

        public static List<Personaje> operator +(List<Personaje> listaPersonajes, Personaje personaje)
        {
            if (!(listaPersonajes==personaje))
            {
                listaPersonajes.Add(personaje);
            }
            return listaPersonajes;
        }
        public static bool operator ==(List<Personaje> listaPersonajes, Personaje personaje)
        {
            bool result = false;
            foreach (Personaje p in listaPersonajes)
            {
                if ((p.nombre == personaje.nombre) && (p.GetType() == personaje.GetType()))
                {
                    result = true;
                }
            }
            return result;
        }
        public static bool operator !=(List<Personaje> listaPersonajes, Personaje personaje)
        {
            return !(listaPersonajes == personaje);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Habilidades:");
            sb.AppendLine(this.ListaHabilidades);

            return sb.ToString();
        }

    }

    public enum EHabilidades
    {
        Volar,
        SuperFuerza,
        Resistencia,
        Rayos,
        Energia,
        InteligenciaSuperior,
        Sigilo,
        Astucia
    }
    public enum EEquipamiento
    {
        Armadura,
        Escudo,
        Martillo,
        Arco,
        Transformacion,
        ArtesMarciales
    }
}

