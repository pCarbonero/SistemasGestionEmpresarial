using Entidades;
using DAL;

namespace BL
{
    public class clsListadosBL
    {
        public static List<clsPersonaje> listadoPersonajesBL()
        {
            return clsListadosDAL.getPersonajesDAL();
        }

        public static List<clsBando> listadoBandosBL()
        {
            return clsListadosDAL.getBandosDAL();
        }

        public static clsPersonaje getPersonajeBL(int id)
        {
            return clsListadosDAL.getPersonajeIdDAL(id);
        }

        public static clsBando getBando(int id)
        {
            return clsListadosDAL.getBandoIdDAL(id);
        }


    }
}
