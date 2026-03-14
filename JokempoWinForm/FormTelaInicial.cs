using JokempoClassLibrary.Models;
using JokempoClassLibrary.Services;
using System.Windows.Forms;


namespace JokempoWinForm
{
    public partial class FormTelaInicial : Form
    {

        JogoService jogoService = new JogoService();

        public FormTelaInicial()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtTitle_Click(object sender, EventArgs e)
        {

        }

        private void inputName_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelName_Click(object sender, EventArgs e)
        {

        }

        private void btnJogar_Click(object sender, EventArgs e)
        {
            string nomeJogador = inputName.Text.Trim();
            if (nomeJogador == "")
            {
                MessageBox.Show("Por favor, digite um nome válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Jogador jogador = new(nomeJogador);
            if (!jogoService.JogadorExiste(nomeJogador))
            {   
                jogoService.AdicionarJogador(jogador);
                listJogadores.Items.Add(nomeJogador);
            }
            inputName.Clear();

            var jogoForm = new FormJogo(jogador, jogoService, this);
            jogoForm.Show();
            this.Hide();
        }

        private void listJogadores_SelectedIndexChanged(object sender, EventArgs e)
        {
            inputName.Text = listJogadores.SelectedItem.ToString();
        }

        private void labelJogadores_Click(object sender, EventArgs e)
        {

        }
    }
}
