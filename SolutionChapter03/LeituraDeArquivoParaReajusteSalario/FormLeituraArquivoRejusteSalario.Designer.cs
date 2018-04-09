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
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTotalSemReajuste = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvLeitura = new System.Windows.Forms.DataGridView();
            this.ofdListaFuncionarios = new System.Windows.Forms.OpenFileDialog();
            this.lblTotalComReajuste = new System.Windows.Forms.Label();
            this.lblPercentualReajuste = new System.Windows.Forms.Label();
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
            this.tbCaminhoArq.Location = new System.Drawing.Point(10, 11);
            this.tbCaminhoArq.Margin = new System.Windows.Forms.Padding(2);
            this.tbCaminhoArq.Name = "tbCaminhoArq";
            this.tbCaminhoArq.Size = new System.Drawing.Size(487, 20);
            this.tbCaminhoArq.TabIndex = 0;
            // 
            // btnAbrirArq
            // 
            this.btnAbrirArq.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrirArq.Location = new System.Drawing.Point(508, 4);
            this.btnAbrirArq.Margin = new System.Windows.Forms.Padding(2);
            this.btnAbrirArq.Name = "btnAbrirArq";
            this.btnAbrirArq.Size = new System.Drawing.Size(56, 28);
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
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 189F));
            this.tableLayoutPanel1.Controls.Add(this.panel3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 37);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(555, 70);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblPercentualReajuste);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(367, 2);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(183, 65);
            this.panel3.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(10, 7);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Percentual Reajuste";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblTotalComReajuste);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(173, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(190, 65);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(16, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Total Com Reajuste";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblTotalSemReajuste);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(167, 65);
            this.panel1.TabIndex = 0;
            // 
            // lblTotalSemReajuste
            // 
            this.lblTotalSemReajuste.AutoSize = true;
            this.lblTotalSemReajuste.Font = new System.Drawing.Font("Courier New", 10F);
            this.lblTotalSemReajuste.Location = new System.Drawing.Point(25, 31);
            this.lblTotalSemReajuste.Name = "lblTotalSemReajuste";
            this.lblTotalSemReajuste.Size = new System.Drawing.Size(56, 17);
            this.lblTotalSemReajuste.TabIndex = 1;
            this.lblTotalSemReajuste.Text = "label1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(10, 7);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Total Sem Reajuste";
            // 
            // dgvLeitura
            // 
            this.dgvLeitura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLeitura.Location = new System.Drawing.Point(12, 119);
            this.dgvLeitura.Margin = new System.Windows.Forms.Padding(2);
            this.dgvLeitura.Name = "dgvLeitura";
            this.dgvLeitura.RowTemplate.Height = 24;
            this.dgvLeitura.Size = new System.Drawing.Size(553, 210);
            this.dgvLeitura.TabIndex = 3;
            // 
            // ofdListaFuncionarios
            // 
            this.ofdListaFuncionarios.DefaultExt = "*.txt";
            this.ofdListaFuncionarios.FileName = "openFileDialog1";
            this.ofdListaFuncionarios.Filter = "Arquivos textos|*.txt";
            this.ofdListaFuncionarios.Title = "Seleção do arquivo com dados de funcionários";
            // 
            // lblTotalComReajuste
            // 
            this.lblTotalComReajuste.AutoSize = true;
            this.lblTotalComReajuste.Font = new System.Drawing.Font("Courier New", 10F);
            this.lblTotalComReajuste.Location = new System.Drawing.Point(37, 31);
            this.lblTotalComReajuste.Name = "lblTotalComReajuste";
            this.lblTotalComReajuste.Size = new System.Drawing.Size(56, 17);
            this.lblTotalComReajuste.TabIndex = 1;
            this.lblTotalComReajuste.Text = "label1";
            // 
            // lblPercentualReajuste
            // 
            this.lblPercentualReajuste.AutoSize = true;
            this.lblPercentualReajuste.Font = new System.Drawing.Font("Courier New", 10F);
            this.lblPercentualReajuste.Location = new System.Drawing.Point(64, 31);
            this.lblPercentualReajuste.Name = "lblPercentualReajuste";
            this.lblPercentualReajuste.Size = new System.Drawing.Size(56, 17);
            this.lblPercentualReajuste.TabIndex = 1;
            this.lblPercentualReajuste.Text = "label1";
            // 
            // FrmLeituraArquivoReajuste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 339);
            this.Controls.Add(this.dgvLeitura);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btnAbrirArq);
            this.Controls.Add(this.tbCaminhoArq);
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvLeitura;
        private System.Windows.Forms.OpenFileDialog ofdListaFuncionarios;
        private System.Windows.Forms.Label lblTotalSemReajuste;
        private System.Windows.Forms.Label lblPercentualReajuste;
        private System.Windows.Forms.Label lblTotalComReajuste;
    }
}

