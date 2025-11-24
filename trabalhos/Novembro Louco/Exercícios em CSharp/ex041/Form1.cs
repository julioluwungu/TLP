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
            label1.Text = "Sequência Fibonacci";
        }

        private void botao_Click(object sender, EventArgs e)
        {
            int[] fibonacci = new int[20];
            fibonacci[0] = 0;
            fibonacci[1] = 1;

            for (int c = 2; c < 20; c++)
            {
                fibonacci[c] = fibonacci[c - 1] + fibonacci[c - 2];
            }

            string resultado = "Os 20 primeiros termos da sequência de Fibonacci são:\n";
            
            foreach (var termo in fibonacci)
            {
                resultado += termo + "\n";
            }

            MessageBox.Show(resultado);
        }
    }
}