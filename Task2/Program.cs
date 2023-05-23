using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe um número inteiro:");
            int numero = int.Parse(Console.ReadLine());

            if (numero > 0)
            {
                Console.WriteLine("O número informado é positivo");
            }
            else if (numero < 0) 
            { 
                Console.WriteLine("O número informado é negativo");
            }
            else 
            {
                Console.WriteLine("O número informado é zero");
            }
                Console.ReadLine();
        }
    }
}
