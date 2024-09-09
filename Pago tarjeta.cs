using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_No._1_P.A
{
    public class Pago_tarjeta : Pago
    {
        public override bool ProcesarPago(decimal monto)
        {
            Console.WriteLine("Ingrese los detalles de la tarjeta.");
            Console.Write("Número de Tarjeta: ");
            string numeroTarjeta = Console.ReadLine();

            Console.Write("Nombre del Titular: ");
            string nombreTitular = Console.ReadLine();

            Console.Write("Fecha de Vencimiento (MM/AA): ");
            string fechaVencimiento = Console.ReadLine();

            Console.Write("CVV: ");
            string cvv = Console.ReadLine();

            if (numeroTarjeta.Length == 16 && cvv.Length >= 3)             // Validación de la tarjeta
            {
                Console.WriteLine("Pago aprobado.");
                return true;
            }
            else
            {
                Console.WriteLine("Detalles de tarjeta inválidos.");
                return false;
            }
        }
    }
}
