using CSharpOverview.OOP.Exceptions;

namespace CSharpOverview.OOP.Classes
{
    public class ContaCorrente
    {
        private double saldo;
        public Cliente Cliente { get; }

        public string Conta { get; set; }

        public int Agencia { get; set; }

        public int Numero
        {
            get;
        }

        public ContaCorrente(int agencia, int numero, Cliente titular)
        {
            Numero = numero;
            Agencia = agencia;
            Cliente = titular;

            if (agencia <= 0) throw new ArgumentException("O valor de agencia dever ser maior que 0", nameof(agencia));
            if (numero <= 0) throw new ArgumentException("O valor de numero dever ser maior que 0", nameof(numero));
        }

        public double GetSaldo()
        {
            return saldo;
        }

        public void SetSaldo(double valor)
        {

            saldo = valor;
        }


        public void Despositar(double valor)
        {
            saldo += valor;
        }

        public void Sacar(double valor)
        {
            if (saldo < valor) throw new SaldoInsuficienteException("Saldo insuficiente para o saque de R$ " + valor);

            saldo -= valor;
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
