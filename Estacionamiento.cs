using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_No._1_P.A
{
    public class Estacionamiento
    {
        private List<Vehiculo> vehiculosEstacionados = new List<Vehiculo>();
        private int capacidadMaxima = 50;

        public bool RegistrarVehiculo(Vehiculo vehiculo)
        {
            if (vehiculosEstacionados.Count >= capacidadMaxima)
            {
                Console.WriteLine("Estacionamiento lleno. No se puede registrar el vehículo.");
                return false;
            }
            vehiculosEstacionados.Add(vehiculo);
            Console.WriteLine("Vehículo registrado exitosamente.");
            return true;
        }

        public bool RetirarVehiculo(string placa)
        {
            var vehiculo = vehiculosEstacionados.FirstOrDefault(v => v.Placa == placa);
            if (vehiculo == null)
            {
                Console.WriteLine("Vehículo no encontrado.");
                return false;
            }

            int horasEstacionado = (int)Math.Ceiling((DateTime.Now - vehiculo.HoraEntrada).TotalHours);
            decimal tarifa = vehiculo.CalcularTarifa(horasEstacionado);
            Console.WriteLine($"Tarifa a pagar: {tarifa:C}");

            vehiculosEstacionados.Remove(vehiculo);
            Console.WriteLine("Vehículo retirado exitosamente.");
            return true;
        }

        public void MostrarVehiculosEstacionados()
        {
            foreach (var vehiculo in vehiculosEstacionados)
            {
                Console.WriteLine($"{vehiculo.Placa} - {vehiculo.Marca} {vehiculo.Modelo} ({vehiculo.Color})");
            }
        }

        public void MostrarEspaciosDisponibles()
        {
            Console.WriteLine($"Espacios disponibles: {capacidadMaxima - vehiculosEstacionados.Count}");
        }
    }
}
