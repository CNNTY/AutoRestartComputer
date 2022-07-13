using Microsoft.VisualBasic;
using Microsoft.Win32;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace WinRemoteDesktop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            btnRestart.Enabled = true;
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(checkBox1, "如开机启动无法设置，请以管理员身份运行，或退出杀毒软件");
            toolTip.SetToolTip(btnRestart, "单击此处15秒后重启计算机");
            toolTip.SetToolTip(label5, "倒计时完成后15秒以后重启服务器");
            toolTip.SetToolTip(Btn_RemoteDesktop, "打开远程桌面");
            toolTip.SetToolTip(textBox1, "双击文本框选择文件夹路径");
            toolTip.SetToolTip(Btn_Delete, "单击开始删除指定路径空文件夹");
            toolTip.SetToolTip(Btn_Set, "使用自定义区域前请先设置,然后点击加载否则自定义按钮将不可用");
            toolTip.SetToolTip(groupBox4, "第一次使用自定义区域前请先设置,然后点击加载否则自定义按钮将不可用");
            toolTip.SetToolTip(chkBoxIe, "选中则所有自定义打开网页都以IE方式打开\n否则以系统默认浏览器打开\n默认以IE方式打开");
            toolTip.SetToolTip(checkBox3, "转换自定义按钮5~8的功能，默认5~8为打开文件,选中后5~8的功能为打开网页");

            CommandButtons = new Button[]
            {
                BtnCustom1,
                BtnCustom2,
                BtnCustom3,
                BtnCustom4,
                BtnCustom5,
                BtnCustom6,
                BtnCustom7,
                BtnCustom8,
            };
            // 窗口创建时自动加载自定义命令
            LoadCustomCommands();
        }

        #region 当前时间
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.lblDate.Text = DateTime.Now.Date.ToString("yyyy年MM月dd日");
            this.lbltime.Text = DateTime.Now.ToLongTimeString();
            switch (DateTime.Now.DayOfWeek.ToString())
            {
                case "Monday":
                    this.lblweek.Text = "星期一";
                    break;
                case "Tuesday":
                    this.lblweek.Text = "星期二";
                    break;
                case "Wednesday":
                    this.lblweek.Text = "星期三";
                    break;
                case "Thursday":
                    this.lblweek.Text = "星期四";
                    break;
                case "Friday":
                    this.lblweek.Text = "星期五";
                    break;
                case "Saturday":
                    this.lblweek.Text = "星期六";
                    break;
                case "Sunday":
                    this.lblweek.Text = "星期日";
                    break;
            }
        }
        #endregion

        private void timer()//时间计算的方法
        {
            DateTime Rest_time = GetThisWeekTuesday().Date; //获取重启的日期

            // label3.Text = Rest_time.ToString("yyy年MM月dd日");  //LBL标签显示下一次重启时间并格式化

            //倒计时计算            
            var t0 = Rest_time.AddHours(3);  //锁定时间为凌晨三点
                                             // Rest_time.Date.ToString("yyy年MM月dd日");            
            DateTime t1 = Convert.ToDateTime(t0);      //下一次重启的时间
            DateTime t2 = Convert.ToDateTime(DateTime.Now); //当前系统时间
            string day = Convert.ToString((t1 - t2).Days);
            string hour = Convert.ToString((t1 - t2).Hours);
            string min = Convert.ToString((t1 - t2).Minutes);
            string second = Convert.ToString((t1 - t2).Seconds);
            //this.label5.Text = "距离服务器重启还有" + day + "天" + hour + "小时" + min + "分" + second + "秒";
            long count = DateAndTime.DateDiff(DateInterval.Second, t2, t1, FirstDayOfWeek.Tuesday, FirstWeekOfYear.FirstFourDays);
            if (count > 0|| count==0)
            {
                this.label5.Text = "距离服务器重启还有" + count + "秒" + "→" + day + "天" + hour + "小时" + min + "分" + second + "秒";

            }
            else if (count == 0)
            {
                //测试显示this.label5.Text = "计算错误的" + count + "秒" + "\n" + day + "天" + hour + "小时" + min + "分" + second + "秒";

                Process.Start("shutdown.exe", "-r -t 10");
                //MessageBox.Show("系统将重启");
            }
            this.label3.Text = t1.ToString("yyy年MM月dd日 HH:mm:ss");        //LBL标签显示下一次重启时间
            string status = ReadSetting("Auto_reboot", "");
            if (status.Length < 3)
            {
                tssl1.Text = "当前状态未设置开机启动";    // 读取注册表， 检查是否注册

            }
            else
            {
                tssl1.Text = "当前已设置开机启动," + "程序路径：" + status;
                checkBox1.Checked = true;
            }
        }
        #region 重启按钮
        /// <summary>
        /// 重启按钮 
        /// </summary>
        /// <param name="sender">调用cmd重启计算机</param>
        /// <param name="e">时间为10秒钟后重启计算机</param>
        private void btnRestart_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("这里替换为关机命令","提示信息");
            Process.Start("shutdown.exe", "-r -t 15");
        }
        #endregion
        /// <summary>
        /// 获取本周以及下周的指定时间
        /// </summary>
        /// <returns></returns>
        public static DateTime GetThisWeekTuesday()
        {
            DateTime date = DateTime.Now;
            DateTime firstDate = date;
            switch (date.DayOfWeek)
            {
                case System.DayOfWeek.Monday:
                    firstDate = date.AddDays(1);
                    break;
                case System.DayOfWeek.Tuesday:
                    firstDate = date.AddDays(0);
                    break;
                case System.DayOfWeek.Wednesday:
                    firstDate = date.AddDays(-1);
                    break;
                case System.DayOfWeek.Thursday:
                    firstDate = date.AddDays(-2);
                    break;
                case System.DayOfWeek.Friday:
                    firstDate = date.AddDays(-3);
                    break;
                case System.DayOfWeek.Saturday:
                    firstDate = date.AddDays(-4);
                    break;
                case System.DayOfWeek.Sunday:
                    firstDate = date.AddDays(-5);
                    break;
            }
            if (date.Hour >= 3 && firstDate.Day < date.Day|| date.Hour >= 3 && firstDate.Day == date.Day)
            {
                date = firstDate.AddDays(7);

                switch (date.DayOfWeek)
                {
                    case System.DayOfWeek.Monday:
                        firstDate = date.AddDays(1);

                        break;
                    case System.DayOfWeek.Tuesday:
                        firstDate = date.AddDays(0);
                        break;
                    case System.DayOfWeek.Wednesday:
                        firstDate = date.AddDays(-1);
                        break;
                    case System.DayOfWeek.Thursday:
                        firstDate = date.AddDays(-2);
                        break;
                    case System.DayOfWeek.Friday:
                        firstDate = date.AddDays(-3);
                        break;
                    case System.DayOfWeek.Saturday:
                        firstDate = date.AddDays(-4);
                        break;
                    case System.DayOfWeek.Sunday:
                        firstDate = date.AddDays(-5);
                        break;
                }
            }
            return firstDate;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            try
            {
                if (checkBox1.Checked==true) //设置开机自启动  
                {
                    //MessageBox.Show("设置开机自启动，需要修改注册表,\n如设置不成功请以管理员身份运行", "提示信息");  // hovertree.com
                    string path = Application.ExecutablePath;
                    RegistryKey rk = Registry.LocalMachine;
                    RegistryKey rk2 = rk.CreateSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run");
                    rk2.SetValue("Auto_reboot", path);
                    rk2.Close();
                    rk.Close();
                }
                else //取消开机自启动  
                {
                    //MessageBox.Show("取消开机自启动，需要修改注册表,\n如设置不成功请以管理员身份运行", "提示信息");
                    string path = Application.ExecutablePath;
                    RegistryKey rk = Registry.LocalMachine;
                    RegistryKey rk2 = rk.CreateSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run");
                    rk2.DeleteValue("Auto_reboot", false);
                    rk2.Close();
                    rk.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static string ReadSetting(string Key, string Default)
        {
            try
            {
                if (Default == null)
                {
                    Default = "-1";
                }
                RegistryKey key1 = Registry.LocalMachine.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run");
                if (key1 != null)
                {
                    object obj1 = key1.GetValue(Key, Default);
                    key1.Close();
                    if (obj1 != null)
                    {
                        if (!(obj1 is string))
                        {
                            return "-1";
                        }
                        string obj2 = obj1.ToString();
                        return obj2;
                    }
                    return "-1";
                }


                return Default;
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void btn_web1_Click(object sender, EventArgs e)
        {
            OpenWeb.CommonIE("http://192.172.1.70:7000/sx");
        }

        private void btn_web2_Click(object sender, EventArgs e)
        {
            OpenWeb.CommonIE("about:blank");
        }



        private void Btn_start_Click(object sender, EventArgs e)
        {
            FormMain fm = new FormMain();
            if (fm != null && fm.Created)
            {
                fm.Focus();
                return;
            }
            fm = new FormMain();
            fm.ShowDialog();
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            // 还原窗口
            WindowState = FormWindowState.Normal;
            // 显示任务栏图标
            this.ShowInTaskbar = true;
        }

        private void TsMenu_Click(object sender, EventArgs e)
        {
            // 还原窗口
            WindowState = FormWindowState.Normal;
            // 显示任务栏图标
            this.ShowInTaskbar = true;
        }

        private void TsExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 最小化ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = true;
            this.notifyIcon1.ShowBalloonTip(30, "提示", "程序以最小化方式运行", ToolTipIcon.Info);
        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
            Dispose();
        }
        /// <summary>
        /// 窗体加载事件
        /// </summary>
        private string filename = null;
        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormClosing += Form1_FormClosing;
            filename = Application.StartupPath + "\\Config.ini";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                //是否取消close操作
                e.Cancel = true;
                this.WindowState = FormWindowState.Minimized;
            }
        }

        private void Btn_Stop_Click(object sender, EventArgs e)
        {
            timer2.Enabled = false;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer();
        }

        private void Btn_star_Click(object sender, EventArgs e)
        {
            timer2.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog f = new FolderBrowserDialog();

            if (f.ShowDialog() == DialogResult.OK)
            {
                String DirPath = f.SelectedPath;
                this.textBox1.Text = DirPath;//G:\新建文件夹
            }
        }


        private void textBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            FolderBrowserDialog f = new FolderBrowserDialog();
            if (f.ShowDialog() == DialogResult.OK)
            {
                String DirPath = f.SelectedPath;
                this.textBox1.Text = DirPath;//G:\新建文件夹
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            // 获取路径
            string str = textBox1.Text;
            str.Replace("\\", "/");
            if (str.Equals(""))
            {
                MessageBox.Show("路径不能为空！", "提示");
            }
            else if (str.Equals("Q:\\") || str.Equals("W:\\") || str.Equals("E:\\") || str.Equals("R:\\") || str.Equals("T:\\") || str.Equals("Y:\\") || str.Equals("U:\\") || str.Equals("I:\\") || str.Equals("O:\\") || str.Equals("P:\\") || str.Equals("A:\\") || str.Equals("S:\\") || str.Equals("D:\\") || str.Equals("G:\\") || str.Equals("H:\\") || str.Equals("J:\\") || str.Equals("K:\\") || str.Equals("L:\\") || str.Equals("Z:\\") || str.Equals("X:\\") || str.Equals("C:\\") || str.Equals("C:\\") || str.Equals("V:\\") || str.Equals("B:\\") || str.Equals("N:\\") || str.Equals("M:\\"))
            {
                MessageBox.Show("路径不能为盘符！", "提示");
            }
            else
            {
                getPath(str);
            }
        }


        static List<string> list = new List<string>();//定义list变量
        public List<string> getPath(string path)
        {
            // 获取子目录
            DirectoryInfo dir = new DirectoryInfo(path);
            FileInfo[] fil = dir.GetFiles();
            DirectoryInfo[] dii = dir.GetDirectories();
            foreach (FileInfo f in fil)
            {
                list.Add(f.FullName);//添加文件的路径到列表
            }
            //获取子文件夹内的文件列表，递归遍历
            foreach (DirectoryInfo d in dii)
            {
                getPath(d.FullName);
                list.Add(d.FullName);//添加文件夹的路径到列表
            }

            // 删除空目录
            /// 删除掉空文件夹
            /// 所有没有子“文件系统”的都将被删除
            DirectoryInfo[] subdirs = dir.GetDirectories("*.*", SearchOption.AllDirectories);
            foreach (DirectoryInfo subdir in subdirs)
            {
                FileSystemInfo[] subFiles = subdir.GetFileSystemInfos();
                if (subFiles.Count() == 0)
                {
                    subdir.Delete();
                   // File.AppendAllText(Application.StartupPath + "\\" + "log.txt",DateTime.Now+"  " + path + "\\" + subdir);
                    File.AppendAllText(Application.StartupPath + "\\" + "删除目录日志记录.txt", string.Format("{0}{1}", DateTime.Now + " 删除  " + path + "\\" + subdir, Environment.NewLine));
                }
                
                //(path +"\\"+ subdir);
            }
            
            return list;           
        }

        #region = 自定义命令 =

        /// <summary>
        /// 自定义命令列表
        /// </summary>
        CustomCommand[] CustomCommands;

        /// <summary>
        /// 命令按钮列表
        /// </summary>
        Button[] CommandButtons;

        private void CustomCommandButton_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;
            var command = btn.Tag as CustomCommand;
            if (command == null) return;

            var url = command.Url;
            if (chkBoxIe.Checked == true)
                OpenWeb.CommonIE(url);
            else
                OpenWeb.Common(url);
            // TODO(url)
        }

        /// <summary>
        /// 加载自定义命令
        /// </summary>
        private void LoadCustomCommands()
        {
            try
            {
                if (File.Exists(Common.DataFilePath))
                {
                    CustomCommands = JsonConvert.DeserializeObject<CustomCommand[]>(File.ReadAllText(Common.DataFilePath));
                }
                else
                {
                    CustomCommands = new CustomCommand[8];
                }
                ShowCustomCommands();
            }
            catch (Exception ex)
            {
                MessageBox.Show("初始化自定义命令失败！" + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void ShowCustomCommands()
        {
            for (int i = 0; i < CustomCommands.Length; i++)
            {
                if (CustomCommands[i] != null)
                {
                    CommandButtons[i].Text = CustomCommands[i].Name;
                    CommandButtons[i].Tag = CustomCommands[i];
                }
            }
        }

        private void Btn_Set_Click(object sender, EventArgs e)
        {
            FormCustomCommand cuset = new FormCustomCommand(CustomCommands);
            if (cuset.ShowDialog() == DialogResult.OK)
            {
                // 设置成功重新载入
                ShowCustomCommands();
            }
        }

        #endregion = 自定义命令 =


    }
}
