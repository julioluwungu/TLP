using System;
using System.Windows.Forms;

namespace WindowsFormsApp9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "Soma de Ímpares Múltiplos de 3";
        }

        private void botao_Click(object sender, EventArgs e)
        {
            int soma = 0;

            for (int c = 1; c <= 500; c++)
            {
                if (c % 2 != 0 && c % 3 == 0)
                {
                    soma += c;
                }
            }

            MessageBox.Show($"A soma de todos os números ímpares múltiplos de três entre 1 e 500 é: {soma}");
        }
    }
}
