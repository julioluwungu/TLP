using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label2.Text = "Digite um número inteiro N:";
        }

        private void botao_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox.Text, out int numN))
            {
                int totalDivisoes = 0;
                var numerosPrimos = new List<int>();

                for (int i = 1; i <= numN; i++)
                {
                    var resultado = EhPrimo(i);
                    totalDivisoes += resultado.divisao;
                    if (resultado.primo)
                    {
                        numerosPrimos.Add(i);
                    }
                }

                MessageBox.Show($"Números primos entre 1 e {numN}: {string.Join(", ", numerosPrimos)}", "Resultado");
                MessageBox.Show($"Total de divisões executadas: {totalDivisoes}", "Resultado");
            }
            else
            {
                MessageBox.Show("Valor inválido! Por favor, digite um número válido!", "Erro");
            }
        }

        static (bool primo, int divisao) EhPrimo(int num)
        {
            if (num < 2)
            {
                return (false, 0);
            }

            int qtdDivisoes = 0;

            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                qtdDivisoes++;
                if (num % i == 0)
                {
                    return (false, qtdDivisoes);
                }
            }
            return (true, qtdDivisoes);
        }
    }
}