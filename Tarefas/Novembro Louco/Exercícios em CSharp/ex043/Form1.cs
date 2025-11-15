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
                    if (numeros.Count > 0)
                    {
                        int maior = numeros.Max();
                        MessageBox.Show($"O maior valor digitado é: {maior}", "Resultado");
                    }
                    else
                    {
                        MessageBox.Show("Nenhum número foi digitado.", "Erro");
                    }
                    ResetFields();
                }
            }
            else
            {
                MessageBox.Show("Valor inválido! Por favor, digite um valor válido.", "Erro");
            }

            textBox.Clear();
        }

        private void ResetFields()
        {
            numeros.Clear();
            contador = 1;
            label2.Text = "Digite o 1º número (9999 para encerrar):";
        }
    }
}