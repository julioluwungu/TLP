using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        private int valorSorteado;
        private Random random = new Random();
        private DateTime tempoInicial;

        public Form1()
        {
            InitializeComponent();
            label2.Text = "Aguarde... sorteando o valor...";
            SortearValor();
        }

        private async void SortearValor()
        {
            int tempoSorteado = random.Next(10);
            await Task.Delay(tempoSorteado * 1000);
            valorSorteado = random.Next(1, 21);
            label2.Text = $"Valor sorteado: {valorSorteado}\nDigite o valor que apareceu na tela:";
            tempoInicial = DateTime.Now;
        }

        private void botao_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox.Text, out int num) && num == valorSorteado)
            {
                TimeSpan tempoFeito = DateTime.Now - tempoInicial;
                MessageBox.Show($"Demorou {tempoFeito.TotalSeconds} segundos para acertar.", "Resultado");
            }
            else
            {
                MessageBox.Show("Valor incorreto. Por favor, digite o valor correto!", "Erro");
            }
        }
    }
}