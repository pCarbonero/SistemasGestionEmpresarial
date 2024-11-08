using BL;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MandalorianoMAUI.ViewModel
{
    internal class VerMisionesVM: INotifyPropertyChanged
    {
        private ClsMision misionSeleccionada;
        private bool esTarde = false;

        #region propiedades
        public ClsMision MisionSeleccionada 
        { 
            get {  return misionSeleccionada; }
            set { misionSeleccionada = value; notifyPropertyChanged("MisionSeleccionada"); }
        }
        public List<ClsMision> ListadoMisiones { get; set; }

        public bool EsTarde
        {
            get { return esTarde; }
        }

        public bool EsTemprano
        {
            get { return !esTarde; }
        }


        #endregion

        #region constructores
        public VerMisionesVM() 
        {
            try
            {
                ListadoMisiones = ClsListadosBL.listadoMisionesBL();
            }
            catch (HourException ex)
            {
                esTarde = true;
                notifyPropertyChanged("EsTarde");
            }

        }

        public VerMisionesVM(ClsMision misionSeleccionada) : this() 
        {
            this.MisionSeleccionada = misionSeleccionada;
        }
        #endregion

        #region notify
        public event PropertyChangedEventHandler? PropertyChanged;

        private void notifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
