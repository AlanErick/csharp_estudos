using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Escopo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Execução do projeto 9 - Escopo");

            int idadeAlan = 18;
            bool acompanhado = false;
            string textoAdicional;

            textoAdicional = "Alan não está acompanhado!";

            if (acompanhado)
            {
                textoAdicional = "Alan está acompanhado.";
            }

            if (idadeAlan >= 18 || acompanhado)
            {
                Console.WriteLine("Alan pode entrar.");
                Console.WriteLine(textoAdicional);
            }
            else
            {
                Console.WriteLine("Alan não pode entrar.");
            }
            Console.ReadKey();
        }
    }
}
