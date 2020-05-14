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
    public partial class Form_PSM : Form
    {
        public Form_PSM()
        {
            InitializeComponent();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            Program.form2.Show();
            this.Hide();

        }

        private void Form_PSM_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
