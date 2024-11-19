using BL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaBDMaui.ViewModels
{
    public class ListadoVM
    {
        #region propiedades
        public List<clsPersona> ListadoPersonas { get; }
        #endregion

        #region constructores
        public ListadoVM()
        {
            try
            {
                ListadoPersonas = clsListadosBL.listadoCompletoPersonasBL();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        #endregion
    }
}
