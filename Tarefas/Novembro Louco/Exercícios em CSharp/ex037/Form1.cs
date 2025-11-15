using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        private List<int> numeros = new List<int>();
        private int contador = 0;

        public Form1()
        {
            InitializeComponent();
            label2.Text = "Digite o 1º número inteiro:";
        }

        private void botao_Click(object sender, EventArgs e)
        {
            if (contador < 10)
            {
                if (int.TryParse(textBox.Text, out int numero))
                {
                    numeros.Add(numero);
                    contador++;
                    textBox.Clear();

                    if (contador < 10)
                    {
                        label2.Text = $"Digite o {contador + 1}º número inteiro:";
                    }
                    else
                    {
                        double soma = numeros.Sum();
                        double media = soma / numeros.Count;
                        int maior = numeros.Max();
                        int menor = numeros.Min();

                        MessageBox.Show($"Média: {media:F1}\n" +
                                        $"Maior número: {maior}\n" +
                                        $"Menor número: {menor}", "Resultados");
                    }
                }
                else
                {
                    MessageBox.Show("Valor inválido! Por favor, digite um valor inteiro válido.", "Erro");
                }
            }
        }
    }
}