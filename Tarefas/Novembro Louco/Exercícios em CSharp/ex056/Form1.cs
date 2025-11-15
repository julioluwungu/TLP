using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        private double totalSalario = 0;
        private int quantidade = 0;
        private int maiorIdade = -1;
        private int menorIdade = 1000000;
        private int mulheresComSalarioBaixo = 0;
        private int passo = 0; // Para controlar os passos de entrada

        public Form1()
        {
            InitializeComponent();
            label2.Text = "Informe a idade (negativa para encerrar):";
        }

        private void botao_Click(object sender, EventArgs e)
        {
            if (passo == 0)
            {
                if (int.TryParse(textBox.Text, out int idade))
                {
                    if (idade < 0)
                    {
                        ExibirResultados();
                        return;
                    }

                    label2.Text = "Informe o sexo (M/F):";
                    passo++;
                    textBox.Clear();
                }
                else
                {
                    MessageBox.Show("Entrada inválida! Por favor, digite uma idade válida.", "Erro");
                }
            }
            else if (passo == 1)
            {
                string sexo = textBox.Text.ToUpper();
                label2.Text = "Informe o salário:";

                if (sexo != "M" && sexo != "F")
                {
                    MessageBox.Show("Entrada inválida! Por favor, digite um sexo válido (M/F).", "Erro");
                    passo--; // Volta para o passo anterior se o sexo for inválido
                }
                else
                {
                    passo++;
                }

                textBox.Clear();
            }
            else if (passo == 2)
            {
                if (double.TryParse(textBox.Text, out double salario))
                {
                    totalSalario += salario;
                    quantidade++;

                    if (passo > maiorIdade)
                    {
                        maiorIdade = idade;
                    }

                    if (idade < menorIdade)
                    {
                        menorIdade = idade;
                    }

                    if (sexo == "F" && salario <= 100)
                    {
                        mulheresComSalarioBaixo++;
                    }

                    // Volta ao primeiro passo
                    passo = 0;
                    label2.Text = "Informe a idade (negativa para encerrar):";
                }
                else
                {
                    MessageBox.Show("Entrada inválida! Por favor, digite um salário válido.", "Erro");
                }

                textBox.Clear();
            }
        }

        private void ExibirResultados()
        {
            double mediaSalario = quantidade > 0 ? totalSalario / quantidade : 0;

            MessageBox.Show($"Média de salário do grupo: R$ {mediaSalario:F2}\n" +
                            $"Maior idade do grupo: {maiorIdade}\n" +
                            $"Menor idade do grupo: {menorIdade}\n" +
                            $"Quantidade de mulheres com salário até R$100,00: {mulheresComSalarioBaixo}", "Resultados");
            ResetFields();
        }

        private void ResetFields()
        {
            totalSalario = 0;
            quantidade = 0;
            maiorIdade = -1;
            menorIdade = 1000000;
            mulheresComSalarioBaixo = 0;
            passo = 0;
            label2.Text = "Informe a idade (negativa para encerrar):";
        }
    }
}