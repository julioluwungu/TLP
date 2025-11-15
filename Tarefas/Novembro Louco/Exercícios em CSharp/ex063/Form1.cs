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
            label1.Text = "Quadrados e Cubos";
        }

        private void botao_Click(object sender, EventArgs e)
        {
            string resultado = "Imprimindo os quadrados e cubos dos números entre 0 e 10:\n";
            
            for (int num = 0; num <= 10; num++)
            {
                resultado += $"{num} === {num * num} === {num * num * num}\n";
            }

            MessageBox.Show(resultado);
        }
    }
}