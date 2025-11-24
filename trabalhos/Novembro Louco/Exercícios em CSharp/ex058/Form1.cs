using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label2.Text = "Informe um número inteiro N (N >= 2):";
        }

        private void botao_Click(object sender, EventArgs e)
        {
            int numN;

            if (int.TryParse(textBox.Text, out numN) && numN >= 2)
            {
                List<int> fibonacci = new List<int> { 0, 1 };

                for (int c = 2; c < numN; c++)
                {
                    int proximoTermo = fibonacci[c - 1] + fibonacci[c - 2];
                    fibonacci.Add(proximoTermo);
                }

                MessageBox.Show($"Os {numN} primeiros termos da sequência de Fibonacci são: {string.Join(", ", fibonacci)}");
            }
            else
            {
                MessageBox.Show("Valor inválido! Por favor, digite um número inteiro maior ou igual a 2.");
            }
        }
    }
}