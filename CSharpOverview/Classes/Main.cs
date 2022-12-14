using CSharpOverview.Classes;

Cliente fulano = new Cliente("Fulano", "12345678", "Apicultor");
ContaCorrente conta = new ContaCorrente(102, "1010-P", fulano);
conta.SetSaldo(1200.5);


Cliente ciclano = new Cliente("ciclano", "12345678", "Apicultor");
ContaCorrente conta2 = new ContaCorrente(124, "1020-A", ciclano);
conta2.SetSaldo(190.5);
Console.WriteLine("Conta Criadas: " + ContaCorrente.TotalDeContasCriadas);

Console.WriteLine("Fulano saldo: " + conta.GetSaldo());
Console.WriteLine("Ciclano saldo: " + conta2.GetSaldo());

conta.Tranferir(100, conta2);

Console.WriteLine("Fulano saldo: " + conta.GetSaldo());
Console.WriteLine("Ciclano saldo: " + conta2.GetSaldo());



