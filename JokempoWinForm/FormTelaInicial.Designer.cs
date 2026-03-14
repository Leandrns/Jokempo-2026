namespace JokempoWinForm
{
    partial class FormTelaInicial
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelNome = new Label();
            btnJogar = new Button();
            txtTitle = new Label();
            inputName = new TextBox();
            listJogadores = new ListBox();
            labelJogadores = new Label();
            SuspendLayout();
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Location = new Point(159, 130);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(121, 20);
            labelNome.TabIndex = 0;
            labelNome.Text = "Digite seu nome:";
            labelNome.Click += labelName_Click;
            // 
            // btnJogar
            // 
            btnJogar.BackColor = Color.White;
            btnJogar.Location = new Point(354, 256);
            btnJogar.Name = "btnJogar";
            btnJogar.Size = new Size(94, 29);
            btnJogar.TabIndex = 1;
            btnJogar.Text = "Jogar";
            btnJogar.UseVisualStyleBackColor = false;
            btnJogar.Click += btnJogar_Click;
            // 
            // txtTitle
            // 
            txtTitle.AutoSize = true;
            txtTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTitle.Location = new Point(276, 34);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(267, 28);
            txtTitle.TabIndex = 2;
            txtTitle.Text = "Bem-vindo(a) ao Jokempo!";
            txtTitle.Click += txtTitle_Click;
            // 
            // inputName
            // 
            inputName.Location = new Point(286, 127);
            inputName.Name = "inputName";
            inputName.Size = new Size(248, 27);
            inputName.TabIndex = 3;
            inputName.TextChanged += inputName_TextChanged;
            // 
            // listJogadores
            // 
            listJogadores.FormattingEnabled = true;
            listJogadores.Location = new Point(613, 149);
            listJogadores.Name = "listJogadores";
            listJogadores.Size = new Size(160, 104);
            listJogadores.TabIndex = 4;
            listJogadores.SelectedIndexChanged += listJogadores_SelectedIndexChanged;
            // 
            // labelJogadores
            // 
            labelJogadores.AutoSize = true;
            labelJogadores.Location = new Point(613, 126);
            labelJogadores.Name = "labelJogadores";
            labelJogadores.Size = new Size(160, 20);
            labelJogadores.TabIndex = 5;
            labelJogadores.Text = "Jogadores Disponíveis:";
            labelJogadores.Click += labelJogadores_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelJogadores);
            Controls.Add(listJogadores);
            Controls.Add(inputName);
            Controls.Add(txtTitle);
            Controls.Add(btnJogar);
            Controls.Add(labelNome);
            Name = "Form1";
            Text = "Tela inicial";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelNome;
        private Button btnJogar;
        private Label txtTitle;
        private TextBox inputName;
        private ListBox listJogadores;
        private Label labelJogadores;
    }
}
