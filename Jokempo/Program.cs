// ✅ Modularizar o código criando métodos e aplicando os conceitos aprendidos
// ✅ Validar de entrada de dados;
// ✅ Gravar o nome do jogador;
// Permitir mudar de jogador;
// Imprimir estatísticas dos jogadores.

using System;

Console.OutputEncoding = System.Text.Encoding.UTF8;

var jogadores = new Dictionary<string, int[]>();

Console.WriteLine("Seja bem-vindo ao Jokempo!!");

// Obter nome do jogador e registrar no dicionário 
var nomeJogador = RegistrarJogador(jogadores);

// Iniciar jogo
bool continuar = EscolhaSimOuNao($"😀 Olá, {nomeJogador}! Vamos jogar Jokempo?");

while (continuar)
{
    Console.WriteLine("Então vamos começar...");

    char opcaoJogador = ObterEscolhaJogador(nomeJogador);

    // Gerar opção do computador
    var opcaoPC = new Random().Next(3);

    bool vitoria = DefinirResultado(opcaoJogador, opcaoPC);

    Console.WriteLine(ExibirOpcaoPC(opcaoPC));

    Console.WriteLine(ExibirResultado(opcaoJogador, opcaoPC, vitoria));

    continuar = EscolhaSimOuNao("Quer jogar novamente?");
}
Console.WriteLine("👋 Tchau! Até a próxima");


string RegistrarJogador(Dictionary<string, int[]> jogadores)
{
    string nome;
    do
    {
        Console.WriteLine("Digite o seu nome:");
        nome = (Console.ReadLine() ?? "").Trim();

        if (string.IsNullOrEmpty(nome))
        {
            Console.WriteLine("Nome inválido. Tente novamente.");
        }
    } while (string.IsNullOrEmpty(nome));

    if (!jogadores.ContainsKey(nome))
    {
        jogadores[nome] = new int[3];
    }

    return nome;
}

bool EscolhaSimOuNao(string mensagem)
{
    char opcaoJogador;
    do
    {
        Console.WriteLine($"\n{mensagem}");
        Console.WriteLine("1 - Sim ou 0 - Não");
        opcaoJogador = Console.ReadKey().KeyChar;

        if (opcaoJogador != '1' || opcaoJogador != '0')
        {
            Console.WriteLine("Opção inválida! Tente novamente.");
        }
    } while (opcaoJogador != '1' || opcaoJogador != '0');

    return opcaoJogador == '1';
}

char ObterEscolhaJogador(string nomeJogador)
{
    char opcao;
    do
    {
        Console.WriteLine("Escolha uma opção: 0 - Pedra ✊, 1 - Papel ✋ ou 2 - Tesoura ✌");
        opcao = Console.ReadKey().KeyChar;

        if (opcao != 0 || opcao != 1 || opcao != 2)
        {
            Console.WriteLine("Opção inválida! Tente novamente.");
        }
    } while (opcao != 0 || opcao != 1 || opcao != 2);

    return opcao;
}

bool DefinirResultado(char opcaoJogador, int opcaoPC)
{
    bool vitoria = false;
    switch (opcaoJogador)
    {
        case '0':
            Console.WriteLine("\nVocê escoheu Pedra ✊!");
            vitoria = opcaoPC == 2;
            break;
        case '1':
            Console.WriteLine("\nVocê escoheu Papel ✋");
            vitoria = opcaoPC == 0;
            break;
        case '2':
            Console.WriteLine("\nVocê escoheu Tesoura ✌");
            vitoria = opcaoPC == 1;
            break;
    }

    return vitoria;
}

string ExibirOpcaoPC(int opcaoPC)
{
    switch (opcaoPC)
    {
        case 0:
            return "Eu escolhi Pedra ✊!";
        case 1:
            return "Eu escolhi Papel ✋";
        case 2:
            return "Eu escolhi Tesoura ✌";
        default:
            return "Opção inválida!";
    }
}

string ExibirResultado(char opcaoJogador, int opcaoPC, bool vitoria)
{
    if (int.Parse(opcaoJogador.ToString()) == opcaoPC)
        return "😀 Legal! Nós empatamos!";
    else if (vitoria)
        return "😀 Parabéns! Você venceu.";
    else
        return "😀 Haha, eu venci! Não foi dessa vez. Você pode ter mais sorte na próxima.";
}
