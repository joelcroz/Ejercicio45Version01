using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio45Version01
{
    class Program
    {
        static void Main(string[] args)
        {

            var suma = 0;
			suma = 0;
            for (int contador = 1; contador <= 5; contador++)
            {
				Console.Write($"Ingrese el {contador}º nùmero:");
                int numeroIngresado = Convert.ToInt32(Console.ReadLine());
                suma += numeroIngresado;
            }

            Console.WriteLine($"El resultado de la suma es {suma}");
            Console.ReadLine();
		}
    }
}
