using System;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label2.Text = "Digite um tempo em segundos:"; // Alterando o texto da label2
        }

        private void botao_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox.Text, out int tempo) && tempo >= 0)
            {
                int horas = tempo / 3600;
                int minutos = (tempo % 3600) / 60;
                int segundos = tempo % 60;

                string resultado = $"{tempo} segundos equivale a:\n{horas:D2}:{minutos:D2}:{segundos:D2}";
                MessageBox.Show(resultado, "Resultado"); // Exibindo o resultado em uma MessageBox
            }
            else
            {
                MessageBox.Show("Valor inválido! Por favor, digite um número válido!", "Erro");
            }
        }
    }
}