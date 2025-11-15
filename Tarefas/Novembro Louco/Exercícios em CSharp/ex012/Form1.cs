using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        private List<double> valores = new List<double>();
        private int contador = 0;

        public Form1()
        {
            InitializeComponent();
            label2.Text = "Digite o 1º valor inteiro:";
        }

        private void botao_Click(object sender, EventArgs e)
        {
            if (contador < 10)
            {
                if (double.TryParse(textBox.Text, out double num))
                {
                    valores.Add(num);
                    contador++;
                    if (contador < 10)
                    {
                        label2.Text = $"Digite o {contador + 1}º valor inteiro:";
                    }
                    else
                    {
                        label2.Text = "Digite um outro valor:";
                    }
                }
                else
                {
                    MessageBox.Show("Valor inválido! Por favor, digite um número válido!", "Erro");
                }
            }
            else
            {
                if (double.TryParse(textBox.Text, out double outroValor))
                {
                    var inferiores = valores.Where(num => num < outroValor).ToList();
                    MessageBox.Show($"Dentre os valores digitados anteriormente, {inferiores.Count} são inferiores à {outroValor}\nEles são: {string.Join(", ", inferiores)}", "Resultado");
                }
                else
                {
                    MessageBox.Show("Valor inválido! Por favor, digite um número válido!", "Erro");
                }
            }
        }
    }
}