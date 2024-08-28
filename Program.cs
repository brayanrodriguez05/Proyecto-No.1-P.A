



using Proyecto_No._1_P.A;

List <Vehiculo> listaVehiculos = new List <Vehiculo> ();

int opcion = 0;

do
{
    Console.Clear();
    Console.WriteLine("Bienvenido al menu");
    Console.WriteLine("1. Registrar vehiculos");
    Console.WriteLine("2. Retirar vehiculos");
    Console.WriteLine("3. Visualizacion de vehiculos estacionados");
    Console.WriteLine("4. Visualizacion de espacios disponibles");
    Console.WriteLine("5. Salir");
    Console.Write("Seleccione una de las opciones:");

    int opciones = int.Parse(Console.ReadLine());

    switch (opciones)
    {
        case 1:
            // Registrar vehiculos

            Console.Clear();
            Console.Write("Ingrese el tipo de vehiculo que desea registrar (carro, moto o camion):");
            string tipoVehiculo = Console.ReadLine();

            Console.Write("Ingrese el numero de placa:");
            string placa = Console.ReadLine();

            Console.Write("Ingrese la hora de entrada:");
            DateTime horaEntrada = DateTime.Now;



            Console.ReadKey();
            break;
        case 2:
            // Retirar vehiculos

            Console.Clear();
            Console.Write("Ingrese la placa del vehiculo que desea retirar");

            Console.ReadKey();
            break;
        case 3:
            //Visualizacion de vehiculos estacionados

            Console.Clear();
            Console.ReadKey();
            break;
        case 4:
            // Visualizacion de espacios disponibles

            Console.Clear();
            Console.ReadKey();
            break;
        case 5:
            // Salir del programa

            Console.Clear();
            Console.WriteLine("Saliendo del programa...");
            Console.ReadKey();
            break ;
        default:
            Console.WriteLine("Error. Seleccione una opcion valida");
            break;
    }


} while (opcion != 5);