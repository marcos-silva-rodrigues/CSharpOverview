using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOverview.OOP
{
    public abstract class Funcionario
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public double Salario { get; protected set; }


        public Funcionario(string nome, string cpf, double salario)
        {
            this.Nome = nome;
            this.Cpf = cpf;
            this.Salario = salario;
        }

        public abstract double GetBonificacao();

        public abstract void AumentarSalario();

    }
}
