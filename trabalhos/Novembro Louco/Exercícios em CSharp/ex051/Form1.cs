using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        private List<Funcionario> funcionarios = new List<Funcionario>();
        private int etapa = 0;

        public Form1()
        {
            InitializeComponent();
            label2.Text = "Digite o nome do funcionário (ou 'fim' para encerrar):";
        }

        private void botao_Click(object sender, EventArgs e)
        {
            if (etapa == 0)
            {
                string nome = textBox.Text;

                if (nome.ToLower() == "fim")
                {
                    ExibirResultados();
                    return;
                }

                label2.Text = $"Digite o salário de {nome}:";
                funcionarios.Add(new Funcionario { Nome = nome });
                etapa++;
            }
            else if (etapa == 1)
            {
                if (double.TryParse(textBox.Text, out double salario))
                {
                    funcionarios[funcionarios.Count - 1].Salario = salario;
                    etapa = 0; // Reseta para a próxima entrada
                    label2.Text = "Digite o nome do funcionário (ou 'fim' para encerrar):";
                }
                else
                {
                    MessageBox.Show("Salário inválido! Por favor, insira um número.", "Erro");
                }
            }

            textBox.Clear();
        }

        private void ExibirResultados()
        {
            if (funcionarios.Count > 0)
            {
                double totalSalarios = funcionarios.Sum(funcionario => funcionario.Salario);
                double salarioMaisAlto = funcionarios.Max(funcionario => funcionario.Salario);
                double salarioMaisBaixo = funcionarios.Min(funcionario => funcionario.Salario);
                double mediaSalarios = totalSalarios / funcionarios.Count;

                MessageBox.Show($"Média de salários: {mediaSalarios:F1}\n" +
                                $"Salário mais alto: {salarioMaisAlto:F1}\n" +
                                $"Salário mais baixo: {salarioMaisBaixo:F1}", "Resultados");
            }
            else
            {
                MessageBox.Show("Nenhum funcionário foi registrado.", "Informação");
            }

            ResetFields();
        }

        private void ResetFields()
        {
            funcionarios.Clear();
            etapa = 0;
            label2.Text = "Digite o nome do funcionário (ou 'fim' para encerrar):";
        }
    }

    class Funcionario
    {
        public string Nome { get; set; }
        public double Salario { get; set; }
    }
}