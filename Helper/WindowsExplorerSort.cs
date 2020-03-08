﻿using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace SystemTrayMenu.Helper
{
    class WindowsExplorerSort : IComparer<string>
    {
        [DllImport("shlwapi.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
        static extern int StrCmpLogicalW(String x, String y);

        public int Compare(string x, string y)
        {
            return StrCmpLogicalW(x, y);
        }
    }
}
