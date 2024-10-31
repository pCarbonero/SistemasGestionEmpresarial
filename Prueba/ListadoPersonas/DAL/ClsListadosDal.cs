using ListadoPersonas.Entidades;

namespace DAL
{
    public class ClsListadosDal
    {
        /// <summary>
        /// Función estática que devuelve una lista de objetos de la clase persona
        /// </summary>
        /// <returns>List ClsPersona</returns>
        public static List<ClsPersona> listadoPersonas()
        {
            List<ClsPersona> list = new List<ClsPersona>();

            //ClsPersona p1 = new ClsPersona("Pablo", "Carbonero", 21);
            //ClsPersona p2 = new ClsPersona("Raul", "Romerap", 20);
            //ClsPersona p3 = new ClsPersona("Lorenco", "Ballena", 19);
            //ClsPersona p4 = new ClsPersona("Malco", "Casquín", 18);
            //ClsPersona p5 = new ClsPersona("Hecori", "Arial", 15);
            //ClsPersona p6 = new ClsPersona("Edualdo", "Bellidon", 18);
            //ClsPersona p7 = new ClsPersona("PePeLu", "Mejorado", 24);
            //ClsPersona p8 = new ClsPersona("Pablo", "Carbonero", 21);
            //ClsPersona p9 = new ClsPersona("Pablo", "Carbonero", 21);
            //ClsPersona p10 = new ClsPersona("Pablo", "Carbonero", 21);

            list.Add(new ClsPersona("Pablo", "Carbonero", 21));
            list.Add(new ClsPersona("Raul", "Romerap", 20));
            list.Add(new ClsPersona("Lorenco", "Ballena", 19));
            list.Add(new ClsPersona("Malco", "Casquín", 18));
            list.Add(new ClsPersona("Hecori", "Arial", 15));
            list.Add(new ClsPersona("Edualdo", "Bellidon", 18));
            list.Add(new ClsPersona("PePeLu", "Mejorado", 24));
            list.Add(new ClsPersona("Pablo", "Carbonero", 21));
            list.Add(new ClsPersona("Pablo", "Carbonero", 21));
            list.Add(new ClsPersona("Pablo", "Carbonero", 21));

            return list;
        }
    }
}
