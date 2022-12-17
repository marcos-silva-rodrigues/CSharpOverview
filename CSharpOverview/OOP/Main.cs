using CSharpOverview.OOP.Classes;
using CSharpOverview.OOP.Exceptions;

try
{
    Cliente fulano = new Cliente("Fulano", "12345678", "Apicultor");
    ContaCorrente conta = new ContaCorrente(102, 12, fulano);
    conta.SetSaldo(1200.5);

    conta.Sacar(2000);
}
catch (ArgumentException ex)
{
    Console.WriteLine("Erro no argumento");
    Console.WriteLine(ex.Message);
    Console.WriteLine(ex.StackTrace);
}
catch (OperacaoFinanceiraException ex)
{
    Console.WriteLine(ex.Message);
    Console.WriteLine(ex.StackTrace);
    Console.WriteLine("Inner Exception");
    Console.WriteLine(ex.InnerException.Message);
    Console.WriteLine(ex.InnerException.StackTrace);
}



//Cliente ciclano = new Cliente("ciclano", "12345678", "Apicultor");
//ContaCorrente conta2 = new ContaCorrente(124, "1020-A", ciclano);
//conta2.SetSaldo(190.5);
//Console.WriteLine("Conta Criadas: " + ContaCorrente.TotalDeContasCriadas);

//Console.WriteLine("Fulano saldo: " + conta.GetSaldo());
//Console.WriteLine("Ciclano saldo: " + conta2.GetSaldo());

//conta.Tranferir(100, conta2);

//Console.WriteLine("Fulano saldo: " + conta.GetSaldo());
//Console.WriteLine("Ciclano saldo: " + conta2.GetSaldo());

var aux = new Auxiliar("Fulano", "123123123", 1300.0);
var dir = new Diretor("Ciclano", "123123123", 4000.0, "abc");

GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();

gerenciador.Registrar(dir);
gerenciador.Registrar(aux);

aux.AumentarSalario();

Console.WriteLine("Total das bonificações: " + gerenciador.TotalDeBonificacao);
Console.WriteLine("Fulano: " + aux.Salario);
Console.WriteLine("Ciclano: " + dir.Salario);

Sistema sistema = new Sistema();
sistema.Logar(dir, "abc");


