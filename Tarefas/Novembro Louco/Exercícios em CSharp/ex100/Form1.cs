using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void botao_Click(object sender, EventArgs e)
        {
            string textoOriginal = richTextBox1.Text;
            string textoSemEspacos = textoOriginal.Replace(" ", "");
            MessageBox.Show(textoSemEspacos, "Texto sem Espaços");
        }
    }
}