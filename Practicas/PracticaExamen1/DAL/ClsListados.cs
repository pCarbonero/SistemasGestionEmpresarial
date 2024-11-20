using Entidades;

namespace DAL
{
    public class clsListados
    {
        static List<clsPersona> listadoDAL = new List<clsPersona>
        {
            new clsPersona(1, "Pablo", "Carbonero", DateTime.Parse("02/01/2003"), 1),
            new clsPersona(2, "Laura", "Gómez", DateTime.Parse("15/03/1998"), 2),
            new clsPersona(3, "Carlos", "Fernández", DateTime.Parse("07/12/2000"), 3),
            new clsPersona(4, "Ana", "Martínez", DateTime.Parse("22/06/1995"), 1),
            new clsPersona(5, "Luis", "Hernández", DateTime.Parse("13/08/1992"), 2),
            new clsPersona(6, "María", "Pérez", DateTime.Parse("01/09/2001"), 3),
            new clsPersona(7, "Jorge", "Sánchez", DateTime.Parse("30/10/1997"), 1),
            new clsPersona(8, "Claudia", "Díaz", DateTime.Parse("20/02/1999"), 2),
            new clsPersona(9, "Sergio", "López", DateTime.Parse("17/11/2004"), 3),
            new clsPersona(10, "Elena", "García", DateTime.Parse("05/07/1996"), 1),
            new clsPersona(11, "Miguel", "Ruiz", DateTime.Parse("14/04/2002"), 2),
            new clsPersona(12, "Alba", "Jiménez", DateTime.Parse("28/09/1993"), 3),
            new clsPersona(13, "Fernando", "Navarro", DateTime.Parse("09/06/1990"), 1),
            new clsPersona(14, "Raquel", "Romero", DateTime.Parse("19/01/1988"), 2),
            new clsPersona(15, "Iván", "Ortega", DateTime.Parse("03/05/2005"), 3),
            new clsPersona(16, "Patricia", "Castro", DateTime.Parse("08/11/1994"), 1),
            new clsPersona(17, "Alberto", "Moreno", DateTime.Parse("11/03/2000"), 2),
            new clsPersona(18, "Sara", "Vega", DateTime.Parse("26/12/2003"), 3),
            new clsPersona(19, "David", "Ramos", DateTime.Parse("16/02/1991"), 1),
            new clsPersona(20, "Inés", "Torres", DateTime.Parse("21/10/1999"), 2),
            new clsPersona(21, "Rafael", "Gil", DateTime.Parse("04/08/1995"), 3),
            new clsPersona(22, "Cristina", "Molina", DateTime.Parse("31/07/2002"), 1),
            new clsPersona(23, "Víctor", "Álvarez", DateTime.Parse("06/05/1987"), 2),
            new clsPersona(24, "Adriana", "Domínguez", DateTime.Parse("24/04/1998"), 3),
            new clsPersona(25, "Francisco", "Delgado", DateTime.Parse("12/01/1992"), 1),
            new clsPersona(26, "Silvia", "Reyes", DateTime.Parse("10/03/2001"), 2),
            new clsPersona(27, "Héctor", "Flores", DateTime.Parse("18/09/1990"), 3),
            new clsPersona(28, "Natalia", "Cano", DateTime.Parse("07/07/1989"), 1),
            new clsPersona(29, "Andrés", "Ibáñez", DateTime.Parse("25/11/1993"), 2),
            new clsPersona(30, "Rocío", "Martín", DateTime.Parse("29/06/2004"), 3)
        };
        public static List<clsPersona> listadoCompletoPersonasDAL()
        {
            List<clsPersona> listado = listadoDAL;
            return listado;
        }

        public static clsPersona getPersonaId(int id)
        {
            List<clsPersona> listado = listadoCompletoPersonasDAL();
            clsPersona persona = new clsPersona();
           
            persona = listado.Find(p => p.Id == id) ?? new clsPersona();

            return persona;
        }

        public static bool editarPersonaIdDAL(clsPersona persona)
        {
            bool edit = false;
            clsPersona p;
            int i = 0;

            while (i < listadoDAL.Count && !edit) 
            { 
                if(persona.Id == listadoDAL[i].Id)
                {
                    edit = true;
                    listadoDAL[i] = persona;
                }
                i++;
            }

            return edit;
        }
    }
}
