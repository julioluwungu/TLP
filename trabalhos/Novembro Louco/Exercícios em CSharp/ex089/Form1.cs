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

            string fraseSemEspacos = RemoverEspacos(frase);
            MessageBox.Show($"Frase sem espaços em branco: {fraseSemEspacos}");
        }

        private string RemoverEspacos(string frase)
        {
            return frase.Replace(" ", "");
        }
    }
}