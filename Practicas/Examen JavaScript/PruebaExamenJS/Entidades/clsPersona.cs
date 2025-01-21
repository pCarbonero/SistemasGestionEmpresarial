namespace Entidades
{
    public class clsPersona
    {
        public int Id { get; set; }
        public string Nombre {  get; set; }
        public string Apellidos { get; set; }
        public int idDept {  get; set; }


        public clsPersona() { }

        public clsPersona(int id, string nombre, string apellidos, int idDept)
        {
            Id = id;
            Nombre = nombre;
            Apellidos = apellidos;
            this.idDept = idDept;
        }
    }
}
