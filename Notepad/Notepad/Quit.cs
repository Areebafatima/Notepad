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
    
    public partial class Quit : Form
    {
        public Quit()
        {
            InitializeComponent();
        }
        Form1 f1 = new Form1();
        
        private void Quit_Load(object sender, EventArgs e)
        {
            this.Text = "Notepad";
            this.button1.Text = "Save";
            this.button2.Text = "Don't Save";
            this.button3.Text = "Cancel";
            this.label1.Text = "Do you want to save changes ?";
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            f1.Enabled = false;
            this.button1.Cursor = Cursors.Hand;
            this.button2.Cursor = Cursors.Hand;
            this.button3.Cursor = Cursors.Hand;
            this.StartPosition = FormStartPosition.CenterScreen;
            pictureBox1.Image = Properties.Resources.New_Question_mark;
            this.BackColor = Color.White;
            pictureBox1.BackColor = Color.White;
            this.button1.FlatStyle = FlatStyle.Popup;
            this.button2.FlatStyle = FlatStyle.Popup;
            this.button3.FlatStyle = FlatStyle.Popup;
           this.button2.BackColor = Color.SteelBlue;
            this.button3.BackColor = Color.SteelBlue;
            this.button1.BackColor = Color.SteelBlue;
            this.button2.ForeColor = Color.White;
            this.button3.ForeColor = Color.White;
            this.button1.ForeColor = Color.White;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            f1.Save();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            f1.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            return;
        }
    }
}
