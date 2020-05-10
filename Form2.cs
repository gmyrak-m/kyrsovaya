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
    }
}
