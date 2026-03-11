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
    Console.WriteLine("\nEntão vamos começar...");

    char opcaoJogador = ObterEscolhaJogador(nomeJogador);

    // Gerar opção do computador
    var opcaoPC = new Random().Next(3);

    bool vitoria = DefinirResultado(opcaoJogador, opcaoPC);

    Console.WriteLine(ExibirOpcaoPC(opcaoPC));

    Console.WriteLine(ExibirResultado(opcaoJogador, opcaoPC, vitoria, ref jogadores, nomeJogador));

    continuar = EscolhaSimOuNao($"\nQuer jogar novamente, {nomeJogador}?");

    if (continuar)
    {
        nomeJogador = TrocarJogador(ref jogadores, nomeJogador);
    }
}

Console.WriteLine($"\n👋 Tchau, {nomeJogador}! Até a próxima!");
ExibirEstatisticas(jogadores);


string RegistrarJogador(Dictionary<string, int[]> jogadores)
{
    string nome;
    do
    {
        Console.WriteLine("\nDigite o seu nome:");
        nome = (Console.ReadLine() ?? "").Trim();

        if (string.IsNullOrEmpty(nome))
        {
            Console.WriteLine("\nNome inválido. Tente novamente.");
        }
    } while (string.IsNullOrEmpty(nome));

    if (!jogadores.ContainsKey(nome))
    {
        jogadores[nome] = new int[3]; // [vitórias, derrotas, empates]
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

        if (opcaoJogador != '1' && opcaoJogador != '0')
        {
            Console.WriteLine("\nOpção inválida! Tente novamente.");
        }
    } while (opcaoJogador != '1' && opcaoJogador != '0');

    return opcaoJogador == '1';
}

char ObterEscolhaJogador(string nomeJogador)
{
    char opcao;
    do
    {
        Console.WriteLine($"\n{nomeJogador}, escolha uma opção: 0 - Pedra ✊, 1 - Papel ✋ ou 2 - Tesoura ✌");
        opcao = Console.ReadKey().KeyChar;

        if (opcao != '0' && opcao != '1' && opcao != '2')
        {
            Console.WriteLine("\nOpção inválida! Tente novamente.");
        }
    } while (opcao != '0' && opcao != '1' && opcao != '2');

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

string ExibirResultado(char opcaoJogador, int opcaoPC, bool vitoria, ref Dictionary<string, int[]> jogadores, string nomeJogador)
{
    if (int.Parse(opcaoJogador.ToString()) == opcaoPC)
    {
        jogadores[nomeJogador][2]++; // Incrementar empate
        return $"\n😀 Legal, {nomeJogador}! Nós empatamos!";
    }
    else if (vitoria)
    {
        jogadores[nomeJogador][0]++; // Incrementar vitória
        return $"\n😀 Parabéns, {nomeJogador}! Você venceu.";
    }
    else
    {
        jogadores[nomeJogador][1]++; // Incrementar derrota
        return $"\n😀 Haha, eu venci! Não foi dessa vez, {nomeJogador}. Você pode ter mais sorte na próxima.";
    }
}

string TrocarJogador(ref Dictionary<string, int[]> jogadores, string jogadorAtual)
{
    bool trocarJogador = EscolhaSimOuNao($"Deseja trocar de jogador, {jogadorAtual}?");
    while (true)
    {
        if (trocarJogador)
        {
            Console.WriteLine("\nQual jogador deseja usar?");
            var nomes = new List<string>(jogadores.Keys);
            for (int i = 0; i < nomes.Count; i++)
            {
                Console.WriteLine($"{i + 1} - {nomes[i]}");
            }
            Console.WriteLine("0 - Criar novo jogador");

            char opcaoTroca = Console.ReadKey().KeyChar;
            if (opcaoTroca == '0')
            {
                return RegistrarJogador(jogadores);
            }
            else
            {
                opcaoTroca -= '0'; // Converter char para int
                if (opcaoTroca > nomes.Count || opcaoTroca < 1)
                {
                    Console.WriteLine("Opção inválida! Tente novamente");
                }
                else
                {      
                    return nomes[opcaoTroca - 1];
                }
            }
        }
        return jogadorAtual;
    }
}

void ExibirEstatisticas(Dictionary<string, int[]> jogadores)
{
    Console.WriteLine("\n📊 Estatísticas dos Jogadores:");
    foreach (var jogador in jogadores)
    {
        Console.WriteLine($"{jogador.Key}: {jogador.Value[0]} vitória(s), {jogador.Value[1]} derrota(s), {jogador.Value[2]} empate(s)");
    }
}
