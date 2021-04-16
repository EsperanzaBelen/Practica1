using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    /
    class Program
    {
        static void Main(string[] args)
        {
            var num1 = default(int);
            var num2 = default(int);
            num1 = getNum(1);
            num2 = getNum(2);
            if (num1 == num2)
            {
                Console.WriteLine($"{num1} es igual que {num2}");
            } else if (num2 > num1)
            {
                Console.WriteLine($"{num2} es mayor que {num1}");
            } else
            {
                Console.WriteLine($"{num1} es mayor que {num2}");
            }
            Console.ReadKey();
        }

        /// Comprobación
        static int getNum(int index)
        {
            Console.WriteLine($"Ingrese ún número {index}");
            int num = default(int);
            var line = default(string);
            while (!int.TryParse(line = Console.ReadLine(), out num))
                Console.WriteLine($"{line} no es un número");
            return num;
        }
    }
}
