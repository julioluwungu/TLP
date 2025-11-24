using System;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label2.Text = "Digite uma frase ou uma palavra qualquer:";
        }

        private void botao_Click(object sender, EventArgs e)
        {
            string texto = textBox.Text;
            string[] vetorTxt = texto.Split(' ');
            string[] listaAsteriscos = Array.ConvertAll(vetorTxt, palavra => new string('*', palavra.Length));
            string textoAsteriscos = string.Join(" ", listaAsteriscos);
            
            MessageBox.Show($"Caracteres substituídos por asterisco: {textoAsteriscos}");
        }
    }
}