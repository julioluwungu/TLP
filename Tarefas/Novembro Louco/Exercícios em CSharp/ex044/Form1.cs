using System;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label2.Text = "Digite o primeiro número inteiro positivo:";
        }

        private void botao_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox.Text, out int numero1) && numero1 > 0)
            {
                label2.Text = "Digite o segundo número inteiro positivo:";
                textBox.Clear();
                botao.Tag = "segundo"; // Marcar que o próximo número a ser digitado é o segundo
            }
            else if (botao.Tag?.ToString() == "segundo")
            {
                if (int.TryParse(textBox.Text, out int numero2) && numero2 > 0)
                {
                    int quociente = 0;
                    int resto = numero1;

                    while (resto >= numero2)
                    {
                        resto -= numero2;
                        quociente++;
                    }

                    MessageBox.Show($"Quociente: {quociente}\nResto: {resto}", "Resultado");
                    ResetFields();
                }
                else
                {
                    MessageBox.Show("Entrada inválida! Por favor, digite um número inteiro positivo.", "Erro");
                }
            }
            else
            {
                MessageBox.Show("Entrada inválida! Por favor, digite um número inteiro positivo.", "Erro");
            }
        }

        private void ResetFields()
        {
            textBox.Clear();
            label2.Text = "Digite o primeiro número inteiro positivo:";
            botao.Tag = null; // Limpa a tag
        }
    }
}