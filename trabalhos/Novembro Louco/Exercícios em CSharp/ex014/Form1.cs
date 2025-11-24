using System;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        private string[] palavras = new string[2];
        private int contador = 0;

        public Form1()
        {
            InitializeComponent();
            label2.Text = "Digite a 1ª palavra:";
        }

        private void botao_Click(object sender, EventArgs e)
        {
            palavras[contador] = textBox.Text;
            contador++;

            if (contador < 2)
            {
                label2.Text = $"Digite a {contador + 1}ª palavra:";
                textBox.Clear();
            }
            else
            {
                if (palavras[0] == palavras[1])
                {
                    MessageBox.Show("As palavras digitadas são iguais.", "Resultado");
                }
                else
                {
                    if (palavras[0].Length > palavras[1].Length)
                        MessageBox.Show($"A palavra \"{palavras[0]}\" tem maior comprimento em relação à palavra \"{palavras[1]}\".", "Resultado");
                    else if (palavras[1].Length > palavras[0].Length)
                        MessageBox.Show($"A palavra \"{palavras[1]}\" tem maior comprimento em relação à palavra \"{palavras[0]}\".", "Resultado");
                    else
                        MessageBox.Show($"A palavra \"{palavras[0]}\" e a palavra \"{palavras[1]}\" têm o mesmo comprimento.", "Resultado");

                    if (palavras[0].Contains(palavras[1]))
                        MessageBox.Show($"A palavra \"{palavras[1]}\" é uma substring da palavra \"{palavras[0]}\".", "Resultado");
                }
            }
        }
    }
}