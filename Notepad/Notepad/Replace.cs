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
    public partial class Replace : Form
    {
        Form1 frm;
       
        public Replace(Form1 f1)
            
        {
            frm = f1;
            InitializeComponent();
        }

        private void Replace_Load(object sender, EventArgs e)
        {
            this.label1.Text = "Find What : ";
            this.label2.Text = "Replace With :";
            this.button1.Text = "REPLACE";
            this.button2.Text = "CANCEL";
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.button1.Cursor = Cursors.Hand;
            this.button2.Cursor = Cursors.Hand;
            this.AcceptButton = button1;
           // this.ShowIcon = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.White;
            this.button1.BackColor = Color.SteelBlue;
            this.button1.ForeColor = Color.White;
            this.button2.BackColor = Color.SteelBlue;
            this.button2.ForeColor = Color.White;
            this.button1.FlatStyle = FlatStyle.Popup;
            this.button2.FlatStyle = FlatStyle.Popup;
            this.textBox1.BorderStyle = BorderStyle.Fixed3D;
            this.textBox2.BorderStyle = BorderStyle.Fixed3D;
            this.textBox1.Text = "Enter your string here.........";
            this.textBox1.ForeColor = Color.Gray;
            this.textBox2.Text = "Enter your string here.........";
            this.textBox2.ForeColor = Color.Gray;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a = frm.textBox1.Text.Replace(this.textBox1.Text, this.textBox2.Text);
            frm.textBox1.Text = a;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.textBox1.ForeColor = Color.Black;

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            this.textBox2.ForeColor = Color.Black;
        }
    }
}
