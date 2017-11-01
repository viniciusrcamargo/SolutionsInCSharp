namespace LeituraDeArquivoParaReajusteSalario
{
    partial class FrmLeituraArquivoReajuste
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
            this.tbCaminhoArq = new System.Windows.Forms.TextBox();
            this.btnAbrirArq = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblPercentualReajuste = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTotalComReajuste = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTotalSemReajuste = new System.Windows.Forms.Label();
            this.dgvLeitura = new System.Windows.Forms.DataGridView();
            this.ofdListaFuncionarios = new System.Windows.Forms.OpenFileDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeitura)).BeginInit();
            this.SuspendLayout();
            // 
            // tbCaminhoArq
            // 
            this.tbCaminhoArq.Enabled = false;
            this.tbCaminhoArq.Location = new System.Drawing.Point(13, 13);
            this.tbCaminhoArq.Name = "tbCaminhoArq";
            this.tbCaminhoArq.Size = new System.Drawing.Size(648, 22);
            this.tbCaminhoArq.TabIndex = 0;
            // 
            // btnAbrirArq
            // 
            this.btnAbrirArq.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrirArq.Location = new System.Drawing.Point(678, 5);
            this.btnAbrirArq.Name = "btnAbrirArq";
            this.btnAbrirArq.Size = new System.Drawing.Size(75, 34);
            this.btnAbrirArq.TabIndex = 1;
            this.btnAbrirArq.Text = "...";
            this.btnAbrirArq.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAbrirArq.UseVisualStyleBackColor = true;
            this.btnAbrirArq.Click += new System.EventHandler(this.btnAbrirArq_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.98113F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.01887F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tableLayoutPanel1.Controls.Add(this.panel3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 45);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(740, 86);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblPercentualReajuste);
            this.panel3.Location = new System.Drawing.Point(492, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(244, 80);
            this.panel3.TabIndex = 2;
            // 
            // lblPercentualReajuste
            // 
            this.lblPercentualReajuste.AutoSize = true;
            this.lblPercentualReajuste.Font = new System.Drawing.Font("Courier New", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPercentualReajuste.Location = new System.Drawing.Point(13, 9);
            this.lblPercentualReajuste.Name = "lblPercentualReajuste";
            this.lblPercentualReajuste.Size = new System.Drawing.Size(219, 22);
            this.lblPercentualReajuste.TabIndex = 0;
            this.lblPercentualReajuste.Text = "Percentual Reajuste";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblTotalComReajuste);
            this.panel2.Location = new System.Drawing.Point(233, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(253, 80);
            this.panel2.TabIndex = 1;
            // 
            // lblTotalComReajuste
            // 
            this.lblTotalComReajuste.AutoSize = true;
            this.lblTotalComReajuste.Font = new System.Drawing.Font("Courier New", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalComReajuste.Location = new System.Drawing.Point(21, 9);
            this.lblTotalComReajuste.Name = "lblTotalComReajuste";
            this.lblTotalComReajuste.Size = new System.Drawing.Size(208, 22);
            this.lblTotalComReajuste.TabIndex = 0;
            this.lblTotalComReajuste.Text = "Total Com Reajuste";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblTotalSemReajuste);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(224, 80);
            this.panel1.TabIndex = 0;
            // 
            // lblTotalSemReajuste
            // 
            this.lblTotalSemReajuste.AutoSize = true;
            this.lblTotalSemReajuste.Font = new System.Drawing.Font("Courier New", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSemReajuste.Location = new System.Drawing.Point(14, 9);
            this.lblTotalSemReajuste.Name = "lblTotalSemReajuste";
            this.lblTotalSemReajuste.Size = new System.Drawing.Size(208, 22);
            this.lblTotalSemReajuste.TabIndex = 0;
            this.lblTotalSemReajuste.Text = "Total Sem Reajuste";
            // 
            // dgvLeitura
            // 
            this.dgvLeitura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLeitura.Location = new System.Drawing.Point(16, 147);
            this.dgvLeitura.Name = "dgvLeitura";
            this.dgvLeitura.RowTemplate.Height = 24;
            this.dgvLeitura.Size = new System.Drawing.Size(737, 258);
            this.dgvLeitura.TabIndex = 3;
            // 
            // ofdListaFuncionarios
            // 
            this.ofdListaFuncionarios.DefaultExt = "*.txt";
            this.ofdListaFuncionarios.FileName = "openFileDialog1";
            this.ofdListaFuncionarios.Filter = "Arquivos textos|*.txt";
            this.ofdListaFuncionarios.Title = "Seleção do arquivo com dados de funcionários";
            // 
            // FrmLeituraArquivoReajuste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 417);
            this.Controls.Add(this.dgvLeitura);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btnAbrirArq);
            this.Controls.Add(this.tbCaminhoArq);
            this.Name = "FrmLeituraArquivoReajuste";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Leitura de Arquivo para Reajuste de Salário";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeitura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbCaminhoArq;
        private System.Windows.Forms.Button btnAbrirArq;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblPercentualReajuste;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTotalComReajuste;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTotalSemReajuste;
        private System.Windows.Forms.DataGridView dgvLeitura;
        private System.Windows.Forms.OpenFileDialog ofdListaFuncionarios;
    }
}

