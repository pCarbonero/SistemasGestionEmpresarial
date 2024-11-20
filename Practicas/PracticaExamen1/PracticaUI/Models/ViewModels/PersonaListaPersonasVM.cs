using BL;
using Entidades;

namespace PracticaUI.Models.ViewModels
{
    public class PersonaListaPersonasVM
    {
        public List<clsPersona> ListaPersonas { get; }
        public clsPersona Persona { get; set; }

        public PersonaListaPersonasVM()
        {
            ListaPersonas = clsListadosBL.listadoCompletoPersonasBL();
        }

    }
}
