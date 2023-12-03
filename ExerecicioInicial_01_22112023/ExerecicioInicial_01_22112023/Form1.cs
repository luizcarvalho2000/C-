using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExerecicioInicial_01_22112023
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMenssagem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Este é o meu primeiro botão!");
        }

        private void btnDesvioCond_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Escolha ok ou cancelar", "Menssagem", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                MessageBox.Show("Você escolheu OK!");
            }
            else
            {
                MessageBox.Show("Você escolheu Cancelar!");
            }
        }

        
    }
}
