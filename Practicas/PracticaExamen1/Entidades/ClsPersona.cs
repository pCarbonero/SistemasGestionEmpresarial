namespace Entidades
{
    public class ClsPersona
    {
        #region Propiedades
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }

        public DateTime FechaNacimiento { get; set; }

        public int IdDepartamento { get; set; }
        #endregion

        #region Constructores
        public ClsPersona() { }
        public ClsPersona(int id, string nombre, string apellidos, DateTime fechaNacimiento, int idDepartamento)
        {
            Id = id;
            Nombre = nombre;
            Apellidos = apellidos;
            FechaNacimiento = fechaNacimiento;
            IdDepartamento = idDepartamento;
        }

        #endregion
    }
}
