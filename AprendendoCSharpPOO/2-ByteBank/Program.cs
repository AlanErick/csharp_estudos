using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();

            conta.nome = "Erick";

            Console.WriteLine(conta.nome);
            Console.WriteLine(conta.saldo);
            Console.WriteLine(conta.numero);

            Console.ReadKey();
        }
    }
}
