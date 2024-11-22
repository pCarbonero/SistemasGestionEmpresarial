using BL;
using Entidades;
using Microsoft.VisualBasic;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ExamenUI.Models
{
    public class clsCandidatoConEdad: clsCandidato
    {
        public int Edad {  get; set; }

        /// <summary>
        /// Cosntructor que hereda del padre y además completa el atributo edad
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nombre"></param>
        /// <param name="apellidos"></param>
        /// <param name="direccion"></param>
        /// <param name="nacionalidad"></param>
        /// <param name="telefono"></param>
        /// <param name="fechaNacimiento"></param>
        /// <param name="precioMedio"></param>
        public clsCandidatoConEdad(int id, string nombre, string apellidos, string direccion, string nacionalidad, int telefono, DateTime fechaNacimiento, int precioMedio) 
            : base(id, nombre, apellidos, direccion, nacionalidad, telefono, fechaNacimiento, precioMedio)
        {
            Edad = clsListadosBL.calcularEdadCandidato(FechaNacimiento);
        }
    }
}
