using System;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label2.Text = "Informe um valor inteiro e positivo para N:";
        }

        private void botao_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox.Text, out int numN) && numN >= 0)
            {
                double numE = 1;
                double fatorial = 1;

                for (int c = 1; c <= numN; c++)
                {
                    fatorial *= c;
                    numE += 1 / fatorial;
                }

                MessageBox.Show($"O valor de E é: {numE:F6}", "Resultado");
                ResetFields();
            }
            else
            {
                MessageBox.Show("Valor inválido! Por favor, digite um número inteiro positivo.", "Erro");
            }

            textBox.Clear();
        }

        private void ResetFields()
        {
            label2.Text = "Informe um valor inteiro e positivo para N:";
        }
    }
}