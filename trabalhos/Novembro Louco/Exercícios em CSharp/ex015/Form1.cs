using System;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label2.Text = "Digite uma lista de nomes separados por vírgula:";
        }

        private void botao_Click(object sender, EventArgs e)
        {
            string nomesInput = textBox.Text;

            var listaNomes = nomesInput.Split(',')
                                        .Select(nome => nome.Trim())
                                        .OrderBy(nome => nome)
                                        .ToList();
            
            MessageBox.Show($"Lista de nomes em ordem alfabética: {string.Join(", ", listaNomes)}", "Resultado");
        }
    }
}