using System;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label2.Text = "Escolha a figura ([1] triângulo ou [2] losango):";
        }

        private void botao_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox.Text, out int figura) && figura >= 1 && figura <= 2)
            {
                label2.Text = "Digite o tamanho (número de linhas):";
                textBox.Clear();
            }
            else
            {
                MessageBox.Show("Opção inválida. Escolha '[1] triângulo' ou '[2] losango'.");
                return;
            }
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            if (label2.Text.Contains("tamanho"))
            {
                if (int.TryParse(textBox.Text, out int tamanho))
                {
                    if (int.TryParse(textBox.Tag?.ToString(), out int figura))
                    {
                        if (figura == 1)
                        {
                            DesenharTriangulo(tamanho);
                        }
                        else if (figura == 2)
                        {
                            DesenharLosango(tamanho);
                        }
                    }
                }
                textBox.Clear();
                label2.Text = "Escolha a figura ([1] triângulo ou [2] losango):";
            }
        }

        private void DesenharTriangulo(int tamanho)
        {
            string resultado = "";
            for (int c = 1; c <= tamanho; c++)
            {
                resultado += new string(' ', tamanho - c) + new string('%', 2 * c - 1) + "\n";
            }
            MessageBox.Show(resultado);
        }

        private void DesenharLosango(int tamanho)
        {
            DesenharTriangulo(tamanho);
            for (int c = tamanho - 1; c >= 1; c--)
            {
                string resultado = new string(' ', tamanho - c) + new string('%', 2 * c - 1) + "\n";
                MessageBox.Show(resultado);
            }
        }
    }
}