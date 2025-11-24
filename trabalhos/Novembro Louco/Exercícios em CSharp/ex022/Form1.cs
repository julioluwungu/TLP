using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        private List<double> numQ = new List<double>();
        private int contador = 0;

        public Form1()
        {
            InitializeComponent();
            label2.Text = "Digite o 1º valor (positivo):";
        }

        private void botao_Click(object sender, EventArgs e)
        {
            if (contador < 20)
            {
                if (double.TryParse(textBox.Text, out double num) && num > 0)
                {
                    numQ.Add(num);
                    contador++;
                    if (contador < 20)
                    {
                        label2.Text = $"Digite o {contador + 1}º valor (positivo):";
                        textBox.Clear();
                    }
                    else
                    {
                        double maiorElemento = numQ[0];
                        int posicao = 0;

                        for (int i = 1; i < numQ.Count; i++)
                        {
                            if (numQ[i] > maiorElemento)
                            {
                                maiorElemento = numQ[i];
                                posicao = i;
                            }
                        }

                        MessageBox.Show($"O maior elemento é {maiorElemento} e ocupa a posição {posicao + 1} no vetor.", "Resultado");
                    }
                }
                else
                {
                    MessageBox.Show("Valor inválido! Por favor, digite um número positivo.", "Erro");
                }
            }
        }
    }
}