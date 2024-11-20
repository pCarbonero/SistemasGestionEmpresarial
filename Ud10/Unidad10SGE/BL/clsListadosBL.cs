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
            try
            {
                lista = clsListados.listadoCompletoPersonasDal();
            }
            catch (Exception ex) { throw; }       

            return lista;
        }

        /// <summary>
        /// Funcion que busca una persona por su id y la devuelve
        /// </summary>
        /// <param name="id"></param>
        /// <returns>objeto persona</returns>
        public static clsPersona getPersonaIdBL(int id) 
        {
            clsPersona persona = new clsPersona();

            try
            {
                 persona = clsListados.GetPersonaId(id);
            }
            catch (Exception ex) { throw; }

            return persona;
        }
    }
}
