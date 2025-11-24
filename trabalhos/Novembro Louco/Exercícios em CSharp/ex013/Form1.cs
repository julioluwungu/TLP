using System;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label2.Text = "Digite o seu nome completo:";
        }

        private void botao_Click(object sender, EventArgs e)
        {
            string nomeCompleto = textBox.Text;
            var listaNomes = nomeCompleto.Split(' ');

            var nomesAbbr = listaNomes.Select(nome =>
                nome.Length > 2 ? $"{nome[0].ToString().ToUpper()}." : nome
            );

            MessageBox.Show($"Abreviação: {string.Join(' ', nomesAbbr)}", "Resultado");
        }
    }
}