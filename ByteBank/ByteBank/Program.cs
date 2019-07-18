using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            // o atalho ctlr + . é equivalente ao atalho ctrl + espaço do Java
            Funcionario alan = new Funcionario(1000,"123.456.789-10");

            alan.Nome = "Alan";

            //alan.Salario = 1000;
            gerenciador.Registrar(alan);

            Console.WriteLine(alan.Nome);
            Console.WriteLine(alan.GetBonificacao());

            Diretor erick = new Diretor(20000, "987.654.321-10");
            //Diretor erickTeste = erick; //polimorfismo
            Diretor erickTeste = new Diretor(15000,"123.654.789-10");

            Console.WriteLine("Total de Funcionarios: " + Funcionario.TotalFuncionarios);

            erick.Nome = "Erick";
            //erick.Salario = 20000;
            gerenciador.Registrar(erick);

            Console.WriteLine("Salário de Diretor: " + erick.Salario);
            Console.WriteLine("Salário de Diretor: " + erick.Salario);

            Console.WriteLine("Bonificação de Diretor: " + erick.GetBonificacao());
            Console.WriteLine("Bonificação de Diretor: " + erickTeste.GetBonificacao());

            Console.WriteLine(erick.Nome);
            Console.WriteLine(erick.GetBonificacao());

            Console.WriteLine("Total de bonificação: " + gerenciador.GetTotalBonificacao());

            Console.ReadKey();
        }
    }
}
