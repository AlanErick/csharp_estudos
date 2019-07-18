using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_AtribuicoesDeVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Execução do projeto 6");

            int idade = 32;
            int idadeAlan = idade;

            idade = 20;

            Console.WriteLine(idade);
            Console.WriteLine(idadeAlan);

            Console.ReadKey();
        }
    }
}
