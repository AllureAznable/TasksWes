using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_93___Exibir_todos_os_números_pares_entre_dois_inteiros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira um número inteiro: ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira um número inteiro: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Os números pares entre {0} e {1} são:", a, b);

            if (a <= b)
            {
                for (int i = a + 1; i < b; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            else
            {
                for (int i = a - 1; i > b; i--)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();
        }
    }
}
