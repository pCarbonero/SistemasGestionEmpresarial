using Entidades;
using DAL;

namespace BL
{
    public class clsListadosBL
    {
        /// <summary>
        /// static function that takes list from DAL and returns it
        /// </summary>
        /// <returns></returns>
        public static List<clsPersona> listadoCompletoPersonasBL()
        {
            List<clsPersona> lista = new List<clsPersona>();

            lista = clsListados.listadoCompletoPersonasDal();

            return lista;
        }
    }
}
