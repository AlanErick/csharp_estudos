using ByteBank.Funcionarios;
using ByteBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Sistema
{
    public class SistemaInterno
    {
        public bool Logar(Autenticavel usuario, string senhaTentativa)
        {
            bool usuarioAutenticado = usuario.Autenticar(senhaTentativa); 

            if(usuarioAutenticado)
            {
                Console.WriteLine("Bem-vindo usuário!");
                return true;
            }
            else
            {
                Console.WriteLine("Senha incorreta!");
                return false;
            }
        }


    }
}
