namespace ListadoPersonas.Entidades
{
    public class ClsPersona
    {
        #region Propiedades
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        
        #endregion

        #region constructores
        public ClsPersona(string firstName,string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        public ClsPersona() { }
        #endregion
    }
}
