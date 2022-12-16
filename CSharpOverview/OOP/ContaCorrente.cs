using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOverview.Classes
{
    public class ContaCorrente
    {

        private int numeroAgencia;
        private double saldo;
        public Cliente Cliente { get; }

        public string Conta { get; set; }
        public static int TotalDeContasCriadas { get; private set; }

        public int NumeroAgencia { 
            get { return numeroAgencia;} 
            private set {
                if (value > 0)
                    this.numeroAgencia = value;
            } 
        }

        public ContaCorrente(int numeroAgencia, string numeroConta, Cliente titular)
        {
            this.numeroAgencia = numeroAgencia;
            this.Conta = numeroConta;
            this.Cliente = titular;
            TotalDeContasCriadas++;
        }

        public double GetSaldo()
        {
            return this.saldo;
        }

        public void SetSaldo(double valor)
        {
            
            this.saldo = valor;
        }


        public void Despositar(double valor)
        {
            saldo += valor;
        }

        public bool Sacar(double valor)
        {
            if (saldo > valor)
            {
                saldo -= valor;
                return true;
            }

            return false;
        }

        public bool Tranferir(double valor, ContaCorrente contaDestino)
        {
            if (contaDestino.saldo < valor)
                return false;

            Sacar(valor);
            contaDestino.Despositar(valor);

            return true;
        }

    }
}
