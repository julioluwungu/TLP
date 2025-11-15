using System;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label2.Text = "Digite a base do triângulo (entre 5 e 15):";
        }

        private void botao_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox.Text, out int baseTriangulo) && baseTriangulo >= 5 && baseTriangulo <= 15)
            {
                string resultado = "";

                for (int c = 1; c <= baseTriangulo; c += 2)
                {
                    int espaco = (baseTriangulo - c) / 2;
                    resultado += new string(' ', espaco) + new string('#', c) + "\n";
                }

                MessageBox.Show(resultado.Trim(), "Triângulo");
            }
            else
            {
                MessageBox.Show("A base deve ser entre 5 e 15. Tente novamente.", "Erro");
            }
        }
    }
}