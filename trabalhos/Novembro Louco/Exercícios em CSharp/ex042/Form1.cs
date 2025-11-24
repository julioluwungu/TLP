using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        private List<int> numeros = new List<int>();
        private int contador = 1;

        public Form1()
        {
            InitializeComponent();
            label2.Text = "Digite o 1º número (9999 para encerrar):";
        }

        private void botao_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox.Text, out int numero))
            {
                if (numero != 9999)
                {
                    numeros.Add(numero);
                    contador++;
                    label2.Text = $"Digite o {contador}º número (9999 para encerrar):";
                }
                else
                {
                    CalcularResultados();
                }
            }
            else
            {
                MessageBox.Show("Valor inválido! Por favor, digite um valor válido.", "Erro");
            }

            textBox.Clear();
        }

        private void CalcularResultados()
        {
            int soma = numeros.Sum();
            double media = numeros.Count > 0 ? (double)soma / numeros.Count : 0;

            MessageBox.Show($"A soma dos números é de: {soma}\nA média dos números é de: {media:F1}", "Resultados");
            ResetFields();
        }

        private void ResetFields()
        {
            numeros.Clear();
            contador = 1;
            label2.Text = "Digite o 1º número (9999 para encerrar):";
        }
    }
}