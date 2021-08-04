using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***************************************");
            Console.WriteLine("*********     Exercicio 5     *********");
            Console.WriteLine("***************************************");

            Console.WriteLine("");

            int num1;
            
            Console.Write("Digite um número: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("");

            Console.WriteLine("***************************************");

            Console.WriteLine($"O antecessor ao número {num1} é o número {num1 - 1} .");

            Console.WriteLine("***************************************");

            Console.WriteLine("");

            Console.ReadKey();

        }
    }
}
