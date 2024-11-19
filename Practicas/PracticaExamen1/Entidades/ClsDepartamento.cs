using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ClsDepartamento
    {
        #region Propiedades
        public int Id { get; set; }
        public string Nombre { get; set; }
        #endregion

        #region Constructores
        public ClsDepartamento() { }

        public ClsDepartamento(int id, string nombre)
        {
            Id = id;
            Nombre = nombre;
        }
        #endregion
    }
}
