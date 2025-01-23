namespace Entidades
{
    public class clsPersonaje
    {
        #region propiedades
        public int Id { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int IdBando { get; set; }
        #endregion

        #region constructores
        public clsPersonaje() { }
        public clsPersonaje(int id, string nombre, DateTime fechaNacimiento, int idBando)
        {
            Id = id;
            Nombre = nombre;
            FechaNacimiento = fechaNacimiento;
            this.IdBando = idBando;
        }

        public clsPersonaje(string nombre, DateTime fechaNacimiento, int idBando)
        {
            Nombre = nombre;
            FechaNacimiento = fechaNacimiento;
            this.IdBando = idBando;
        }
        #endregion
    }
}
