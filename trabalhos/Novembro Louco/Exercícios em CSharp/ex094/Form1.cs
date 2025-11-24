using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        int numN = 0;
        int contador = 0;
        List<int> listaValores = new List<int>();
        List<int> listaFatorial = new List<int>();

        public Form1()
        {
            InitializeComponent();
            label2.Text = "Digite quantos valores devem ser lidos:";
        }

        private void botao_Click(object sender, EventArgs e)
        {
            string entrada = textBox.Text;

            if (numN == 0)
            {
                if (int.TryParse(entrada, out numN) && numN > 0)
                {
                    label2.Text = $"Digite o 1º valor:";
                    textBox.Clear();
                }
                else
                {
                    MessageBox.Show("Valor inválido! Digite um número inteiro válido.");
                }
                return;
            }

            int valor;

            if (!int.TryParse(entrada, out valor) || valor <= 0)
            {
                MessageBox.Show("Valor inválido! Digite um número inteiro válido.");
                return;
            }

            listaValores.Add(valor);
            listaFatorial.Add(CalcularFatorial(valor));
            contador++;

            textBox.Clear();

            if (contador < numN)
            {
                label2.Text = $"Digite o {contador + 1}º valor:";
                return;
            }

            string resultado = "Valor\tFatorial\n-------------------\n";

            for (int i = 0; i < listaValores.Count; i++)
                resultado += $"{listaValores[i]}\t{listaFatorial[i]}\n";

            MessageBox.Show(resultado, "Resultado");

            numN = 0;
            contador = 0;
            listaValores.Clear();
            listaFatorial.Clear();
            label2.Text = "Digite quantos valores devem ser lidos:";
        }

        int CalcularFatorial(int numero)
        {
            if (numero <= 1) return 1;
            return numero * CalcularFatorial(numero - 1);
        }
    }
}
