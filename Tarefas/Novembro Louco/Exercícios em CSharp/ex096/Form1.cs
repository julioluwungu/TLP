using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "Editor de Texto com Cores";
            label2.Text = "Digite um texto com /*comentários*/:";
        }

        private void botao_Click(object sender, EventArgs e)
        {
            string texto = textBox.Text;
            
            if (string.IsNullOrEmpty(texto))
            {
                MessageBox.Show("Por favor, digite algum texto!", "Aviso", 
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MostrarTextoColorido(texto);
        }

        private void MostrarTextoColorido(string texto)
        {
            Form resultadoForm = new Form();
            resultadoForm.Text = "Texto Formatado";
            resultadoForm.Size = new Size(400, 300);
            resultadoForm.StartPosition = FormStartPosition.CenterScreen;

            RichTextBox richTextBox = new RichTextBox();
            richTextBox.Dock = DockStyle.Fill;
            richTextBox.ReadOnly = true;
            resultadoForm.Controls.Add(richTextBox);

            bool dentroDoComentario = false;
            string textoComentario = "";
            string textoSemComentario = "";

            for (int i = 0; i < texto.Length; i++)
            {
                if (i < texto.Length - 1 && texto[i] == '/' && texto[i + 1] == '*' && !dentroDoComentario)
                {
                    dentroDoComentario = true;
                    richTextBox.AppendText(textoSemComentario);
                    textoSemComentario = "";
                    textoComentario += "/*";
                    i++;
                }
                else if (i < texto.Length - 1 && texto[i] == '*' && texto[i + 1] == '/' && dentroDoComentario)
                {
                    dentroDoComentario = false;
                    textoComentario += "*/";
                    
                    richTextBox.SelectionStart = richTextBox.TextLength;
                    richTextBox.SelectionLength = 0;
                    richTextBox.SelectionColor = Color.Red;
                    richTextBox.AppendText(textoComentario);
                    richTextBox.SelectionColor = richTextBox.ForeColor;
                    
                    textoComentario = "";
                    i++;
                }
                else if (dentroDoComentario)
                {
                    textoComentario += texto[i];
                }
                else
                {
                    textoSemComentario += texto[i];
                }
            }

            if (!string.IsNullOrEmpty(textoSemComentario))
            {
                richTextBox.AppendText(textoSemComentario);
            }
            if (!string.IsNullOrEmpty(textoComentario))
            {
                richTextBox.SelectionStart = richTextBox.TextLength;
                richTextBox.SelectionLength = 0;
                richTextBox.SelectionColor = Color.Red;
                richTextBox.AppendText(textoComentario);
            }

            resultadoForm.ShowDialog();
        }

        private void label1_TextChanged(object sender, EventArgs e) { }
        private void label2_TextChanged(object sender, EventArgs e) { }
    }
}