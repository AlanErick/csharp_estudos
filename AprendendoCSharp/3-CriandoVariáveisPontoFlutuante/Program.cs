﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_CriandoVariáveisPontoFlutuante
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 3 - Criando Variáveis Ponto Flutuante");

            double salario = 1200.7;

            Console.WriteLine(salario);

            double idade;
            idade = 15 / 2;
            Console.WriteLine(idade);

            idade = 15.0 / 2;
            Console.WriteLine(idade);

            idade = 5 / 3;
            Console.WriteLine(idade);

            idade = 5.0 / 3;
            Console.WriteLine(idade);

            Console.WriteLine("Fim da execução, aperte enter para sair ...");
            Console.ReadLine();
        }

    }
}