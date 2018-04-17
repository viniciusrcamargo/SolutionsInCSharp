namespace DadosParaGeracaoDeArquivoTexto
{
    partial class FormDadosParaGeracaoDeArquivo
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
            this.label1 = new System.Windows.Forms.Label();
            this.txbNumFuncionario = new System.Windows.Forms.TextBox();
            this.btnCriarLinhas = new System.Windows.Forms.Button();
            this.dgvFuncionarios = new System.Windows.Forms.DataGridView();
            this.btnCriarArquivo = new System.Windows.Forms.Button();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.sfdGravarArquivo = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionarios)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nr. de Funcionários:";
            // 
            // txbNumFuncionario
            // 
            this.txbNumFuncionario.Location = new System.Drawing.Point(113, 10);
            this.txbNumFuncionario.Name = "txbNumFuncionario";
            this.txbNumFuncionario.Size = new System.Drawing.Size(66, 20);
            this.txbNumFuncionario.TabIndex = 1;
            // 
            // btnCriarLinhas
            // 
            this.btnCriarLinhas.Location = new System.Drawing.Point(185, 8);
            this.btnCriarLinhas.Name = "btnCriarLinhas";
            this.btnCriarLinhas.Size = new System.Drawing.Size(239, 23);
            this.btnCriarLinhas.TabIndex = 2;
            this.btnCriarLinhas.Text = "Criar linhas para registro";
            this.btnCriarLinhas.UseVisualStyleBackColor = true;
            this.btnCriarLinhas.Click += new System.EventHandler(this.btnCriarLinhas_Click);
            // 
            // dgvFuncionarios
            // 
            this.dgvFuncionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFuncionarios.Location = new System.Drawing.Point(16, 42);
            this.dgvFuncionarios.Name = "dgvFuncionarios";
            this.dgvFuncionarios.Size = new System.Drawing.Size(408, 291);
            this.dgvFuncionarios.TabIndex = 3;
            // 
            // btnCriarArquivo
            // 
            this.btnCriarArquivo.Enabled = false;
            this.btnCriarArquivo.Location = new System.Drawing.Point(16, 339);
            this.btnCriarArquivo.Name = "btnCriarArquivo";
            this.btnCriarArquivo.Size = new System.Drawing.Size(229, 23);
            this.btnCriarArquivo.TabIndex = 4;
            this.btnCriarArquivo.Text = "Criar arquivo";
            this.btnCriarArquivo.UseVisualStyleBackColor = true;
            this.btnCriarArquivo.Click += new System.EventHandler(this.btnCriarArquivo_Click);
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.Enabled = false;
            this.btnReiniciar.Location = new System.Drawing.Point(251, 339);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(173, 23);
            this.btnReiniciar.TabIndex = 5;
            this.btnReiniciar.Text = "Reiniciar";
            this.btnReiniciar.UseVisualStyleBackColor = true;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // sfdGravarArquivo
            // 
            this.sfdGravarArquivo.DefaultExt = "*.txt";
            this.sfdGravarArquivo.Filter = "Arquivos Textos|*.txt";
            this.sfdGravarArquivo.Title = "Dados para geração de arquivo";
            // 
            // FormDadosParaGeracaoDeArquivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 367);
            this.Controls.Add(this.btnReiniciar);
            this.Controls.Add(this.btnCriarArquivo);
            this.Controls.Add(this.dgvFuncionarios);
            this.Controls.Add(this.btnCriarLinhas);
            this.Controls.Add(this.txbNumFuncionario);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "FormDadosParaGeracaoDeArquivo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dados para geração de arquivos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbNumFuncionario;
        private System.Windows.Forms.Button btnCriarLinhas;
        private System.Windows.Forms.DataGridView dgvFuncionarios;
        private System.Windows.Forms.Button btnCriarArquivo;
        private System.Windows.Forms.Button btnReiniciar;
        private System.Windows.Forms.SaveFileDialog sfdGravarArquivo;
    }
}