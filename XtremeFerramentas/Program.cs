using System;
using System.Windows.Forms;

namespace XtremeFerramentas
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ContainerP containerPrincipal = new ContainerP();
            Application.Run(containerPrincipal);
                      
        }
    }
}
