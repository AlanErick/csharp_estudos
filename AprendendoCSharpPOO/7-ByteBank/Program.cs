using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------ Agência ByteBank -----------------------");
            Cliente cliente = new Cliente();
            cliente.Nome = "Alan";
            cliente.Cpf = "123.456.789-10";
            cliente.Profissao = "Desenvolvedor C#";
            ContaCorrente conta = new ContaCorrente(4283, 21636);
            ContaCorrente conta2 = new ContaCorrente(4333, 25555);
            conta.Saldo = 1000;
            conta2.Saldo = 200;

            Console.WriteLine("Titular: " + cliente.Nome);
            Console.WriteLine("CPF: " + cliente.Cpf);
            Console.WriteLine("Profissão: " + cliente.Profissao);
            Console.WriteLine("Agencia: " + conta.Agencia);
            Console.WriteLine("Conta: " + conta.Conta);
            Console.WriteLine("Saldo: " + conta.Saldo);

            conta.Depositar(500);
            Console.WriteLine("DEPÓSITO");
            Console.WriteLine("Titular: " + cliente.Nome);
            Console.WriteLine("CPF: " + cliente.Cpf);
            Console.WriteLine("Profissão: " + cliente.Profissao);
            Console.WriteLine("Agencia: " + conta.Agencia);
            Console.WriteLine("Conta: " + conta.Conta);
            Console.WriteLine("Saldo Atualizado: " + conta.Saldo);

            bool status1 = conta.Sacar(550);
            Console.WriteLine("Sacar: " + status1);
            Console.WriteLine("Titular: " + cliente.Nome);
            Console.WriteLine("CPF: " + cliente.Cpf);
            Console.WriteLine("Profissão: " + cliente.Profissao);
            Console.WriteLine("Agencia: " + conta.Agencia);
            Console.WriteLine("Conta: " + conta.Conta);
            Console.WriteLine("Saldo Atualizado: " + conta.Saldo);

            bool status2 = conta.Transferir(150, conta2);
            Console.WriteLine("Transferir: " + status2);
            Console.WriteLine("Titular: " + cliente.Nome);
            Console.WriteLine("CPF: " + cliente.Cpf);
            Console.WriteLine("Profissão: " + cliente.Profissao);
            Console.WriteLine("Agencia: " + conta.Agencia);
            Console.WriteLine("Conta: " + conta.Conta);
            Console.WriteLine("Saldo Atualizado: " + conta.Saldo);
            Console.WriteLine("Saldo da Conta de Destino: " + conta2.Saldo);

            Console.WriteLine("------------------------ FIM -----------------------------");
            Console.ReadKey();
        }
    }
}
