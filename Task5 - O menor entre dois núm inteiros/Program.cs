using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5___O_menor_entre_dois_núm_inteiros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira um número inteiro: ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira um número inteiro: ");
            int b = int.Parse(Console.ReadLine());

            if (a < b)
            {
                Console.WriteLine(a + " é menor");
            }
            else if (b < a)
            {
                Console.WriteLine(b + " é menor");
            }
            Console.ReadLine();
        }
    }
}
