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
            label1.Text = "Soma Ímpares Múltiplos de 3";
        }

        private void botao_Click(object sender, EventArgs e)
        {
            int soma = 0;

            for (int num = 1; num <= 500; num++)
            {
                if (num % 2 != 0 && num % 3 == 0)
                {
                    soma += num;
                }
            }

            MessageBox.Show($"A soma dos números ímpares que são múltiplos de três de 1 até 500 é: {soma}");
        }
    }
}