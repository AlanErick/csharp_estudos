using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Condicionais2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Execução do projeto 8 - Condicionais2");

            int idadeAlan = 18;
            int quantidadePessoas = 2;

            bool acompanhado = quantidadePessoas >= 2;

            if (idadeAlan >= 18 && acompanhado == true)
            {
                Console.WriteLine("Alan pode entrar.");
            }
            else
            {
                Console.WriteLine("Alan não pode entrar.");

            }
            Console.ReadKey();
        }
    }
}
