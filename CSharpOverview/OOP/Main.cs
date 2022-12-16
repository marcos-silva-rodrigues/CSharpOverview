using CSharpOverview.Classes;
using CSharpOverview.OOP;

//Cliente fulano = new Cliente("Fulano", "12345678", "Apicultor");
//ContaCorrente conta = new ContaCorrente(102, "1010-P", fulano);
//conta.SetSaldo(1200.5);


//Cliente ciclano = new Cliente("ciclano", "12345678", "Apicultor");
//ContaCorrente conta2 = new ContaCorrente(124, "1020-A", ciclano);
//conta2.SetSaldo(190.5);
//Console.WriteLine("Conta Criadas: " + ContaCorrente.TotalDeContasCriadas);

//Console.WriteLine("Fulano saldo: " + conta.GetSaldo());
//Console.WriteLine("Ciclano saldo: " + conta2.GetSaldo());

//conta.Tranferir(100, conta2);

//Console.WriteLine("Fulano saldo: " + conta.GetSaldo());
//Console.WriteLine("Ciclano saldo: " + conta2.GetSaldo());

var fulano = new Auxiliar("Fulano", "123123123", 1300.0);
var ciclano = new Diretor("Ciclano", "123123123", 4000.0, "abc");

GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();

gerenciador.Registrar(ciclano);
gerenciador.Registrar(fulano);

fulano.AumentarSalario();

Console.WriteLine("Total das bonificações: " + gerenciador.TotalDeBonificacao);
Console.WriteLine("Fulano: " + fulano.Salario);
Console.WriteLine("Ciclano: " + ciclano.Salario);

Sistema sistema= new Sistema();
sistema.Logar(ciclano, "abc");


