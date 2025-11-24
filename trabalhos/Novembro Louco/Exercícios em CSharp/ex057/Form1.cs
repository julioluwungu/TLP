using System;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label2.Text = "Informe um número inteiro N:";
        }

        private void botao_Click(object sender, EventArgs e)
        {
            int numN;

            if (int.TryParse(textBox.Text, out numN) && numN >= 0)
            {
                int maiorQuadrado = (int)Math.Floor(Math.Sqrt(numN));
                maiorQuadrado *= maiorQuadrado;

                MessageBox.Show($"O maior quadrado menor ou igual a {numN} é: {maiorQuadrado}");
            }
            else
            {
                MessageBox.Show("Valor inválido! Por favor, digite um número inteiro não negativo.");
            }
        }
    }
}