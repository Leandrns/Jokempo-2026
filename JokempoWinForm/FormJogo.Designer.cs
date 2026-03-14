namespace JokempoWinForm
{
    partial class FormJogo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnPedra = new Button();
            btnPapel = new Button();
            btnTesoura = new Button();
            labelJogada = new Label();
            txtResultadoPC = new Label();
            labelEscolhaJogador = new Label();
            labelEscolhaPC = new Label();
            txtEscolhaJogador = new Label();
            txtResultado = new Label();
            btnJogarNovamente = new Button();
            btnEncerrar = new Button();
            SuspendLayout();
            // 
            // btnPedra
            // 
            btnPedra.Location = new Point(156, 161);
            btnPedra.Name = "btnPedra";
            btnPedra.Size = new Size(110, 40);
            btnPedra.TabIndex = 0;
            btnPedra.Text = "✊Pedra";
            btnPedra.UseVisualStyleBackColor = true;
            btnPedra.Click += btnPedra_Click;
            // 
            // btnPapel
            // 
            btnPapel.Location = new Point(351, 161);
            btnPapel.Name = "btnPapel";
            btnPapel.Size = new Size(110, 40);
            btnPapel.TabIndex = 1;
            btnPapel.Text = "✋Papel";
            btnPapel.UseVisualStyleBackColor = true;
            btnPapel.Click += btnPapel_Click;
            // 
            // btnTesoura
            // 
            btnTesoura.Location = new Point(542, 161);
            btnTesoura.Name = "btnTesoura";
            btnTesoura.Size = new Size(110, 40);
            btnTesoura.TabIndex = 2;
            btnTesoura.Text = "✌Tesoura";
            btnTesoura.UseVisualStyleBackColor = true;
            btnTesoura.Click += btnTesoura_Click;
            // 
            // labelJogada
            // 
            labelJogada.AutoSize = true;
            labelJogada.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelJogada.Location = new Point(306, 67);
            labelJogada.Name = "labelJogada";
            labelJogada.Size = new Size(196, 28);
            labelJogada.TabIndex = 3;
            labelJogada.Text = "Escolha sua jogada:";
            // 
            // txtResultadoPC
            // 
            txtResultadoPC.AutoSize = true;
            txtResultadoPC.Location = new Point(403, 299);
            txtResultadoPC.Name = "txtResultadoPC";
            txtResultadoPC.Size = new Size(18, 20);
            txtResultadoPC.TabIndex = 4;
            txtResultadoPC.Text = "...";
            // 
            // labelEscolhaJogador
            // 
            labelEscolhaJogador.AutoSize = true;
            labelEscolhaJogador.Location = new Point(264, 237);
            labelEscolhaJogador.Name = "labelEscolhaJogador";
            labelEscolhaJogador.Size = new Size(90, 20);
            labelEscolhaJogador.TabIndex = 5;
            labelEscolhaJogador.Text = "Sua Escolha:";
            // 
            // labelEscolhaPC
            // 
            labelEscolhaPC.AutoSize = true;
            labelEscolhaPC.Location = new Point(264, 299);
            labelEscolhaPC.Name = "labelEscolhaPC";
            labelEscolhaPC.Size = new Size(105, 20);
            labelEscolhaPC.TabIndex = 6;
            labelEscolhaPC.Text = "Escolha do PC:";
            // 
            // txtEscolhaJogador
            // 
            txtEscolhaJogador.AutoSize = true;
            txtEscolhaJogador.Location = new Point(403, 237);
            txtEscolhaJogador.Name = "txtEscolhaJogador";
            txtEscolhaJogador.Size = new Size(18, 20);
            txtEscolhaJogador.TabIndex = 7;
            txtEscolhaJogador.Text = "...";
            txtEscolhaJogador.Click += txtEscolhaJogador_Click;
            // 
            // txtResultado
            // 
            txtResultado.AutoSize = true;
            txtResultado.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtResultado.Location = new Point(369, 345);
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(123, 23);
            txtResultado.TabIndex = 8;
            txtResultado.Text = "Resultado é ...";
            // 
            // btnJogarNovamente
            // 
            btnJogarNovamente.Location = new Point(156, 396);
            btnJogarNovamente.Name = "btnJogarNovamente";
            btnJogarNovamente.Size = new Size(200, 29);
            btnJogarNovamente.TabIndex = 9;
            btnJogarNovamente.Text = "Jogar Novamente?";
            btnJogarNovamente.UseVisualStyleBackColor = true;
            btnJogarNovamente.Click += btnJogarNovamente_Click;
            // 
            // btnEncerrar
            // 
            btnEncerrar.Location = new Point(452, 396);
            btnEncerrar.Name = "btnEncerrar";
            btnEncerrar.Size = new Size(200, 29);
            btnEncerrar.TabIndex = 10;
            btnEncerrar.Text = "Encerrar";
            btnEncerrar.UseVisualStyleBackColor = true;
            btnEncerrar.Click += btnEncerrar_Click;
            // 
            // FormJogo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEncerrar);
            Controls.Add(btnJogarNovamente);
            Controls.Add(txtResultado);
            Controls.Add(txtEscolhaJogador);
            Controls.Add(labelEscolhaPC);
            Controls.Add(labelEscolhaJogador);
            Controls.Add(txtResultadoPC);
            Controls.Add(labelJogada);
            Controls.Add(btnTesoura);
            Controls.Add(btnPapel);
            Controls.Add(btnPedra);
            Name = "FormJogo";
            Text = "Form1";
            Load += FormJogo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPedra;
        private Button btnPapel;
        private Button btnTesoura;
        private Label labelJogada;
        private Label txtResultadoPC;
        private Label labelEscolhaJogador;
        private Label labelEscolhaPC;
        private Label txtEscolhaJogador;
        private Label txtResultado;
        private Button btnJogarNovamente;
        private Button btnEncerrar;
    }
}