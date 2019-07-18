using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_ByteBank
{
    public class ContaCorrente
    {
        public Cliente titular { get; set;}
        public int Agencia { get; set; }
        public int Numero { get; set; }

        private double _saldo = 100;// O underline prescedente ao inicio da palavra saldo caracteriza a  
                                    // aplicação de restrições nas propriedades
        
        // Propriedades do atributo SALDO
        public double Saldo
        {
            get //O GET TEM RETURN SEMPRE.
            {
                return _saldo;
            }
            set
            {
                if (value < 0) // A palavra reservada value, serve para substituir a variável que recebe
                {              // o valor que vinha antes como parâmetro (Particularidade do C#)
                    return;
                }
                _saldo = value;
            }
        }

        public bool Sacar(double valor)
        {
            if (this._saldo < valor)
            {
                return false;
            }
            this._saldo -= valor;
            return true;
        }

        public void Depositar(double valor)
        {
            this._saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (this._saldo < valor)
            {
                return false;
            }
            this._saldo -= valor;
            contaDestino.Depositar(valor);
            return true;
        }

        // GetSaldo() e SetSalDO() são métodos definidos para obter o valor de saldo, 
        // visto que o atributo é private, sendo acessado somente pela classe que o declara
        /*
        public void SetSaldo(double valor)
        {
            if (_saldo < valor)
            {
                return;
            }
            _saldo = valor;
        }

        public double GetSaldo()
        {
            return _saldo;
        }
        */
        // Simplificando o GET e o SET, no C# podemos criar propriedades e dentro delas chamar os métodos
        // Get e Set que são descritos nativamente na linguagem, segue exemplo.
    }
}
