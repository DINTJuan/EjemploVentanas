using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploVentanas
{
    class UserControl1VM : ObservableRecipient
    {
        private string mensaje;

        public string Mensaje
        {
            get { return mensaje; }
            set { SetProperty(ref mensaje, value); }
        }

        public UserControl1VM()
        {
            Mensaje = WeakReferenceMessenger.Default.Send<TextoInicialRequestMessage>();

            WeakReferenceMessenger.Default.Register<TextoNuevoValueChangedMessage>
                (this, (r, m) =>
                {
                    Mensaje = m.Value;
                });
        }
    }
}
