using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace TaskManager
{
    static class Program
    {
    
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
