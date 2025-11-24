using System;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label2.Text = "Digite um número:";
        }

        private void botao_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox.Text, out double numero))
            {
                int contagem = 0;
                double resultado = numero;

                while (resultado >= 1)
                {
                    resultado /= 2;
                    contagem++;
                }

                MessageBox.Show($"O resultado da última divisão é: {resultado}\n" +
                                $"Quantidade de divisões efetuadas: {contagem}", "Resultados");
                ResetFields();
            }
            else
            {
                MessageBox.Show("Valor inválido! Por favor, digite um número válido.", "Erro");
            }

            textBox.Clear();
        }

        private void ResetFields()
        {
            label2.Text = "Digite um número:";
        }
    }
}