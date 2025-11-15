using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        private List<double> salarios = new List<double>();
        private int contador = 0;
        private int quantidadeFuncionarios = 0;

        public Form1()
        {
            InitializeComponent();
            label2.Text = "Informe a quantidade de funcionários:";
        }

        private void botao_Click(object sender, EventArgs e)
        {
            if (contador == 0)
            {
                if (int.TryParse(textBox.Text, out quantidadeFuncionarios) && quantidadeFuncionarios > 0)
                {
                    label2.Text = "Digite o nome do 1º funcionário:";
                    contador++;
                }
                else
                {
                    MessageBox.Show("Por favor, insira um número válido de funcionários.", "Erro");
                }
            }
            else if (contador <= quantidadeFuncionarios)
            {
                string nome = textBox.Text;
                label2.Text = $"Informe o salário de {nome}:";
                textBox.Clear();
                contador++;
            }
            else
            {
                if (double.TryParse(textBox.Text, out double salario))
                {
                    salarios.Add(salario);
                    textBox.Clear();

                    if (contador <= quantidadeFuncionarios)
                    {
                        label2.Text = $"Digite o nome do {contador}º funcionário:";
                    }
                    else
                    {
                        double somaSalarios = salarios.Sum();
                        double mediaSalarios = somaSalarios / salarios.Count;
                        double salarioMaisAlto = salarios.Max();
                        double salarioMaisBaixo = salarios.Min();

                        MessageBox.Show($"Média dos salários: R$ {mediaSalarios:F1}\n" +
                                        $"Salário mais alto: R$ {salarioMaisAlto:F1}\n" +
                                        $"Salário mais baixo: R$ {salarioMaisBaixo:F1}", "Resultados");
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, insira um salário válido.", "Erro");
                }
            }
        }
    }
}