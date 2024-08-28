using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_No._1_P.A
{
    public class Estacionamiento
    {
        private List<Vehiculo> vehiculosEstacionados;
        private int capacidadMaxima;

        public Estacionamiento(int capacidad)
        {
            capacidadMaxima = capacidad;
            vehiculosEstacionados = new List<Vehiculo>();
        }

        public bool RegistrarVehiculo(Vehiculo vehiculo)
        {
            if (vehiculosEstacionados.Count < capacidadMaxima)
            {
                vehiculosEstacionados.Add(vehiculo);
                Console.WriteLine("Vehiculo registrado con exito.");
                return true;
            }
            else
            {
                Console.WriteLine("No hay espacios disponibles.");
                return false;
            }
        }

        public bool RetirarVehiculo(string placa)
        {
            Vehiculo vehiculo = vehiculosEstacionados.Find(v => v.Placa == placa);
            if (vehiculo != null)
            {
                vehiculosEstacionados.Remove(vehiculo);
                Console.WriteLine("Vehiculo retirado exitosamente.");
                return true;
            }
            else
            {
                Console.WriteLine("Vehiculo no encontrado. ");
                return false;
            }
        }

        public int ObtenerEspaciosDisponibles()
        {
            return capacidadMaxima - vehiculosEstacionados.Count;
        }

        public void MostrarVehiculosEstacionados()
        {
            Console.WriteLine("Estos son los vehiculos que estan estan estacionados actualmente:");
            foreach (Vehiculo vehiculo in vehiculosEstacionados)
            {
                Console.WriteLine($"Placa: {vehiculo.Placa}, Tiopo Vehiculo: {vehiculo.TipoVehiculo}, Hora de entrada: {vehiculo.HoraEntrada}");
            }
        }
    }  
}
