using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_CaracteresETextos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Execução do projeto 5 - Caracters e Textos");

            char palavra = 'a';
            Console.WriteLine(palavra);

            palavra = (char)65;
            Console.WriteLine(palavra);

            palavra = (char)(palavra + 1);
            Console.WriteLine(palavra);

            //o @ faz com que o texto fique exatamente como está escrito no código
            Console.WriteLine(@" 
                    -Alan
                    -Erick
                    -Eremita 
                    -Dias");

            Console.ReadKey();
        }
    }
}
