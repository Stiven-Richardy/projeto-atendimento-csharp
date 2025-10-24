namespace projeto_atendimento
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
            this.lbGeracao = new System.Windows.Forms.ListBox();
            this.btnGerar = new System.Windows.Forms.Button();
            this.btnListarSenhas = new System.Windows.Forms.Button();
            this.lbAtendimentos = new System.Windows.Forms.ListBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblQtdeGuiche = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.nudGuiche = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudGuiche)).BeginInit();
            this.SuspendLayout();
            // 
            // lbGeracao
            // 
            this.lbGeracao.FormattingEnabled = true;
            this.lbGeracao.Location = new System.Drawing.Point(12, 41);
            this.lbGeracao.Name = "lbGeracao";
            this.lbGeracao.Size = new System.Drawing.Size(207, 186);
            this.lbGeracao.TabIndex = 0;
            // 
            // btnGerar
            // 
            this.btnGerar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnGerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerar.Location = new System.Drawing.Point(12, 12);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(207, 23);
            this.btnGerar.TabIndex = 1;
            this.btnGerar.Text = "Gerar";
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // btnListarSenhas
            // 
            this.btnListarSenhas.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnListarSenhas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarSenhas.Location = new System.Drawing.Point(12, 233);
            this.btnListarSenhas.Name = "btnListarSenhas";
            this.btnListarSenhas.Size = new System.Drawing.Size(207, 23);
            this.btnListarSenhas.TabIndex = 2;
            this.btnListarSenhas.Text = "Listar Senhas";
            this.btnListarSenhas.UseVisualStyleBackColor = true;
            this.btnListarSenhas.Click += new System.EventHandler(this.btnListarSenhas_Click);
            // 
            // lbAtendimentos
            // 
            this.lbAtendimentos.FormattingEnabled = true;
            this.lbAtendimentos.Location = new System.Drawing.Point(438, 41);
            this.lbAtendimentos.Name = "lbAtendimentos";
            this.lbAtendimentos.Size = new System.Drawing.Size(324, 186);
            this.lbAtendimentos.TabIndex = 3;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.Location = new System.Drawing.Point(225, 204);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(207, 23);
            this.btnAdicionar.TabIndex = 4;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(276, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Qtde Guichês";
            // 
            // lblQtdeGuiche
            // 
            this.lblQtdeGuiche.AutoSize = true;
            this.lblQtdeGuiche.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtdeGuiche.Location = new System.Drawing.Point(290, 94);
            this.lblQtdeGuiche.Name = "lblQtdeGuiche";
            this.lblQtdeGuiche.Size = new System.Drawing.Size(69, 73);
            this.lblQtdeGuiche.TabIndex = 6;
            this.lblQtdeGuiche.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(438, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Guiche:";
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(594, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(168, 23);
            this.button4.TabIndex = 9;
            this.button4.Text = "Chamar";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button5.Location = new System.Drawing.Point(438, 237);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(324, 23);
            this.button5.TabIndex = 10;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // nudGuiche
            // 
            this.nudGuiche.Location = new System.Drawing.Point(488, 15);
            this.nudGuiche.Name = "nudGuiche";
            this.nudGuiche.Size = new System.Drawing.Size(100, 20);
            this.nudGuiche.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(777, 272);
            this.Controls.Add(this.nudGuiche);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblQtdeGuiche);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.lbAtendimentos);
            this.Controls.Add(this.btnListarSenhas);
            this.Controls.Add(this.btnGerar);
            this.Controls.Add(this.lbGeracao);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudGuiche)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbGeracao;
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.Button btnListarSenhas;
        private System.Windows.Forms.ListBox lbAtendimentos;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblQtdeGuiche;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.NumericUpDown nudGuiche;
    }
}

