﻿using System;
using System.Runtime.InteropServices;

internal partial class Interop
{
    internal partial class User32
    {
        [DllImport(Libraries.User32, SetLastError = true)]
        internal static extern bool UnhookWindowsHookEx(IntPtr hhk);
    }
}
