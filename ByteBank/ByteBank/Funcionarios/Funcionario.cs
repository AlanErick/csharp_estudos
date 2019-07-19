using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public abstract class Funcionario
    {
        public static int TotalFuncionarios { get; private set; } //static pois é uma propriedade da classe
        public string Nome { get; set; }
        public string CPF { get; private set; }
        public virtual double Salario { get; protected set; }

        public Funcionario(string cpf, double salario) //construtor
        {
            Salario = salario;
            CPF = cpf;
            TotalFuncionarios++;
        }

        public Funcionario(string cpf) //Construtor quando o funcionário não é declarado
        {
            CPF = cpf;
            Salario = 1000;
        }

        public abstract void AumentarSalario();

        public abstract double GetBonificacao();
    }
}
