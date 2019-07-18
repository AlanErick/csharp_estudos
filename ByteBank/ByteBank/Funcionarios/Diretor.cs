using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class Diretor : Funcionario// Os DOIS PONTOS indicam Herança de código
    {
        public Diretor(double salario, string cpf) : base(salario, cpf)
        {
            
        }

        /*public override double Salario {//tornei o salário com valor fixo através de uma sobrecarga
            get
            {
                return Salario = 2000;
            }
            set { }
        }*/

        public override void AumentarSalario()//para realizar a sobrecarga
        {
            //Salario = Salario + (Salario * 0.1);
            //Salario = Salario * 1.1;
            Salario *= 1.15; //atribui e incrementa
        }

        public override double GetBonificacao()
        {
            return Salario + base.GetBonificacao();
        }
    }
}
