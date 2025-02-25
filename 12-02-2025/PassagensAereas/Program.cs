// Declarando as variáveis do meu sistema
string[] nomes = new string[2];
string[] origem = new string[2];
string[] destino = new string[2];
string[] data = new string[2]; // DateTime

Console.WriteLine("---------------------------");
Console.WriteLine("Sistema de Passagens Áereas");
Console.WriteLine("---------------------------");

EfetuarLogin();

int opcao;

do
{
    
    Console.WriteLine("Menu Inicial");
    Console.WriteLine("Selecione uma opção: ");
    Console.WriteLine("[1] - Cadastrar uma Passagem");
    Console.WriteLine("[2] - Listar as Passagens");
    Console.WriteLine("[0] - Sair do Sistema");

    opcao = int.Parse(Console.ReadLine());
    // Indentacao
    switch (opcao)
    {
        // Decidir o que fazer quando o cara escolhe uma opcao
        case 1:
            CadastrarPassagem();
            Console.Clear(); //limpa a tela
            break;//indica quando o caso termina

        case 2:
            ListarPassagens();
            break;

        case 0:
            SairDoSistema();
            break;

        default:
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Opção Inválida!");
            Console.ResetColor();
            break;

    }
} while (opcao != 0);

//modularizar o sistema = criar funções
static void EfetuarLogin()
{
    string senhaRecebida;
    do
    {
        Console.WriteLine("Digite sua Senha: ");
        senhaRecebida = Console.ReadLine();
    } while (senhaRecebida != "123456");
}

 void CadastrarPassagem()
{
    Console.WriteLine("Iniciando Cadastro de Passagem...");

    for (int i = 0; i < nomes.Length; i++)
    {
        Console.WriteLine($"Digite o nome do {i + 1} Passageiro: ");
        nomes[i] = Console.ReadLine();

        Console.WriteLine($"Digite a origem do {i + 1} Passageiro: ");
        origem[i] = Console.ReadLine();

        Console.WriteLine($"Digite o destino do {i + 1} Passageiro: ");
        destino[i] = Console.ReadLine();

        Console.WriteLine($"Digite a data da viagem do {i + 1} Passageiro: ");
        data[i] = Console.ReadLine();
    }
}


void ListarPassagens()
{
    for (int i = 0; i < nomes.Length; i++)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"Passagem Aérea {i + 1}");

        Console.WriteLine($"Nome: {nomes[i]}");
        Console.WriteLine($"Origem: {origem[i]}");
        Console.WriteLine($"Destino: {destino[i]}");
        Console.WriteLine($"Data: {data[i]}");
        Console.ResetColor();
    }
}

void SairDoSistema()
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("Obrigado por utilizar nosso sistema!");
    Console.ResetColor();
}