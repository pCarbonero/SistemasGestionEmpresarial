using DAL;
using Entidades;

namespace BL
{
    public class clsListadosBL
    {
        /// <summary>
        /// Funcion estatica qeu devuelve un listado con las persoans de un departamento
        /// </summary>
        /// <param name="idDepartamento"></param>
        /// <returns>lista de personas, lista vacia si no hay datos</returns>
        public static List<clsPersona> listadoPersonasDepartamentoBL(int idDepartamento)
        {
            List<clsDepartamento> departamentos = clsListadosDAL.getListadoDepartamentos();
            List<clsPersona> listaCompleta = clsListadosDAL.getListaPersonasDepartamento(idDepartamento);
            List<clsPersona> listaFinal = new List<clsPersona>();

            clsDepartamento nombreDep = departamentos.Find(x=>x.Id == idDepartamento);

            // comrpueba si el nombre del departamento es Recursos Humanos
            if (nombreDep.Nombre == "Recursos Humanos")
            {
                foreach(clsPersona persona in listaCompleta)
                {
                    // si cumple la condicion se añade a la lista definitiva
                    if (calcularEdad(persona.FechaNacimiento) > 35)
                    {
                        listaFinal.Add(persona);
                    }
                }
            }
            else
            {
                listaFinal = listaCompleta;
            }

            return listaFinal;
        }

        /// <summary>
        /// Funcion estatica qeu devuelve listado completo de departamentos
        /// </summary>
        /// <returns></returns>
        public static List<clsDepartamento> getListaDepartamentosBL()
        {
            return clsListadosDAL.getListadoDepartamentos();
        }

        /// <summary>
        /// Funcion que devuelve un departamento por su id
        /// </summary>
        /// <param name="nombre"></param>
        /// <returns></returns>
        public static clsDepartamento getDepartamentoIdBL(int id)
        {
            return clsListadosDAL.getDepartamentoIdDAL(id);
        }

        /// <summary>
        /// Funcion estatic que devuelve una persona concreta
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static clsPersona getPersonaIdBL(int id)
        {
            return clsListadosDAL.getPersonaIdDAL(id);
        }

        /// <summary>
        /// Funcion que calcula la edad de una persona
        /// </summary>
        /// <param name="fechaNac"></param>
        /// <returns></returns>
        private static int calcularEdad(DateTime fechaNac)
        {
            int edad = DateTime.Now.Year - fechaNac.Year;

            if(fechaNac.DayOfYear < DateTime.Now.DayOfYear)
            {
                edad -= 1;
            }

            return edad;
        }
        
    }
}
