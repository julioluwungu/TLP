using System;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        private double[] valores = new double[3];
        private int contador = 0;

        public Form1()
        {
            InitializeComponent();
            label2.Text = "Digite o 1º valor:";
        }

        private void botao_Click(object sender, EventArgs e)
        {
            if (contador < 3)
            {
                if (double.TryParse(textBox.Text, out double num))
                {
                    valores[contador] = num;
                    contador++;

                    if (contador < 3)
                    {
                        label2.Text = $"Digite o {contador + 1}º valor:";
                    }
                    else
                    {
                        Array.Sort(valores);
                        MessageBox.Show($"Maior valor: {valores[2]}\nMenor valor: {valores[0]}\nValor intermédio: {valores[1]}", "Resultado");
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