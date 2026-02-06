//namespace MeuBanco.models
//{
//public abstract class ContaBancaria{
    
//    public int NumeroConta {get; init;}
//    public string Titular {get;set;}
//    public double Saldo {get; private set;}
//    public double Juros {get; init;}
//    public double Rendimento {get; init;}
//    public double LimEmprestimo {get; init;}

//    protected ContaBancaria(int numConta, string titular, double saldoInicial, float juros, float rendimento, float limEmprestimo)
//    {
//        NumeroConta = numConta;
//        Titular = titular;
//        Saldo = saldoInicial;
//        Juros = juros;
//        Rendimento = rendimento;
//        LimEmprestimo = limEmprestimo;
//    }

//    public void Depositar( double valor)
//    {
//        if (valor > 0)
//        {
//            Saldo += valor;
//        }
//        else
//        {
//            Console.WriteLine("Valor não pode ser negativo ");
//        }
//    }

//    public void Sacar(double valor)
//    {
//        if(valor > 0 && valor <= Saldo)
//        {
//            Saldo -= valor;
//          Console.WriteLine($"Você sacou {valor}.");
//          Console.WriteLine($"Seu saldo é de  R${Saldo} reais");
//        }
//    }

//    public void exibirDados()
//    {
//        Console.WriteLine($"Número da Conta : {NumeroConta}");
//        Console.WriteLine($"Pessoa : {Titular}");
//        Console.WriteLine($"Ver Saldo : {Saldo}");
//        Console.WriteLine($"Taxa de juros : {Juros}");
//        Console.WriteLine($"Rendimento : {Rendimento}");
//        Console.WriteLine($"Seu limite de empréstimo :  {LimEmprestimo:2}");
//    }
//}



//}

