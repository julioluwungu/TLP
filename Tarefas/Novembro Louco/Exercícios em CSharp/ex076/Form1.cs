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

            string palavraAntiga = textBoxPalavraAntiga.Text;
            string palavraNova = textBoxPalavraNova.Text;

            string resultado = SubstituirUltimaOcorrencia(frase, palavraAntiga, palavraNova);
            MessageBox.Show($"Resultado: {resultado}");
        }

        private string SubstituirUltimaOcorrencia(string frase, string palavraAntiga, string palavraNova)
        {
            int ultimaOcorrencia = frase.LastIndexOf(palavraAntiga);

            if (ultimaOcorrencia == -1)
            {
                return frase;
            }

            return frase.Substring(0, ultimaOcorrencia) + palavraNova + frase.Substring(ultimaOcorrencia + palavraAntiga.Length);
        }
    }
}