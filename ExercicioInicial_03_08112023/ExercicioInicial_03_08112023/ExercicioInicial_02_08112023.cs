using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExercicioInicial_03_08112023
{
    public partial class ExercicioInicial_02_08112023 : Form
    {
        public ExercicioInicial_02_08112023()
        {
            InitializeComponent();
        }

        private void ExercicioInicial_02_08112023_Load(object sender, EventArgs e)
        {
            
        }

        private void btnDesvioCond_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Escolha Ok ou Cancelar!", "Menssagem", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                MessageBox.Show("Você escolheu OK!");
            }
            else
            {
                MessageBox.Show("Você cancelou!");
            }
        }

        private void btnMenssagem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Meu Primeiro Botão", "Aviso");
        }
    }
}
