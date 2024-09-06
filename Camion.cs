using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_No._1_P.A
{
    public class Camion : Vehiculo
    {
        public Camion(string placa, string marca, string modelo, string color)
       : base(placa, marca, modelo, color) { }

        public override decimal CalcularTarifa(int horas) // Cuota por hora para camiones
        {
            return horas * 20m;
        }
    }
}
