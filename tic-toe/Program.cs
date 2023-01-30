using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tic_toe
{
    internal static class Program

    {
        public static ApplicationContext Context;
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Context = new ApplicationContext(new Form2()); // Form2 - название класса вашей первой формы
            Application.Run(Context);
        }
    }
}
