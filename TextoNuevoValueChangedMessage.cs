using Microsoft.Toolkit.Mvvm.Messaging.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploVentanas
{
    public class TextoNuevoValueChangedMessage : ValueChangedMessage<string>
    {
        public TextoNuevoValueChangedMessage(string texto) : base(texto)
        {

        }
    }
}
