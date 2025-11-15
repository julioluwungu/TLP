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
            label1.Text = "Soma de 1 a 10";
        }

        private void botao_Click(object sender, EventArgs e)
        {
            int cont = 1;
            int soma = 0;

            do
            {
                soma += cont;
                cont++;
            } while (cont != 11);

            MessageBox.Show($"A soma dos números de 1 à 10 é de: {soma}");
        }
    }
}