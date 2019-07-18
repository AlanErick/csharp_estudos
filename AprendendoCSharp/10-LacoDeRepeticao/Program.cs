using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_LacoDeRepeticao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Execução do projeto 10 - Laco de Repeticao");

            double valor = 1000;
            int contadorMes = 1;

            while(contadorMes <= 12)
            {
                valor = valor + valor * 0.0036;
                Console.WriteLine("O valor em " + contadorMes + " meses é de: R$" + valor);
                //contadorMes = contadorMes + 1;
                //contadorMes += 1;
                contadorMes++;
            }

            Console.ReadKey();
        }
    }
}
