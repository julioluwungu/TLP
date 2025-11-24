using System;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label2.Text = "Digite uma frase:";
        }

        private void botao_Click(object sender, EventArgs e)
        {
            string frase = textBox.Text;

            string fraseRepetida = RepetirPalavras(frase);
            MessageBox.Show($"Saída: {fraseRepetida}");
        }

        private string RepetirPalavras(string frase)
        {
            string[] palavras = frase.Split(' ');
            for (int i = 0; i < palavras.Length; i++)
            {
                palavras[i] += $" {palavras[i]}";
            }
            return string.Join(" ", palavras);
        }
    }
}