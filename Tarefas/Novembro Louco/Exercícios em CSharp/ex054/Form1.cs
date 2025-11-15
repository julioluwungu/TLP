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
            label1.Text = "Crescimento Alturas";
        }

        private void botao_Click(object sender, EventArgs e)
        {
            double alturaChico = 1.50;
            double alturaZe = 1.10;
            double crescimentoChico = 0.02;
            double crescimentoZe = 0.03;
            int anos = 0;

            while (alturaZe <= alturaChico)
            {
                alturaChico += crescimentoChico;
                alturaZe += crescimentoZe;
                anos++;
            }

            MessageBox.Show($"Serão necessários {anos} anos para que Zé seja maior que Chico.");
        }
    }
}