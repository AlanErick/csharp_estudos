using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();
            Cliente cliente = new Cliente();

            //Não acessa o valor de saldo pois o atributo é privado (private)
            //Console.WriteLine(conta.saldo);

            //conta.SetSaldo(-10); //para definir o valor (SETar o valor)

            //Console.WriteLine(conta.GetSaldo());

            //SIMPLIFICANDO O get E O set
            conta.Saldo = -10;
            Console.WriteLine(conta.Saldo);

            cliente.Nome = "Alan";
            cliente.Cpf = "123.456.789-10";
            cliente.Profissao = "Desenvolvedor C#";
            
            Console.ReadKey();
        }
    }
}
