using JokempoClassLibrary.Enums;
using JokempoClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JokempoClassLibrary.Services
{
    public class JogoService
    {

        public List<Jogador> Jogadores { get; } = new();

        public static EscolhaEnum GerarEscolhaPC(){
            Random random = new();
            int escolha = random.Next(0, 3); 
            return (EscolhaEnum)escolha;
        }

        public void AdicionarJogador(Jogador jogador)
        {
           
            Jogadores.Add(jogador);

        }

        public bool JogadorExiste(string nome)
        {
            foreach (var jogador in Jogadores)
            {
                if (jogador.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                } 
            }
            return false;
        } 

        public Rodada ExecutarRodada(Jogador jogador, EscolhaEnum escolhaJogador)
        {
            var escolhaPC = GerarEscolhaPC();
            var rodada = new Rodada(jogador, escolhaJogador, escolhaPC);
            if (rodada.Resultado == ResultadoRodadaEnum.Vitoria)
            {
                jogador.Estatisticas.RegistrarVitoria();
            }
            else if (rodada.Resultado == ResultadoRodadaEnum.Derrota)
            {
                jogador.Estatisticas.RegistrarDerrota();
            }
            else
            {
                jogador.Estatisticas.RegistrarEmpate();
            }
            return rodada;
        }

    }
}
