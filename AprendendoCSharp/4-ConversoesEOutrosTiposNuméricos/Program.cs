using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ConversoesEOutrosTiposNuméricos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Execução do projeto 4 - Conversoes e outros tipos numéricos");

            double salario = 1200.50;

            Console.WriteLine(salario);
            //Para converter, basta deixar explícitio o tipo desejado em um parênteses que precede à variável.

            //o tipo int armazena uma variável de 32 bits
            int salarioEmInteiro = (int)salario;

            Console.WriteLine(salarioEmInteiro);

            //o tipo long armazena uma variável de 64 bits
            long idadel = 15000000000;
            Console.WriteLine(idadel);

            //o tipo short armazena uma variável de 16 bits
            short idades = 15000;
            Console.WriteLine(idades);

            //A precisao em casas decimais depois do ponto é bem menor que a do double
            float altura = 1.80f;//Deve-se colocar o f depois do valor da variável para que o C# n interprete como um double
            Console.WriteLine(altura);

            Console.ReadKey();

        }
    }
}
