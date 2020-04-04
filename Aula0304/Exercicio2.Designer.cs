namespace Aula0304
{
    partial class frmExercicio2
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
            this.lblExercicio2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbnTriangulo = new System.Windows.Forms.RadioButton();
            this.rbnCirculo = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblExercicio2
            // 
            this.lblExercicio2.AutoSize = true;
            this.lblExercicio2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExercicio2.ForeColor = System.Drawing.SystemColors.Menu;
            this.lblExercicio2.Location = new System.Drawing.Point(284, 31);
            this.lblExercicio2.Name = "lblExercicio2";
            this.lblExercicio2.Size = new System.Drawing.Size(201, 42);
            this.lblExercicio2.TabIndex = 0;
            this.lblExercicio2.Text = "Exercício 2";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbnCirculo);
            this.groupBox1.Controls.Add(this.rbnTriangulo);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Menu;
            this.groupBox1.Location = new System.Drawing.Point(32, 129);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // rbnTriangulo
            // 
            this.rbnTriangulo.AutoSize = true;
            this.rbnTriangulo.ForeColor = System.Drawing.SystemColors.Menu;
            this.rbnTriangulo.Location = new System.Drawing.Point(21, 20);
            this.rbnTriangulo.Name = "rbnTriangulo";
            this.rbnTriangulo.Size = new System.Drawing.Size(94, 17);
            this.rbnTriangulo.TabIndex = 0;
            this.rbnTriangulo.TabStop = true;
            this.rbnTriangulo.Text = "Área Triângulo";
            this.rbnTriangulo.UseVisualStyleBackColor = true;
            // 
            // rbnCirculo
            // 
            this.rbnCirculo.AutoSize = true;
            this.rbnCirculo.ForeColor = System.Drawing.SystemColors.Menu;
            this.rbnCirculo.Location = new System.Drawing.Point(21, 43);
            this.rbnCirculo.Name = "rbnCirculo";
            this.rbnCirculo.Size = new System.Drawing.Size(82, 17);
            this.rbnCirculo.TabIndex = 1;
            this.rbnCirculo.TabStop = true;
            this.rbnCirculo.Text = "Área Circulo";
            this.rbnCirculo.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.ForeColor = System.Drawing.SystemColors.Menu;
            this.radioButton3.Location = new System.Drawing.Point(102, 224);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(85, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "radioButton3";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // frmExercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblExercicio2);
            this.Name = "frmExercicio2";
            this.Text = "Exercicio2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblExercicio2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbnCirculo;
        private System.Windows.Forms.RadioButton rbnTriangulo;
        private System.Windows.Forms.RadioButton radioButton3;
    }
}