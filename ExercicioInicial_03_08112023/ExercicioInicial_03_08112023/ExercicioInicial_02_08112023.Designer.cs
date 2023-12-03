namespace ExercicioInicial_03_08112023
{
    partial class ExercicioInicial_02_08112023
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
            this.btnMenssagem = new System.Windows.Forms.Button();
            this.btnDesvioCond = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMenssagem
            // 
            this.btnMenssagem.Location = new System.Drawing.Point(97, 126);
            this.btnMenssagem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMenssagem.Name = "btnMenssagem";
            this.btnMenssagem.Size = new System.Drawing.Size(230, 38);
            this.btnMenssagem.TabIndex = 0;
            this.btnMenssagem.Text = "Menssagem";
            this.btnMenssagem.UseVisualStyleBackColor = true;
            this.btnMenssagem.Click += new System.EventHandler(this.btnMenssagem_Click);
            // 
            // btnDesvioCond
            // 
            this.btnDesvioCond.Location = new System.Drawing.Point(97, 189);
            this.btnDesvioCond.Name = "btnDesvioCond";
            this.btnDesvioCond.Size = new System.Drawing.Size(230, 40);
            this.btnDesvioCond.TabIndex = 1;
            this.btnDesvioCond.Text = "Desvio Condicional";
            this.btnDesvioCond.UseVisualStyleBackColor = true;
            this.btnDesvioCond.Click += new System.EventHandler(this.btnDesvioCond_Click);
            // 
            // ExercicioInicial_02_08112023
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 402);
            this.Controls.Add(this.btnDesvioCond);
            this.Controls.Add(this.btnMenssagem);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ExercicioInicial_02_08112023";
            this.Text = "Exercicio feito no dia 08/11/2023";
            this.Load += new System.EventHandler(this.ExercicioInicial_02_08112023_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMenssagem;
        private System.Windows.Forms.Button btnDesvioCond;
    }
}

