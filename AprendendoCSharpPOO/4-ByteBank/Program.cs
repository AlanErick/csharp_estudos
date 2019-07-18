using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();

            conta.nome = "Alan";

            Console.WriteLine("Saldo: " + conta.saldo);
            bool status = conta.Sacar(500);
            Console.WriteLine("Saldo Atualizado: " + conta.saldo);
            Console.WriteLine("Status função Sacar(): " + status);

            Console.WriteLine("Saldo: " + conta.saldo);
            status = conta.Sacar(1500); // Não foi necessário a declaração da variável novamente, pois seu estado 
                                        // irá se alterar
            Console.WriteLine("Saldo Atualizado: " + conta.saldo);
            Console.WriteLine("Status função Sacar(): " + status);

            conta.Depositar(5000);
            Console.WriteLine("Saldo Atualizado: " + conta.saldo);

            ContaCorrente conta2 = new ContaCorrente();
            conta2.nome = "Erick";

            Console.WriteLine("Saldo Atual Alan: " + conta.saldo);
            Console.WriteLine("Saldo Atual Erick: " + conta2.saldo);

            bool status2 = conta.Transferir(100, conta2);

            Console.WriteLine("Status Transferência: " + status2);
            Console.WriteLine("Saldo Atualizado Alan: " + conta.saldo);
            Console.WriteLine("Saldo Atualizado Erick: " + conta2.saldo);
                                
            Console.ReadKey();
        }
    }
}
