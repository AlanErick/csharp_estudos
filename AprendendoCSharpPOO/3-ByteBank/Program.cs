using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();
            conta.nome = "Alan";
            conta.agencia = 4283;
            conta.numero = 21636;

            ContaCorrente conta2 = new ContaCorrente();
            conta.nome = "Erick";
            conta.agencia = 4283;
            conta.numero = 21636;
            
            /* Aqui o resultado apresentado será false porque estão sendo comparadas as referências dos objetos
             * Por exemplo, quando declaramos conta e conta2, nao estamos inserindo valores nas variáveis e sim
             * as referencias das instancias dos objetos na memória
             */
            Console.WriteLine("Igualdade por referência: " + (conta == conta2));

            int idade = 1;
            int idade2 = 1;

            // Aqui o resultado vai ser true, pois estamos comparando os valores na memória
            Console.WriteLine("Igualdade por valor: " + (idade == idade2));

            /* Neste codigo indexamos as referências como as mesmas, por exemplo, se for imprimir o objeto
             * será o mesmo para as duas variáveis
             */
            conta = conta2;

            //Como os valores de referências serão os mesmos, o resultado da expressão abaixo será true
            Console.WriteLine("Igualdade por referência: " + (conta == conta2));

            Console.ReadKey();
        }
    }
}
