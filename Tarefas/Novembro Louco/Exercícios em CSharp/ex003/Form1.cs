using System;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        private string[] letras = { "X", "Y", "Z" };
        private int[] valores = new int[3];
        private int contador = 0;

        public Form1()
        {
            InitializeComponent();
            label2.Text = "Digite o valor inteiro de X:";
        }

        private void botao_Click(object sender, EventArgs e)
        {
            if (contador < 3)
            {
                if (int.TryParse(textBox.Text, out int num) && num > 0)
                {
                    valores[contador] = num;
                    contador++;

                    if (contador < 3)
                    {
                        label2.Text = $"Digite o valor inteiro de {letras[contador]}:";
                    }
                    else
                    {
                        if (valores[0] < valores[1] + valores[2] &&
                            valores[1] < valores[0] + valores[2] &&
                            valores[2] < valores[0] + valores[1])
                        {
                            if (valores[0] == valores[1] && valores[0] == valores[2])
                            {
                                MessageBox.Show("Triângulo Equilátero!", "Resultado");
                            }
                            else if (valores[0] == valores[1] || valores[0] == valores[2] || valores[1] == valores[2])
                            {
                                MessageBox.Show("Triângulo Isósceles!", "Resultado");
                            }
                            else
                            {
                                MessageBox.Show("Triângulo Escaleno!", "Resultado");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Não é possível formar um triângulo com os valores fornecidos!", "Erro");
                        }
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