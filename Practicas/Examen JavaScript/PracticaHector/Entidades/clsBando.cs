using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class clsBando
    {
        #region propiedades
        public int Id { get; set; }
        public string Nombre { get; set; }
        #endregion

        #region constructores
        public clsBando() { }
        public clsBando(int id, string nombre)
        {
            Id = id;
            Nombre = nombre;
        }

        public clsBando(string nombre)
        {
            Nombre = nombre;
        }
        #endregion
    }
}
