using Entidades;

namespace DAL
{
    public class clsListadosDAL
    {
        /// <summary>
        /// Funcion estatica que devuelve una lista compelta de objetos de la clase clsMision
        /// </summary>
        /// <returns></returns>
        public static List<clsMision> listadoCompletoMisionesDAL()
        {
            List<clsMision> listado = new List<clsMision>();

            listado.Add(new clsMision(1, "Recoger impuestos en el restaurante", 1));
            listado.Add(new clsMision(2, "Hacer una oferta que no puedad rechazar al sindicato de basura", 2));
            listado.Add(new clsMision(3, "Supervidar obras en New Jersey", 3));
            listado.Add(new clsMision(4, "Converncer al Concejal de urbanismo para conseguir favores", 4));
            listado.Add(new clsMision(5, "Encargarse del Concejal de urbanismo que no se dejó convencer", 5));
            listado.Add(new clsMision(6, "Llevar la contabilidad del Bada Bing", 1));

            return listado;
        }

        /// <summary>
        /// Funcion estatica que devuelve una lista completa de objetos de la clase clsCandidato
        /// </summary>
        /// <returns></returns>
        public static List<clsCandidato> listadoCompletoCandidatosDAL()
        {
            List<clsCandidato> listado = new List<clsCandidato>();

            listado.Add(new clsCandidato(1, "Vito", "Gordon", "Pizza Street, 1232", "USA", 54567696, DateTime.Parse("10/11/1961"), 2500));
            listado.Add(new clsCandidato(2, "Christopher", "Moltisalti", "St Monti Av", "USA", 54567696, DateTime.Parse("23/03/2000"), 1500));
            listado.Add(new clsCandidato(3, "Braulia", "Galliani", "Brooklyn Av", "USA", 54567688, DateTime.Parse("09/12/1998"), 2500));
            listado.Add(new clsCandidato(4, "Paulie", "Gualitieri", "Soprano Street, 5", "USA",654567696, DateTime.Parse("24/07/1968"), 2000));
            listado.Add(new clsCandidato(5, "Estás", "Caputo", "Via BOnna Sera, 14", "Italia", 654345687, DateTime.Parse("02/06/1973"), 20000));
            listado.Add(new clsCandidato(6, "Gianluigi", "Buffon", "Juventus Stadium", "Italia", 54567696, DateTime.Parse("12/03/1984"), 14000));
            listado.Add(new clsCandidato(7, "Giorno", "Giovanna", "Pasionne, 41", "Italia", 896541237, DateTime.Parse("05/04/1999"), 16000));
            listado.Add(new clsCandidato(8, "Risotto", "Nero", "Squadra Di Essecuzione", "Italia", 999654127, DateTime.Parse("30/01/1966"), 2000));

            return listado;
        }

        /// <summary>
        /// Funcion estatica que devuelve un objeto de clsCandidato con un id concreto
        /// </summary>
        /// <pre>El int debe ser mayor que 0</pre>
        /// <pos>Si no se encuentra ningun candidato con el id pasado por parametro devuelve un objeto null</pos>
        /// <param name="id"></param>
        /// <returns></returns>
        public static clsCandidato getCandidatoPorIdDAL(int id)
        {
            clsCandidato candidato = new clsCandidato();
            List<clsCandidato> listadoCandidatos = listadoCompletoCandidatosDAL();

            candidato = (clsCandidato)listadoCandidatos.Where(per => per.Id == id).FirstOrDefault();

            return candidato;
        }
    }
}
