using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasksWes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Andei pesquisando nessa parte e muitos insistiam em "Convert.ToInt32",
            //mas vi que não vale a pena, então segui pelo Int.Parse 
            Console.WriteLine("Informe um número inteiro:");
            int numero = int.Parse(Console.ReadLine()); 

            if (numero % 2 == 0)
            {
                Console.WriteLine("O número informado é par");
            }
            else
            {
                Console.WriteLine("O número informado é ímpar");
            }
            Console.ReadLine();
        }
    }
}
