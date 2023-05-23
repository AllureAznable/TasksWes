using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7___Todos_os_números_ímpares_entre_0_e_ele
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira um número inteiro: ");
            int numero = int.Parse(Console.ReadLine());

            Console.WriteLine("Os números ímpares entre 0 e {0} são:", numero);

            for (int i = 1; i <= numero; i += 2)
            {
                    Console.WriteLine(i);
            }

            Console.ReadLine();
        }
    }
}
