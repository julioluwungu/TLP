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
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "Soma de 15 Números";
            label2.Text = "Digite 15 números separados por vírgula:";
        }

        private void botao_Click(object sender, EventArgs e)
        {
            string input = textBox.Text.Trim();
            
            if (string.IsNullOrEmpty(input))
            {
                MessageBox.Show("Por favor, digite os números!", "Aviso", 
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string[] numeros = input.Split(',');

            if (numeros.Length != 15)
            {
                MessageBox.Show("Por favor, digite exatamente 15 números separados por vírgula!", "Erro", 
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                double soma = 0;
                foreach (string numero in numeros)
                {
                    soma += double.Parse(numero.Trim());
                }

                MessageBox.Show($"A soma dos 15 números é: {soma}", "Resultado", 
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, digite apenas números válidos!", "Erro", 
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}", "Erro", 
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_TextChanged(object sender, EventArgs e) { }
        private void label2_TextChanged(object sender, EventArgs e) { }
    }
}