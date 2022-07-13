using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using Microsoft.Win32;
using System.Windows.Forms;
using System.Diagnostics;

namespace WinRemoteDesktop
{
    public class OpenWeb
    {
        [DllImport("shell32.dll")]
        private static extern int ShellExecute(IntPtr hwnd, StringBuilder lpszOp, StringBuilder lpszFile, StringBuilder lpszParams, StringBuilder lpszDir, int FsShowCmd);
        public static void Common(string url) //电脑默认浏览器
        {
            ShellExecute(IntPtr.Zero, new StringBuilder("Open"), new StringBuilder(url), new StringBuilder(""), new StringBuilder(""), 1);
        }
        public static void CommonIE(string url) //指定IE浏览器
        {
            ShellExecute(IntPtr.Zero, new StringBuilder("Open"), new StringBuilder("IEXPLORE.exe"), new StringBuilder(url), new StringBuilder(""), 1);
        }
   

    }
}
