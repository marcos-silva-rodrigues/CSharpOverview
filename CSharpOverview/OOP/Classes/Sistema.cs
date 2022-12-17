using CSharpOverview.OOP.interfaces;

namespace CSharpOverview.OOP.Classes
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
