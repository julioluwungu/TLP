using System;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        private int somaPares = 0;
        private int somaPrimos = 0;
        private int contagem = 0;

        public Form1()
        {
            InitializeComponent();
            label2.Text = "Digite o número:";
        }

        private void botao_Click(object sender, EventArgs e)
        {
            if (contagem < 10)
            {
                if (double.TryParse(textBox.Text, out double numero))
                {
                    if (numero % 2 == 0)
                    {
                        somaPares += (int)numero;
                    }

                    if (EhPrimo((int)numero))
                    {
                        somaPrimos += (int)numero;
                    }

                    contagem++;
                    textBox.Clear();
                    if (contagem == 10)
                    {
                        MessageBox.Show($"Soma dos números pares: {somaPares}");
                        MessageBox.Show($"Soma dos números primos: {somaPrimos}");
                    }
                }
                else
                {
                    MessageBox.Show("Valor inválido! Por favor, digite um número válido.");
                }
            }
            else
            {
                MessageBox.Show("Já foram digitados 10 números.");
            }
        }

        private bool EhPrimo(int numero)
        {
            if (numero <= 1) return false;
            for (int c = 2; c <= Math.Sqrt(numero); c++)
            {
                if (numero % c == 0) return false;
            }
            return true;
        }
    }
}