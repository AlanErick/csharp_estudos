using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class GerenteDeContaCorrente : Funcionario
    {
        public GerenteDeContaCorrente(string cpf, double salario) : base(cpf, 1000)
        {

        }
        public override void AumentarSalario()
        {
            Salario *= 1.2;
        }

        public override double GetBonificacao()
        {
            return Salario *= 0.5;
        }
    }
}
