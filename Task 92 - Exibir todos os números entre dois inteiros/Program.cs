using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_92___Exibir_todos_os_números_entre_dois_inteiros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira um número inteiro: ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira um número inteiro: ");
            int b = int.Parse(Console.ReadLine());

            if (a <= b)
            {
                for (int i = a + 1; i < b; i++)
                {
                    Console.WriteLine(i);
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
