using CSharpOverview.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOverview.OOP
{
    public class Sistema
    {

        public void Logar(Autenticavel func, string senha)
        {
            bool usuarioAutenticado = func.Autenticar(senha);
            if (usuarioAutenticado)
            {
                Console.WriteLine("Boas vindas ao nosso sistema.");
            }
            else
            {
                Console.WriteLine("Senha incorreta!");
            }
        }
    }
}
