using CSharpOverview.OOP.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOverview.OOP.Classes
{
    public class Diretor : Funcionario, Autenticavel
    {
        public string Senha { get; set; }

        public Diretor(string nome, string cpf, double salario, string senha) : base(nome, cpf, salario)
        {
            Senha = senha;
        }

        public override double GetBonificacao()
        {
            return Salario * 0.5;
        }

        public override void AumentarSalario()
        {
            Salario *= 1.15;
        }

        public bool Autenticar(string senha)
        {
            return Senha == senha;
        }

    }
}
