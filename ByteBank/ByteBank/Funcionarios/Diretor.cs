using ByteBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class Diretor : Autenticavel// Os DOIS PONTOS indicam Herança de código
    {
        public Diretor(double salario, string cpf) : base(cpf, 5000)
        {
            
        }

        public override void AumentarSalario()//para realizar a sobrecarga
        {
            Salario *= 1.15;
        }

        public override double GetBonificacao()
        {
            return Salario *= 0.5;
        }
    }
}
