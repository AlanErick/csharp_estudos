using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class Desenvolvedor : Funcionario
    {
        public Desenvolvedor(string cpf, double salario) : base(cpf, 1200)
        {

        }
        public override void AumentarSalario() 
        {
            Salario *= 1.2;
        }

        public override double GetBonificacao()
        {
            return Salario *= 0.1;
        }
    }
}
