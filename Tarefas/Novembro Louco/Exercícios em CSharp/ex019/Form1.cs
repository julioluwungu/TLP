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
            label2.Text = "Digite uma string:";
        }

        private void botao_Click(object sender, EventArgs e)
        {
            string texto = textBox.Text.Trim().ToLower();
            char[] listaTxt = texto.ToCharArray();

            var digitos = listaTxt.Where(elemento => char.IsDigit(elemento)).ToArray();
            bool palindromo = texto == new string(listaTxt.Reverse().ToArray());
            var vogais = listaTxt.Where(elemento => "aeiou".Contains(elemento)).ToArray();

            string resultado = $"a) Número de caracteres: {texto.Length}\n" +
                               $"b) String em maiúsculo: {texto.ToUpper()}\n" +
                               $"c) Número de vogais: {vogais.Length}\n" +
                               $"d) A string começa com \"UNI\": {texto.ToUpper().StartsWith("UNI")}\n" +
                               $"e) A string termina com \"RIO\": {texto.ToUpper().EndsWith("RIO")}\n" +
                               $"f) Número de dígitos: {digitos.Length}\n" +
                               $"g) A string é um palíndromo: {palindromo}";

            MessageBox.Show(resultado, "Resultado");
        }
    }
}