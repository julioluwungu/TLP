using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox3.Text) && int.TryParse(textBox3.Text, out int numero))
            {
                if (numero % 2 != 0)
                {
                    MessageBox.Show("Digite apenas números pares.");
                    textBox3.Clear();
                }
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar))
            {
                string vogais = "aeiouAEIOUáéíóúÁÉÍÓÚàèìòùÀÈÌÒÙãõÃÕâêîôûÂÊÎÔÛ";
                if (!vogais.Contains(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox5.Text) && int.TryParse(textBox5.Text, out int numero))
            {
                if (!EhPrimo(numero) || numero < 2)
                {
                    MessageBox.Show("Digite apenas números primos (2, 3, 5, 7, 11, 13, 17, 19, 23, ...).");
                    textBox5.Clear();
                }
            }
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox6.Text))
            {
                List<string> valoresPermitidos = new List<string> { "1", "2", "3", "4", "5" };
                if (!valoresPermitidos.Contains(textBox6.Text))
                {
                    MessageBox.Show("Digite apenas valores da lista: 1, 2, 3, 4, 5");
                    textBox6.Clear();
                }
            }
        }

        private bool EhPrimo(int numero)
        {
            if (numero < 2) return false;
            if (numero == 2) return true;
            if (numero % 2 == 0) return false;

            for (int i = 3; i <= Math.Sqrt(numero); i += 2)
            {
                if (numero % i == 0)
                    return false;
            }
            return true;
        }
    }
}