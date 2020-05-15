using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;


namespace kyrsovaya
{
    public partial class Form_menu : Form
    {
        public Form_menu()
        {
            InitializeComponent();
          
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Выйти?", "Выход", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {            
            Program.form_ikt.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                Program.form_author.Show();
                this.Hide();
            }
            else if (radioButton2.Checked)
            {
                Program.form_consult.Show();
                this.Hide();
            }
            else MessageBox.Show("Сделайте выбор");
            
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Button8_Click(object sender, EventArgs e)
        {
            Program.form_main.Show();
            this.Hide();

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Program.form_tm.Show();
            this.Hide();

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Program.form_okd.Show();
            this.Hide();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Program.form_ka.Show();
            this.Hide();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            Program.form_psm.Show();
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

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button8_MouseHover(object sender, EventArgs e)
        {
            button8.Image = Properties.Resources.back_m;
        }

        private void button8_MouseLeave(object sender, EventArgs e)
        {
            button8.Image = Properties.Resources.back;
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
    }
}
