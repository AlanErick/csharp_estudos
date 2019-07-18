using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_ByteBank
{
    public class Cliente
    {
        // Os atributos abaixo foram criados com o comando prop (que já tornou o acesso limitado
        // dentro da classe, ou seja, os atributos estão PRIVADOS)
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Profissao { get; set; }

    }
}
