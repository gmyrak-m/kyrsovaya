using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kyrsovaya
{

    static class Program
    {
        public static Form1 form1;
        public static Form2 form2;
        public static Form3 form3;
        public static Form4 form4;

        public static Form_IKT form_ikt;
        public static Form_KA form_ka;
        public static Form_OKD form_okd;
        public static Form_PSM form_psm;
        public static Form_TM form_tm;

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]

        static void Main()
        {             
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            form1 = new Form1();
            form2 = new Form2();
            form3 = new Form3();
            form4 = new Form4();

            form_ikt = new Form_IKT();
            form_ka = new Form_KA();
            form_okd = new Form_OKD();
            form_psm = new Form_PSM();
            form_tm = new Form_TM();


            Application.Run(form1);
        }
    }
}
