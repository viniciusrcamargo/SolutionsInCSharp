namespace CalculodeSalario
{
    partial class FrmCalculodeSalario
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSalMinimo = new System.Windows.Forms.TextBox();
            this.tbHorasTrab = new System.Windows.Forms.TextBox();
            this.grpTurno = new System.Windows.Forms.GroupBox();
            this.rbNoturno = new System.Windows.Forms.RadioButton();
            this.rbVespertino = new System.Windows.Forms.RadioButton();
            this.rbMatutino = new System.Windows.Forms.RadioButton();
            this.gbCategoria = new System.Windows.Forms.GroupBox();
            this.rbVeterano = new System.Windows.Forms.RadioButton();
            this.rbCalouro = new System.Windows.Forms.RadioButton();
            this.lblSituacao = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lbResultado = new System.Windows.Forms.ListBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.grpTurno.SuspendLayout();
            this.gbCategoria.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Salário Mínino:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Horas trabalhadas:";
            // 
            // tbSalMinimo
            // 
            this.tbSalMinimo.BackColor = System.Drawing.Color.Yellow;
            this.tbSalMinimo.ForeColor = System.Drawing.Color.Blue;
            this.tbSalMinimo.Location = new System.Drawing.Point(109, 14);
            this.tbSalMinimo.Name = "tbSalMinimo";
            this.tbSalMinimo.Size = new System.Drawing.Size(100, 20);
            this.tbSalMinimo.TabIndex = 2;
            this.toolTip1.SetToolTip(this.tbSalMinimo, "Informe o valor atual do salário mínimo");
            // 
            // tbHorasTrab
            // 
            this.tbHorasTrab.Location = new System.Drawing.Point(110, 39);
            this.tbHorasTrab.Name = "tbHorasTrab";
            this.tbHorasTrab.Size = new System.Drawing.Size(100, 20);
            this.tbHorasTrab.TabIndex = 3;
            // 
            // grpTurno
            // 
            this.grpTurno.Controls.Add(this.rbNoturno);
            this.grpTurno.Controls.Add(this.rbVespertino);
            this.grpTurno.Controls.Add(this.rbMatutino);
            this.grpTurno.Location = new System.Drawing.Point(263, 12);
            this.grpTurno.Name = "grpTurno";
            this.grpTurno.Size = new System.Drawing.Size(154, 92);
            this.grpTurno.TabIndex = 4;
            this.grpTurno.TabStop = false;
            this.grpTurno.Text = "Turno";
            // 
            // rbNoturno
            // 
            this.rbNoturno.AutoSize = true;
            this.rbNoturno.Location = new System.Drawing.Point(17, 59);
            this.rbNoturno.Name = "rbNoturno";
            this.rbNoturno.Size = new System.Drawing.Size(63, 17);
            this.rbNoturno.TabIndex = 2;
            this.rbNoturno.TabStop = true;
            this.rbNoturno.Text = "Noturno";
            this.rbNoturno.UseVisualStyleBackColor = true;
            // 
            // rbVespertino
            // 
            this.rbVespertino.AutoSize = true;
            this.rbVespertino.Location = new System.Drawing.Point(16, 38);
            this.rbVespertino.Name = "rbVespertino";
            this.rbVespertino.Size = new System.Drawing.Size(73, 17);
            this.rbVespertino.TabIndex = 1;
            this.rbVespertino.TabStop = true;
            this.rbVespertino.Text = "Verpertino";
            this.rbVespertino.UseVisualStyleBackColor = true;
            // 
            // rbMatutino
            // 
            this.rbMatutino.AutoSize = true;
            this.rbMatutino.Location = new System.Drawing.Point(16, 18);
            this.rbMatutino.Name = "rbMatutino";
            this.rbMatutino.Size = new System.Drawing.Size(66, 17);
            this.rbMatutino.TabIndex = 0;
            this.rbMatutino.TabStop = true;
            this.rbMatutino.Text = "Matutino";
            this.rbMatutino.UseVisualStyleBackColor = true;
            // 
            // gbCategoria
            // 
            this.gbCategoria.Controls.Add(this.rbVeterano);
            this.gbCategoria.Controls.Add(this.rbCalouro);
            this.gbCategoria.Location = new System.Drawing.Point(16, 65);
            this.gbCategoria.Name = "gbCategoria";
            this.gbCategoria.Size = new System.Drawing.Size(216, 39);
            this.gbCategoria.TabIndex = 5;
            this.gbCategoria.TabStop = false;
            this.gbCategoria.Text = "Categoria";
            // 
            // rbVeterano
            // 
            this.rbVeterano.AutoSize = true;
            this.rbVeterano.Location = new System.Drawing.Point(135, 16);
            this.rbVeterano.Name = "rbVeterano";
            this.rbVeterano.Size = new System.Drawing.Size(68, 17);
            this.rbVeterano.TabIndex = 1;
            this.rbVeterano.TabStop = true;
            this.rbVeterano.Text = "Veterano";
            this.rbVeterano.UseVisualStyleBackColor = true;
            // 
            // rbCalouro
            // 
            this.rbCalouro.AutoSize = true;
            this.rbCalouro.Location = new System.Drawing.Point(22, 16);
            this.rbCalouro.Name = "rbCalouro";
            this.rbCalouro.Size = new System.Drawing.Size(61, 17);
            this.rbCalouro.TabIndex = 0;
            this.rbCalouro.TabStop = true;
            this.rbCalouro.Text = "Calouro";
            this.rbCalouro.UseVisualStyleBackColor = true;
            // 
            // lblSituacao
            // 
            this.lblSituacao.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSituacao.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSituacao.Location = new System.Drawing.Point(14, 249);
            this.lblSituacao.Name = "lblSituacao";
            this.lblSituacao.Size = new System.Drawing.Size(322, 23);
            this.lblSituacao.TabIndex = 7;
            this.lblSituacao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(342, 249);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 8;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lbResultado
            // 
            this.lbResultado.FormattingEnabled = true;
            this.lbResultado.Location = new System.Drawing.Point(14, 110);
            this.lbResultado.MultiColumn = true;
            this.lbResultado.Name = "lbResultado";
            this.lbResultado.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbResultado.Size = new System.Drawing.Size(403, 134);
            this.lbResultado.TabIndex = 9;
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Ajuda";
            // 
            // FrmCalculodeSalario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 290);
            this.Controls.Add(this.lbResultado);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblSituacao);
            this.Controls.Add(this.gbCategoria);
            this.Controls.Add(this.grpTurno);
            this.Controls.Add(this.tbHorasTrab);
            this.Controls.Add(this.tbSalMinimo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmCalculodeSalario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cálculo de Salários";
            this.grpTurno.ResumeLayout(false);
            this.grpTurno.PerformLayout();
            this.gbCategoria.ResumeLayout(false);
            this.gbCategoria.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSalMinimo;
        private System.Windows.Forms.TextBox tbHorasTrab;
        private System.Windows.Forms.GroupBox grpTurno;
        private System.Windows.Forms.RadioButton rbNoturno;
        private System.Windows.Forms.RadioButton rbVespertino;
        private System.Windows.Forms.RadioButton rbMatutino;
        private System.Windows.Forms.GroupBox gbCategoria;
        private System.Windows.Forms.RadioButton rbVeterano;
        private System.Windows.Forms.RadioButton rbCalouro;
        private System.Windows.Forms.Label lblSituacao;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.ListBox lbResultado;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

