using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
namespace Notepad
{
    public partial class Form1 : Form
    {
        //Quit qt = new Quit();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {



            this.Text = " Notepad , Areeba Fatima ";
            this.wordWrapToolStripMenuItem.Checked = false;
            this.textBox1.WordWrap = true;
            this.newToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            this.cutToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.X;
            this.copyToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.C;
            this.pasteToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.V;
            this.deleteToolStripMenuItem.ShortcutKeys = Keys.Delete;
            this.selectAllToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.A;
            this.findToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.F;
            this.replaceToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.R;
            this.dateTimeToolStripMenuItem.ShortcutKeys = Keys.F5;
            this.openToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            this.saveToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            this.textBox1.ScrollBars = ScrollBars.Vertical;
            // this.ShowIcon = false;
            this.WindowState = FormWindowState.Maximized;
            this.StartPosition = FormStartPosition.WindowsDefaultBounds;
            this.deleteToolStripMenuItem.Enabled = false;
            this.findToolStripMenuItem.Enabled = false;
            this.replaceToolStripMenuItem.Enabled = false;
            this.copyToolStripMenuItem.Enabled = false;
            this.pasteToolStripMenuItem.Enabled = false;
            this.cutToolStripMenuItem.Enabled = false;
            this.menuStrip1.BackColor = Color.White;
            this.textBox1.BorderStyle = BorderStyle.Fixed3D;
            this.label1.Text = "Type Your Text Here...";
            this.label1.ForeColor = Color.SteelBlue;
            this.label1.BackColor = Color.White;
            this.label1.TextAlign = ContentAlignment.MiddleCenter;
            this.newToolStripMenuItem.ForeColor = Color.Brown;
            this.openToolStripMenuItem.ForeColor = Color.Brown;
            this.saveToolStripMenuItem.ForeColor = Color.Brown;
            this.exitToolStripMenuItem.ForeColor = Color.Brown;
            this.cutToolStripMenuItem.ForeColor = Color.DeepPink;
            this.copyToolStripMenuItem.ForeColor = Color.DeepPink;
            this.pasteToolStripMenuItem.ForeColor = Color.DeepPink;
            this.deleteToolStripMenuItem.ForeColor = Color.DeepPink;
            this.findToolStripMenuItem.ForeColor = Color.DarkGoldenrod;
            this.replaceToolStripMenuItem.ForeColor = Color.DarkGoldenrod;
            this.selectAllToolStripMenuItem.ForeColor = Color.DarkBlue;
            this.dateTimeToolStripMenuItem.ForeColor = Color.DarkBlue;
            this.wordWrapToolStripMenuItem.ForeColor = Color.ForestGreen;
            this.fontToolStripMenuItem.ForeColor = Color.ForestGreen;
            this.fontWithColorToolStripMenuItem.ForeColor = Color.DarkMagenta;
            this.colorToolStripMenuItem.ForeColor = Color.DarkMagenta;
            this.regularToolStripMenuItem.ForeColor = Color.DarkMagenta;
            this.aboutToolStripMenuItem.ForeColor = Color.Orange;
            this.Hide();
            Startup stratup = new Startup();
            stratup.ShowDialog();
            this.Show();
        }
        public void Save()
        {
            string abc = saveFileDialog1.Filter = "Text Document(*.Text)|*.Text";
            DialogResult sdr = this.saveFileDialog1.ShowDialog();

            if (sdr == DialogResult.OK)
            {
                string a = saveFileDialog1.FileName;
                File.WriteAllText(a, this.textBox1.Text);
                //return true;
            }
            else
            {
                //return false;
            }

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {

            }
            else
            {
                DialogResult dr = MessageBox.Show("Do you want to save changes?", "Notepad", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    Save();
                }
                else if (dr == DialogResult.No)
                {
                    textBox1.Clear();
                }
                else if (dr == DialogResult.Cancel)
                {
                    return;
                }
            }
        }

        private void wordWrapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (wordWrapToolStripMenuItem.Checked == false)
            {
                this.wordWrapToolStripMenuItem.Checked = true;
                this.textBox1.WordWrap = true;
            }
            else if (wordWrapToolStripMenuItem.Checked == true)
            {
                this.wordWrapToolStripMenuItem.Checked = false;
                this.textBox1.WordWrap = false;
            }
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBox1.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBox1.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBox1.Paste();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBox1.Cut();
        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Find frm2 = new Find(this);
            frm2.ShowDialog();
        }

        private void replaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Replace frm3 = new Replace(this);
            frm3.ShowDialog();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBox1.Select();
        }

        private void regularToolStripMenuItem_Click(object sender, EventArgs e)
        {

            DialogResult dr = this.fontDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                this.textBox1.Font = this.fontDialog1.Font;
            }
            else
            {
            }
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {

            DialogResult dr = this.colorDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                this.textBox1.ForeColor = this.colorDialog1.Color;
            }
        }

        private void fontWithColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowColor = true;
            DialogResult dr = this.fontDialog1.ShowDialog();

            if (dr == DialogResult.OK)
            {
                this.textBox1.Font = this.fontDialog1.Font;
                this.textBox1.ForeColor = this.fontDialog1.Color;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.label1.Visible = false;
            if (textBox1.Text == "")
            {
                this.cutToolStripMenuItem.Enabled = false;
                this.copyToolStripMenuItem.Enabled = false;
                this.pasteToolStripMenuItem.Enabled = false;
                this.findToolStripMenuItem.Enabled = false;
                this.replaceToolStripMenuItem.Enabled = false;
                this.deleteToolStripMenuItem.Enabled = false;
            }
            else
            {
                this.cutToolStripMenuItem.Enabled = true;
                this.copyToolStripMenuItem.Enabled = true;
                this.pasteToolStripMenuItem.Enabled = true;
                this.findToolStripMenuItem.Enabled = true;
                this.replaceToolStripMenuItem.Enabled = true;
                this.deleteToolStripMenuItem.Enabled = true;
            }
        }

        private void dateTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = System.DateTime.Today.ToString();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string abc = openFileDialog1.Filter = "Text Document(*.Text)|*.Text";
            DialogResult dr = this.openFileDialog1.ShowDialog();

            if (dr == DialogResult.OK)
            {
                string a = openFileDialog1.FileName;
                this.textBox1.Text = File.ReadAllText(a);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Save();
        }

        //private DialogResult ApplicationExit()
        //{
        //    if (textBox1.Text == "")
        //    {
        //        Application.Exit();
        //    }
        //    else
        //    {
        //        //Quit qt = new Quit();
        //        //qt.ShowDialog();

        //        DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Notepad", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
        //        if (result == DialogResult.Yes)
        //        {
        //            return DialogResult.Yes;
        //        }
        //        else if (result == DialogResult.No)
        //        {
        //            return DialogResult.No;
        //        }
        //        else if (result == DialogResult.Cancel)
        //        {
        //            return DialogResult.Cancel;
        //        }

        //    }
        //    return DialogResult.Yes;
        //}

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {

            }
            else
            {
                Quit qt = new Quit();
                qt.ShowDialog();
                //        DialogResult dr = MessageBox.Show("Are you sure you want to exit", "Notepad", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                //        if (dr == DialogResult.Yes)
                //        {
                //            Application.Exit();
                //        }
                //        else if (dr == DialogResult.No)
                //        {
                //            Save();
                //        }
                //        else if (dr == DialogResult.Cancel)
                //        {
                //            return;
                //        }
            }
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (textBox1.Text == "")
            {

            }
            else
            {
                Quit qt = new Quit();
                qt.ShowDialog();
                //DialogResult dr = MessageBox.Show("Are you sure you want to exit", "Notepad", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                //if (dr == DialogResult.Yes)
                //{
                //    Application.Exit();
                //}
                //else if (dr == DialogResult.No)
                //{
                //    Save();
                //}
                //else if (dr == DialogResult.Cancel)
                //{
                //    return;
                //}
            }
            //if (ApplicationExit() == DialogResult.Cancel)
            //{
            //    e.Cancel = true;
            //}
            //if (Save() == false)
            //{
            //    e.Cancel = true;
            //}
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About ab = new About();
            ab.ShowDialog();
        }
    }
}
