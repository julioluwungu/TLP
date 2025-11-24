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
            label2.Text = "Informe o número de termos (n):";
        }

        private int n;
        private double a1, r;
        private int passo = 0;

        private void botao_Click(object sender, EventArgs e)
        {
            if (passo == 0)
            {
                if (int.TryParse(textBox.Text, out n) && n > 0)
                {
                    label2.Text = "Informe o primeiro termo (a1):";
                    passo++;
                }
                else
                {
                    MessageBox.Show("Valor inválido! Por favor, digite um número válido de termos.", "Erro");
                }
            }
            else if (passo == 1)
            {
                if (double.TryParse(textBox.Text, out a1))
                {
                    label2.Text = "Informe a razão (r):";
                    passo++;
                }
                else
                {
                    MessageBox.Show("Valor inválido! Por favor, digite um número válido para o primeiro termo.", "Erro");
                }
            }
            else if (passo == 2)
            {
                if (double.TryParse(textBox.Text, out r))
                {
                    List<double> termos = new List<double>();
                    double soma = 0;

                    for (int c = 0; c < n; c++)
                    {
                        double termo = a1 + c * r;
                        termos.Add(termo);
                        soma += termo;
                    }

                    MessageBox.Show("Os termos da PA são: " + string.Join(", ", termos) + 
                                    $"\nA soma dos termos é: {soma}", "Resultados");
                    ResetFields();
                }
                else
                {
                    MessageBox.Show("Valor inválido! Por favor, digite um número válido para a razão.", "Erro");
                }
            }

            textBox.Clear();
        }

        private void ResetFields()
        {
            n = 0;
            a1 = 0;
            r = 0;
            passo = 0;
            label2.Text = "Informe o número de termos (n):";
        }
    }
}