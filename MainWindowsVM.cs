using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploVentanas
{
    class MainWindowsVM : ObservableObject
    {
        public RelayCommand AbrirHijaCommand { get; }

        private ServicioNavegacion navegacion;

        public MainWindowsVM()
        {
            AbrirHijaCommand = new RelayCommand(AbrirHija);
            navegacion = new ServicioNavegacion();
        }

        public void AbrirHija()
        {
            navegacion.AbrirVentanaHija();
        }
    }
}
