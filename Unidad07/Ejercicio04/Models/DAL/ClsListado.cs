using Ejercicio04.Models.Entidades;

namespace Ejercicio04.Models.DAL
{
    public class ClsListado
    {
        /// <summary>
        /// Funcion que devuelve un lsitado de objetos de la clase ClsPersona
        /// </summary>
        /// <returns>Lista de personas</returns>
        public static List<ClsPersona> listadoPersonas()
        {
            List<ClsPersona>lista = new List<ClsPersona>();

            ClsPersona p1 = new ClsPersona("Pablo", "Carbonero Almellones", 21, 1);
            ClsPersona p2 = new ClsPersona("Sara", "Ruíz Rico", 23, 1);
            ClsPersona p3 = new ClsPersona("Marcos", "Holguín Cascado", 19, 2);
            ClsPersona p4 = new ClsPersona("Raúl", "Romora Romerap", 20, 2);
            ClsPersona p5 = new ClsPersona("Lorezo Jesús", "Belido Ballenato", 17, 3);
            ClsPersona p6 = new ClsPersona("Hector", "Ariados Jordijunior", 11, 3);
            ClsPersona p7 = new ClsPersona("Edualdo", "Hernesto Romino", 19, 4);
            ClsPersona p8 = new ClsPersona("Jordi", "Ariados Catalan", 51, 4);
            ClsPersona p9 = new ClsPersona("PEPELU", "Mejorata Xakata", 27, 5);
            ClsPersona p10 = new ClsPersona("Vera", "Almellones de Jesús", 2, 5);

            lista.Add(p1);
            lista.Add(p2);
            lista.Add(p3);              
            lista.Add(p4);
            lista.Add(p5);
            lista.Add(p6);             
            lista.Add(p7);
            lista.Add(p8);
            lista.Add(p9);
            lista.Add(p10);


            return lista;
        }

        /// <summary>
        /// Función que devuelve una lista de objetos de la clase ClsDepartamento
        /// </summary>
        /// <returns>Lista de departamentos</returns>
        public static List<ClsDepartamento> listadoDepartamentos()
        {
            List<ClsDepartamento> lista = new List<ClsDepartamento>();

            ClsDepartamento d = new ClsDepartamento("Logística", 1);
            ClsDepartamento d2 = new ClsDepartamento("Marketing", 2);
            ClsDepartamento d3 = new ClsDepartamento("Recursos Humanos", 3);
            ClsDepartamento d4 = new ClsDepartamento("Finanzas", 4);
            ClsDepartamento d5 = new ClsDepartamento("Producción", 5);

            lista.Add(d);
            lista.Add(d2);
            lista.Add(d3);
            lista.Add(d4);
            lista.Add(d5);

            return lista;
        }
    }
}
