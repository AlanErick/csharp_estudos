using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class Funcionario
    {
        public static int TotalFuncionarios { get; private set; } //static pois é uma propriedade da classe
        public string Nome { get; set; }
        public string CPF { get; private set; }
        public virtual double Salario { get; protected set; }

        public Funcionario(double salario, string cpf) //construtor
        {
            Salario = salario;
            CPF = cpf;
            TotalFuncionarios++;
        }

        public virtual void AumentarSalario()
        {
            //Salario = Salario + (Salario * 0.1);
            //Salario = Salario * 1.1;
            Salario *= 1.1; //atribui e incrementa
        }

        public virtual double GetBonificacao()
        {
            return Salario * 0.10;
        }

    }
}
