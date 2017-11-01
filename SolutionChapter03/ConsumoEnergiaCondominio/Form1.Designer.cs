namespace ConsumoEnergiaCondominio
{
    partial class FrmConsEnergiaCond
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
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotalSemDesc = new System.Windows.Forms.Label();
            this.txbNumCasa = new System.Windows.Forms.TextBox();
            this.txbConsumo = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnProcessarDados = new System.Windows.Forms.Button();
            this.dgvLeitura = new System.Windows.Forms.DataGridView();
            this.Casa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Consumo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Desconto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeitura)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número da Casa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(342, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Consumo:";
            // 
            // lblTotalSemDesc
            // 
            this.lblTotalSemDesc.AutoSize = true;
            this.lblTotalSemDesc.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSemDesc.Location = new System.Drawing.Point(291, 416);
            this.lblTotalSemDesc.Name = "lblTotalSemDesc";
            this.lblTotalSemDesc.Size = new System.Drawing.Size(347, 24);
            this.lblTotalSemDesc.TabIndex = 2;
            this.lblTotalSemDesc.Text = "Total consumo sem desconto R$";
            // 
            // txbNumCasa
            // 
            this.txbNumCasa.Location = new System.Drawing.Point(200, 35);
            this.txbNumCasa.Name = "txbNumCasa";
            this.txbNumCasa.Size = new System.Drawing.Size(118, 22);
            this.txbNumCasa.TabIndex = 3;
            // 
            // txbConsumo
            // 
            this.txbConsumo.Location = new System.Drawing.Point(455, 34);
            this.txbConsumo.Name = "txbConsumo";
            this.txbConsumo.Size = new System.Drawing.Size(132, 22);
            this.txbConsumo.TabIndex = 4;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(596, 31);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(118, 28);
            this.btnRegistrar.TabIndex = 5;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnProcessarDados
            // 
            this.btnProcessarDados.Location = new System.Drawing.Point(20, 412);
            this.btnProcessarDados.Name = "btnProcessarDados";
            this.btnProcessarDados.Size = new System.Drawing.Size(141, 28);
            this.btnProcessarDados.TabIndex = 6;
            this.btnProcessarDados.Text = "Processar Dados";
            this.btnProcessarDados.UseVisualStyleBackColor = true;
            this.btnProcessarDados.Click += new System.EventHandler(this.btnProcessarDados_Click);
            // 
            // dgvLeitura
            // 
            this.dgvLeitura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLeitura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Casa,
            this.Consumo,
            this.Desconto});
            this.dgvLeitura.Location = new System.Drawing.Point(20, 79);
            this.dgvLeitura.Name = "dgvLeitura";
            this.dgvLeitura.RowTemplate.Height = 24;
            this.dgvLeitura.Size = new System.Drawing.Size(694, 316);
            this.dgvLeitura.TabIndex = 7;
            // 
            // Casa
            // 
            this.Casa.HeaderText = "Column1";
            this.Casa.Name = "Casa";
            this.Casa.Width = 210;
            // 
            // Consumo
            // 
            this.Consumo.HeaderText = "Consumo";
            this.Consumo.Name = "Consumo";
            this.Consumo.Width = 210;
            // 
            // Desconto
            // 
            this.Desconto.HeaderText = "Desconto";
            this.Desconto.Name = "Desconto";
            this.Desconto.Width = 210;
            // 
            // FrmConsEnergiaCond
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 458);
            this.Controls.Add(this.dgvLeitura);
            this.Controls.Add(this.btnProcessarDados);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.txbConsumo);
            this.Controls.Add(this.txbNumCasa);
            this.Controls.Add(this.lblTotalSemDesc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmConsEnergiaCond";
            this.Text = "Consumo de Energia de Condomínio";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeitura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotalSemDesc;
        private System.Windows.Forms.TextBox txbNumCasa;
        private System.Windows.Forms.TextBox txbConsumo;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnProcessarDados;
        private System.Windows.Forms.DataGridView dgvLeitura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Casa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Consumo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Desconto;
    }
}

