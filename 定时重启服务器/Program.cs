using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace WinRemoteDesktop
{
    static class Program
    {
        /// <summary>
        ///  设置窗口的显示状态
        ///  Win32 函数定义为：http://msdn.microsoft.com/en-us/library/windows/desktop/ms633548(v=vs.85).aspx
        /// </summary>
        /// <param name="hWnd">窗口句柄</param>
        /// <param name="cmdShow">指示窗口如何被显示</param>
        /// <returns>如果窗体之前是可见，返回值为非零；如果窗体之前被隐藏，返回值为零</returns>
        [DllImport("User32.dll")]
        private static extern bool ShowWindow(IntPtr hWnd, int cmdShow);
        /// <summary>
        ///  创建指定窗口的线程设置到前台，并且激活该窗口。键盘输入转向该窗口，并为用户改变各种可视的记号。
        ///  系统给创建前台窗口的线程分配的权限稍高于其他线程。
        /// </summary>
        /// <param name="hWnd">将被激活并被调入前台的窗口句柄</param>
        /// <returns>如果窗口设入了前台，返回值为非零；如果窗口未被设入前台，返回值为零</returns>
        [DllImport("User32.dll")]
        private static extern bool SetForegroundWindow(IntPtr hWnd);
        // 指示窗口为普通显示
        private const int WS_SHOWNORMAL = 1;

        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>       
        [STAThread]
        static void Main()
        {
            #region 调用Win32 API,并激活运行程序的窗口显示在最前端
            // 这种方式在VS调用的情况不成立的，因为在VS中按F5运行的进程为OnlyInstanceRunning.vshost,从这个进程的命名就可以看出，该进程为OnlyInstanceRunning进程的宿主进程
            // 关于这个进程的更多内容可以查看：http://msdn.microsoft.com/zh-cn/library/ms185331(v=vs.100).aspx
            // 而直接点OnlyInstanceRunning.exe运行的程序进程为OnlyInstanceRunning,
            // 但是我们可以一些小的修改，即currentProcess.ProcessName.Replace(".vshose","")此时无论如何都为 OnlyInstanceRunning
            // 获得正在运行的程序，如果没有相同的程序，则运行该程序
            Process process = RunningInstance();
            if (process == null)
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());
            }
            else
            {
                // 已经运行该程序，显示信息并使程序显示在前端

                HandleRunningInstance(process);
                //MessageBox.Show("该应用程序已经在运行中请勿重复启动......","提示信息",MessageBoxButtons.OK);
            }

            #endregion
        }
        #region 定义的方法
        /// <summary>
        /// 获取正在运行的程序，没有运行的程序则返回null
        /// </summary>
        /// <returns></returns>
        private static Process RunningInstance()
        {
            // 获取当前活动的进程
            Process currentProcess = Process.GetCurrentProcess();
            // 根据当前进程的进程名获得进程集合
            // 如果该程序运行，进程的数量大于1
            Process[] processcollection = Process.GetProcessesByName(currentProcess.ProcessName.Replace(".vshost", ".exe"));
            foreach (Process process in processcollection)
            {
                // 如果进程ID不等于当前运行进程的ID以及运行进程的文件路径等于当前进程的文件路径
                // 则说明同一个该程序已经运行了，此时将返回已经运行的进程
                if (process.Id != currentProcess.Id)
                {
                    if (Assembly.GetExecutingAssembly().Location.Replace("/", "\\") == process.MainModule.FileName)
                    {
                        return process;
                    }
                }
            }
            return null;
        }
        /// <summary>
        /// 显示已运行的程序
        /// </summary>
        /// <param name="instance"></param>
        private static void HandleRunningInstance(Process instance)
        {
            // 显示窗口
            ShowWindow(instance.MainWindowHandle, WS_SHOWNORMAL);
            // 把窗体放在前端
            SetForegroundWindow(instance.MainWindowHandle);
        }
        #endregion

    }
}
