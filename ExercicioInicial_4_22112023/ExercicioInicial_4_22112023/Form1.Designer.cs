namespace ExercicioInicial_4_22112023
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
            this.btnDesvioCad = new System.Windows.Forms.Button();
            this.btnSwitchCase = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.listBoxPreferencias = new System.Windows.Forms.ListBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnImportaTxtDoWhile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMenssagem
            // 
            this.btnMenssagem.Location = new System.Drawing.Point(12, 60);
            this.btnMenssagem.Name = "btnMenssagem";
            this.btnMenssagem.Size = new System.Drawing.Size(280, 39);
            this.btnMenssagem.TabIndex = 0;
            this.btnMenssagem.Text = "Menssagem";
            this.btnMenssagem.UseVisualStyleBackColor = true;
            this.btnMenssagem.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDesvioCond
            // 
            this.btnDesvioCond.Location = new System.Drawing.Point(12, 119);
            this.btnDesvioCond.Name = "btnDesvioCond";
            this.btnDesvioCond.Size = new System.Drawing.Size(280, 39);
            this.btnDesvioCond.TabIndex = 1;
            this.btnDesvioCond.Text = "Desvio Condicional";
            this.btnDesvioCond.UseVisualStyleBackColor = true;
            this.btnDesvioCond.Click += new System.EventHandler(this.btnDesvioCond_Click);
            // 
            // btnDesvioCad
            // 
            this.btnDesvioCad.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnDesvioCad.Location = new System.Drawing.Point(12, 177);
            this.btnDesvioCad.Name = "btnDesvioCad";
            this.btnDesvioCad.Size = new System.Drawing.Size(280, 37);
            this.btnDesvioCad.TabIndex = 2;
            this.btnDesvioCad.Text = "Desvio Encadeado";
            this.btnDesvioCad.UseVisualStyleBackColor = true;
            this.btnDesvioCad.Click += new System.EventHandler(this.btnDesvioCad_Click);
            // 
            // btnSwitchCase
            // 
            this.btnSwitchCase.Location = new System.Drawing.Point(12, 232);
            this.btnSwitchCase.Name = "btnSwitchCase";
            this.btnSwitchCase.Size = new System.Drawing.Size(280, 39);
            this.btnSwitchCase.TabIndex = 3;
            this.btnSwitchCase.Text = "Switch Case";
            this.btnSwitchCase.UseVisualStyleBackColor = true;
            this.btnSwitchCase.Click += new System.EventHandler(this.btnSwitchCase_Click);
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(12, 297);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(280, 36);
            this.btnImport.TabIndex = 4;
            this.btnImport.Text = "Importar texto Whille";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // listBoxPreferencias
            // 
            this.listBoxPreferencias.FormattingEnabled = true;
            this.listBoxPreferencias.ItemHeight = 20;
            this.listBoxPreferencias.Location = new System.Drawing.Point(335, 60);
            this.listBoxPreferencias.Name = "listBoxPreferencias";
            this.listBoxPreferencias.Size = new System.Drawing.Size(256, 284);
            this.listBoxPreferencias.TabIndex = 5;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(335, 363);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(145, 37);
            this.btnLimpar.TabIndex = 6;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnImportaTxtDoWhile
            // 
            this.btnImportaTxtDoWhile.Location = new System.Drawing.Point(12, 363);
            this.btnImportaTxtDoWhile.Name = "btnImportaTxtDoWhile";
            this.btnImportaTxtDoWhile.Size = new System.Drawing.Size(280, 37);
            this.btnImportaTxtDoWhile.TabIndex = 7;
            this.btnImportaTxtDoWhile.Text = "Importa Texto Do While";
            this.btnImportaTxtDoWhile.UseVisualStyleBackColor = true;
            this.btnImportaTxtDoWhile.Click += new System.EventHandler(this.btnImportaTxtDoWhile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 653);
            this.Controls.Add(this.btnImportaTxtDoWhile);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.listBoxPreferencias);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.btnSwitchCase);
            this.Controls.Add(this.btnDesvioCad);
            this.Controls.Add(this.btnDesvioCond);
            this.Controls.Add(this.btnMenssagem);
            this.Name = "Form1";
            this.Text = "Exercicio Inicial";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMenssagem;
        private System.Windows.Forms.Button btnDesvioCond;
        private System.Windows.Forms.Button btnDesvioCad;
        private System.Windows.Forms.Button btnSwitchCase;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.ListBox listBoxPreferencias;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnImportaTxtDoWhile;
    }
}

