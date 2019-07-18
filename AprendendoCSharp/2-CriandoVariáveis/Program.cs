using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_CriandoVariáveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 2 - Criando Variáveis");

            int idade;
            idade = 32;

            Console.WriteLine("\nIdade " + idade);

            idade = 10 + 5;
            Console.WriteLine("\nIdade " + idade);

            idade = 10 + 5 * 2;
            Console.WriteLine("\nIdade " + idade);

            idade = (10 + 5) * 2;
            Console.WriteLine("\nIdade " + idade);

            Console.WriteLine("\nAperte enter para sair ...");
            Console.ReadLine();
        }
    }
}
