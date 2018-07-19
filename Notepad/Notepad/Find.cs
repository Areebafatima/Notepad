using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notepad
{
    public partial class Find : Form
    {
        Form1 frm;
        public Find(Form1 f1)
        {
            frm = f1;
            InitializeComponent();
        }

        private void Find_Load(object sender, EventArgs e)
        {
            this.label1.Text = "Find What :";
            this.button1.Text = "FIND ";
            this.button2.Text = "CANCEL";
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.button1.Cursor = Cursors.Hand;
            this.button2.Cursor = Cursors.Hand;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.AcceptButton = button1;
            this.ShowIcon = false;
            this.button1.BackColor = Color.SteelBlue;
            this.button1.ForeColor = Color.White;
            this.button2.BackColor = Color.SteelBlue;
            this.button2.ForeColor = Color.White;
            this.BackColor = Color.White;
            this.textBox1.BorderStyle = BorderStyle.Fixed3D;
            this.textBox1.Text = "Enter your string here.........";
            this.textBox1.ForeColor = Color.Gray;
            this.button1.FlatStyle = FlatStyle.Popup;
            this.button2.FlatStyle = FlatStyle.Popup;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (frm.textBox1.Text.Contains(this.textBox1.Text))
            {
                MessageBox.Show(" String can found", "Notepad", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(" String cannot found","Notepad",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.textBox1.ForeColor = Color.Black;
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }
    }
}
