using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void botao_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox.Text, out int variacao))
            {
                switch (variacao)
                {
                    case 1:
                        label2.Text = "Executando Variação 1...";
                        await CasoUm();
                        break;
                    case 2:
                        MessageBox.Show("Nenhum código disponível para esta opção.", "Informação");
                        break;
                    case 3:
                        label2.Text = "Executando Variação 3...";
                        await CasoTres();
                        break;
                    case 4:
                        label2.Text = "Executando Variação 4...";
                        await CasoQuatro();
                        break;
                    default:
                        MessageBox.Show("Opção inválida! Por favor, tente novamente.", "Erro");
                        break;
                }
            }
            else
            {
                MessageBox.Show("Entrada inválida!", "Erro");
            }
        }

        private async Task CasoUm()
        {
            for (int c = 0; c < 10; c++)
            {
                label2.Text = "Informe o valor de A:";
                double numA = PromptForDouble("Informe o valor de A:");
                label2.Text = "Informe o valor de B:";
                double numB = PromptForDouble("Informe o valor de B:");

                if (numB == 0)
                {
                    MessageBox.Show("Divisão por zero não é permitida, tente novamente.", "Erro");
                    c--;
                    continue;
                }

                double modulo = numA % numB;
                MessageBox.Show($"O resultado do módulo é: {modulo}", "Resultado");
            }
        }

        private async Task CasoTres()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    label2.Text = "Informe o valor de A:";
                    double numA = PromptForDouble("Informe o valor de A:");
                    label2.Text = "Informe o valor de B:";
                    double numB = PromptForDouble("Informe o valor de B:");

                    if (numB == 0)
                    {
                        MessageBox.Show("Divisão por zero não é permitida, tente novamente.", "Erro");
                        j--;
                        continue;
                    }

                    double modulo = numA % numB;
                    MessageBox.Show($"O resto da divisão será de: {modulo}", "Resultado");
                }
            }
        }

        private async Task CasoQuatro()
        {
            label2.Text = "Informe quantas vezes deseja executar:";
            int numN = (int)PromptForDouble("Informe quantas vezes deseja executar:");

            for (int c = 0; c < numN; c++)
            {
                label2.Text = "Informe o valor de A:";
                double numA = PromptForDouble("Informe o valor de A:");
                label2.Text = "Informe o valor de B:";
                double numB = PromptForDouble("Informe o valor de B:");

                if (numB == 0)
                {
                    MessageBox.Show("Divisão por zero não é permitida, tente novamente.", "Erro");
                    c--;
                    continue;
                }

                double modulo = numA % numB;
                MessageBox.Show($"O resto da divisão será de: {modulo}", "Resultado");
            }
        }

        private double PromptForDouble(string message)
        {
            return Convert.ToDouble(Microsoft.VisualBasic.Interaction.InputBox(message, "Entrada"));
        }
    }
}