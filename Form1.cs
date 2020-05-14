using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kyrsovaya
{
    public partial class Form1 : Form
    {
        public System.ComponentModel.ComponentResourceManager resources;

        public Form1()
        {
            InitializeComponent();
            resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Выйти?", "Выход", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {            
            Program.form2.Show();
            this.Hide();
        }

        private void Button1_MouseHover(object sender, EventArgs e)
        {
            
            button1.Image = Properties.Resources.exit_m;

        }

        private void Button1_MouseLeave(object sender, EventArgs e)
        {            
            button1.Image = Properties.Resources.exit;
        }

        private void Button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.Image = Properties.Resources.next_m;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.Image = Properties.Resources.next;
        }
    }
}
