using System;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label2.Text = "Digite o nome da primeira pessoa:";
        }

        private string nome1, nome2;
        private double altura1, peso1, altura2, peso2;
        private int passo = 0;

        private void botao_Click(object sender, EventArgs e)
        {
            if (passo == 0)
            {
                nome1 = textBox.Text;
                label2.Text = $"Digite a altura de {nome1} (em metros):";
                passo++;
            }
            else if (passo == 1)
            {
                if (double.TryParse(textBox.Text, out altura1))
                {
                    label2.Text = $"Digite o peso de {nome1} (em kg):";
                    passo++;
                }
                else
                {
                    MessageBox.Show("Valor inválido! Por favor, digite uma altura válida.", "Erro");
                }
            }
            else if (passo == 2)
            {
                if (double.TryParse(textBox.Text, out peso1))
                {
                    label2.Text = "Digite o nome da segunda pessoa:";
                    passo++;
                }
                else
                {
                    MessageBox.Show("Valor inválido! Por favor, digite um peso válido.", "Erro");
                }
            }
            else if (passo == 3)
            {
                nome2 = textBox.Text;
                label2.Text = $"Digite a altura de {nome2} (em metros):";
                passo++;
            }
            else if (passo == 4)
            {
                if (double.TryParse(textBox.Text, out altura2))
                {
                    label2.Text = $"Digite o peso de {nome2} (em kg):";
                    passo++;
                }
                else
                {
                    MessageBox.Show("Valor inválido! Por favor, digite uma altura válida.", "Erro");
                }
            }
            else if (passo == 5)
            {
                if (double.TryParse(textBox.Text, out peso2))
                {
                    var maisPesado = peso1 >= peso2 ? new { Nome = nome1, Peso = peso1 } : new { Nome = nome2, Peso = peso2 };
                    var maisAlto = altura1 >= altura2 ? new { Nome = nome1, Altura = altura1 } : new { Nome = nome2, Altura = altura2 };

                    MessageBox.Show($"A pessoa mais pesada é {maisPesado.Nome} com {maisPesado.Peso} kg.\n" +
                                    $"A pessoa mais alta é {maisAlto.Nome} com {maisAlto.Altura} m.", "Resultados");
                    ResetFields();
                }
                else
                {
                    MessageBox.Show("Valor inválido! Por favor, digite um peso válido.", "Erro");
                }
            }

            textBox.Clear();
        }

        private void ResetFields()
        {
            nome1 = nome2 = string.Empty;
            altura1 = peso1 = altura2 = peso2 = 0;
            passo = 0;
            label2.Text = "Digite o nome da primeira pessoa:";
        }
    }
}