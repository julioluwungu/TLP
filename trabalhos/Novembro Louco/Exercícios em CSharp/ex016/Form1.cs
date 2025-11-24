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
            label1.Text = "Crescimento Populacional";
        }

        private void botao_Click(object sender, EventArgs e)
        {
            double populacaoA = 80000;
            double taxaCrescimentoA = 0.03;

            double populacaoB = 200000;
            double taxaCrescimentoB = 0.015;

            int anos = 0;

            while (populacaoA < populacaoB)
            {
                populacaoA += populacaoA * taxaCrescimentoA;
                populacaoB += populacaoB * taxaCrescimentoB;
                anos++;
            }

            MessageBox.Show($"Anos necessários para a população A ultrapassar a população B: {anos}");
        }
    }
}
