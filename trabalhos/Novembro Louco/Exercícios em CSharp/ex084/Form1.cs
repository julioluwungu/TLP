using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        private Dictionary<string, int> nomesContador = new Dictionary<string, int>();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "Gerenciador de Nomes";
            label2.Text = "Digite um nome:";
            textBox.Text = "";
        }

        private void botao_Click(object sender, EventArgs e)
        {
            string nome = textBox.Text.Trim();
            
            if (string.IsNullOrEmpty(nome))
            {
                MessageBox.Show("Por favor, digite um nome!", "Aviso", 
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string nomeNormalizado = nome.ToLower();

            if (nomesContador.ContainsKey(nomeNormalizado))
            {
                nomesContador[nomeNormalizado]++;
            }
            else
            {
                nomesContador[nomeNormalizado] = 1;
            }

            AtualizarListBox();
            
            textBox.Text = "";
            textBox.Focus();
        }

        private void botao2_Click(object sender, EventArgs e)
        {
            MostrarResultados();
        }

        private void AtualizarListBox()
        {
            listBox.Items.Clear();
            
            foreach (var item in nomesContador.OrderBy(x => x.Key))
            {
                listBox.Items.Add($"{item.Key} - {item.Value} vez(es)");
            }
        }

        private void MostrarResultados()
        {
            if (nomesContador.Count == 0)
            {
                MessageBox.Show("Nenhum nome foi inserido!", "Resultado", 
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var maisInserido = nomesContador.OrderByDescending(x => x.Value).First();
            var menosInserido = nomesContador.OrderBy(x => x.Value).First();

            string resultado = $"RESULTADOS FINAIS:\n\n" +
                             $"Nome mais inserido: {maisInserido.Key}\n" +
                             $"Quantidade: {maisInserido.Value} vez(es)\n\n" +
                             $"Nome menos inserido: {menosInserido.Key}\n" +
                             $"Quantidade: {menosInserido.Value} vez(es)\n\n" +
                             $"Total de nomes distintos: {nomesContador.Count}";

            MessageBox.Show(resultado, "Estatísticas dos Nomes", 
                          MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void label1_TextChanged(object sender, EventArgs e) { }
        private void label2_TextChanged(object sender, EventArgs e) { }
    }
}