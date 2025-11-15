using System;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        private string string1;

        public Form1()
        {
            InitializeComponent();
            label2.Text = "Digite a primeira string:";
        }

        private void botao_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(string1))
            {
                string1 = textBox.Text;
                label2.Text = "Digite a segunda string:";
                textBox.Clear();
                textBox.Focus();
            }
            else
            {
                string string2 = textBox.Text;
                bool resultado = PalindromasMutuas(string1, string2);
                MessageBox.Show(resultado 
                    ? $"As strings \"{string1}\" e \"{string2}\" são palíndromas mútuas." 
                    : $"As strings \"{string1}\" e \"{string2}\" não são palíndromas mútuas.");
                string1 = null;
                label2.Text = "Digite a primeira string:";
                textBox.Clear();
            }
        }

        private bool PalindromasMutuas(string str1, string str2)
        {
            char[] str2Array = str2.ToCharArray();
            Array.Reverse(str2Array);
            string str2Reversa = new string(str2Array);
            return str1 == str2Reversa;
        }
    }
}