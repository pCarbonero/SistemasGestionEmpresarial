namespace Entidades
{
    public class ClsMision
    {
        #region Propiedades
        public int Id { get; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public float Recompensa { get; set; }
        #endregion

        #region Constructores
        public ClsMision() { }
        public ClsMision(string nombre, string descripcion, float recompensa)
        {
            Nombre = nombre;
            Descripcion = descripcion;
            Recompensa = recompensa;
        }
        #endregion
    }
}
