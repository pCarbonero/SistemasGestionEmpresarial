using Ejercicio04.Models.DAL;
using Ejercicio04.Models.Entidades;
using System.Xml.Serialization;

namespace Ejercicio04.Models.VM
{
    public class ClsEditarPersona: ClsPersona
    {


        public List<ClsDepartamento> ListadoDepartamentos { get; }

        public ClsEditarPersona()
        {
            ListadoDepartamentos = ClsListado.listadoDepartamentos();
        }
    }
}
