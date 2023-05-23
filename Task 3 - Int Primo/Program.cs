using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3___Int_Primo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe um número inteiro:");
            int numero = int.Parse(Console.ReadLine());

            bool ehPrimo = true;

            if (numero == 1)
            {
                ehPrimo = false;
            }
            else
            {
                for (int i = 2; i <= Math.Sqrt(numero); i++)
                {
                    if (numero % i == 0)
                    {
                        ehPrimo = false;
                        break;
                    }
                }
            }
        
        if (ehPrimo)
        { 
            Console.WriteLine("O número é primo");
        }
        else
        {
            Console.WriteLine("O número não é primo");
        }
            Console.ReadLine();
    }
} 
