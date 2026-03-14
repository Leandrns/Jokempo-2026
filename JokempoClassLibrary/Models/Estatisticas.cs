using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JokempoClassLibrary.Models
{
    public class Estatisticas
    {
        public int Vitorias { get; private set; }
        public int Derrotas { get; private set; }
        public int Empates { get; private set; }
        public void RegistrarVitoria()
        {
            Vitorias++;
        }
        public void RegistrarDerrota()
        {
            Derrotas++;
        }
        public void RegistrarEmpate()
        {
            Empates++;
        }
    }
}
