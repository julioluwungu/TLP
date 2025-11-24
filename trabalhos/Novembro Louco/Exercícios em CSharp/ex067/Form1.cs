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
            label1.Text = "Múltiplos de 5";
        }

        private void botao_Click(object sender, EventArgs e)
        {
            List<int> multiplos5 = new List<int>();
            int fim = 10000;

            for (int num = 1; num <= fim; num++)
            {
                if (num % 5 == 0)
                {
                    multiplos5.Add(num);
                }
            }

            double percentual5 = (multiplos5.Count * 100.0) / fim;
            string resultado = $"No intervalo de 1 à 10.000 foram encontrados {multiplos5.Count} múltiplos de 5.\n";
            resultado += $"O percentual de 5 é de {percentual5:F1}%";

            MessageBox.Show(resultado);
        }
    }
}