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
            label2.Text = "Digite seu nome:";
        }

        private void botao_Click(object sender, EventArgs e)
        {
            string nome = textBox.Text;

            string nomeInvertido = new string(nome.ToCharArray().Reverse().ToArray()).ToUpper();

            MessageBox.Show($"Seu nome ao contrário é: {nomeInvertido}");
        }
    }
}