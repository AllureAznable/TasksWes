using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8___Todos_os_números_divisíveis_por_3_entre_0_e_o_inteiro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira um número inteiro: ");
            int numero = int.Parse(Console.ReadLine());

            Console.WriteLine("Os números que dividem por 3 entre 0 e {0} são:", numero);

            for (int i = 0; i <= numero; i++)
            {
                if (i % 3 == 0)
                { 
                Console.WriteLine(i);
                }
            }

            Console.ReadLine();
        }
    }
}
