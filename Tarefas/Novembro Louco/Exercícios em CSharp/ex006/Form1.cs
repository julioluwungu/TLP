using System;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label2.Text = "Digite uma sequência de números:";
        }

        private void botao_Click(object sender, EventArgs e)
        {
            string numeros = textBox.Text;
            if (numeros.All(char.IsDigit))
            {
                int[] listaNum = numeros.Select(c => (int)char.GetNumericValue(c)).ToArray();
                int soma = listaNum.Sum();
                MessageBox.Show($"A soma dos números digitados é: {soma}", "Resultado");
            }
            else
            {
                MessageBox.Show("Valor inválido! Por favor, digite um número válido!", "Erro");
            }
        }
    }
}