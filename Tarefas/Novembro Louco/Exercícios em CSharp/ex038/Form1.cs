using System;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label2.Text = "Digite um número para calcular o fatorial:";
        }

        private void botao_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox.Text, out int numero))
            {
                if (numero < 0)
                {
                    MessageBox.Show("Fatorial não é definido para números negativos.", "Erro");
                }
                else
                {
                    long fatorial = 1;

                    for (int c = 1; c <= numero; c++)
                    {
                        fatorial *= c;
                    }

                    MessageBox.Show($"O fatorial de {numero} é: {fatorial}", "Resultado");
                }
            }
            else
            {
                MessageBox.Show("Valor inválido! Por favor, digite um valor inteiro válido.", "Erro");
            }
        }
    }
}