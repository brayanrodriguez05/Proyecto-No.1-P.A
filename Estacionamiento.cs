using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_No._1_P.A
{
    public class Estacionamiento
    {
        private List<Vehiculo> carrosEstacionados = new List<Vehiculo>();
        private List<Vehiculo> motosEstacionadas = new List<Vehiculo>();
        private List<Vehiculo> camionesEstacionados = new List<Vehiculo>();

        private int capacidadCarros = 5;
        private int capacidadMotos = 3;
        private int capacidadCamiones = 2;

        public bool RegistrarVehiculo(Vehiculo vehiculo)
        {
            if (vehiculo is Carro)
            {
                if (carrosEstacionados.Count >= capacidadCarros)
                {
                    Console.WriteLine("Estacionamiento de carros lleno.");
                    return false;
                }
                carrosEstacionados.Add(vehiculo);
            }
            else if (vehiculo is Moto)
            {
                if (motosEstacionadas.Count >= capacidadMotos)
                {
                    Console.WriteLine("Estacionamiento de motos lleno.");
                    return false;
                }
                motosEstacionadas.Add(vehiculo);
            }
            else if (vehiculo is Camion)
            {
                if (camionesEstacionados.Count >= capacidadCamiones)
                {
                    Console.WriteLine("Estacionamiento de camiones lleno.");
                    return false;
                }
                camionesEstacionados.Add(vehiculo);
            }

            Console.WriteLine("Vehículo registrado exitosamente.");
            return true;
        }

        public bool RetirarVehiculo(string placa)
        {
            Vehiculo vehiculo = BuscarVehiculoPorPlaca(placa);
            if (vehiculo == null)
            {
                Console.WriteLine("Vehículo no encontrado.");
                return false;
            }

            int horasEstacionado = (int)Math.Ceiling((DateTime.Now - vehiculo.HoraEntrada).TotalHours);
            decimal tarifa = vehiculo.CalcularTarifa(horasEstacionado);
            Console.WriteLine($"Tarifa a pagar: {tarifa:C}");

            // Eliminar el vehículo de la lista correspondiente
            if (vehiculo is Carro)
                carrosEstacionados.Remove(vehiculo);
            else if (vehiculo is Moto)
                motosEstacionadas.Remove(vehiculo);
            else if (vehiculo is Camion)
                camionesEstacionados.Remove(vehiculo);

            return true;
        }

        public void MostrarVehiculosEstacionados()
        {
            Console.WriteLine("Carros estacionados:");
            foreach (var vehiculo in carrosEstacionados)
            {
                Console.WriteLine($"{vehiculo.Placa} - {vehiculo.Marca} {vehiculo.Modelo} ({vehiculo.Color})");
            }
            Console.WriteLine("\nMotos estacionadas:");
            foreach (var vehiculo in motosEstacionadas)
            {
                Console.WriteLine($"{vehiculo.Placa} - {vehiculo.Marca} {vehiculo.Modelo} ({vehiculo.Color})");
            }
            Console.WriteLine("\nCamiones estacionados:");
            foreach (var vehiculo in camionesEstacionados)
            {
                Console.WriteLine($"{vehiculo.Placa} - {vehiculo.Marca} {vehiculo.Modelo} ({vehiculo.Color})");
            }
        }

        public void MostrarEspaciosDisponibles()
        {
            Console.WriteLine($"Espacios disponibles para carros: {capacidadCarros - carrosEstacionados.Count}");
            Console.WriteLine($"Espacios disponibles para motos: {capacidadMotos - motosEstacionadas.Count}");
            Console.WriteLine($"Espacios disponibles para camiones: {capacidadCamiones - camionesEstacionados.Count}");
        }

        private Vehiculo BuscarVehiculoPorPlaca(string placa)
        {
            return carrosEstacionados.FirstOrDefault(v => v.Placa == placa)
                ?? motosEstacionadas.FirstOrDefault(v => v.Placa == placa)
                ?? camionesEstacionados.FirstOrDefault(v => v.Placa == placa);
        }
    }
}
