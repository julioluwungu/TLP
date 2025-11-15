using System;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        private int totalAprovados = 0;
        private int totalReprovados = 0;
        private int totalAlunos = 0;
        private int c = 1;
        private bool entradaMatricula = true;

        public Form1()
        {
            InitializeComponent();
            label2.Text = "Informe a matrícula do aluno (9999 para encerrar):";
        }

        private void botao_Click(object sender, EventArgs e)
        {
            if (entradaMatricula)
            {
                int matricula = int.Parse(textBox.Text);

                if (matricula == 9999)
                {
                    ShowResults();
                    return;
                }

                entradaMatricula = false;
                label2.Text = "Informe a 1ª nota:";
            }
            else
            {
                double nota;

                if (c == 1)
                {
                    nota = double.Parse(textBox.Text);
                    label2.Text = "Informe a 2ª nota:";
                }
                else if (c == 2)
                {
                    nota = double.Parse(textBox.Text);
                    label2.Text = "Informe a 3ª nota:";
                }
                else
                {
                    nota = double.Parse(textBox.Text);
                    double mediaFinal = ((2 * nota) + (3 * (double)nota)) / 9;

                    if (mediaFinal >= 5)
                    {
                        MessageBox.Show($"Matrícula: {textBox.Text}, Média Final: {mediaFinal:F2} - APROVADO");
                        totalAprovados++;
                    }
                    else
                    {
                        MessageBox.Show($"Matrícula: {textBox.Text}, Média Final: {mediaFinal:F2} - REPROVADO");
                        totalReprovados++;
                    }

                    totalAlunos++;
                    entradaMatricula = true;
                    c++;
                    label2.Text = "Informe a matrícula do aluno (9999 para encerrar):";
                }
                c++;
            }

            textBox.Clear();
        }

        private void ShowResults()
        {
            MessageBox.Show($"Total de alunos: {totalAlunos}");
            MessageBox.Show($"Total de aprovados: {totalAprovados}");
            MessageBox.Show($"Total de reprovados: {totalReprovados}");
        }
    }
}