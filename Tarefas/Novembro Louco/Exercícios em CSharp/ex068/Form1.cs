using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        private string frase;

        public Form1()
        {
            InitializeComponent();
            label2.Text = "Digite uma frase qualquer:";
        }

        private void botao_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(frase))
            {
                frase = textBox.Text;
                label2.Text = "Digite uma palavra que exista na frase:";
            }
            else
            {
                string palavra = textBox.Text;

                if (frase.Contains(palavra))
                {
                    string[] vetorFrase = frase.Split(' ');
                    int indice = Array.IndexOf(vetorFrase, palavra);
                    MessageBox.Show($"A palavra \"{palavra}\" encontra-se com o índice {indice}");
                }
                else
                {
                    MessageBox.Show("Digite uma palavra que exista na frase!");
                }

                frase = null; // Reseta a frase para iniciar um novo processo, se necessário
                label2.Text = "Digite uma frase qualquer:";
            }

            textBox.Clear();
        }
    }
}