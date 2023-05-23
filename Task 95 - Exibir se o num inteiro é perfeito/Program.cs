using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_95___Exibir_se_o_num_inteiro_é_perfeito
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira um número inteiro: ");
            int num = Convert.ToInt32(Console.ReadLine());

            bool resultado = VerificarNumeroPerfeito(num);

            if (resultado)
            {
                Console.WriteLine("{0} é um valor perfeito", num);
            }
            else
            {
                Console.WriteLine("{0} não é um valor perfeito", num);
            }
            Console.ReadLine();
        }

        static bool VerificarNumeroPerfeito(int num)
        {
            int somadosDivisores = 0;

            for (int i = 1; i < num; i++)
            {
                if (num % i == 0)
                {
                    somadosDivisores += i;
                }
            }

            return somadosDivisores == num;
        }
    }
}
