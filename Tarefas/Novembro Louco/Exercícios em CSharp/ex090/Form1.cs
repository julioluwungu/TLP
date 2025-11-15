using System;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label2.Text = "Digite uma frase:";
        }

        private void botao_Click(object sender, EventArgs e)
        {
            string frase = textBox.Text;

            string fraseModificada = ModificarFrase(frase);
            MessageBox.Show($"Frase transformada: {fraseModificada}");
        }

        private string ModificarFrase(string frase)
        {
            char[] resultado = new char[frase.Length];
            int index = 0;

            foreach (char letra in frase)
            {
                resultado[index++] = "aeiouAEIOU".Contains(letra) ? '!' : letra;
            }

            return new string(resultado, 0, index).ToUpper();
        }
    }
}