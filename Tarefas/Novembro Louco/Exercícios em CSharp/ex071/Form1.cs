using System;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label2.Text = "Digite uma sequência de caracteres:";
        }

        private void botao_Click(object sender, EventArgs e)
        {
            string texto = textBox.Text;

            string textoLimpo = new string(texto.Where(c => char.IsLetterOrDigit(c)).ToArray()).ToLower();
            string textoInvertido = new string(textoLimpo.Reverse().ToArray());

            bool palindromo = textoLimpo == textoInvertido;

            MessageBox.Show($"Frase: {texto}\nÉ um palíndromo? {(palindromo ? "Sim" : "Não")}");
        }
    }
}