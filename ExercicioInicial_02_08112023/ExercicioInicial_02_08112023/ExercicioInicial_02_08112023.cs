using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExercicioInicial_02_08112023
{
    public partial class ExercicioInicial_02_08112023 : Form
    {
        public ExercicioInicial_02_08112023()
        {
            InitializeComponent();
        }

        private void btnMenssagem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Parabens meu primeiro botão", "Aviso");
        }
    }
}
