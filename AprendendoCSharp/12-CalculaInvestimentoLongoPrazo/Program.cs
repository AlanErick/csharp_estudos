using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_CalculaInvestimentoLongoPrazo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Execução do projeto 12 - Encadeando laco FOR");

            double valor = 1000;
            double fatorInvestimento = 1.0036;

            for(int contadorAno = 1; contadorAno <=5; contadorAno++)
            {
                for(int contadorMes = 1; contadorMes <= 12; contadorMes++)
                {
                    valor *= fatorInvestimento;
                }
                fatorInvestimento += 0.0010;
            }
            Console.WriteLine("O valor ao término do investimento será de R$" + valor);
            Console.ReadKey();
        }
    }
}
