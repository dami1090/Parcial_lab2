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

        #region Propiedades
        /// <summary>
        /// Esta propiedad , de solo lectura, devuelve mediante string todas las habilidades del personaje
        /// </summary>
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
        #endregion
        #region Constructores
        private Personaje()
        {
            this.listaHabilidades = new List<EHabilidades>();
        }
        public Personaje(string nombre, List<EHabilidades> habilidades) : this()
        {
            this.listaHabilidades = habilidades;
            this.nombre = nombre;
        }
        #endregion
        #region Operators
        /// <summary>
        /// sobreescribo el operador + para poder agregar personajes a las listas de personajes.
        /// </summary>
        /// <param name="listaPersonajes">Lista donde deseeo agregar un personaje que no este</param>
        /// <param name="personaje">Personaje a agregar a la lista</param>
        /// <returns>Devuelve la misma lista con la adicion, si el personaje ya no se encontraba dentro de la lista</returns>
        public static List<Personaje> operator +(List<Personaje> listaPersonajes, Personaje personaje)
        {
            if (!(listaPersonajes == personaje))
            {
                listaPersonajes.Add(personaje);
            }
            return listaPersonajes;
        }
        /// <summary>
        /// Deseo saber si un personaje se encuentra en la lista
        /// </summary>
        /// <param name="listaPersonajes">Lista la cual quiero comparar</param>
        /// <param name="personaje">Personaje que quiero encontrar en la lista</param>
        /// <returns>Devuelve true si dentro de la lista hay otro objeto con el mismo nombre y del mismo tipo</returns>
        public static bool operator ==(List<Personaje> listaPersonajes, Personaje personaje)
        {
            bool result = false;
            foreach (Personaje p in listaPersonajes)
            {
                if ((p.nombre == personaje.nombre) && (p.GetType() == personaje.GetType()))
                {
                    result = true;
                    break;
                }
            }
            return result;
        }
        /// <summary>
        /// Deseo saber si un personaje se encuentra en la lista
        /// </summary>
        /// <param name="listaPersonajes">Lista la cual quiero comparar</param>
        /// <param name="personaje">Personaje que quiero encontrar en la lista</param>
        /// <returns>Devuelve false si dentro de la lista no hay otro objeto con el mismo nombre y del mismo tipo</returns>
        public static bool operator !=(List<Personaje> listaPersonajes, Personaje personaje)
        {
            return !(listaPersonajes == personaje);
        }
        #endregion
        /// <summary>
        /// Sobreescribo el metodo para que devuelva la informacion al alcance la clase personaje
        /// </summary>
        /// <returns>String con todas las habilidades de ese personaje</returns>
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

