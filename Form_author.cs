﻿using System;
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
    public partial class Form_author : Form
    {
        public Form_author()
        {
            InitializeComponent();
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
