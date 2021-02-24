namespace BancoSocialista
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnChamarSenha = new System.Windows.Forms.Button();
            this.btnGerar = new System.Windows.Forms.Button();
            this.btnSacar = new System.Windows.Forms.Button();
            this.btnDepositar = new System.Windows.Forms.Button();
            this.elementoValor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSaldo = new System.Windows.Forms.Button();
            this.btnHistorico = new System.Windows.Forms.Button();
            this.listaHistorico = new System.Windows.Forms.ListBox();
            this.senhas = new System.Windows.Forms.GroupBox();
            this.telaSenha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.senhasGeradas = new System.Windows.Forms.TextBox();
            this.telaSaldo = new System.Windows.Forms.TextBox();
            this.senhas.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "SENHA";
            // 
            // btnChamarSenha
            // 
            this.btnChamarSenha.Location = new System.Drawing.Point(26, 288);
            this.btnChamarSenha.Name = "btnChamarSenha";
            this.btnChamarSenha.Size = new System.Drawing.Size(219, 51);
            this.btnChamarSenha.TabIndex = 1;
            this.btnChamarSenha.Text = "Chamar Senha";
            this.btnChamarSenha.UseVisualStyleBackColor = true;
            this.btnChamarSenha.Click += new System.EventHandler(this.btnChamarSenha_Click);
            // 
            // btnGerar
            // 
            this.btnGerar.Location = new System.Drawing.Point(24, 346);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(219, 51);
            this.btnGerar.TabIndex = 2;
            this.btnGerar.Text = "Gerar Senha";
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // btnSacar
            // 
            this.btnSacar.Location = new System.Drawing.Point(355, 146);
            this.btnSacar.Name = "btnSacar";
            this.btnSacar.Size = new System.Drawing.Size(207, 51);
            this.btnSacar.TabIndex = 4;
            this.btnSacar.Text = "Saque";
            this.btnSacar.UseVisualStyleBackColor = true;
            this.btnSacar.Click += new System.EventHandler(this.btnSacar_Click);
            // 
            // btnDepositar
            // 
            this.btnDepositar.Location = new System.Drawing.Point(580, 146);
            this.btnDepositar.Name = "btnDepositar";
            this.btnDepositar.Size = new System.Drawing.Size(208, 51);
            this.btnDepositar.TabIndex = 5;
            this.btnDepositar.Text = "Depositar";
            this.btnDepositar.UseVisualStyleBackColor = true;
            this.btnDepositar.Click += new System.EventHandler(this.btnDepositar_Click);
            // 
            // elementoValor
            // 
            this.elementoValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.elementoValor.Location = new System.Drawing.Point(476, 95);
            this.elementoValor.Name = "elementoValor";
            this.elementoValor.Size = new System.Drawing.Size(191, 45);
            this.elementoValor.TabIndex = 6;
            this.elementoValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(530, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "CONTA";
            // 
            // btnSaldo
            // 
            this.btnSaldo.Location = new System.Drawing.Point(355, 212);
            this.btnSaldo.Name = "btnSaldo";
            this.btnSaldo.Size = new System.Drawing.Size(207, 51);
            this.btnSaldo.TabIndex = 8;
            this.btnSaldo.Text = "Saldo";
            this.btnSaldo.UseVisualStyleBackColor = true;
            this.btnSaldo.Click += new System.EventHandler(this.btnSaldo_Click);
            // 
            // btnHistorico
            // 
            this.btnHistorico.Location = new System.Drawing.Point(580, 212);
            this.btnHistorico.Name = "btnHistorico";
            this.btnHistorico.Size = new System.Drawing.Size(208, 51);
            this.btnHistorico.TabIndex = 9;
            this.btnHistorico.Text = "Histórico";
            this.btnHistorico.UseVisualStyleBackColor = true;
            this.btnHistorico.Click += new System.EventHandler(this.btnHistorico_Click);
            // 
            // listaHistorico
            // 
            this.listaHistorico.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaHistorico.FormattingEnabled = true;
            this.listaHistorico.ItemHeight = 16;
            this.listaHistorico.Location = new System.Drawing.Point(580, 269);
            this.listaHistorico.Name = "listaHistorico";
            this.listaHistorico.Size = new System.Drawing.Size(208, 164);
            this.listaHistorico.TabIndex = 11;
            // 
            // senhas
            // 
            this.senhas.Controls.Add(this.telaSenha);
            this.senhas.Controls.Add(this.label3);
            this.senhas.Controls.Add(this.senhasGeradas);
            this.senhas.Controls.Add(this.btnGerar);
            this.senhas.Controls.Add(this.btnChamarSenha);
            this.senhas.Controls.Add(this.label1);
            this.senhas.Location = new System.Drawing.Point(16, 13);
            this.senhas.Name = "senhas";
            this.senhas.Size = new System.Drawing.Size(296, 455);
            this.senhas.TabIndex = 12;
            this.senhas.TabStop = false;
            // 
            // telaSenha
            // 
            this.telaSenha.BackColor = System.Drawing.SystemColors.MenuText;
            this.telaSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 90F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telaSenha.ForeColor = System.Drawing.Color.Red;
            this.telaSenha.Location = new System.Drawing.Point(26, 82);
            this.telaSenha.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.telaSenha.Name = "telaSenha";
            this.telaSenha.ReadOnly = true;
            this.telaSenha.Size = new System.Drawing.Size(219, 143);
            this.telaSenha.TabIndex = 17;
            this.telaSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 403);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Fila";
            // 
            // senhasGeradas
            // 
            this.senhasGeradas.BackColor = System.Drawing.Color.Gainsboro;
            this.senhasGeradas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.senhasGeradas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.senhasGeradas.Location = new System.Drawing.Point(26, 426);
            this.senhasGeradas.Name = "senhasGeradas";
            this.senhasGeradas.Size = new System.Drawing.Size(219, 23);
            this.senhasGeradas.TabIndex = 14;
            // 
            // telaSaldo
            // 
            this.telaSaldo.Enabled = false;
            this.telaSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telaSaldo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.telaSaldo.Location = new System.Drawing.Point(355, 270);
            this.telaSaldo.Name = "telaSaldo";
            this.telaSaldo.Size = new System.Drawing.Size(207, 45);
            this.telaSaldo.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(896, 474);
            this.Controls.Add(this.telaSaldo);
            this.Controls.Add(this.senhas);
            this.Controls.Add(this.listaHistorico);
            this.Controls.Add(this.btnHistorico);
            this.Controls.Add(this.btnSaldo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.elementoValor);
            this.Controls.Add(this.btnDepositar);
            this.Controls.Add(this.btnSacar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Banco Da Coréia do Norte";
            this.senhas.ResumeLayout(false);
            this.senhas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnChamarSenha;
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.Button btnSacar;
        private System.Windows.Forms.Button btnDepositar;
        private System.Windows.Forms.TextBox elementoValor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSaldo;
        private System.Windows.Forms.Button btnHistorico;
        private System.Windows.Forms.ListBox listaHistorico;
        private System.Windows.Forms.GroupBox senhas;
        private System.Windows.Forms.TextBox senhasGeradas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox telaSaldo;
        private System.Windows.Forms.TextBox telaSenha;
    }
}

