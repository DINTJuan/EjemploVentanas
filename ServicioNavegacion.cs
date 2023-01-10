using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploVentanas
{
    class ServicioNavegacion
    {
        public bool? AbrirVentanaHija()
        {
            VentanaHija nueva = new VentanaHija();
            return nueva.ShowDialog();
        }
    }
}
