using System.Windows.Forms;

namespace WinRemoteDesktop
{
    /// <summary>
    /// 应用程序公共类
    /// </summary>
    static class Common
    {
        /// <summary>
        /// 数据文件路径
        /// </summary>
        public static string DataFilePath { get; } = Application.StartupPath + "\\FileConfig.json";
    }
}
