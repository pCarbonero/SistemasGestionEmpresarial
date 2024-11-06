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

            if (TimeOnly.FromDateTime(DateTime.Now) > new TimeOnly(0,0) && TimeOnly.FromDateTime(DateTime.Now) < new TimeOnly(20, 00))
            {
                listado = ClsListadosDAL.listadoMisionesDAL();
            }
            else
            {
                listado = null;
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
