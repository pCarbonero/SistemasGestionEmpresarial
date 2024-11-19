using Entidades;

namespace DAL
{
    public class ClsListados
    {
        public static List<ClsPersona> listadoCompletoPersonasDAL()
        {
            List<ClsPersona> listado = new List<ClsPersona>();

            #region addPersonas
            listado.Add(new ClsPersona(1, "Pablo", "Carbonero", DateTime.Parse("02/01/2003"), 1));
            listado.Add(new ClsPersona(2, "María", "González", DateTime.Parse("15/03/1998"), 2));
            listado.Add(new ClsPersona(3, "Juan", "Martínez", DateTime.Parse("12/07/2000"), 3));
            listado.Add(new ClsPersona(4, "Lucía", "López", DateTime.Parse("25/11/1995"), 4));
            listado.Add(new ClsPersona(5, "Carlos", "Rodríguez", DateTime.Parse("18/06/1989"), 1));
            listado.Add(new ClsPersona(6, "Ana", "Hernández", DateTime.Parse("09/04/1992"), 2));
            listado.Add(new ClsPersona(7, "David", "Pérez", DateTime.Parse("22/09/2001"), 3));
            listado.Add(new ClsPersona(8, "Sara", "Sánchez", DateTime.Parse("04/12/1997"), 4));
            listado.Add(new ClsPersona(9, "Javier", "Ramírez", DateTime.Parse("30/05/1985"), 1));
            listado.Add(new ClsPersona(10, "Elena", "Torres", DateTime.Parse("16/10/1990"), 2));
            listado.Add(new ClsPersona(11, "Alberto", "Vega", DateTime.Parse("08/08/2002"), 3));
            listado.Add(new ClsPersona(12, "Claudia", "Rivas", DateTime.Parse("23/02/1994"), 4));
            listado.Add(new ClsPersona(13, "Francisco", "Ortega", DateTime.Parse("05/01/1996"), 1));
            listado.Add(new ClsPersona(14, "Marta", "Ibáñez", DateTime.Parse("29/03/1993"), 2));
            listado.Add(new ClsPersona(15, "Adrián", "Gil", DateTime.Parse("14/07/1999"), 3));
            listado.Add(new ClsPersona(16, "Patricia", "Cano", DateTime.Parse("19/11/2004"), 4));
            listado.Add(new ClsPersona(17, "Daniel", "Molina", DateTime.Parse("11/06/1991"), 1));
            listado.Add(new ClsPersona(18, "Laura", "Blanco", DateTime.Parse("06/04/2000"), 2));
            listado.Add(new ClsPersona(19, "Alejandro", "Domínguez", DateTime.Parse("27/09/1998"), 3));
            listado.Add(new ClsPersona(20, "Raquel", "Serrano", DateTime.Parse("02/12/2003"), 4));
            listado.Add(new ClsPersona(21, "Sergio", "Medina", DateTime.Parse("15/05/1997"), 1));
            listado.Add(new ClsPersona(22, "Irene", "Fernández", DateTime.Parse("20/10/1995"), 2));
            listado.Add(new ClsPersona(23, "Miguel", "Navarro", DateTime.Parse("09/08/1986"), 3));
            listado.Add(new ClsPersona(24, "Nuria", "Castro", DateTime.Parse("13/02/2001"), 4));
            listado.Add(new ClsPersona(25, "Andrés", "Rojas", DateTime.Parse("17/01/1994"), 1));
            listado.Add(new ClsPersona(26, "Carmen", "Flores", DateTime.Parse("21/03/1999"), 2));
            listado.Add(new ClsPersona(27, "Iván", "Suárez", DateTime.Parse("10/07/1993"), 3));
            listado.Add(new ClsPersona(28, "Sofía", "Rubio", DateTime.Parse("05/11/1992"), 4));
            listado.Add(new ClsPersona(29, "Pedro", "Cruz", DateTime.Parse("18/06/1998"), 1));
            listado.Add(new ClsPersona(30, "Teresa", "Delgado", DateTime.Parse("22/04/2000"), 2));
            #endregion

            return listado;
        }

        public static ClsPersona getPersonaId(int id)
        {
            List<ClsPersona> listado = listadoCompletoPersonasDAL();
            ClsPersona persona = new ClsPersona();
           
            persona = listado.Find(p => p.Id == id) ?? new ClsPersona();

            return persona;
        }

        public static bool editarPersonaIdDAL(ClsPersona persona)
        {
            bool edit = false;
            List<ClsPersona> listado = listadoCompletoPersonasDAL();
            ClsPersona p;
            int i = 0;

            while (i < listado.Count && !edit) 
            { 
                if(persona.Id == listado[i].Id)
                {
                    edit = true;
                    listado[i] = persona;
                }
                i++;
            }

            return edit;
        }
    }
}
