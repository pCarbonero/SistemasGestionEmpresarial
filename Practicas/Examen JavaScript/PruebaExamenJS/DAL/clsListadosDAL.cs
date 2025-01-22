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
        public static clsDepartamento getDepartamentoIdDAL(int id)
        {
            //MyClass result = list.Find(x => x.GetId() == "xy");
            clsDepartamento dept = listaDepartamentos.Find(d => d.Id == id);
            return dept;
        }

        private static int lastIdPersona(clsPersona persona)
        {
            int id = 1;

            foreach (clsPersona p in listaPersonas)
            {
                id++;
            }
            return id+1;
        }
    }
}
