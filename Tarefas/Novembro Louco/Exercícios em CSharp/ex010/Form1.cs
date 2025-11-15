using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        private List<int> valores = new List<int>();
        private int contador = 1;

        public Form1()
        {
            InitializeComponent();
            label2.Text = $"Digite o {contador}º valor (valor negativo para encerrar):";
        }

        private void botao_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox.Text, out int num))
            {
                if (num > 0)
                {
                    valores.Add(num);
                    contador++;
                    label2.Text = $"Digite o {contador}º valor (valor negativo para encerrar):";
                }
                else if (num < 0)
                {
                    if (valores.Count > 0)
                    {
                        double soma = valores.Sum();
                        double media = soma / valores.Count;
                        MessageBox.Show($"A média é de {media:F1}", "Resultado");
                    }
                    else
                    {
                        MessageBox.Show("Nenhum valor positivo foi digitado!", "Erro");
                    }
                }
            }
            else
            {
                MessageBox.Show("Valor inválido! Por favor, digite um número válido!", "Erro");
            }
        }
    }
}