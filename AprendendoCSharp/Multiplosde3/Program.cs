using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplosde3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Execução dos múltiplos de 3");

            for(int valorT = 1; valorT <= 100; valorT++)
            {
                if(valorT % 3 == 0)
                {
                    Console.WriteLine(valorT);
                }
            }

            Console.ReadKey();
        }
    }
}
