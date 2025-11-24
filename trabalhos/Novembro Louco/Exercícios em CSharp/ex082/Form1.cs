using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int numero))
            {
                if (numero >= 0 && numero <= 20)
                {
                    long resultado = CalcularFatorial(numero);
                    MessageBox.Show($"O fatorial de {numero} é: {resultado}", "Resultado Fatorial");
                }
                else
                {
                    MessageBox.Show("Por favor, digite um número entre 0 e 20.", "Número Inválido");
                }
            }
            else
            {
                MessageBox.Show("Por favor, digite um número válido.", "Entrada Inválida");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int numero))
            {
                string resultado = VerificarParImpar(numero);
                MessageBox.Show($"O número {numero} é {resultado}.", "Resultado Par/Ímpar");
            }
            else
            {
                MessageBox.Show("Por favor, digite um número válido.", "Entrada Inválida");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int numero))
            {
                if (numero >= 0)
                {
                    string resultado = VerificarPrimo(numero);
                    MessageBox.Show($"O número {numero} {resultado}.", "Resultado Primo");
                }
                else
                {
                    MessageBox.Show("Por favor, digite um número não negativo.", "Número Inválido");
                }
            }
            else
            {
                MessageBox.Show("Por favor, digite um número válido.", "Entrada Inválida");
            }
        }

        private long CalcularFatorial(int n)
        {
            if (n == 0 || n == 1)
                return 1;

            long resultado = 1;
            for (int i = 2; i <= n; i++)
            {
                resultado *= i;
            }
            return resultado;
        }

        private string VerificarParImpar(int n)
        {
            return n % 2 == 0 ? "PAR" : "ÍMPAR";
        }

        private string VerificarPrimo(int n)
        {
            if (n < 2)
                return "NÃO É PRIMO";

            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                    return "NÃO É PRIMO";
            }

            return "É PRIMO";
        }
    }
}