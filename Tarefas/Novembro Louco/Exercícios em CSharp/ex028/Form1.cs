using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        private List<int> valores = new List<int>();
        private int contador = 0;

        public Form1()
        {
            InitializeComponent();
            label2.Text = "Digite o 1º valor:";
        }

        private void botao_Click(object sender, EventArgs e)
        {
            if (contador < 50)
            {
                if (int.TryParse(textBox.Text, out int num))
                {
                    valores.Add(num);
                    contador++;
                    if (contador < 50)
                    {
                        label2.Text = $"Digite o {contador + 1}º valor:";
                        textBox.Clear();
                    }
                    else
                    {
                        var positivos = valores.Where(num => num > 0).ToList();
                        var negativos = valores.Where(num => num < 0).ToList();
                        int soma = positivos.Sum();

                        MessageBox.Show($"A soma dos valores positivos digitados é de: {soma}\n" +
                                        $"A quantidade dos valores negativos digitados é de: {negativos.Count}", "Resultado");
                    }
                }
                else
                {
                    MessageBox.Show("Valor inválido! Por favor, digite um número válido!", "Erro");
                }
            }
        }
    }
}