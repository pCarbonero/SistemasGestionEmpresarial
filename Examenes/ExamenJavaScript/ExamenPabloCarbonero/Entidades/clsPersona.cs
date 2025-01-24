namespace Entidades
{
    public class clsPersona
    {
        #region Propiedades
        public int Id { get; set; }
        public string Nombre { get; set; }

        public string Apellidos { get; set; }

        public int Telefono { get; set; }

        public DateTime FechaNacimiento { get; set; }

        public int IdDepartamento {  get; set; }

        public string NombreDepartamento { get; set; }
        #endregion

        #region constructores

        public clsPersona() { }

        public clsPersona(int id, string nombre, string apellidos, int telefono, DateTime fechanacimiento, int idDepartamento)
        {
            Id = id;
            Nombre = nombre;
            Apellidos = apellidos;
            Telefono = telefono;
            FechaNacimiento = fechanacimiento;
            IdDepartamento = idDepartamento;
        }

        public clsPersona(string nombre, string apellidos, int telefono, DateTime fechanacimiento, int idDepartamento)
        {
            Nombre = nombre;
            Apellidos = apellidos;
            Telefono = telefono;
            FechaNacimiento = fechanacimiento;
            IdDepartamento = idDepartamento;
        }
        #endregion
    }
}
