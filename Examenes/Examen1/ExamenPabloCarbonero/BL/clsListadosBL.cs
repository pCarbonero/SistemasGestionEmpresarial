using DAL;
using Entidades;

namespace BL
{
    public class clsListadosBL
    {
        /// <summary>
        /// Funcion estatica que devuelve una lista de objetos de la clase clsMision que obtiene de la capa DAL
        /// </summary>
        /// <returns></returns>
        public static List<clsMision> listadoCompletoMisionesBL()
        {
            List<clsMision> listado = clsListadosDAL.listadoCompletoMisionesDAL();
            return listado;
        }

        /// <summary>
        /// Funcion estatica que devuelve un listado completo de candidatos
        /// </summary>
        /// <returns></returns>
        public static List<clsCandidato> listadoCompletoCandidatosBL()
        {
            List<clsCandidato> listado = clsListadosDAL.listadoCompletoCandidatosDAL();
            return listado;
        }

        /// <summary>
        /// Funcion estatica que filtra una lista de misiones completas y la filtra con las reglas de negocio
        /// Se usa la funcion estatica para calcular la edad
        /// </summary>
        /// <pre>el id debe de ser mayor que 0</pre>
        /// <pos> si ningun candidato cummple las condiciones enviara una lista vacia</pos>
        /// <returns></returns>
        public static List<clsCandidato> listadoCandidatosPorIdMision(int idMision)
        { 
            List<clsCandidato> listadoCompleto = clsListadosDAL.listadoCompletoCandidatosDAL();
            List<clsCandidato> listadoFiltrado = new List<clsCandidato>();
            List<clsMision> listadoMisiones = clsListadosBL.listadoCompletoMisionesBL();

            clsMision misionBuscada = (clsMision) listadoMisiones.Where(per => per.Id == idMision).FirstOrDefault();

            if (misionBuscada.Dificultad == 1 || misionBuscada.Dificultad == 2)
            {
                listadoFiltrado = listadoCompleto.Where(per => per.Nacionalidad == ("USA")).ToList();
            }
            else if (misionBuscada.Dificultad == 3)
            {
                listadoFiltrado = listadoCompleto.Where(per => per.Nacionalidad == ("USA") && 40 < calcularEdadCandidato(per.FechaNacimiento)).ToList();
            }
            else if (misionBuscada.Dificultad == 4)
            {
                listadoFiltrado = listadoCompleto.Where(per => per.Nacionalidad == ("Italia") && 45 > calcularEdadCandidato(per.FechaNacimiento)).ToList();
            }
            else if (misionBuscada.Dificultad == 5)
            {
                listadoFiltrado = listadoCompleto.Where(per => per.Nacionalidad == ("Italia") && (45 < calcularEdadCandidato(per.FechaNacimiento) && 55 > calcularEdadCandidato(per.FechaNacimiento))).ToList();
            }

            return listadoFiltrado;
        }

        /// <summary>
        /// Funcion estatica que devuelve un candidato con un id concreto de la capa DAL
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static clsCandidato getCandidatoPorIdBL(int id)
        {
            clsCandidato candidato = clsListadosDAL.getCandidatoPorIdDAL(id);
            return candidato;
        }

        /// <summary>
        /// Funcion estatica que devuelve la edad de un candidato recibiendo su fecha de nacimiento
        /// </summary>
        /// <param name="fechaNac"></param>
        /// <returns></returns>
        public static int calcularEdadCandidato(DateTime fechaNac)
        {
            int edad = 0;
            if (fechaNac.DayOfYear < DateTime.Now.DayOfYear)
            {
                edad = DateTime.Now.Year - fechaNac.Year;
            }
            else
            {
                edad = (DateTime.Now.Year - fechaNac.Year)-1;
            }
            return edad;
        }
    }
}
