using System;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        int etapa = 0;
        int num1 = 0;
        int num2 = 0;

        public Form1()
        {
            InitializeComponent();
            label2.Text = "Digite o primeiro número:";
        }

        private void botao_Click(object sender, EventArgs e)
        {
            string entrada = textBox.Text;

            if (etapa == 0)
            {
                if (double.TryParse(entrada, out double n))
                {
                    num1 = (int)n;
                    etapa = 1;
                    label2.Text = "Digite o segundo número:";
                    textBox.Clear();
                }
                else
                {
                    MessageBox.Show("Valor inválido! Digite um número válido.");
                }
                return;
            }

            if (etapa == 1)
            {
                if (double.TryParse(entrada, out double n))
                {
                    num2 = (int)n;

                    int soma = SomarSemSoma(num1, num2);
                    string tipo = soma % 2 == 0 ? "par" : "ímpar";

                    string msg =
                        $"A soma de {num1} e {num2} é: {soma}\n" +
                        $"A soma é {tipo}.";

                    MessageBox.Show(msg, "Resultado");

                    etapa = 0;
                    label2.Text = "Digite o primeiro número:";
                    textBox.Clear();
                }
                else
                {
                    MessageBox.Show("Valor inválido! Digite um número válido.");
                }
                return;
            }
        }

        int SomarSemSoma(int a, int b)
        {
            while (b != 0)
            {
                int carry = a & b;
                a = a ^ b;
                b = carry << 1;
            }
            return a;
        }
    }
}
