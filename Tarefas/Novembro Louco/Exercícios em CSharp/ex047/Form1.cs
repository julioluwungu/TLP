using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        private List<int> alunos = new List<int>();
        private int numAlunos;
        private int contador = 0;

        public Form1()
        {
            InitializeComponent();
            label2.Text = "Digite o número de alunos:";
        }

        private void botao_Click(object sender, EventArgs e)
        {
            if (contador == 0)
            {
                if (int.TryParse(textBox.Text, out numAlunos) && numAlunos > 0)
                {
                    alunos.Clear(); // Limpa a lista de alunos
                    contador++;
                    label2.Text = "Digite o número de vezes que cada aluno utilizou o restaurante:";
                }
                else
                {
                    MessageBox.Show("Entrada inválida! Por favor, digite um número válido de alunos.", "Erro");
                }
            }
            else
            {
                if (contador <= numAlunos)
                {
                    if (int.TryParse(textBox.Text, out int uso) && uso >= 0)
                    {
                        alunos.Add(uso);
                        contador++;

                        if (contador > numAlunos)
                        {
                            CalcularResultados();
                        }
                        else
                        {
                            label2.Text = $"Aluno {contador}:";
                        }
                    }
                    else
                    {
                        MessageBox.Show("Número inválido! Por favor, digite um valor válido.", "Erro");
                    }
                }
            }

            textBox.Clear();
        }

        private void CalcularResultados()
        {
            int menosQue10 = alunos.Count(aluno => aluno < 10);
            int entre10e15 = alunos.Count(aluno => aluno >= 10 && aluno <= 15);
            int acimaDe15 = alunos.Count(aluno => aluno > 15);

            int totalAlunos = alunos.Count;
            double percentualMenosQue10 = (menosQue10 * 100.0) / totalAlunos;
            double percentualEntre10e15 = (entre10e15 * 100.0) / totalAlunos;
            double percentualAcimaDe15 = (acimaDe15 * 100.0) / totalAlunos;

            MessageBox.Show($"a) Percentual de alunos que utilizaram menos que 10 vezes: {percentualMenosQue10:F1}%\n" +
                            $"b) Percentual de alunos que utilizaram entre 10 e 15 vezes: {percentualEntre10e15:F1}%\n" +
                            $"c) Percentual de alunos que utilizaram mais de 15 vezes: {percentualAcimaDe15:F1}%", "Resultados");
            ResetFields();
        }

        private void ResetFields()
        {
            alunos.Clear();
            numAlunos = 0;
            contador = 0;
            label2.Text = "Digite o número de alunos:";
        }
    }
}