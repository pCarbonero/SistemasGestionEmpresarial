using DAL;
using ListadoPersonas.Entidades;

namespace BL
{
    public class ClsListadosBl
    {
        /// <summary>
        /// Funcion estatica que llama a la dal, aplica las reglas de negocio oportunas y devuelve la lista de personas correspondiente
        /// </summary>
        /// <returns>List ClsPersonas</returns>
        public static List<ClsPersona> listadoPersonasBl()
        {
            List<ClsPersona> list = ClsListadosDal.listadoPersonas();
            //TODO Comprobar si es jueves y si es antes o despues de las 13:30
            return list;
        }
    }
}
