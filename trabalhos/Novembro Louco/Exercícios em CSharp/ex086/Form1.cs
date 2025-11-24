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

            string fraseDuplicada = DuplicarLetras(frase);
            MessageBox.Show($"Frase gerada: {fraseDuplicada}");
        }

        private string DuplicarLetras(string frase)
        {
            char[] resultado = new char[frase.Length * 2];
            int index = 0;

            foreach (char letra in frase)
            {
                resultado[index++] = letra;
                if (letra != ' ')
                {
                    resultado[index++] = letra;
                }
            }

            return new string(resultado, 0, index);
        }
    }
}