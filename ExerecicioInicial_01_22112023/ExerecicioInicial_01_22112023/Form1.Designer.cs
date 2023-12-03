namespace ExerecicioInicial_01_22112023
{
    partial class Form1
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
            this.btnMenssagem.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnMenssagem.Location = new System.Drawing.Point(207, 296);
            this.btnMenssagem.Name = "btnMenssagem";
            this.btnMenssagem.Size = new System.Drawing.Size(295, 33);
            this.btnMenssagem.TabIndex = 0;
            this.btnMenssagem.Text = "Menssagem";
            this.btnMenssagem.UseVisualStyleBackColor = true;
            this.btnMenssagem.Click += new System.EventHandler(this.btnMenssagem_Click);
            // 
            // btnDesvioCond
            // 
            this.btnDesvioCond.Location = new System.Drawing.Point(207, 344);
            this.btnDesvioCond.Name = "btnDesvioCond";
            this.btnDesvioCond.Size = new System.Drawing.Size(295, 30);
            this.btnDesvioCond.TabIndex = 1;
            this.btnDesvioCond.Text = "Desvio Condicional";
            this.btnDesvioCond.UseVisualStyleBackColor = true;
            this.btnDesvioCond.Click += new System.EventHandler(this.btnDesvioCond_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(710, 658);
            this.Controls.Add(this.btnDesvioCond);
            this.Controls.Add(this.btnMenssagem);
            this.Name = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        
        private System.Windows.Forms.Button btnMenssagem;
        private System.Windows.Forms.Button btnDesvioCond;
    }
}

