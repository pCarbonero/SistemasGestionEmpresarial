using Entidades;

namespace DAL
{
    public class ClsListadosDAL
    {
        /// <summary>
        /// Funcion que devuelve una una lista de objetos de ClsMision
        /// </summary>
        /// <returns>List ClsMision</returns>
        public static List<ClsMision> listadoMisionesDAL()
        {
            List<ClsMision> lista = new List<ClsMision>();

            lista.Add(new ClsMision(0, "Cazar al Contrabandista Korrik",
                "Un conocido contrabandista de especias ha sido visto en el planeta Tatooine. Se necesita tu habilidad para rastrearlo y traerlo vivo o muerto.",
                5000));
            lista.Add(new ClsMision(1, "Buscar a \"el Bicho\"", 
                "Buscar y eliminar al super humano portugués que vive en la tierra. Se hace llamar \"el Bicho\". " +
                "Es una persona muy peligrosa, tiene a un ejercito de seguidores locos que parecen estar bajo control mental," +
                " solo gritan a pleno pulmón \"Pessi < RonaldoGoat\"", 
                15000f));
            lista.Add(new ClsMision(2, "Recuperar el Artefacto Perdido",
                "Un artefacto Jedi antiguo ha caído en manos de los Hutt. Debes infiltrarte en su guarida y recuperarlo antes de que sea usado en rituales oscuros.", 
                10000));
            lista.Add(new ClsMision(3, "Eliminación de Droides Descontrolados",
                "Un grupo de droides de combate ha comenzado a atacar a civiles en Naboo. Se necesita un cazarrecompensas experimentado para desactivarlos.",
                7000));
            lista.Add(new ClsMision(4, "Rescate en la Luna de Endor",
                "Un oficial imperial ha sido secuestrado por un grupo de Ewoks. Necesitas negociar o eliminar para asegurar la liberación.",
                8000f));
            lista.Add(new ClsMision(5, "Detener el Tráfico de Wookies",
                "Una organización criminal está traficando con Wookies. Detén a los responsables y salva a los prisioneros en Kashyyyk.",
                12000f));
            lista.Add(new ClsMision(6, "Venganza en Mustafar",
                "Un viejo enemigo del pasado se ha refugiado en las peligrosas tierras de Mustafar. El tiempo se acaba y tu venganza debe ser cumplida.",
                15000f));
            lista.Add(new ClsMision(7, "Capturar al Traidor Imperial",
                "Un ex oficial imperial se ha fugado con información secreta. Sigue su rastro a través de los sistemas Outer Rim y tráelo ante la justicia.",
                9000f));
            lista.Add(new ClsMision(8, "Caza de Rancor en el Desierto",
                "Un Rancor salvaje ha escapado de su jaula y ahora aterrorizan a las aldeas en Jakku. Detén la amenaza.",
                20000f));
            lista.Add(new ClsMision(9, "Espionaje en Coruscant",
                "La inteligencia de la Nueva República necesita información crucial. Infiltrarse en Coruscant y obtener documentos clasificados es tu misión.",
                6000f));
            lista.Add(new ClsMision(10, "Buscar a un Jedi Perdido",
                "Un Jedi ha sido localizado en el planeta Lothal, pero su paradero es incierto. Debes encontrarlo antes de que los enemigos lo hagan.",
                25000f));
            lista.Add(new ClsMision(11, "Encontrar tungsteno",
                "Encuentra tungsteno y traemelo rápido, lo necesito para vivir.",
                3500f));

            return lista;
        }

        /// <summary>
        /// Funcion que devuelve un objeto de la clase mision
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Objeto de ClsMision</returns>
        public static ClsMision misionPorIdDAL(int Id)
        {
            List<ClsMision> lista = listadoMisionesDAL();
            ClsMision misionBuscada = null;
            foreach (ClsMision mision in lista)
            {
                if (mision.Id == Id) 
                { 
                    misionBuscada = mision;
                }
            }
            
            return misionBuscada;
        }
    }
}
