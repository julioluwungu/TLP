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
            label1.Text = "Soma de 1 a 100";
        }

        private void botao_Click(object sender, EventArgs e)
        {
            int soma = 0;

            for (int num = 1; num <= 100; num++)
            {
                soma += num;
            }

            MessageBox.Show($"A soma dos números entre 1 e 100 é: {soma}");
        }
    }
}
