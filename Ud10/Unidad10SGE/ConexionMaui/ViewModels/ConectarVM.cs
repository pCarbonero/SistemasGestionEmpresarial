using DAL;
using BL;
using Entidades;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Unidad10SGE.ConexionMaui.ViewModels.Utilities;

namespace ConexionMaui.ViewModels
{
    internal class ConectarVM : INotifyPropertyChanged
    {
        #region atributos
        //private DelegateCommand conectarCommand;
       // private string mensaje = "";
        #endregion

        #region propiedades
        //public string Mensaje { get { return mensaje; } }
        public List<clsPersona> listadoPersonas { get; }

        //public DelegateCommand ConectarCommannd { get { return conectarCommand; } }
        #endregion

        #region constructores
        public ConectarVM() 
        { 
           // conectarCommand = new DelegateCommand(executeConectar);
            //listadoPersonas = clsListadosBL.listadoCompletoPersonasBL();
        }
        #endregion

        #region notify
        public event PropertyChangedEventHandler? PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new
            PropertyChangedEventArgs(propertyName));
        }
        #endregion

        #region comandos
        /*private void executeConectar()
        {
            SqlConnection sqlConnect = new SqlConnection();
            clsMyConnection connection = new clsMyConnection();
            try
            {
                sqlConnect = connection.getConnection();
                mensaje = "BIEN";
            }
            catch (Exception ex)
            {
                mensaje = "AAA  " + ex.Message;
            }
            finally { NotifyPropertyChanged("Mensaje");}
        }

        private bool canExecuteConectar()
        {
            return true;
        }
        */

        #endregion
    }
}
