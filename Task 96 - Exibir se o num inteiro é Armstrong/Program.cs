using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_96___Exibir_se_o_num_inteiro_é_Armstrong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, resto, sum = 0;
            Console.Write("Insira um valor: ");

            num = int.Parse(Console.ReadLine());
            for (int i = num; i > 0; i = i / 10)
            {
                resto = i % 10;
                sum = sum + resto * resto * resto;
            }

            if (sum == num)
            {
                Console.WriteLine("O valor inserido é um número Armstrong");
            }
            else
                Console.WriteLine("O valor inserido não é um número Armstrong");
            Console.ReadLine();
        }
    }
}
