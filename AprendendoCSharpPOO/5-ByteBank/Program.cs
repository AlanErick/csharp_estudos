using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente alan = new Cliente();

            alan.nome = "Alan";
            alan.profissao = "Desenvolvedor C#";
            alan.cpf = "123.456.789-11";

            ContaCorrente conta = new ContaCorrente();

            conta.titular = alan;
            conta.agencia = 4283;
            conta.numero = 21636;
            conta.saldo = 1000;

            Console.WriteLine("Titular: " + alan.nome);
            Console.WriteLine("Titular: " + conta.titular.nome);

            Console.ReadKey();
        }
    }
}
