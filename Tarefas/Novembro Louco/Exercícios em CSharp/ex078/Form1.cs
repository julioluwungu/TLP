using System;
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

            string fraseAlterada = SubstituirEspacos(frase);
            MessageBox.Show($"Frase alterada: {fraseAlterada}");
        }

        private string SubstituirEspacos(string frase)
        {
            return frase.Replace(" ", "#");
        }
    }
}