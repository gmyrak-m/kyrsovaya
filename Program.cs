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


            Application.Run(form1);
        }
    }
}
