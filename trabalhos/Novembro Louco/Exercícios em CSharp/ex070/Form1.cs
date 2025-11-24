using System;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label2.Text = "Digite sua data de nascimento (dd/mm/aaaa):";
        }

        private void botao_Click(object sender, EventArgs e)
        {
            string data = textBox.Text;
            string[] partes = data.Split('/');

            if (partes.Length == 3 && int.TryParse(partes[0], out int dia) && int.TryParse(partes[1], out int mes) && int.TryParse(partes[2], out int ano))
            {
                string[] meses = { "Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho", "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro" };
                string mesExtenso = meses[mes - 1];

                MessageBox.Show($"Você nasceu em {dia} de {mesExtenso} de {ano}");
            }
            else
            {
                MessageBox.Show("Mês inválido. Certifique-se de digitar no formato dd/mm/aaaa.");
            }
        }
    }
}