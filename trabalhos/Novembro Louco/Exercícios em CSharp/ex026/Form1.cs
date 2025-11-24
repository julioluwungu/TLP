using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        private List<(int codigo, string sexo, double salario_bruto, double salario_liquido)> listagem = new List<(int, string, double, double)>();
        private List<double> salarioM = new List<double>();
        private List<double> salarioF = new List<double>();

        public Form1()
        {
            InitializeComponent();
            label2.Text = "Digite o código (ou 99999 para sair):";
        }

        private void botao_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox.Text, out int codigo))
            {
                if (codigo == 99999)
                {
                    EmitirListagem();
                    return;
                }

                string sexo;
                while (true)
                {
                    sexo = PromptForSexo();
                    if (sexo != null) break;
                }

                if (int.TryParse(Microsoft.VisualBasic.Interaction.InputBox("Digite o número de horas/aulas dadas:"), out int horas))
                {
                    double salBruto = horas * 30;
                    double desconto = (sexo == "M") ? 0.10 : 0.05;
                    double salLiquido = salBruto * (1 - desconto);

                    if (sexo == "M")
                    {
                        salarioM.Add(salLiquido);
                    }
                    else
                    {
                        salarioF.Add(salLiquido);
                    }

                    listagem.Add((codigo, sexo, salBruto, salLiquido));
                    label2.Text = "Digite o código (ou 99999 para sair):";
                }
                else
                {
                    MessageBox.Show("Valor inválido para horas.", "Erro");
                }
            }
            else
            {
                MessageBox.Show("Valor inválido! Por favor, insira um número.", "Erro");
            }
        }

        private string PromptForSexo()
        {
            string sexo = Microsoft.VisualBasic.Interaction.InputBox("Qual o sexo? [M/F]:").Trim().ToUpper();
            if (sexo == "M" || sexo == "F") return sexo;
            else MessageBox.Show("Sexo inválido. Por favor, tente novamente!", "Erro");
            return null;
        }

        private void EmitirListagem()
        {
            double somaSalM = salarioM.Sum();
            double somaSalF = salarioF.Sum();
            double mediaSalM = salarioM.Count > 0 ? somaSalM / salarioM.Count : 0;
            double mediaSalF = salarioF.Count > 0 ? somaSalF / salarioF.Count : 0;

            string resultado = "Emitindo listagem:\n";
            foreach (var pessoa in listagem)
            {
                resultado += $"Código: {pessoa.codigo}. Sexo: {pessoa.sexo}. Salário bruto: R$ {pessoa.salario_bruto:F1}. Salário líquido: R$ {pessoa.salario_liquido:F1}.\n";
            }
            resultado += $"Média dos salários líquidos do sexo masculino: R$ {mediaSalM:F1}\n";
            resultado += $"Média dos salários líquidos do sexo feminino: R$ {mediaSalF:F1}";

            MessageBox.Show(resultado, "Listagem");
        }
    }
}