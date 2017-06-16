namespace LotacaoPessoas
{
    partial class FrmLotacaoPessoas
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblLotacao = new System.Windows.Forms.Label();
            this.pbLogo2 = new System.Windows.Forms.PictureBox();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(261, 50);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(774, 91);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Lotação de Pessoas";
            // 
            // lblLotacao
            // 
            this.lblLotacao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLotacao.Font = new System.Drawing.Font("Arial Narrow", 300F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLotacao.Location = new System.Drawing.Point(60, 177);
            this.lblLotacao.Name = "lblLotacao";
            this.lblLotacao.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblLotacao.Size = new System.Drawing.Size(1025, 374);
            this.lblLotacao.TabIndex = 3;
            this.lblLotacao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbLogo2
            // 
            this.pbLogo2.BackgroundImage = global::LotacaoPessoas.Properties.Resources.festajunina;
            this.pbLogo2.Location = new System.Drawing.Point(1067, 38);
            this.pbLogo2.Name = "pbLogo2";
            this.pbLogo2.Size = new System.Drawing.Size(150, 127);
            this.pbLogo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo2.TabIndex = 2;
            this.pbLogo2.TabStop = false;
            // 
            // pbLogo
            // 
            this.pbLogo.BackgroundImage = global::LotacaoPessoas.Properties.Resources.festajunina;
            this.pbLogo.Location = new System.Drawing.Point(60, 38);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(150, 127);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 1;
            this.pbLogo.TabStop = false;
            // 
            // FrmLotacaoPessoas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 566);
            this.Controls.Add(this.lblLotacao);
            this.Controls.Add(this.pbLogo2);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.lblTitulo);
            this.KeyPreview = true;
            this.Name = "FrmLotacaoPessoas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lotação de Pessoas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmLotacaoPessoas_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FrmLotacaoPessoas_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.PictureBox pbLogo2;
        private System.Windows.Forms.Label lblLotacao;
    }
}

