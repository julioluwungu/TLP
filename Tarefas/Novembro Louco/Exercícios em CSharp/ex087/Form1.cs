using System;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label2.Text = "Digite um verbo regular terminado em ER:";
        }

        private void botao_Click(object sender, EventArgs e)
        {
            string verbo = textBox.Text.ToUpper();

            if (!verbo.EndsWith("ER"))
            {
                MessageBox.Show("Por favor, insira um verbo regular que termine em \"ER\".");
                return;
            }

            string radical = verbo.Substring(0, verbo.Length - 2).ToLower();

            string conjugacao = $"Conjugação do verbo \"{verbo}\" no presente:\n" +
                                $"Eu {radical}o\n" +
                                $"Tu {radical}es\n" +
                                $"Ele {radical}e\n" +
                                $"Ela {radical}e\n" +
                                $"Nós {radical}emos\n" +
                                $"Vós {radical}eis\n" +
                                $"Eles {radical}em\n" +
                                $"Elas {radical}em";

            MessageBox.Show(conjugacao);
        }
    }
}