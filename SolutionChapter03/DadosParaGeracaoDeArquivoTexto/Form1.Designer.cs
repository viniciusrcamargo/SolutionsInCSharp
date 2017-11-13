namespace DadosParaGeracaoDeArquivoTexto
{
    partial class FrmDadosParaGeracaoArqTexto
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
            this.dgvLeitura = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txbNumFunc = new System.Windows.Forms.TextBox();
            this.btnCriarLinhas = new System.Windows.Forms.Button();
            this.btnCriarArq = new System.Windows.Forms.Button();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.sfdGravarArquivos = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeitura)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLeitura
            // 
            this.dgvLeitura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLeitura.Location = new System.Drawing.Point(15, 60);
            this.dgvLeitura.Name = "dgvLeitura";
            this.dgvLeitura.RowTemplate.Height = 24;
            this.dgvLeitura.Size = new System.Drawing.Size(504, 315);
            this.dgvLeitura.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nr. de Funcionários:";
            // 
            // txbNumFunc
            // 
            this.txbNumFunc.Location = new System.Drawing.Point(154, 19);
            this.txbNumFunc.Name = "txbNumFunc";
            this.txbNumFunc.Size = new System.Drawing.Size(100, 22);
            this.txbNumFunc.TabIndex = 6;
            // 
            // btnCriarLinhas
            // 
            this.btnCriarLinhas.Location = new System.Drawing.Point(278, 10);
            this.btnCriarLinhas.Name = "btnCriarLinhas";
            this.btnCriarLinhas.Size = new System.Drawing.Size(241, 35);
            this.btnCriarLinhas.TabIndex = 7;
            this.btnCriarLinhas.Text = "Criar linhas para registro";
            this.btnCriarLinhas.UseVisualStyleBackColor = true;
            this.btnCriarLinhas.Click += new System.EventHandler(this.btnCriarLinhas_Click);
            // 
            // btnCriarArq
            // 
            this.btnCriarArq.Enabled = false;
            this.btnCriarArq.Location = new System.Drawing.Point(15, 382);
            this.btnCriarArq.Name = "btnCriarArq";
            this.btnCriarArq.Size = new System.Drawing.Size(239, 36);
            this.btnCriarArq.TabIndex = 8;
            this.btnCriarArq.Text = "Criar Arquivo";
            this.btnCriarArq.UseVisualStyleBackColor = true;
            this.btnCriarArq.Click += new System.EventHandler(this.btnCriarArq_Click);
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.Enabled = false;
            this.btnReiniciar.Location = new System.Drawing.Point(278, 382);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(239, 36);
            this.btnReiniciar.TabIndex = 9;
            this.btnReiniciar.Text = "Reiniciar";
            this.btnReiniciar.UseVisualStyleBackColor = true;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // sfdGravarArquivos
            // 
            this.sfdGravarArquivos.DefaultExt = "*.txt";
            this.sfdGravarArquivos.Filter = "Arquivos textos|*.txt";
            this.sfdGravarArquivos.Title = "Dados para Geração de Arquivo";
            // 
            // FrmDadosParaGeracaoArqTexto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 426);
            this.Controls.Add(this.btnReiniciar);
            this.Controls.Add(this.btnCriarArq);
            this.Controls.Add(this.btnCriarLinhas);
            this.Controls.Add(this.txbNumFunc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvLeitura);
            this.Name = "FrmDadosParaGeracaoArqTexto";
            this.Text = "Dados para geração de arquivo texto";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeitura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLeitura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbNumFunc;
        private System.Windows.Forms.Button btnCriarLinhas;
        private System.Windows.Forms.Button btnCriarArq;
        private System.Windows.Forms.Button btnReiniciar;
        private System.Windows.Forms.SaveFileDialog sfdGravarArquivos;
    }
}

