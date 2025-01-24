using Entidades;

namespace DAL
{
    public class clsListadosDAL
    {
        // lista de las personas
        private static List<clsPersona> listaPersonas = new List<clsPersona>
        {
            new clsPersona (1, "Pablo", "Carbonero", 123456789, new DateTime(2003, 1, 2), 1),
            new clsPersona (2, "Joel", "Ramirez", 456321789, new DateTime(2000, 12, 1), 2),
            new clsPersona (3, "Sergio", "Escudero", 777888555, new DateTime(2000, 1, 1), 2),
            new clsPersona (5, "Alduin", "Dovah", 111222333, new DateTime(1981, 5, 30), 1),

            new clsPersona (6, "Pepe", "Azul", 44455666, new DateTime(2003, 2, 1), 3),
            new clsPersona (7, "Alberto", "Barrera", 777888999, new DateTime(2003, 2, 1), 3),
            new clsPersona (8, "Hermeus", "Mora", 444444666, new DateTime(1969, 2, 1), 3),
            new clsPersona (9, "Tito", "Mede II", 555222888, new DateTime(1980, 8, 4), 3),
            new clsPersona (10, "Tiber", "Septim", 987654123, new DateTime(1950, 2, 1), 3),
            new clsPersona (11, "Pepe", "Ramos", 321456987, new DateTime(2005, 4, 3), 3)
        };

        // lista de los departamentos
        private static List<clsDepartamento> listaDepartamentos = new List<clsDepartamento>
        {
            new clsDepartamento(1, "Finanzas"),
            new clsDepartamento(2, "Marketig"),
            new clsDepartamento(3, "Recursos Humanos")
        };

        /// <summary>
        /// Funcion estatica que devuelve un listado completo de personas
        /// </summary>
        /// <returns></returns>
        public static List<clsPersona> getListadoCompletoPersonasDAL()
        {
            return listaPersonas;
        }

        /// <summary>
        /// Funcion estatica que devuelve un objeto de la clase persona
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static clsPersona getPersonaIdDAL(int id)
        {
            clsPersona persona;

            persona = listaPersonas.Find(x=> x.Id == id);

            return persona;
        }

        /// <summary>
        /// Funcion estatica que devuelve un listado con las personas de un determinado departamento
        /// </summary>
        /// <param name="idDepartamento"></param>
        /// <returns></returns>
        public static List<clsPersona> getListaPersonasDepartamento(int idDepartamento)
        {
            List<clsPersona> listado = new List<clsPersona>();

            foreach (clsPersona persona in listaPersonas)
            {
                if (persona.IdDepartamento == idDepartamento)
                {
                    listado.Add(persona);
                }
            }

            return listado;
        }

        /// <summary>
        /// Funcion que devuelv el id de un departamento por su nombre
        /// </summary>
        /// <param name="nombre"></param>
        /// <returns></returns>
        public static clsDepartamento getDepartamentoIdDAL(int id)
        {
            clsDepartamento departamento = listaDepartamentos.Find(x=>x.Id == id);
            return departamento;
        }

        /// <summary>
        /// Funcion estatica que devuelve un listado de todos los departamentos
        /// </summary>
        /// <returns></returns>
        public static List<clsDepartamento> getListadoDepartamentos()
        {
            return listaDepartamentos;
        }
    }
}
