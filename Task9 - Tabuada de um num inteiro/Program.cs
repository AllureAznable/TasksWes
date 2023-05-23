using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9___Tabuada_de_um_num_inteiro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira um número inteiro: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1;i<=10;i++)
                Console.WriteLine(n + "x" + i + " = " + (n*i));
            Console.ReadLine();
        }
    }
}
