using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taks4___Maior_entre_dois_num_inteiros
{
    internal class Program
    {
        static void Main(string[] args)
        {
        int a = 10;
        int b = 20;

            if (a > b) 
            {
                Console.WriteLine(a + " é maior");
            }
            else if (b > a)
            {
                Console.WriteLine(b + " é maior");
            }
            Console.ReadLine();
        }
    }
}
