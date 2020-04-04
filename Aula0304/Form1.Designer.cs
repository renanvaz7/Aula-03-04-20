namespace Aula0304
{
    partial class frmMenu
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnExercicio1 = new System.Windows.Forms.Button();
            this.btnExcercicio2 = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblExplicacao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.Menu;
            this.lblTitulo.Location = new System.Drawing.Point(227, 30);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(375, 73);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Calculadora";
            // 
            // btnExercicio1
            // 
            this.btnExercicio1.BackColor = System.Drawing.SystemColors.Menu;
            this.btnExercicio1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExercicio1.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnExercicio1.Location = new System.Drawing.Point(65, 198);
            this.btnExercicio1.Name = "btnExercicio1";
            this.btnExercicio1.Size = new System.Drawing.Size(163, 86);
            this.btnExercicio1.TabIndex = 2;
            this.btnExercicio1.Text = "Exercício 1";
            this.btnExercicio1.UseVisualStyleBackColor = false;
            this.btnExercicio1.Click += new System.EventHandler(this.btnExercicio1_Click);
            // 
            // btnExcercicio2
            // 
            this.btnExcercicio2.BackColor = System.Drawing.SystemColors.Menu;
            this.btnExcercicio2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcercicio2.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnExcercicio2.Location = new System.Drawing.Point(307, 198);
            this.btnExcercicio2.Name = "btnExcercicio2";
            this.btnExcercicio2.Size = new System.Drawing.Size(163, 86);
            this.btnExcercicio2.TabIndex = 3;
            this.btnExcercicio2.Text = "Exercício 2";
            this.btnExcercicio2.UseVisualStyleBackColor = false;
            this.btnExcercicio2.Click += new System.EventHandler(this.btnExcercicio2_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.SystemColors.Menu;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnSair.Location = new System.Drawing.Point(562, 198);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(163, 86);
            this.btnSair.TabIndex = 4;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblExplicacao
            // 
            this.lblExplicacao.AutoSize = true;
            this.lblExplicacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExplicacao.ForeColor = System.Drawing.SystemColors.Menu;
            this.lblExplicacao.Location = new System.Drawing.Point(82, 355);
            this.lblExplicacao.Name = "lblExplicacao";
            this.lblExplicacao.Size = new System.Drawing.Size(632, 50);
            this.lblExplicacao.TabIndex = 5;
            this.lblExplicacao.Text = "Este programa soluciona os Exercícios da Aula 03/04 Semana 9 \r\nclique no botão pa" +
    "ra resolver o exercício desejado.";
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblExplicacao);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnExcercicio2);
            this.Controls.Add(this.btnExercicio1);
            this.Controls.Add(this.lblTitulo);
            this.Name = "frmMenu";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnExercicio1;
        private System.Windows.Forms.Button btnExcercicio2;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblExplicacao;
    }
}

