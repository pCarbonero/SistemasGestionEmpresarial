namespace Entidades
{
    public class clsCandidato
    {
        #region propiedades
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Direccion {  get; set; }
        public string Nacionalidad { get; set; }
        public int Telefono { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int PrecioMedio {  get; set; }
        #endregion

        #region constructores
        public clsCandidato() { }
        public clsCandidato(int id, string nombre, string apellidos, string direccion, string nacionalidad, int telefono, DateTime fechaNacimiento, int precioMedio)
        {
            Id = id;
            Nombre = nombre;
            Apellidos = apellidos;
            Direccion = direccion;
            Nacionalidad = nacionalidad;
            Telefono = telefono;
            FechaNacimiento = fechaNacimiento;
            PrecioMedio = precioMedio;
        }

        #endregion
    }
}
