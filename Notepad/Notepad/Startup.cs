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
    public partial class Startup : Form
    {
        public Startup()
        {
            InitializeComponent();
        }

        private void Startup_Load(object sender, EventArgs e)
        {
            this.label1.Text = "Welcome To My Notepad";
            this.BackColor = Color.White; 
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.label1.BackColor = Color.White;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.label1.ForeColor = Color.SteelBlue;
            this.label1.BackColor = Color.White;
            this.label2.Text = "Made by Areeba Fatima";
            this.label2.BackColor = Color.White;
            this.button1.Text = "OPEN";
            this.button2.Text = "CLOSE";
            this.button1.ForeColor = Color.White;
            this.button1.BackColor = Color.SteelBlue;
            this.button2.ForeColor = Color.White;
            this.button2.BackColor = Color.SteelBlue;
            this.button1.FlatStyle = FlatStyle.Popup;
            this.button2.FlatStyle = FlatStyle.Popup;
            this.button1.Cursor = Cursors.Hand;
            this.button2.Cursor = Cursors.Hand;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
