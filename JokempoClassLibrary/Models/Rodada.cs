using JokempoClassLibrary.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JokempoClassLibrary.Models
{
    public class Rodada
    {
        public Jogador Jogador { get; }
        public EscolhaEnum EscolhaJogador { get; }
        public EscolhaEnum EscolhaPC { get; }
        public ResultadoRodadaEnum Resultado { get; }

        public Rodada(Jogador jogador, EscolhaEnum escolhaJogador, EscolhaEnum escolhaPC)
        {
            Jogador = jogador ?? throw new ArgumentNullException(nameof(jogador));
            EscolhaJogador = escolhaJogador;
            EscolhaPC = escolhaPC;
            Resultado = DeterminarResultado();
        }

        private ResultadoRodadaEnum DeterminarResultado()
        {
            if (EscolhaJogador == EscolhaPC)
                return ResultadoRodadaEnum.Empate;

            bool vitoria = (EscolhaJogador,EscolhaPC) switch
            {
                (EscolhaEnum.Pedra, EscolhaEnum.Tesoura) => true,
                (EscolhaEnum.Papel, EscolhaEnum.Pedra) => true,
                (EscolhaEnum.Tesoura, EscolhaEnum.Papel) => true,
                _ => false
            };

            return vitoria ? ResultadoRodadaEnum.Vitoria : ResultadoRodadaEnum.Derrota;

        }

        public string ExibirResultado()
        {
            string resultadoTexto = Resultado switch
            {
                ResultadoRodadaEnum.Vitoria => $"😀 Parabéns, {Jogador.Nome}! Você venceu.",
                ResultadoRodadaEnum.Derrota => $"😀 Haha, eu venci! Não foi dessa vez, {Jogador.Nome}. Você pode ter mais sorte na próxima.",
                _ => $"😀 Legal, {Jogador.Nome}! Nós empatamos!"
            };
            return resultadoTexto;
        }

    }
}
