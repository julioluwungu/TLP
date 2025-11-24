using System;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label2.Text = "Digite seu nome completo:";
        }

        private void botao_Click(object sender, EventArgs e)
        {
            string nomeCompleto = textBox.Text.Trim();
            string[] partes = nomeCompleto.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            if (partes.Length > 1)
            {
                string sobrenome = partes[^1];
                MessageBox.Show($"Sobrenome: {sobrenome}");
            }
            else
            {
                MessageBox.Show("Sobrenome não encontrado. Certifique-se de digitar um nome completo.");
            }
        }
    }
}