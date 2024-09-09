using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_No._1_P.A
{
    public class Pago_efectivo : Pago
    {
        public override bool ProcesarPago(decimal monto)
        {
            Console.Write("Ingrese el monto entregado: ");
            decimal montoEntregado = decimal.Parse(Console.ReadLine());

            if (montoEntregado < monto)
            {
                Console.WriteLine("Monto insuficiente.");
                return false;
            }

            decimal cambio = montoEntregado - monto;
            Console.WriteLine($"Cambio a devolver: {cambio:C}");

            if (cambio > 0)
            {
                CalcularCambio(cambio);
            }

            return true;
        }

        private void CalcularCambio(decimal cambio)
        {
            int[] billetes = { 200, 100, 50, 20, 10, 5, 1 };
            int[] cantidadBilletes = new int[billetes.Length];

            for (int i = 0; i < billetes.Length; i++)
            {
                if (cambio >= billetes[i])
                {
                    cantidadBilletes[i] = (int)(cambio / billetes[i]);
                    cambio %= billetes[i];
                }
            }

            Console.WriteLine("Cambio a devolver en billetes:");
            for (int i = 0; i < billetes.Length; i++)
            {
                if (cantidadBilletes[i] > 0)
                {
                    Console.WriteLine($"Q{billetes[i]}: {cantidadBilletes[i]} billete(s)");
                }
            }
        }
    }
}
