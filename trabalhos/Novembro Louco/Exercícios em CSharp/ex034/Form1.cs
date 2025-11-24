using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        private const int totalAlunos = 45;
        private List<int> idades = new List<int>();
        private List<double> alturas = new List<double>();
        private int contador = 0;

        public Form1()
        {
            InitializeComponent();
            label2.Text = "Informe a idade do aluno 1:";
        }

        private void botao_Click(object sender, EventArgs e)
        {
            if (contador < totalAlunos)
            {
                if (contador % 2 == 0) // Par significa idade
                {
                    if (int.TryParse(textBox.Text, out int idade))
                    {
                        idades.Add(idade);
                        contador++;
                        if (contador < totalAlunos)
                        {
                            label2.Text = $"Informe a altura do aluno {(contador + 1) / 2 + 1} em metros:";
                        }
                    }
                    else
                    {
                        MessageBox.Show("Valor inválido! Por favor, digite uma idade válida.", "Erro");
                    }
                }
                else // Ímpar significa altura
                {
                    if (double.TryParse(textBox.Text, out double altura))
                    {
                        if (altura < 1.70)
                        {
                            idades.Add(idades[contador - 1]); // Adiciona a idade do aluno anterior
                        }

                        if (contador >= 1 && contador % 2 != 0) // Adiciona apenas se for o segundo aluno
                        {
                            alturas.Add(altura);
                        }
                        contador++;

                        if (contador < totalAlunos)
                        {
                            label2.Text = $"Informe a idade do aluno {(contador / 2) + 1}:";
                        }
                        else
                        {
                            CalcularMedias();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Valor inválido! Por favor, digite uma altura válida.", "Erro");
                    }
                }
                textBox.Clear();
            }
        }

        private void CalcularMedias()
        {
            double somaIdade = 0;
            foreach (var idade in idades)
            {
                somaIdade += idade;
            }
            double idadeMedia = idades.Count > 0 ? somaIdade / idades.Count : 0;

            double somaAltura = 0;
            foreach (var altura in alturas)
            {
                somaAltura += altura;
            }
            double alturaMedia = alturas.Count > 0 ? somaAltura / alturas.Count : 0;

            MessageBox.Show($"A idade média dos alunos com menos de 1,70 m é: {idadeMedia:F1} anos\n" +
                            $"A altura média dos alunos com mais de 20 anos é: {alturaMedia:F1} metros", "Resultados");
        }
    }
}