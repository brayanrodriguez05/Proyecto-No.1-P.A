﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_No._1_P.A
{
   public abstract class Pago
    {
        public abstract bool ProcesarPago(decimal monto);
    }
}
