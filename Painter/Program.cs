﻿using System;
using System.Windows.Forms;

namespace Painter
{
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new PainterForm());
        }
    }
}