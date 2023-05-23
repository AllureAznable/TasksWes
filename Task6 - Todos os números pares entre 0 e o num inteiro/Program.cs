using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6___Todos_os_números_pares_entre_0_e_o_num_inteiro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Esse foi complicado, porque não sei se é a minha máquina, mas toda vez que exibe, fecha só
            Console.WriteLine("Insira um número inteiro: ");
            int numero = int.Parse(Console.ReadLine());

            Console.WriteLine("Os números pares entre 0 e {0} são:", numero);

            for (int i = 0; i <= numero; i+= 2) 
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            Console.ReadLine();
        }
    }
}
