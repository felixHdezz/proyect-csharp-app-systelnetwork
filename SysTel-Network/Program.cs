using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysTel_Network
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            View.Frm_splash _frm_splash = new View.Frm_splash();
            Controller.cls_splash _cls_con_spl = new Controller.cls_splash(_frm_splash);
            //View.Frm_principal _frm_prin = new View.Frm_principal();
            //Controller.cls_principal _cls_con = new Controller.cls_principal(_frm_prin);
            //View.Frm_principal _prin = new View.Frm_principal();
            //Controller.cls_principal _cont_pri = new Controller.cls_principal(_prin);
            Application.Run(_frm_splash);
        }
    }
}
