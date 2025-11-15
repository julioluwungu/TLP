using System;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label2.Text = "Digite um número entre 20 e 99:";
        }

        private void botao_Click(object sender, EventArgs e)
        {
            int numero;

            if (int.TryParse(textBox.Text, out numero) && numero >= 20 && numero <= 99)
            {
                string[] unidades = { "", "um", "dois", "três", "quatro", "cinco", "seis", "sete", "oito", "nove" };
                string[] dezenas = { "", "dez", "vinte", "trinta", "quarenta", "cinquenta", "sessenta", "setenta", "oitenta", "noventa" };
                string extenso;

                if (numero < 30)
                {
                    extenso = dezenas[2] + (numero == 20 ? "" : " e " + unidades[numero % 10]);
                }
                else
                {
                    extenso = dezenas[numero / 10] +
                               (numero % 10 != 0 ? " e " + unidades[numero % 10] : "");
                }

                MessageBox.Show($"O número {numero} por extenso é: {extenso}");
            }
            else
            {
                MessageBox.Show("Número inválido. Por favor, digite um número entre 20 e 99.");
            }
        }
    }
}