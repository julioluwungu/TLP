using System;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        private int numAndares;
        private int totalPessoas = 0;

        public Form1()
        {
            InitializeComponent();
            label2.Text = "Informe o número de andares do prédio:";
        }

        private void botao_Click(object sender, EventArgs e)
        {
            if (numAndares == 0)
            {
                if (int.TryParse(textBox.Text, out numAndares) && numAndares > 0)
                {
                    etapa = 1;
                    textBox.Clear();
                    label2.Text = "Informe o número de pessoas que entraram no elevador no 1º andar:";
                }
                else
                {
                    MessageBox.Show("Valor inválido! Por favor, digite um número válido de andares.");
                }
            }
            else
            {
                if (etapa <= numAndares)
                {
                    if (int.TryParse(textBox.Text, out int entraram))
                    {
                        totalPessoas += entraram;
                        label2.Text = $"Informe o número de pessoas que saíram do elevador no {etapa}º andar:";
                        etapa++;
                    }
                    else
                    {
                        MessageBox.Show("Entrada inválida! Insira um número.");
                    }
                }
                else
                {
                    if (int.TryParse(textBox.Text, out int sairam))
                    {
                        totalPessoas -= sairam;

                        if (totalPessoas > 15)
                        {
                            int excesso = totalPessoas - 15;
                            MessageBox.Show($"Excesso de passageiros! Deve sair {excesso} pessoas.");
                            totalPessoas -= excesso;
                        }

                        if (totalPessoas < 0)
                        {
                            totalPessoas = 0;
                        }

                        if (etapa == numAndares + 1)
                        {
                            ShowResults();
                        }
                        else
                        {
                            label2.Text = $"Informe o número de pessoas que entraram no elevador no {etapa}º andar:";
                            etapa++;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Entrada inválida! Insira um número.");
                    }
                }
            }

            textBox.Clear();
        }

        private int etapa = 0;

        private void ShowResults()
        {
            MessageBox.Show($"Número de pessoas que irão descer no último andar: {totalPessoas}");
        }
    }
}