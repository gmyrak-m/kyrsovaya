using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kyrsovaya
{

    static class Program
    {
        public static Form_main form_main;
        public static Form_menu form_menu;
        public static Form_author form_author;
        public static Form_consult form_consult;

        public static Form_IKT form_ikt;
        public static Form_KA form_ka;
        public static Form_OKD form_okd;
        public static Form_PSM form_psm;
        public static Form_TM form_tm;

        public static Form_consult_IKT form_Consult_IKT;
        public static Form_consult_KA form_Consult_KA;
        public static Form_consult_OKD form_Consult_OKD;
        public static Form_consult_PSM form_Consult_PSM;
        public static Form_consult_TM form_Consult_TM;

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]

        static void Main()
        {             
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            form_main = new Form_main();

            form_menu = new Form_menu();
            form_author = new Form_author();
            form_consult = new Form_consult();

            form_ikt = new Form_IKT();
            form_ka = new Form_KA();
            form_okd = new Form_OKD();
            form_psm = new Form_PSM();
            form_tm = new Form_TM();

            form_Consult_IKT = new Form_consult_IKT();
            form_Consult_KA = new Form_consult_KA();
            form_Consult_OKD = new Form_consult_OKD();
            form_Consult_PSM = new Form_consult_PSM();
            form_Consult_TM = new Form_consult_TM();

            Application.Run(form_main);

        }
    }
}
