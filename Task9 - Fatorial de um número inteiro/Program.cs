using System;

namespace Task9___Fatorial_de_um_número_inteiro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira um número inteiro:");
            int num = Convert.ToInt32(Console.ReadLine());

            long fat = CalculoFatorial(num);

            Console.WriteLine("O fatorial de {0} é {1}", num, fat);
            Console.ReadLine();
        }
        static long CalculoFatorial(int num) 
        {
            if (num == 0 || num == 1)
                return 1;

            long resultado = 1;

            for (int i = 2; i <= num; i++) 
            { 
                resultado *= i;
            }

            return resultado;
        }

    }
}
