using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label2.Text = "Digite o seu nome completo:";
        }

        private void botao_Click(object sender, EventArgs e)
        {
            List<string> conectores = new List<string> { "e", "do", "da", "dos", "das", "de", "di", "du" };

            string nome = textBox.Text;
            string[] palavras = nome.Split(' ');

            List<string> iniciais = palavras
                .Where(palavra => !conectores.Contains(palavra.ToLower()))
                .Select(palavra => palavra[0].ToString().ToUpper())
                .ToList();

            MessageBox.Show($"As iniciais são: {string.Join(", ", iniciais)}");
        }
    }
}