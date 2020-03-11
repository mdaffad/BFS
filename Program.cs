using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
namespace src
{
    class Program
    {
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            
            Console.WriteLine("Done");
        }
    }
}