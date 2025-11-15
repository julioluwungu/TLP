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
            label1.Text = "Sequência Numérica";
        }

        private void botao_Click(object sender, EventArgs e)
        {
            string resultado = "";

            for (int i = 1; i <= 10; i++)
            {
                string sequencia = $"{i}, ";
                for (int j = 1; j <= 10; j++)
                {
                    sequencia += j;
                    if (j < 10)
                    {
                        sequencia += " ";
                    }
                }
                resultado += sequencia + "\n";
            }

            MessageBox.Show(resultado);
        }
    }
}
