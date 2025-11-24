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

            int numeroDePalavras = ContarPalavras(frase);
            MessageBox.Show($"Número de palavras: {numeroDePalavras}");
        }

        private int ContarPalavras(string frase)
        {
            string[] palavras = frase.Trim().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            return palavras.Length;
        }
    }
}