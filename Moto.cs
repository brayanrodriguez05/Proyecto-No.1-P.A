using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_No._1_P.A
{
    public class Moto : Vehiculo
    {
        public Moto(string placa, string marca, string modelo, string color)
        : base(placa, marca, modelo, color) { }

        public override decimal CalcularTarifa(int horas) // Cuota por hora para motos
        {
            return horas * 5m; 
        }
    }
}
