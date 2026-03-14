namespace JokempoWinForm
{
    partial class FormEstatisticas
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
            label1 = new Label();
            flpEstatisticas = new FlowLayoutPanel();
            btnFinalizar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(114, 41);
            label1.Name = "label1";
            label1.Size = new Size(293, 28);
            label1.TabIndex = 0;
            label1.Text = "📊 Estatísticas dos Jogadores";
            label1.Click += label1_Click;
            // 
            // flpEstatisticas
            // 
            flpEstatisticas.BackColor = Color.Transparent;
            flpEstatisticas.Location = new Point(114, 100);
            flpEstatisticas.Name = "flpEstatisticas";
            flpEstatisticas.Size = new Size(935, 365);
            flpEstatisticas.TabIndex = 4;
            flpEstatisticas.Paint += flpEstatisticas_Paint;
            // 
            // btnFinalizar
            // 
            btnFinalizar.Location = new Point(540, 502);
            btnFinalizar.Name = "btnFinalizar";
            btnFinalizar.Size = new Size(94, 29);
            btnFinalizar.TabIndex = 5;
            btnFinalizar.Text = "Finalizar";
            btnFinalizar.UseVisualStyleBackColor = true;
            btnFinalizar.Click += btnFinalizar_Click;
            // 
            // FormEstatisticas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1155, 559);
            Controls.Add(btnFinalizar);
            Controls.Add(flpEstatisticas);
            Controls.Add(label1);
            Name = "FormEstatisticas";
            Text = "Estatísticas";
            Load += FormEstatisticas_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private FlowLayoutPanel flpEstatisticas;
        private Button btnFinalizar;
    }
}