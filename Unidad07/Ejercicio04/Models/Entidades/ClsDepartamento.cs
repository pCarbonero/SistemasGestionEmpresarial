namespace Ejercicio04.Models.Entidades
{
    public class ClsDepartamento
    {
        #region propiedades 
        public string NombreDepartamento {  get; set; }
        public int IdDepartamento { get; }
        #endregion

        public ClsDepartamento(string nombre, int idDepartamento) {
            NombreDepartamento = nombre;
            IdDepartamento = idDepartamento;
        }
    }
}
