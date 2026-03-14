using JokempoClassLibrary.Services;

namespace JokempoWinForm
{
    internal class JogoForm
    {
        private object jogador;
        private JogoService jogoService;

        public JogoForm(object jogador, JogoService jogoService)
        {
            this.jogador = jogador;
            this.jogoService = jogoService;
        }
    }
}