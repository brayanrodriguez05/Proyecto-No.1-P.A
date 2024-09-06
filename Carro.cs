using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_No._1_P.A
{
    public class Carro : Vehiculo
    {
        public Carro (string placa, string marca, string modelo, string color)
       : base(placa, marca, modelo, color) { }

        public override decimal CalcularTarifa(int horas) // Cuota por hora para carros
        {
            return horas * 10m; 
        }
    }

}
