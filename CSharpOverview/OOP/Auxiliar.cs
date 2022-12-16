using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOverview.OOP
{
    public class Auxiliar:Funcionario
    {
        public Auxiliar(string nome, string cpf, double salario) 
            : base(nome, cpf, salario) { }

        public override double GetBonificacao()
        {
            return this.Salario * 0.2;
        }

        public override void AumentarSalario()
        {
            this.Salario *= 1.10;
        }
    }
}
