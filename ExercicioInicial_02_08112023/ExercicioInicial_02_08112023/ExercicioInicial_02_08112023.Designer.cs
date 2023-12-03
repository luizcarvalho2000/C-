namespace ExercicioInicial_02_08112023
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
            this.SuspendLayout();
            // 
            // btnMenssagem
            // 
            this.btnMenssagem.Location = new System.Drawing.Point(0, 0);
            this.btnMenssagem.Name = "btnMenssagem";
            this.btnMenssagem.Size = new System.Drawing.Size(75, 23);
            this.btnMenssagem.TabIndex = 0;
            this.btnMenssagem.Text = "Menssagem";
            this.btnMenssagem.UseVisualStyleBackColor = true;
            this.btnMenssagem.Click += new System.EventHandler(this.btnMenssagem_Click);
            // 
            // ExercicioInicial_02_08112023
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnMenssagem);
            this.Name = "ExercicioInicial_02_08112023";
            this.Text = "Formulario Feito no dia 08/11/2023";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMenssagem;
    }
}

