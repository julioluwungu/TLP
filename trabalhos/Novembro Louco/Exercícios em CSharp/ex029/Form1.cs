using System;
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
            label1.Text = "Múltiplos de 7 até 1000";
        }

        private void botao_Click(object sender, EventArgs e)
        {
            string resultado = "Múltiplos de 7 inferiores a 1000:\n";

            for (int num = 1; num < 1000; num++)
            {
                if (num % 7 == 0)
                {
                    resultado += num + "\n";
                }
            }

            MessageBox.Show(resultado);
        }
    }
}
