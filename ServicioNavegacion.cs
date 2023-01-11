using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace EjemploVentanas
{
    class ServicioNavegacion
    {
        public bool? AbrirVentanaHija()
        {
            VentanaHija nueva = new VentanaHija();
            return nueva.ShowDialog();
        }

        public UserControl ObtenerUC1()
        {
            return new UserControl1();
        }

        public UserControl ObtenerUC2()
        {
            return new UserControl2();
        }
    }
}
