

using Proyecto_No._1_P.A;

Estacionamiento estacionamiento = new Estacionamiento();
bool ejecutando = true;

while (ejecutando)
{
    Console.Clear();
    Console.WriteLine("-----------------------");
    Console.WriteLine("Bienvenido al CityPark ");
    Console.WriteLine("----------------------- \n");
    Console.WriteLine("Menú Principal:");
    Console.WriteLine("1. Registrar un nuevo vehículo");
    Console.WriteLine("2. Retirar un vehículo");
    Console.WriteLine("3. Ver vehículos estacionados");
    Console.WriteLine("4. Ver espacios disponibles");
    Console.WriteLine("5. Salir");
    Console.Write("Seleccione una opción: ");
    string opcion = Console.ReadLine();

    switch (opcion)
    {
        case "1":
            RegistrarVehiculo(estacionamiento);
            Console.ReadKey();
            break;
        case "2":
            RetirarVehiculo (estacionamiento);
            Console.ReadKey();
            break;
        case "3":
            estacionamiento.MostrarVehiculosEstacionados();
            Console.ReadKey();
            break;
        case "4":
            estacionamiento.MostrarEspaciosDisponibles();
            Console.ReadKey();
            break;
        case "5":
            ejecutando = false;
            Console.ReadKey();
            break;
        default:
            Console.WriteLine("Opción no válida.");
            break;
    }
}

    static void RegistrarVehiculo(Estacionamiento estacionamiento)
{
    Console.WriteLine("Ingrese los detalles del vehículo:");
    Console.WriteLine("Tipo de vehículo (1. Auto, 2. Moto, 3. Camión): ");
    string tipo = Console.ReadLine();
    Console.Write("Placa: ");
    string placa = Console.ReadLine();
    Console.Write("Marca: ");
    string marca = Console.ReadLine();
    Console.Write("Modelo: ");
    string modelo = Console.ReadLine();
    Console.Write("Color: ");
    string color = Console.ReadLine();

    Vehiculo vehiculo;
    switch (tipo)
    {
        case "1":
            Console.Clear();
            vehiculo = new Carro(placa, marca, modelo, color);
            Console.ReadKey();
            break;
        case "2":
            Console.Clear();
            vehiculo = new Moto(placa, marca, modelo, color);
            Console.ReadKey();
            break;
        case "3":
            Console.Clear();
            vehiculo = new Camion(placa, marca, modelo, color);
            Console.ReadKey();
            break;
        default:
            Console.WriteLine("Tipo de vehículo no válido.");
            return;
    }

    estacionamiento.RegistrarVehiculo(vehiculo);
}
    static void RetirarVehiculo(Estacionamiento estacionamiento)
    {
        Console.Write("Ingrese la placa del vehículo que desea retirar: ");
        string placa = Console.ReadLine();

        if (estacionamiento.RetirarVehiculo(placa))
        {
            Console.WriteLine("Seleccione método de pago (1. Efectivo, 2. Tarjeta): ");
            string metodoPago = Console.ReadLine();
            Pago pago;

            switch (metodoPago)
            {
                case "1":
                Console.Clear();
                    pago = new Pago_efectivo();
                Console.ReadKey();
                    break;
                case "2":
                Console.Clear();
                    pago = new Pago_tarjeta();
                Console.ReadKey();
                    break;
                default:
                    Console.WriteLine("Método de pago no válido.");
                    return;
            }

            if (pago.ProcesarPago(10))                                      // Ejemplo de monto.
            {
                Console.WriteLine("Pago exitoso. Vehículo retirado.");
            }
            else
            {
                Console.WriteLine("Pago fallido. Intente nuevamente.");
            }
        }
    }
