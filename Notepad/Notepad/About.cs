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
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }
        Form1 frm = new Form1();
        private void About_Load(object sender, EventArgs e)
        {
            this.Text = "Notepad";
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            frm.Enabled = false;
            this.button1.Cursor = Cursors.Hand;
            this.button1.Text = "OK";
            this.label1.Text = "All rights reserved by Areeba Fatima.";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.button1.FlatStyle = FlatStyle.Popup;
            this.BackColor = Color.White;
            this.button1.BackColor = Color.SteelBlue;
            this.button1.ForeColor = Color.White;
            pictureBox1.Image = Properties.Resources.About_2;
            pictureBox1.BackColor = Color.White;
   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
