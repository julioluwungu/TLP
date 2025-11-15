using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApp9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "Sequência de Fibonacci";
        }

        private void botao_Click(object sender, EventArgs e)
        {
            List<int> fibonacci = new List<int> { 0, 1 };

            for (int c = 2; c < 15; c++)
            {
                int proximoTermo = fibonacci[c - 1] + fibonacci[c - 2];
                fibonacci.Add(proximoTermo);
            }

            string resultado = "Os 15 primeiros termos da sequência de Fibonacci são:\n";
            
            foreach (var termo in fibonacci)
            {
                resultado += termo + "\n";
            }

            MessageBox.Show(resultado);
        }
    }
}
