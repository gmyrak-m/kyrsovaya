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
    public partial class Form_main : Form
    {
        public System.ComponentModel.ComponentResourceManager resources;

        public Form_main()
        {
            InitializeComponent();
            resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_main));
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
            Program.form_menu.Show();
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
