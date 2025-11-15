using System;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label2.Text = "Digite uma palavra (ou uma palavra que comece com \"f\" para terminar):";
        }

        private void botao_Click(object sender, EventArgs e)
        {
            string palavra = textBox.Text;

            if (string.IsNullOrEmpty(palavra))
            {
                return;
            }

            char primeiraLetra = palavra[0];
            char ultimaLetra = palavra[palavra.Length - 1];

            MessageBox.Show($"{palavra}: {primeiraLetra}-{ultimaLetra}");

            if (char.ToLower(primeiraLetra) == 'f')
            {
                MessageBox.Show("Programa encerrado.");
                this.Close(); 
            }
            
            textBox.Clear();
        }
    }
}