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
                if (numero == 9999)
                {
                    ExibirResultados();
                }
                else
                {
                    numeros.Add(numero);
                    contador++;
                    label2.Text = $"Digite o {contador}º número (9999 para encerrar):";
                }
            }
            else
            {
                MessageBox.Show("Valor inválido! Por favor, digite um número válido.", "Erro");
            }

            textBox.Clear();
        }

        private void ExibirResultados()
        {
            var pares = numeros.Where(num => num % 2 == 0).ToList();
            var impares = numeros.Where(num => num % 2 != 0).ToList();

            MessageBox.Show($"Quantidade de números pares: {pares.Count}\nQuantidade de números ímpares: {impares.Count}", "Resultados");
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