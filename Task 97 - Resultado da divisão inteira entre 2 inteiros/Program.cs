using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_97___Resultado_da_divisão_inteira_entre_2_inteiros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira um número inteiro: ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira um número inteiro: ");
            int b = int.Parse(Console.ReadLine());

            if (b != 0)
            {
                int resultado = a / b;
                Console.WriteLine("O resultado da divisão inteira entre {0} e {1} é: {2}", a, b, resultado);
            }
            Console.ReadLine();
        }
    }
}
