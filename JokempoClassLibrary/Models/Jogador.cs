using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JokempoClassLibrary.Models
{
    public class Jogador
    {
        public string Nome { get; set; }
        public Estatisticas Estatisticas { get; set; }

        public Jogador(string nome)
        {
            if (string.IsNullOrWhiteSpace(nome))
            {
                throw new ArgumentException("O nome do jogador não pode ser vazio.", nameof(nome));
            }

            Nome = nome.Trim();
            Estatisticas = new Estatisticas();
        }

        public override string ToString()
        {
            return $"{Nome} - Vitória(s): {Estatisticas.Vitorias}, Derrota(s): {Estatisticas.Derrotas}, Empate(s): {Estatisticas.Empates}";
        }
        


    }
}
