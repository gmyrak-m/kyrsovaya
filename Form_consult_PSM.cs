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
    public partial class Form_consult_PSM : Form
    {
        public Form_consult_PSM()
        {
            InitializeComponent();
        }

        private void Form_consult_PSM_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button7_MouseHover(object sender, EventArgs e)
        {
            button7.Image = Properties.Resources.back_m;
        }

        private void button7_MouseLeave(object sender, EventArgs e)
        {
            button7.Image = Properties.Resources.back;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Program.form_consult.Show();
            this.Hide();
        }
    }
}
