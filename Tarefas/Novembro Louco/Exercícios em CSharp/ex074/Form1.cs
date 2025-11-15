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
            label2.Text = "Digite uma frase:";
        }

        private void botao_Click(object sender, EventArgs e)
        {
            string frase = textBox.Text;

            int espacos = frase.Count(c => c == ' ');

            MessageBox.Show($"Número de espaços em branco: {espacos}");
        }
    }
}