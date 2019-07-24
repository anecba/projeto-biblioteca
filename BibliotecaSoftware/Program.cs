using BibliotecaSoftware.View;
using System;
using System.Windows.Forms;

namespace BibliotecaSoftware
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TelaBibliotecaDev());
            //Application.Run(new TelaBibliotecaPrincipal());
        }
    }
}