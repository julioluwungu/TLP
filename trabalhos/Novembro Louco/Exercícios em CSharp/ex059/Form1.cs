using System;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        private int etapa = 0;
        private int maiorIdade = -1;
        private int qtdMulheres18_35 = 0;
        private int qtdVerdeLouros = 0;
        private int idade;
        private string sexo;

        public Form1()
        {
            InitializeComponent();
            label2.Text = "Informe a idade (ou -1 para encerrar):";
        }

        private void botao_Click(object sender, EventArgs e)
        {
            if (etapa == 0)
            {
                if (int.TryParse(textBox.Text, out idade) && idade == -1)
                {
                    ShowResults();
                    return;
                }

                if (int.TryParse(textBox.Text, out idade))
                {
                    maiorIdade = Math.Max(maiorIdade, idade);
                    etapa++;
                    label2.Text = "Informe o sexo (M/F):";
                }
            }
            else if (etapa == 1)
            {
                sexo = textBox.Text.ToUpper();
                etapa++;
                label2.Text = "Informe a cor dos olhos ([1] azuis, [2] verdes ou [3] castanhos):";
            }
            else if (etapa == 2)
            {
                int corOlhos = int.Parse(textBox.Text);
                etapa++;
                label2.Text = "Informe a cor dos cabelos ([1] loiro, [2] castanho ou [3] preto):";
            }
            else if (etapa == 3)
            {
                int corCabelos = int.Parse(textBox.Text);

                if (sexo == "F" && idade >= 18 && idade <= 35)
                {
                    qtdMulheres18_35++;
                }

                if (corOlhos == 2 && corCabelos == 1)
                {
                    qtdVerdeLouros++;
                }

                etapa = 0;
                label2.Text = "Informe a idade (ou -1 para encerrar):";
            }

            textBox.Clear();
        }

        private void ShowResults()
        {
            MessageBox.Show($"A maior idade dos habitantes é: {maiorIdade}");
            MessageBox.Show($"Quantidade de mulheres entre 18 e 35 anos: {qtdMulheres18_35}");
            MessageBox.Show($"Quantidade de indivíduos com olhos verdes e cabelos louros: {qtdVerdeLouros}");
        }
    }
}