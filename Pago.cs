using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_No._1_P.A
{
   public class Pago
    {
        public double Efectivo { get; set; }
        public double Tarjeta { get; set; }

        public Pago(double efectivo, double tarjeta)
        {
            Efectivo = efectivo;
            Tarjeta = tarjeta;
        }
    }
}
