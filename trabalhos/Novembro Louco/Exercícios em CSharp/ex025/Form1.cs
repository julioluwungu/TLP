using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        private List<double> valores = new List<double>();

        public Form1()
        {
            InitializeComponent();
            label2.Text = "Digite um número (ou \"sair\" para encerrar):";
        }

        private void botao_Click(object sender, EventArgs e)
        {
            string entrada = textBox.Text;

            if (entrada.ToLower() == "sair")
            {
                if (valores.Count > 0)
                {
                    double soma = valores.Sum();
                    double media = soma / valores.Count;
                    var positivos = valores.Where(num => num > 0).ToList();
                    var negativos = valores.Where(num => num < 0).ToList();

                    double percentualPositivo = (positivos.Count * 100) / (double)valores.Count;
                    double percentualNegativo = (negativos.Count * 100) / (double)valores.Count;

                    string resultado = $"Média Aritmética: {media:F1}\n" +
                                       $"Quantidade de Valores Positivos: {positivos.Count}\n" +
                                       $"Quantidade de Valores Negativos: {negativos.Count}\n" +
                                       $"Percentual de Valores Positivos: {percentualPositivo:F1}%\n" +
                                       $"Percentual de Valores Negativos: {percentualNegativo:F1}%";

                    MessageBox.Show(resultado, "Resultados");
                }
                else
                {
                    MessageBox.Show("Nenhum valor foi digitado.", "Resultado");
                }
            }
            else if (double.TryParse(entrada, out double numero))
            {
                valores.Add(numero);
                textBox.Clear();
                label2.Text = "Digite um número (ou \"sair\" para encerrar):";
            }
            else
            {
                MessageBox.Show("Valor inválido! Por favor, insira um número.", "Erro");
            }
        }
    }
}