namespace FormRestoDivisao
{
    partial class FrmRestoDeDivisao
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
            this.lblDividendo = new System.Windows.Forms.Label();
            this.lblDivisor = new System.Windows.Forms.Label();
            this.txbDividendo = new System.Windows.Forms.TextBox();
            this.txbDivisor = new System.Windows.Forms.TextBox();
            this.lblResto = new System.Windows.Forms.Label();
            this.btnDivisao = new System.Windows.Forms.Button();
            this.txbResto = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblDividendo
            // 
            this.lblDividendo.AutoSize = true;
            this.lblDividendo.Location = new System.Drawing.Point(1, 7);
            this.lblDividendo.Name = "lblDividendo";
            this.lblDividendo.Size = new System.Drawing.Size(55, 13);
            this.lblDividendo.TabIndex = 0;
            this.lblDividendo.Text = "Dividendo";
            // 
            // lblDivisor
            // 
            this.lblDivisor.AutoSize = true;
            this.lblDivisor.Location = new System.Drawing.Point(162, 6);
            this.lblDivisor.Name = "lblDivisor";
            this.lblDivisor.Size = new System.Drawing.Size(39, 13);
            this.lblDivisor.TabIndex = 1;
            this.lblDivisor.Text = "Divisor";
            // 
            // txbDividendo
            // 
            this.txbDividendo.Location = new System.Drawing.Point(56, 3);
            this.txbDividendo.Name = "txbDividendo";
            this.txbDividendo.Size = new System.Drawing.Size(100, 20);
            this.txbDividendo.TabIndex = 2;
            // 
            // txbDivisor
            // 
            this.txbDivisor.Location = new System.Drawing.Point(207, 3);
            this.txbDivisor.Name = "txbDivisor";
            this.txbDivisor.Size = new System.Drawing.Size(100, 20);
            this.txbDivisor.TabIndex = 3;
            // 
            // lblResto
            // 
            this.lblResto.AutoSize = true;
            this.lblResto.Location = new System.Drawing.Point(165, 36);
            this.lblResto.Name = "lblResto";
            this.lblResto.Size = new System.Drawing.Size(35, 13);
            this.lblResto.TabIndex = 4;
            this.lblResto.Text = "Resto";
            // 
            // btnDivisao
            // 
            this.btnDivisao.Location = new System.Drawing.Point(25, 29);
            this.btnDivisao.Name = "btnDivisao";
            this.btnDivisao.Size = new System.Drawing.Size(131, 23);
            this.btnDivisao.TabIndex = 5;
            this.btnDivisao.Text = "Realizar Divisão";
            this.btnDivisao.UseVisualStyleBackColor = true;
            this.btnDivisao.Click += new System.EventHandler(this.btnDivisao_Click);
            // 
            // txbResto
            // 
            this.txbResto.Enabled = false;
            this.txbResto.Location = new System.Drawing.Point(206, 31);
            this.txbResto.Name = "txbResto";
            this.txbResto.Size = new System.Drawing.Size(100, 20);
            this.txbResto.TabIndex = 6;
            // 
            // FrmRestoDeDivisao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 61);
            this.Controls.Add(this.txbResto);
            this.Controls.Add(this.btnDivisao);
            this.Controls.Add(this.lblResto);
            this.Controls.Add(this.txbDivisor);
            this.Controls.Add(this.txbDividendo);
            this.Controls.Add(this.lblDivisor);
            this.Controls.Add(this.lblDividendo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmRestoDeDivisao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resto de uma divisão";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDividendo;
        private System.Windows.Forms.Label lblDivisor;
        private System.Windows.Forms.TextBox txbDividendo;
        private System.Windows.Forms.TextBox txbDivisor;
        private System.Windows.Forms.Label lblResto;
        private System.Windows.Forms.Button btnDivisao;
        private System.Windows.Forms.TextBox txbResto;
    }
}

