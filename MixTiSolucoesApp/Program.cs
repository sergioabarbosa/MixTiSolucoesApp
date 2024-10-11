using System;
using System.Windows.Forms;

namespace MixTiSolucoesApp
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain()); // Alterado para carregar o FormMain
        }
    }
}
