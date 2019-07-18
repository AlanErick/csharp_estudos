using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_BancoByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();

            conta.nome = "Alan";
            conta.agencia = 4283;
            conta.numero = 21636;
            conta.saldo = 1000;

            Console.WriteLine(conta.nome);
            Console.WriteLine("Agencia: " + conta.agencia);
            Console.WriteLine("Conta: " + conta.numero);
            Console.WriteLine("Saldo: " + conta.saldo);

            conta.saldo += 2000.50;

            Console.WriteLine("Saldo Atualizado: " + conta.saldo);

            Console.ReadKey();
        }
    }
}
