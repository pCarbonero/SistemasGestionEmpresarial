using BL;
using Entidades;

namespace ExamenUI.ViewModels
{
    public class ListaMisionesCandidatosVM
    {
        #region propiedades
        public List<clsMision> ListadoMisiones { get; }
        public List<clsCandidato> ListadoCandidatos { get; set; }
        public clsMision MisionSeleccionada { get; }
        #endregion

        #region constructores
        public ListaMisionesCandidatosVM()
        {
            ListadoMisiones = clsListadosBL.listadoCompletoMisionesBL();
        }

        public ListaMisionesCandidatosVM(int idMision)
        {
            ListadoMisiones = clsListadosBL.listadoCompletoMisionesBL();
            ListadoCandidatos = clsListadosBL.listadoCandidatosPorIdMision(idMision);
        }
        #endregion constructores

    }
}
