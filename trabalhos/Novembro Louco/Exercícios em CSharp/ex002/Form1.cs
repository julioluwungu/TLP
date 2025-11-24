using System;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        private int[] valores = new int[3];
        private int contador = 0;

        public Form1()
        {
            InitializeComponent();
            label2.Text = "Digite o 1º valor inteiro:";
        }

        private void botao_Click(object sender, EventArgs e)
        {
            if (contador < 3)
            {
                if (int.TryParse(textBox.Text, out int num))
                {
                    valores[contador] = num;
                    contador++;

                    if (contador < 3)
                    {
                        label2.Text = $"Digite o {contador + 1}º valor inteiro:";
                    }
                    else
                    {
                        double soma = valores.Sum();
                        double media = soma / valores.Length;
                        MessageBox.Show($"A média é de {media:F1}", "Resultado");
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