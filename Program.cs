
using System;
using System.Globalization;
using System.Runtime.Intrinsics.X86;
using System.Text.RegularExpressions;

//Dictionary<>

Console.Clear();

menu();

//utils

void validarCpf(string a)
{
     string cpfLimpo = Regex.Replace(a, @"[^\d]", "");

        // 2. Validação simples: verificar se tem 11 dígitos
        if (cpfLimpo.Length == 11)
        {
            Console.WriteLine($"CPF aceito: {cpfLimpo}");
            limparTela(1500);
        // Aqui você chamaria uma função para validar os dígitos verificadores
    }
        else
        {
            Console.WriteLine("CPF inválido! Deve conter 11 dígitos.");
        }
}

void validarData(string a)
{
     DateTime dataConvertida;
    // Tenta converter, validando o formato exato
    if (DateTime.TryParseExact(a, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out dataConvertida))
    {
        Console.WriteLine($"Data válida: {dataConvertida.ToShortDateString()}");
        limparTela(2000);
    }
    else
    {
        Console.WriteLine("Formato de data inválido. Use dd/mm/aaaa.");
    }
}

void exibirLogo()
{
    Console.WriteLine(@"
███████████████████████████████████████████████
█─▄▄─█▄─██─▄█─▄─▄─███▄─▄─▀██▀▄─██▄─▀█▄─▄█▄─█─▄█
█─██─██─██─████─██████─▄─▀██─▀─███─█▄▀─███─▄▀██
▀▄▄▄▄▀▀▄▄▄▄▀▀▀▄▄▄▀▀▀▀▄▄▄▄▀▀▄▄▀▄▄▀▄▄▄▀▀▄▄▀▄▄▀▄▄▀");
    Console.WriteLine("Bem vindo ao banco OUT BANK");
    Console.WriteLine("O banco voltado para seus negócios, licitos ou não...");
}

void exibirTituloDaopcao(string titulo)
{
    int quantidadeDeLetras = titulo.Length;
    string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos + "\n");
}

void limparTela(int a)
{
    Thread.Sleep(a);
    Console.Clear();
}
//função de criar conta 

void menu()
{
    exibirLogo();
    Console.WriteLine("\n1 - Registrar Conta");

    Console.WriteLine("2 - Acessar Conta");

    Console.WriteLine("0 - Sair");


    Console.Write("\nDigite a sua opção: ");
    int escolha = int.Parse(Console.ReadLine());

    switch (escolha)
    {
        case 1:
            CriarConta();
            break;
        case 2:
            AcessarConta();
            Console.WriteLine("Site funcionando ");
            break;
        case 0: Console.WriteLine("Adeus !");
                break;
        default:
            Console.WriteLine("opção inválida");
            break;
    }
}

void CriarConta()
{
    Console.Clear();
    exibirTituloDaopcao("Criar Conta");

    Console.Write("Digite o seu nome: ");
    string name = Console.ReadLine();

    Console.Write("Digite o seu sobrenome: ");
    string lastname = Console.ReadLine();

    limparTela(0);
    
    string fullName = name +" "+ lastname;
    Console.WriteLine($"Olá, {fullName}");
    limparTela(2000);

    Console.Write("Digite o seu CPF: ");
    string cpf = Console.ReadLine();
    validarCpf(cpf);

    Console.Write("Digite o sua data de nascimento: ");
    string dtNascimento = Console.ReadLine();
    validarData(dtNascimento);

    Console.Write("Digite o seu email: ");
    string email = Console.ReadLine();

    Console.Write("Digite a senha: ");
    string senha = Console.ReadLine();
    Console.Write("Confirme sua senha: ");
    string confirmsenha = Console.ReadLine();

    if(senha != confirmsenha)
    {
        Console.WriteLine("As senhas não são iguais, tente novamente");
    }


    Console.WriteLine($"Parabéns {fullName} Sua conta foi registrada com sucesso!");
    limparTela(2000);
    //VerConta();
}
 void AcessarConta()
{
    exibirTituloDaopcao("Acessar Conta");
    Console.Write("Digite o seu email: ");
    string email = Console.ReadLine();

    Console.Write("Digite a senha: ");
    string senha = Console.ReadLine();

    
    //if(email == pessoa.email && senha == pessoa.senha)
    //{
    //    Console.WriteLine($"Bem vindo de volta {pessoa.Nome}");

    //}
    //else if (!pessoa.email.contains)
    //{
    //    Console.Write("Você não tem conta no OUT BANK\nDeseja criar conta ?");
    //    int resposta = int.Parse(Console.ReadLine());

    //}
    //else
    //{
    //    Console.WriteLine("Acesso Inválido, tente novamente");
    //}
}
