using DAL;
using Entidades;
using System.Collections.Generic;

namespace BL
{
    public class ClsListadosBL
    {
        public static List<ClsPersona> listadoCompletoPersonasBL()
        {
            List<ClsPersona> listado = new List<ClsPersona>();

            try
            {
                listado = ClsListados.listadoCompletoPersonasDAL();
            }catch (Exception ex) 
            {
                throw;
            }

            return listado;
        }

        public static ClsPersona getPersonaID(int id)
        {
            ClsPersona persona = ClsListados.getPersonaId(id);
            return persona;
        }

        public static bool editarPersonaIdBL(ClsPersona persona)
        {
            bool edit = ClsListados.editarPersonaIdDAL(persona);

            return edit;
        }
    }
}
