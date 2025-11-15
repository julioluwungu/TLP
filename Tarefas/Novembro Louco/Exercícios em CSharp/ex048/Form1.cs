using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Text = "Progressão Geométrica";
        }

        private void botao_Click(object sender, EventArgs e)
        {
            int primeiroTermo = 3;
            int razao = 3;
            List<int> termos = new List<int>();
            int termoAtual = primeiroTermo;
            int soma = 0;

            while (termoAtual <= 6561)
            {
                termos.Add(termoAtual);
                soma += termoAtual;
                termoAtual *= razao;
            }

            string resultado = $"Termos da PG: {string.Join(", ", termos)}\n";
            resultado += $"Soma dos termos: {soma}";

            MessageBox.Show(resultado);
        }
    }
}