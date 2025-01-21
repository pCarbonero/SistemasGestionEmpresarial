using Entidades;

namespace DAL
{
    public class clsListadosDAL
    {
        public static List<clsPersona> listaPersonas = new List<clsPersona>()
        {
            new clsPersona(1, "Pablo", "Carbonero", 1),
            new clsPersona(2, "Sara", "Ruiz", 2),
            new clsPersona(3, "Rafaela", "Merino", 3),
            new clsPersona(4, "Elena", "Lorenzo", 4),
            new clsPersona(5, "Javier", "Muñoa", 1)
        };

        public static List<clsDepartamento> listaDepartamentos = new List<clsDepartamento>()
        {
            new clsDepartamento(1, "TI"),
            new clsDepartamento(2, "RRHH"),
            new clsDepartamento(3, "Finanzas"),
            new clsDepartamento(4, "Música")
        };




        public static List<clsPersona> getPersonasDAL()
        {
            return listaPersonas;
        }

        public static void addPersona(clsPersona persona)
        {
            int id = lastIdPersona(persona);
            persona.Id = id;
            listaPersonas.Add(persona);
        }
        public static List<clsDepartamento> getDepartamentosDAL()
        {
            return listaDepartamentos;
        }

        private static int lastIdPersona(clsPersona persona)
        {
            return listaPersonas[^1].Id;
        }
    }
}
