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
            label1.Text = "Pares entre 85 e 31";
        }

        private void botao_Click(object sender, EventArgs e)
        {
            int soma = 0;
            string resultado = "Números pares entre 85 e 31:\n";

            for (int num = 85; num >= 31; num--)
            {
                if (num % 2 == 0)
                {
                    resultado += num + "\n";
                    soma += num;
                }
            }

            resultado += $"\nSoma: {soma}";

            MessageBox.Show(resultado);
        }
    }
}
