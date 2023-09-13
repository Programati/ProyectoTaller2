using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoTaller2
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

            formLogin mylogin = new formLogin();
           // mylogin.Show(); Descomentar esto cuando quiera poner el login

           FormMainMenu menu = new FormMainMenu(); //Borrar estas lineas cuando
            menu.Show();                           //quiera volver a poner el login 
            Application.Run();
            
        }
    }
}
