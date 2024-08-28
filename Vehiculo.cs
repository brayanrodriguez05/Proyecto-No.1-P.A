using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_No._1_P.A
{
    public class Vehiculo
    {
        public string Placa { get; set; }
        public string TipoVehiculo { get; set; }
        public DateTime HoraEntrada { get; set; }

        public Vehiculo(string placa, string tipoVehiculo)
        {
            Placa = placa;
            TipoVehiculo = tipoVehiculo;
            HoraEntrada = DateTime.Now;
        }
    }
}
