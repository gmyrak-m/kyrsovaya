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
    public partial class Form_OKD : Form
    {
        public Form_OKD()
        {
            InitializeComponent();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            Program.form_menu.Show();
            this.Hide();

        }

        private void Form_OKD_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void button7_MouseHover(object sender, EventArgs e)
        {
            button7.Image = Properties.Resources.back_m;
        }

        private void button7_MouseLeave(object sender, EventArgs e)
        {
            button7.Image = Properties.Resources.back;
        }
    }
}
