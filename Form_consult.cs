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
    public partial class Form_consult : Form
    {
        public Form_consult()
        {
            InitializeComponent();
        }

        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.form_main.Show();
            this.Hide();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            Program.form_menu.Show();
            this.Hide();
        }

        private void button7_MouseHover(object sender, EventArgs e)
        {
            button7.Image = Properties.Resources.back_m;
        }

        private void button7_MouseLeave(object sender, EventArgs e)
        {
            button7.Image = Properties.Resources.back;
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.Image = Properties.Resources.autocad_tasks_m;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.Image = Properties.Resources.autocad_tasks;
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            button3.Image = Properties.Resources.tm_tasks_m;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.Image = Properties.Resources.tm_tasks;
        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            button4.Image = Properties.Resources.okd_tasks_m;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.Image = Properties.Resources.okd_tasks;
        }

        private void button5_MouseHover(object sender, EventArgs e)
        {
            button5.Image = Properties.Resources.animation_tasks_m;
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            button5.Image = Properties.Resources.animation_tasks;
        }

        private void button6_MouseHover(object sender, EventArgs e)
        {
            button6.Image = Properties.Resources.psm_tasks_m;
        }

        private void button6_MouseLeave(object sender, EventArgs e)
        {
            button6.Image = Properties.Resources.psm_tasks;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Program.form_Consult_IKT.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Program.form_Consult_TM.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Program.form_Consult_OKD.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Program.form_Consult_KA.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Program.form_Consult_PSM.Show();
            this.Hide();
        }

        private void Form_consult_Load(object sender, EventArgs e)
        {

        }
    }
}
