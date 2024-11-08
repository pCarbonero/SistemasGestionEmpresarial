using DAL;
using Entidades;

namespace BL
{
    public class ClsListadosBL
    {
        /// <summary>
        /// Funcion que devuelve la lista de la capa DAL si está en el horario establecido, si no se devuelve un null
        /// </summary>
        /// <returns>Lista de misiones o null</returns>
        public static List<ClsMision> listadoMisionesBL()
        {
            List<ClsMision> listado;

            if (DateTime.Now.Hour > 0 && DateTime.Now.Hour < 8)
            {
                throw new HourException("Página cerrada. Misiones disponibles a las 08:00. Gracias.");
            }
            else
            {
                listado = ClsListadosDAL.listadoMisionesDAL();
            }

            return listado;
        }

        /// <summary>
        /// Funcion que devuelve un objeto de la clase mision por el id solicitado
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static ClsMision misionPorIdBL(int id)
        {
            ClsMision mision = ClsListadosDAL.misionPorIdDAL(id);
            return mision;
        }

    }
}
