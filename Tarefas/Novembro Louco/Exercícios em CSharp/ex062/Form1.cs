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
            label1.Text = "Produto Ímpares";
        }

        private void botao_Click(object sender, EventArgs e)
        {
            int produto = 1;

            for (int c = 1; c <= 15; c++)
            {
                if (c % 2 != 0)
                {
                    produto *= c;
                }
            }

            MessageBox.Show($"O produto dos inteiros ímpares de 1 a 15 é: {produto}");
        }
    }
}