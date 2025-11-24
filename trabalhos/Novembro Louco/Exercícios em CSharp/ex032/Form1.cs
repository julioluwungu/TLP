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
            label1.Text = "Grãos no Tabuleiro de Xadrez";
        }

        private void botao_Click(object sender, EventArgs e)
        {
            ulong graos = 0;
            ulong total = 0;

            for (int quadro = 1; quadro <= 64; quadro++)
            {
                graos = (ulong)Math.Pow(2, quadro - 1);
                total += graos;
            }

            MessageBox.Show($"O Monge recebeu um total de {total} grãos.");
        }
    }
}
