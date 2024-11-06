using Entidades;

namespace EjercicioMandalorianoUI.Models.ViewModels
{
    public class VerMisionesVM
    {
        #region propiedades
        public ClsMision misionSeleccionada { get; set; }
        public List<ClsMision> listadoMisiones { get; set; }
        #endregion
    }
}
