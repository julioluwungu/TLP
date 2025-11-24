using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        private int valorInicial;
        private bool pedindoInicial = true;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "Contagem de Pares e Ímpares";
            label2.Text = "Digite o valor inicial:";
            textBox.Text = "";
        }

        private void botao_Click(object sender, EventArgs e)
        {
            string input = textBox.Text.Trim();
            
            if (string.IsNullOrEmpty(input))
            {
                MessageBox.Show("Por favor, digite um valor!", "Aviso", 
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (pedindoInicial)
                {
                    valorInicial = int.Parse(input);
                    label2.Text = "Digite o valor final:";
                    textBox.Text = "";
                    pedindoInicial = false;
                }
                else
                {
                    int valorFinal = int.Parse(input);
                    
                    if (valorInicial > valorFinal)
                    {
                        MessageBox.Show("O valor final deve ser maior ou igual ao inicial!", "Erro", 
                                      MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    MostrarContagemColorida(valorInicial, valorFinal);
                    
                    label2.Text = "Digite o valor inicial:";
                    textBox.Text = "";
                    pedindoInicial = true;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, digite um número válido!", "Erro", 
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MostrarContagemColorida(int inicio, int fim)
        {
            Form resultadoForm = new Form();
            resultadoForm.Text = "Contagem de Pares e Ímpares";
            resultadoForm.Size = new Size(300, 400);
            resultadoForm.StartPosition = FormStartPosition.CenterScreen;

            RichTextBox richTextBox = new RichTextBox();
            richTextBox.Dock = DockStyle.Fill;
            richTextBox.ReadOnly = true;
            richTextBox.Font = new Font("Consolas", 10);
            resultadoForm.Controls.Add(richTextBox);

            for (int i = inicio; i <= fim; i++)
            {
                richTextBox.SelectionStart = richTextBox.TextLength;
                richTextBox.SelectionLength = 0;

                if (i % 2 == 0)
                {
                    richTextBox.SelectionColor = Color.Green;
                }
                else
                {
                    richTextBox.SelectionColor = Color.Red;
                }

                richTextBox.AppendText(i.ToString() + Environment.NewLine);
                richTextBox.SelectionColor = richTextBox.ForeColor;
            }

            resultadoForm.ShowDialog();
        }

        private void label1_TextChanged(object sender, EventArgs e) { }
        private void label2_TextChanged(object sender, EventArgs e) { }
    }
}