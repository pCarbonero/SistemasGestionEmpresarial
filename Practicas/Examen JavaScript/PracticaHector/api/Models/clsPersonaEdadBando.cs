using BL;
using DAL;
using Entidades;
using BL;

namespace api.Models
{
    public class clsPersonaEdadBando: clsPersonaje
    {
        public string NombreBando { get; set; }
        public int Edad { get; set; }


        public clsPersonaEdadBando() { }

        public clsPersonaEdadBando(clsPersonaje personaje)
        {
            Id = personaje.Id;
            Nombre = personaje.Nombre;
            FechaNacimiento = personaje.FechaNacimiento;
            IdBando = personaje.IdBando;

            NombreBando = getNombreBando(IdBando);
            Edad = calcularEdad(FechaNacimiento);
        }

        private string getNombreBando(int id)
        {
            string nombre = "";

            clsBando bando = clsListadosBL.getBando(id);

            nombre = bando.Nombre;

            return nombre;
        }

        private int calcularEdad(DateTime fecha)
        {
            int edad = 0;

            edad = DateTime.Now.Year - fecha.Year;

            return edad;
        }
    }
}
