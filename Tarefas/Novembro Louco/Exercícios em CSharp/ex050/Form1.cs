using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        private List<Hotel> hoteis = new List<Hotel>();
        private int passo = 0;

        public Form1()
        {
            InitializeComponent();
            label2.Text = "Digite o nome do hotel:";
        }

        private void botao_Click(object sender, EventArgs e)
        {
            if (passo == 0)
            {
                string nome = textBox.Text;
                label2.Text = "Digite a distância do hotel ao centro da cidade (em km):";
                hoteis.Add(new Hotel { Nome = nome });
                passo++;
            }
            else if (passo == 1)
            {
                if (double.TryParse(textBox.Text, out double distancia))
                {
                    hoteis[hoteis.Count - 1].Distancia = distancia;
                    label2.Text = "Digite o número médio de visitantes no último feriado:";
                    passo++;
                }
                else
                {
                    MessageBox.Show("Valor inválido! Por favor, digite uma distância válida.", "Erro");
                }
            }
            else if (passo == 2)
            {
                if (int.TryParse(textBox.Text, out int visitantes))
                {
                    hoteis[hoteis.Count - 1].Visitantes = visitantes;
                    label2.Text = "Digite o tipo de acesso ao hotel (0 - não asfaltado, 1 - asfaltado):";
                    passo++;
                }
                else
                {
                    MessageBox.Show("Valor inválido! Por favor, digite um número válido de visitantes.", "Erro");
                }
            }
            else if (passo == 3)
            {
                if (int.TryParse(textBox.Text, out int acesso))
                {
                    hoteis[hoteis.Count - 1].Acesso = acesso;

                    label2.Text = "Deseja adicionar mais um hotel? (s/n):";
                    passo++;
                }
                else
                {
                    MessageBox.Show("Valor inválido! Por favor, digite um valor de acesso válido.", "Erro");
                }
            }
            else if (passo == 4)
            {
                if (textBox.Text.ToLower() == "s")
                {
                    passo = 0;
                    label2.Text = "Digite o nome do hotel:";
                }
                else
                {
                    ExibirResultados();
                }
            }

            textBox.Clear();
        }

        private void ExibirResultados()
        {
            int hoteisDistantes = hoteis.Count(h => h.Distancia > 15);
            double mediaVisitantes = hoteis.Where(h => h.Acesso == 0).Average(h => h.Visitantes);

            string resultados = $"Número de hotéis que distam mais de 15 km do centro: {hoteisDistantes}\n" +
                                $"Quantidade média de visitantes em hotéis com acesso não asfaltado: {mediaVisitantes:F1}\n" +
                                "Hotéis asfaltados com menos de 1.000 visitantes:\n";

            foreach (var hotel in hoteis.Where(h => h.Acesso == 1 && h.Visitantes < 1000))
            {
                resultados += $"{hotel.Nome}, Distância: {hotel.Distancia} km\n";
            }

            MessageBox.Show(resultados, "Resultados");
            ResetFields();
        }

        private void ResetFields()
        {
            hoteis.Clear();
            passo = 0;
            label2.Text = "Digite o nome do hotel:";
        }
    }

    class Hotel
    {
        public string Nome { get; set; }
        public double Distancia { get; set; }
        public int Visitantes { get; set; }
        public int Acesso { get; set; }
    }
}