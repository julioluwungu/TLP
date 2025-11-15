using System;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label2.Text = "Montar a tabuada de:";
        }

        private void botao_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox.Text, out int numero))
            {
                label2.Text = "Começar por:";
                textBox.Clear();

                botao.Tag = "inicio"; // Marca o botão para a próxima etapa
            }
            else if (botao.Tag != null && botao.Tag.ToString() == "inicio")
            {
                if (int.TryParse(textBox.Text, out int inicio))
                {
                    label2.Text = "Terminar em:";
                    textBox.Clear();

                    botao.Tag = "fim";
                }
                else
                {
                    MessageBox.Show("Valor inválido! Por favor, digite um número válido!", "Erro");
                }
            }
            else if (botao.Tag != null && botao.Tag.ToString() == "fim")
            {
                if (int.TryParse(textBox.Text, out int fim))
                {
                    if (fim < int.Parse(label2.Text))
                    {
                        MessageBox.Show("O valor final não pode ser menor que o valor inicial. Tente novamente.", "Erro");
                        return;
                    }
                    else
                    {
                        var resultado = $"Vou montar a tabuada de {numero} começando em {inicio} e terminando em {fim}:\n";
                        
                        for (int i = inicio; i <= fim; i++)
                        {
                            resultado += $"{numero} X {i} = {numero * i}\n";
                        }

                        MessageBox.Show(resultado, "Resultado");
                    }
                }
                else
                {
                    MessageBox.Show("Valor inválido! Por favor, digite um número válido!", "Erro");
                }
            }
        }
    }
}