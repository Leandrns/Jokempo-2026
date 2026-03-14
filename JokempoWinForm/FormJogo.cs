using JokempoClassLibrary.Enums;
using JokempoClassLibrary.Models;
using JokempoClassLibrary.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JokempoWinForm
{
    public partial class FormJogo : Form
    {
        private Jogador jogador;
        private JogoService jogoService;
        private FormTelaInicial formTelaInicial;

        public FormJogo()
        {
            InitializeComponent();

        }

        private void FormJogo_Load(object sender, EventArgs e)
        {

        }

        public FormJogo(Jogador jogador, JogoService jogoService, FormTelaInicial formTelaInicial)
        {

            this.jogador = jogador;
            this.jogoService = jogoService;
            InitializeComponent();
            btnJogarNovamente.Visible = false;
            btnEncerrar.Visible = false;
            this.formTelaInicial = formTelaInicial;
        }

        public FormJogo(Jogador jogador, JogoService jogoService)
        {
            this.jogador = jogador;
            this.jogoService = jogoService;
        }

        private void ExibirResultado(Jogador jogador, EscolhaEnum escolhaJogador)
        {

            Rodada rodada = jogoService.ExecutarRodada(jogador, escolhaJogador);
            txtEscolhaJogador.Text = rodada.EscolhaJogador.ToString();
            txtResultadoPC.Text = rodada.EscolhaPC.ToString();
            txtResultado.Text = rodada.ExibirResultado();
            btnJogarNovamente.Visible = true;
            btnEncerrar.Visible = true;
        }

        private void MarcarBotao(Button btnClicado)
        {
            // Destaca o botão clicado
            btnClicado.BackColor = Color.FromArgb(130, 80, 230);
            btnClicado.FlatAppearance.BorderSize = 3;
            btnClicado.FlatAppearance.BorderColor = Color.White;

            // Desabilita todos os botões de escolha
            btnPedra.Enabled = false;
            btnPapel.Enabled = false;
            btnTesoura.Enabled = false;
        }

        private void btnPedra_Click(object sender, EventArgs e)
        {
            EscolhaEnum escolhaJogador = EscolhaEnum.Pedra;
            ExibirResultado(jogador, escolhaJogador);
            MarcarBotao(btnPedra);
        }

        private void btnPapel_Click(object sender, EventArgs e)
        {
            EscolhaEnum escolhaJogador = EscolhaEnum.Papel;
            ExibirResultado(jogador, escolhaJogador);
            MarcarBotao(btnPapel);
        }
        private void btnTesoura_Click(object sender, EventArgs e)
        {
            EscolhaEnum escolhaJogador = EscolhaEnum.Tesoura;
            ExibirResultado(jogador, escolhaJogador);
            MarcarBotao(btnTesoura);
        }

        private void txtEscolhaJogador_Click(object sender, EventArgs e)
        {

        }

        private void btnEncerrar_Click(object sender, EventArgs e)
        {
            var formEstatisticas = new FormEstatisticas(jogoService);
            formEstatisticas.Show();
            this.Close();
        }

        private void btnJogarNovamente_Click(object sender, EventArgs e)
        {
            this.Close();
            formTelaInicial.Show();
        }
    }
}
