using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Execução do projeto 7 - Condicionais");

            int idadeAlan = 17;
            int quantidadePessoas = 2;

            if(idadeAlan >= 18)
            {
                Console.WriteLine("Alan possui 18 anos ou mais, pode entrar.");
            }        
            else
            {
                if (quantidadePessoas >= 2)
                {
                    Console.WriteLine("Alan não possui 18 anos ou mais, mas está acompanhado, pode entrar.");
                }
                else
                {
                    Console.WriteLine("Alan não possui 18 anos ou mais, não pode entrar.");
                }
            }
            Console.ReadKey();
       }
    }
}




