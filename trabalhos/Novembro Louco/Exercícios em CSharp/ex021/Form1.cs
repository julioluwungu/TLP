using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        private List<string> nomes = new List<string>();
        private int contador = 0;

        public Form1()
        {
            InitializeComponent();
            label2.Text = "Digite o nome da pessoa 1:";
        }

        private void botao_Click(object sender, EventArgs e)
        {
            if (contador < 10)
            {
                nomes.Add(textBox.Text);
                contador++;

                if (contador < 10)
                {
                    label2.Text = $"Digite o nome da pessoa {contador + 1}:";
                    textBox.Clear();
                }
                else
                {
                    label2.Text = "Digite um nome para verificar:";
                    textBox.Clear();
                    botao.Text = "Verificar Nome"; // Altera o texto do botão
                }
            }
            else
            {
                string verificarNome = textBox.Text;

                if (nomes.Contains(verificarNome))
                {
                    MessageBox.Show("ACHEI", "Resultado");
                }
                else
                {
                    MessageBox.Show("NÃO ACHEI", "Resultado");
                }
            }
        }
    }
}