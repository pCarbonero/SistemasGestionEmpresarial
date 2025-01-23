using Entidades;
using System.Collections.Generic;

namespace DAL
{
    public class clsListadosDAL
    {
        public static List<clsPersonaje> listadoPersonajes = new List<clsPersonaje>
        {
            new clsPersonaje(1, "Vi", new DateTime(2000, 5, 12), 1),          // Bando 1: Policía
            new clsPersonaje(2, "Jinx", new DateTime(2003, 9, 22), 3),        // Bando 3: Zaun
            new clsPersonaje(3, "Jayce", new DateTime(1997, 7, 15), 2),       // Bando 2: Piltover
            new clsPersonaje(4, "Caitlyn", new DateTime(1999, 2, 5), 1),      // Bando 1: Policía
            new clsPersonaje(5, "Viktor", new DateTime(1996, 4, 10), 2),      // Bando 2: Piltover
            new clsPersonaje(6, "Ekko", new DateTime(2005, 11, 3), 3),        // Bando 3: Zaun
            new clsPersonaje(7, "Heimerdinger", new DateTime(1900, 1, 1), 2), // Bando 2: Piltover
            new clsPersonaje(8, "Silco", new DateTime(1985, 6, 8), 3),        // Bando 3: Zaun
            new clsPersonaje(9, "Mel Medarda", new DateTime(1992, 3, 20), 2), // Bando 2: Piltover
            new clsPersonaje(10, "Sevika", new DateTime(1988, 8, 14), 3),     // Bando 3: Zaun

            new clsPersonaje(11, "Grayson", new DateTime(1975, 3, 10), 1),    // Policía
            new clsPersonaje(12, "Marcus", new DateTime(1980, 6, 18), 1),     // Policía
            new clsPersonaje(13, "Orianna", new DateTime(1998, 12, 25), 2),   // Piltover
            new clsPersonaje(14, "Camille", new DateTime(1965, 9, 4), 2),     // Piltover
            new clsPersonaje(15, "Singed", new DateTime(1960, 1, 20), 3),     // Zaun
            new clsPersonaje(16, "Twitch", new DateTime(2010, 10, 15), 3),    // Zaun
            new clsPersonaje(17, "Zeri", new DateTime(2002, 4, 7), 3),        // Zaun
            new clsPersonaje(18, "Blitzcrank", new DateTime(1990, 8, 12), 2), // Piltover
            new clsPersonaje(19, "Warwick", new DateTime(1985, 11, 8), 3),    // Zaun
            new clsPersonaje(20, "Coriander", new DateTime(1995, 5, 30), 1)   // Policía (ficticio)
        };


        public static List<clsBando> listadoBandos = new List<clsBando>
        {
            new clsBando(1, "Policia"),
            new clsBando(2, "Piltover"),
            new clsBando(3, "Zaun")
        };


        /// <summary>
        /// devuelve listado completo
        /// </summary>
        /// <returns></returns>
        public static List<clsPersonaje> getPersonajesDAL()
        {
            return listadoPersonajes;
        }

        /// <summary>
        /// devuelve un objeto de personaje
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static clsPersonaje getPersonajeIdDAL(int id)
        {
            clsPersonaje personaje = new clsPersonaje();
                    
            personaje = listadoPersonajes.Find(x => x.Id == id);

            return personaje;
        }

        /// <summary>
        /// devuelve lista de bandos
        /// </summary>
        /// <returns></returns>
        public static List<clsBando> getBandosDAL()
        {
            return listadoBandos;
        }

        /// <summary>
        /// devuelve de un solo bando
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static clsBando getBandoIdDAL(int id)
        {
            clsBando bando = new clsBando();

            bando = listadoBandos.Find(x => x.Id == id);

            return bando;
        }

        /// <summary>
        /// funcion que añade un personaje a la lista
        /// </summary>
        /// <param name="personaje"></param>
        /// <returns></returns>
        public static bool addPersonaje(clsPersonaje personaje)
        {
            bool added = true;
            personaje.Id = nextId();

            try
            {
                listadoPersonajes.Add(personaje);
                added = true;
            }
            catch (Exception ex)
            {
                added = false;
            }

            return added;
        }

        /// <summary>
        /// funcion qeu borra un elemento de la lista
        /// </summary>
        /// <param name="personaje"></param>
        /// <returns></returns>
        public static bool deletePersonaje(int id)
        {
            bool deleted = true;
            clsPersonaje p = clsListadosDAL.getPersonajeIdDAL(id);

            try
            {
                listadoPersonajes.Remove(p);
            }
            catch(Exception ex)
            {
                deleted = false;
            }

            return deleted;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="personaje"></param>
        /// <returns></returns>
        public static bool updatePersonaje(int id, clsPersonaje personaje)
        {
            bool changed = true;

            try
            {
                clsPersonaje personajeActual = getPersonajeIdDAL(id);
                int index = listadoPersonajes.IndexOf(personajeActual);
                personajeActual.Nombre = personaje.Nombre;
                personajeActual.FechaNacimiento = personaje.FechaNacimiento;
                personajeActual.IdBando = personaje.IdBando;
                listadoPersonajes[index] = personajeActual;
            }
            catch (Exception ex)
            {
                changed = false;
            }

            return changed;
        }

        private static int nextId()
        {
            int id;

            id = listadoPersonajes.Last().Id;

            return id+1;
        }
    }
}
