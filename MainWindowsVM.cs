using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using Microsoft.Toolkit.Mvvm.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace EjemploVentanas
{
    class MainWindowsVM : ObservableObject
    {
        public RelayCommand AbrirHijaCommand { get; }

        public RelayCommand UC1Command { get; }
        public RelayCommand UC2Command { get; }
        public RelayCommand CambiarTextoCommand { get; }
        private UserControl contenidoVentana;

        public UserControl ContenidoVentana
        {
            get { return contenidoVentana; }
            set { SetProperty(ref contenidoVentana, value); }
        }
        private ServicioNavegacion navegacion;

        public MainWindowsVM()
        {
            AbrirHijaCommand = new RelayCommand(AbrirHija);
            UC1Command = new RelayCommand(AbrirUC1);
            UC2Command = new RelayCommand(AbrirUC2);
            CambiarTextoCommand = new RelayCommand(CambiarTexto);

            navegacion = new ServicioNavegacion();

            WeakReferenceMessenger.Default.Register<MainWindowsVM, TextoInicialRequestMessage>
                (this, (r, m) =>
                {
                    m.Reply("Que la fuerza te acompañe");
                });
        }

        public void AbrirHija()
        {
            navegacion.AbrirVentanaHija();
        }

        public void AbrirUC1()
        {
            ContenidoVentana = navegacion.ObtenerUC1();
        }

        public void AbrirUC2()
        {
            ContenidoVentana = navegacion.ObtenerUC2();
        }

        public void CambiarTexto()
        {
            WeakReferenceMessenger.Default.Send(new TextoNuevoValueChangedMessage("Este es el camino"));
        }
    }
}
