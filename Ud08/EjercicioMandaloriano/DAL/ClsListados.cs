using Entidades;

namespace DAL
{
    public class ClsListados
    {
        /// <summary>
        /// Funcion que devuelve una una lista de objetos de ClsMision
        /// </summary>
        /// <returns>List ClsMision</returns>
        public static List<ClsMision> listadoMisionesDal()
        {
            List<ClsMision> lista = new List<ClsMision>();

            return lista;
        }

        /// <summary>
        /// Funcion que devuelve un objeto de la clase mision
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Objeto de ClsMision</returns>
        public static ClsMision misionPorIdDal(int id)
        {
            ClsMision mision = new ClsMision();
            return mision;
        }
    }
}
