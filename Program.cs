using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Engenhos.Exercicio2
{
    static class Program
    {
        public static Lanterna Lant = new();
        public static Bateria bat = new();
        public static List<Bateria> Bats = new() { bat };
        public static bool OnOffBt = false;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Aplicativo());
        }
    }
}
