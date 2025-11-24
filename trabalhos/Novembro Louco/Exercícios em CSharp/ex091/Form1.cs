using System;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label2.Text = "Digite um número:";
        }

        private void botao_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox.Text, out double numero))
            {
                bool triangular = false;

                for (int x = 1; x < Math.Cbrt(numero) + 1; x++)
                {
                    double produto = x * (x + 1) * (x + 2);
                    if (produto == numero)
                    {
                        triangular = true;
                        MessageBox.Show($"O número {numero} é um número triangular: {x} x {x + 1} x {x + 2} = {produto}");
                        break;
                    }
                }

                if (!triangular)
                {
                    MessageBox.Show($"O número {numero} não é um número triangular.");
                }
            }
            else
            {
                MessageBox.Show("Valor inválido! Por favor, digite um número válido.");
            }
        }
    }
}