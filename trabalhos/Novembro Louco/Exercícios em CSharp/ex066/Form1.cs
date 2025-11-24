using System;
using System.Text.RegularExpressions;
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

            string textoModificado = Regex.Replace(texto, "[bcdfghjklmnpqrstvwxyzBCDFGHJKLMNPQRSTVWXYZ]", "&");

            MessageBox.Show($"Consoantes substituídas por &: {textoModificado}");
        }
    }
}