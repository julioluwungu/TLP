using System;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label2.Text = "Informe a massa inicial em gramas:";
        }

        private void botao_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox.Text, out double massa) && massa > 0)
            {
                double tempoTotal = 0;
                double tempoMeio = 50;

                while (massa >= 0.05)
                {
                    massa /= 2;
                    tempoTotal += tempoMeio;
                }

                MessageBox.Show($"O tempo necessário para que a massa seja menor que 0,05 gramas é: {tempoTotal} segundos", "Resultado");
            }
            else
            {
                MessageBox.Show("Valor inválido! Por favor, digite um valor válido maior que zero.", "Erro");
            }

            textBox.Clear(); // Limpa o campo de texto após a entrada
            label2.Text = "Informe a massa inicial em gramas:"; // Redefine a mensagem
        }
    }
}