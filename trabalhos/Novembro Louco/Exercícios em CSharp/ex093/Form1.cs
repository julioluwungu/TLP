using System;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label2.Text = "Digite um número positivo:";
        }

        private void botao_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox.Text, out double numero) && numero > 0)
            {
                string resultado = $"Contagem regressiva pulando de 2 em 2 começando de {numero}:\n";
                for (int c = (int)numero; c >= 0; c -= 2)
                {
                    resultado += $"{c}\n";
                }
                MessageBox.Show(resultado);
            }
            else
            {
                MessageBox.Show("Valor inválido! Por favor, digite um número válido.");
            }
        }
    }
}