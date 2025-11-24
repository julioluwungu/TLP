using System;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        private double[] valores = new double[2];
        private string strOperacoes = "+-*/";
        private string operacao;
        private int contador = 0;

        public Form1()
        {
            InitializeComponent();
            label2.Text = "Escolha uma operação (+, -, *, /):";
        }

        private void botao_Click(object sender, EventArgs e)
        {
            if (contador == 0)
            {
                operacao = textBox.Text;
                if (strOperacoes.Contains(operacao))
                {
                    contador++;
                    label2.Text = "Digite o 1º valor:";
                }
                else
                {
                    MessageBox.Show("Operação inválida. Por favor, tente novamente!", "Erro");
                }
            }
            else if (contador < 2)
            {
                if (double.TryParse(textBox.Text, out double num))
                {
                    valores[contador - 1] = num;
                    contador++;

                    if (contador < 3)
                    {
                        label2.Text = "Digite o 2º valor:";
                    }
                    else
                    {
                        double resultado = operacao switch
                        {
                            "+" => valores[0] + valores[1],
                            "-" => valores[0] - valores[1],
                            "*" => valores[0] * valores[1],
                            "/" => valores[0] / valores[1],
                            _ => 0
                        };
                        MessageBox.Show($"Resultado: {resultado}", "Resultado");
                    }
                }
                else
                {
                    MessageBox.Show("Valor inválido! Por favor, digite um número válido!", "Erro");
                }
            }
            else
            {
                MessageBox.Show("Todos os valores já foram digitados!", "Erro");
            }
        }
    }
}