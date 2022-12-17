namespace CSharpOverview.OOP.Exceptions
{
    public class SaldoInsuficienteException : OperacaoFinanceiraException
    {
        public SaldoInsuficienteException(string message) : base(message)
        {
        }
    }
}
