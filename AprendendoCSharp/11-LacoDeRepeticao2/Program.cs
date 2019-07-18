using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_LacoDeRepeticao2
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor = 1000;

            Console.WriteLine("Execução do projeto 11 - Laco de Repeticao FOR");

            for(int contadorMes = 1; contadorMes <= 12; contadorMes++)
            {
                //valor = valor + valor * 0.0036;
                //valor = valor * 1.0036;
                valor *= 1.0036;
                Console.WriteLine("O valor em " + contadorMes + " meses é de: R$" + valor);
            }

            Console.ReadKey();
        }
    }
}
