using System;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        private double diaria = 50;
        private double totalGanhoHotel = 0;

        public Form1()
        {
            InitializeComponent();
            label2.Text = "Informe o nome do cliente (ou 'sair' para encerrar):";
        }

        private void botao_Click(object sender, EventArgs e)
        {
            string nome = textBox.Text;

            if (nome.ToLower() == "sair")
            {
                ShowTotal();
                return;
            }

            label2.Text = "Informe o número de diárias:";
            textBox.Clear();
            textBox.Focus();
            etapa = 1;
        }

        private int etapa = 0;

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            if (etapa == 1)
            {
                if (int.TryParse(textBox.Text, out int numDiarias) && numDiarias > 0)
                {
                    double taxaServico;
                    if (numDiarias < 15)
                    {
                        taxaServico = 4;
                    }
                    else if (numDiarias == 15)
                    {
                        taxaServico = 3.6;
                    }
                    else
                    {
                        taxaServico = 3;
                    }

                    double totalConta = (diaria + taxaServico) * numDiarias;
                    totalGanhoHotel += totalConta;

                    MessageBox.Show($"Nome do cliente: {textBox.Text}\nTotal da conta: R$ {totalConta:F2}");

                    etapa = 0;
                    label2.Text = "Informe o nome do cliente (ou 'sair' para encerrar):";
                }
                else
                {
                    MessageBox.Show("Número de diárias inválido!");
                }
            }

            textBox.Clear();
        }

        private void ShowTotal()
        {
            MessageBox.Show($"Total ganho pelo hotel: R$ {totalGanhoHotel:F2}");
        }
    }
}