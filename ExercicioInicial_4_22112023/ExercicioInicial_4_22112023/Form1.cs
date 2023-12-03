using System;
using System.IO;
using System.Windows.Forms;

namespace ExercicioInicial_4_22112023
{
    public partial class Form1 : Form
    {
        
        StreamReader objLeitor;
        string srtLinhaDoLeitor;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Meu Primeiro Botão!");
        }

        private void btnDesvioCond_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Escolha ok ou Cancelar!", "MENSAGEM", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                MessageBox.Show("Você escolheu OK!");
            }
            else
            {
                MessageBox.Show("Você cancelou!");
            }
        }

        private void btnDesvioCad_Click(object sender, EventArgs e)
        {
            DialogResult mensagem = MessageBox.Show("Escolha Sim, Não ou Cancelar", "Aviso", MessageBoxButtons.YesNoCancel);

            if (mensagem == DialogResult.Yes)
            {
                MessageBox.Show("Você escolheu Sim!");
            }
            else if (mensagem == DialogResult.No)
            {
                MessageBox.Show("Você escolheu Não!");
            }
            else
            {
                MessageBox.Show("Você Cancelou!");
            }
        }

        private void btnSwitchCase_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show("Escolha Sim, Não ou Cancelar", "Aviso", MessageBoxButtons.YesNoCancel))
            {
                case DialogResult.Yes:
                    MessageBox.Show("Você escolheu Sim!");
                    break;
                case DialogResult.No:
                    MessageBox.Show("Você escolheu Não!");
                    break;
                case DialogResult.Cancel:
                    MessageBox.Show("Você Cancelou!");
                    break;
                default:
                    MessageBox.Show("Saindo do Sistema");
                    break;
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            
            objLeitor = new StreamReader(@"C:\Curso programar\C#\ExercicioInicial_4_22112023\importar texto.txt");

            
            listBoxPreferencias.Items.Clear();

            srtLinhaDoLeitor = objLeitor.ReadLine();

            while (srtLinhaDoLeitor != null)
            {
                listBoxPreferencias.Items.Add(srtLinhaDoLeitor);
                srtLinhaDoLeitor = objLeitor.ReadLine();
            }

            
            objLeitor.Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            listBoxPreferencias.Items.Clear();
        }

        private void btnImportaTxtDoWhile_Click(object sender, EventArgs e)
        {
            objLeitor = new StreamReader(@"C:\Curso programar\C#\ExercicioInicial_4_22112023\importar texto.txt");
            srtLinhaDoLeitor = objLeitor.ReadLine();

            do
            {
                listBoxPreferencias.Items.Add(srtLinhaDoLeitor);
                srtLinhaDoLeitor = objLeitor.ReadLine();
            } while (srtLinhaDoLeitor != null);
        }
    }
}
