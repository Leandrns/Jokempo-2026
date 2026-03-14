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
    public partial class FormEstatisticas : Form
    {

        private JogoService jogoService;

        public FormEstatisticas(JogoService jogoService)
        {
            InitializeComponent();
            this.jogoService = jogoService;
            CarregarEstatisticas();
        }

        private void FormEstatisticas_Load(object sender, EventArgs e)
        {

        }

        private void CarregarEstatisticas()
        {
            flpEstatisticas.Controls.Clear(); // limpa antes de recarregar

            foreach (var jogador in jogoService.Jogadores)
            {
                // Cria um painel para cada jogador
                Panel card = new Panel
                {
                    Width = 400,
                    Height = 80,
                    BackColor = Color.Transparent,
                    Margin = new Padding(0, 0, 0, 10) // espaço entre cards
                };

                Label lblNome = new Label
                {
                    Text = jogador.Nome,
                    Font = new Font("Segoe UI", 12f, FontStyle.Bold),
                    ForeColor = Color.DarkSlateBlue,
                    Left = 10,
                    Top = 8,
                    AutoSize = true
                };

                Label lblStats = new Label
                {
                    Text = $"✅ {jogador.Estatisticas.Vitorias} vitórias   " +
                           $"❌ {jogador.Estatisticas.Derrotas} derrotas   " +
                           $"🤝 {jogador.Estatisticas.Empates} empates",
                    Font = new Font("Segoe UI", 10f),
                    ForeColor = Color.Black,
                    Left = 10,
                    Top = 40,
                    AutoSize = true
                };

                card.Controls.Add(lblNome);
                card.Controls.Add(lblStats);

                flpEstatisticas.Controls.Add(card); // adiciona o card no painel
            }
        }

        private void flpEstatisticas_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormEstatisticas_Load_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
