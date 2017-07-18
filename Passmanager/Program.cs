using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Frontend;
using System.Net;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using Backend.Core;
using Frontend.Forms;

namespace Passmanager
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            IController controller = new Controller();
            controller.Init();
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //FormMain frmMain = new FormMain(controller);
            Login frmLogin = new Login(controller);
            
            Application.Run(frmLogin);
           
        }
    }
}
