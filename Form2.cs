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
    public partial class Form2 : Form
    {
        public Form2()
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
                Program.form3.Show();
                this.Hide();
            }
            else if (radioButton2.Checked)
            {
                Program.form4.Show();
                this.Hide();
            }
            else MessageBox.Show("Сделайте выбор");
            
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Button8_Click(object sender, EventArgs e)
        {
            Program.form1.Show();
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
    }
}
