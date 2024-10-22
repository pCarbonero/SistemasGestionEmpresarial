using Ejercicio04.Models.Entidades;

namespace Ejercicio04.Models.DAL
{
    public class ClsListado
    {
        /// <summary>
        /// Funcion que devuelve un lsitado de objetos de la clase ClsPersona
        /// </summary>
        /// <returns>Lista de personas</returns>
        public static List<ClsPersona> listadoPersonas()
        {
            List<ClsPersona>lista = new List<ClsPersona>();

            return lista;
        }

        /// <summary>
        /// Función que devuelve una lista de objetos de la clase ClsDepartamento
        /// </summary>
        /// <returns>Lista de departamentos</returns>
        public static List<ClsDepartamento> listadoDepartamentos()
        {
            List<ClsDepartamento> lista = new List<ClsDepartamento>();

            return lista;
        }
    }
}
