﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Grid grid = new Grid(1); // Model of Grid

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(grid));
        }
    }
}
