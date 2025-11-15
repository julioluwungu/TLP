using System;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label2.Text = "Digite um texto:";
        }

        private void botao_Click(object sender, EventArgs e)
        {
            string texto = textBox.Text;

            int numeroCaracteres = texto.Replace(" ", "").Length;
            int numeroPalavras = texto.Trim().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length;

            MessageBox.Show($"Número total de caracteres (sem espaços): {numeroCaracteres}");
            MessageBox.Show($"Número total de palavras: {numeroPalavras}");
        }
    }
}