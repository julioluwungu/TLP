using System;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label2.Text = "Digite o primeiro número inteiro:";
        }

        private int contador = 0;
        private int numero1;
        private int numero2;

        private void botao_Click(object sender, EventArgs e)
        {
            if (contador == 0)
            {
                if (int.TryParse(textBox.Text, out numero1))
                {
                    contador++;
                    label2.Text = "Digite o segundo número inteiro:";
                    textBox.Clear();
                }
                else
                {
                    MessageBox.Show("Entrada inválida! Por favor, digite números inteiros válidos.", "Erro");
                }
            }
            else if (contador == 1)
            {
                if (int.TryParse(textBox.Text, out numero2))
                {
                    int resultado = 0;

                    for (int i = 0; i < Math.Abs(numero2); i++)
                    {
                        resultado += numero1;
                    }

                    if (numero2 < 0)
                    {
                        resultado = -resultado;
                    }

                    MessageBox.Show($"O resultado da multiplicação de {numero1} por {numero2} é: {resultado}", "Resultado");
                    ResetFields();
                }
                else
                {
                    MessageBox.Show("Entrada inválida! Por favor, digite números inteiros válidos.", "Erro");
                }
            }
        }

        private void ResetFields()
        {
            contador = 0;
            textBox.Clear();
            label2.Text = "Digite o primeiro número inteiro:";
        }
    }
}