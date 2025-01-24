using BL;
using Entidades;

namespace ExamenAsp.Models
{
    public class clsPersonaNombreDept: clsPersona
    {
        #region propiedades
        public string NombreDepartamento { get; set; }
        #endregion

        #region constructores
        public clsPersonaNombreDept() { }

        public clsPersonaNombreDept(clsPersona persona)
        {
            Id = persona.Id;
            Nombre = persona.Nombre;
            Apellidos = persona.Apellidos;
            FechaNacimiento = persona.FechaNacimiento;
            Telefono = persona.Telefono;
            IdDepartamento = persona.IdDepartamento;
            NombreDepartamento = clsListadosBL.getDepartamentoIdBL(IdDepartamento).Nombre;
        }
        #endregion
    }
}
