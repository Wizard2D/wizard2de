using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace WizardEngine2D.Ironclad
{
    public static class Ironclad
    {
        const string filePath = @"C:\Users\FURAGA\source\repos\WizardEngine2D\x64\Debug\Ironclad.dll";

        [DllImport(filePath, CharSet = CharSet.Unicode)]
        public static extern void test();
    }
}
