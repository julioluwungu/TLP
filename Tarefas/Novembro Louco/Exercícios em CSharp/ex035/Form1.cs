using System;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label2.Text = "Digite um número para ver sua tabela de multiplicação:";
        }

        private void botao_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox.Text, out int numero))
            {
                string resultado = $"Tabela de multiplicação de {numero}:\n";
                for (int c = 1; c <= 13; c++)
                {
                    int multiplicacao = numero * c;
                    resultado += $"{numero} x {c} = {multiplicacao}\n";
                }
                MessageBox.Show(resultado, "Resultado");
            }
            else
            {
                MessageBox.Show("Valor inválido! Por favor, digite um número válido.", "Erro");
            }
        }
    }
}