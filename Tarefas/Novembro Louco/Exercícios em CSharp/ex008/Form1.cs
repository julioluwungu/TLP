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
            label1.Text = "Números com Propriedade Especial";
        }

        private void botao_Click(object sender, EventArgs e)
        {
            List<int> valores = new List<int>();

            for (int num = 1000; num <= 9999; num++)
            {
                string strnum = num.ToString();
                int parte1 = int.Parse(strnum[0].ToString() + strnum[1].ToString());
                int parte2 = int.Parse(strnum[2].ToString() + strnum[3].ToString());
                int resultado = (int)Math.Pow(parte1 + parte2, 2);

                if (resultado == num)
                {
                    valores.Add(num);
                }
            }

            string saida = "Os números que seguem a regra são:\n";

            foreach (var numero in valores)
            {
                saida += numero + "\n";
            }

            MessageBox.Show(saida);
        }
    }
}
