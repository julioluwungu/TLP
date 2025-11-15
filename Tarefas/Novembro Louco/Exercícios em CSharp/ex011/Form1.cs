using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApp9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "Números Amigáveis";
        }

        private void botao_Click(object sender, EventArgs e)
        {
            const int limite = 100000;
            var paresAmigaveis = EncontrarNumerosAmigaveis(limite);

            string resultado = "Pares de números amigáveis entre 1 e 100000:\n";

            foreach (var par in paresAmigaveis)
            {
                resultado += $"[{par.Item1}, {par.Item2}]\n";
            }

            MessageBox.Show(resultado);
        }

        private int SomaDivisores(int n)
        {
            int soma = 0;
            for (int i = 1; i <= n / 2; i++)
            {
                if (n % i == 0)
                {
                    soma += i;
                }
            }
            return soma;
        }

        private List<(int, int)> EncontrarNumerosAmigaveis(int limite)
        {
            var paresAmigaveis = new List<(int, int)>();

            for (int a = 1; a < limite; a++)
            {
                int b = SomaDivisores(a);
                if (b > a && b < limite && SomaDivisores(b) == a)
                {
                    paresAmigaveis.Add((a, b));
                }
            }

            return paresAmigaveis;
        }
    }
}
