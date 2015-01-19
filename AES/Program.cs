using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using AES;
using System.Runtime.InteropServices;

namespace AES
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        //[STAThread]
        //[DllImport("C:/Users/Damian/Documents/Visual Studio 2013/Projects/AES/Debug/JacobiASM.dll")]
        //public static extern int Jac(int size, double [,] tab); 

        //public static extern int Jac(int size, double[,] tab, double[] ans, int k);

        //[DllImport("C:/Users/Damian/Documents/Visual Studio 2013/Projects/ASM/Debug/ASM.dll")]
        //public static extern int Dodaj(int a, int b);

        //[DllImport("C:/Users/Damian/Documents/Visual Studio 2013/Projects/ASM/Debug/ASM.dll")]
        //public static extern int Dodaj(int size, double[,] tab, double[] ans, int k);

        //[DllImport("C:/Users/Damian/Documents/Visual Studio 2013/Projects/ASM/Debug/ASM.dll")]
        //public static extern int Testowa2(byte k);
        static void Main()
        {


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
