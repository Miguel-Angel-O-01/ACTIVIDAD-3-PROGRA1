using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MACusercontrol
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Mostrar SplashScreen primero
            Application.Run(new SplashScreen());

            // Luego ejecutar el formulario principal de login
            Application.Run(new Usercontrol());
        }
    }
}