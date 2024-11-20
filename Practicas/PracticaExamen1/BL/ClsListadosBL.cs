using DAL;
using Entidades;
using System.Collections.Generic;

namespace BL
{
    public class clsListadosBL
    {
        public static List<clsPersona> listadoCompletoPersonasBL()
        {
            List<clsPersona> listado = new List<clsPersona>();

            try
            {
                listado = clsListados.listadoCompletoPersonasDAL();
            }catch (Exception ex) 
            {
                throw;
            }

            return listado;
        }

        public static clsPersona getPersonaID(int id)
        {
            clsPersona persona = clsListados.getPersonaId(id);
            return persona;
        }

        public static bool editarPersonaIdBL(clsPersona persona)
        {
            bool edit = clsListados.editarPersonaIdDAL(persona);

            return edit;
        }
    }
}
