using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmd_Enter.Enabled = false;
        }

        private void cmd_Enter_Click(object sender, EventArgs e)
        {
           if (!cmd_Enter.Enabled) return;
            MessageBox.Show("entrou!!");
        }

        private void text_textChanged(object sender, EventArgs e)
        {
            cmd_Enter.Enabled = text_textEmail.Text != "" && text_textSenha.Text != "" ? true : false;
        }

        private void text_textEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                text_textSenha.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;


            }
        }

        private void text_textSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmd_Enter_Click(this, EventArgs.Empty);
                e.Handled = true;
                e.SuppressKeyPress = true;


            }
        }
    }
}
