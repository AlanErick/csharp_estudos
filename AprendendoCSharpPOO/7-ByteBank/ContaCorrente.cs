using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_ByteBank
{
    class ContaCorrente
    {
        public Cliente Titular { get; set; } //propriedade
        public int Agencia { get; set; } //propriedade
        public int Conta { get; set; } //propriedade
        public static int TotalDeContas { get; private set; }
        //static , para q todas as vezes que o construtor for chamado o valor do atributo não seja reiniciado
        
        private double _saldo = 100;

        public double Saldo
        { 
            get
            {
                return _saldo;
            }
            set
            {
                if(value < 0) //impede do saldo de ser negativo
                {
                    return;
                }
                _saldo = value;
            }
        }

        public ContaCorrente(int agencia, int numero)
        {
            Agencia = agencia;
            Conta = numero;

            TotalDeContas++;
        }

        public bool Sacar(double valor)
        {
            if(_saldo < valor)
            {
                return false;
            }
            _saldo -= valor;
            return true;
        }

        public void Depositar(double valor)
        {
            _saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if(_saldo < 0)
            {
                return false;
            }
            _saldo -= valor;
            contaDestino.Depositar(valor);
            return true;
        }


    }
}
