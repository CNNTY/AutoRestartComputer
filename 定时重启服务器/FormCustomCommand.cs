using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using System.Windows.Forms;
using System.IO;
using System.Collections.ObjectModel;
using System.Runtime.InteropServices;
using System.Xml.Linq;
using System.Security.Policy;

namespace WinRemoteDesktop
{
    public partial class FormCustomCommand : Form
    {
        public CustomCommand[] Commands { get; }

        public FormCustomCommand(CustomCommand[] commands)
        {
            InitializeComponent();
            Commands = commands;
        }

        private void custom_Load(object sender, EventArgs e)
        {
            this.CmbButtons.Items.AddRange(new object[] {
            "==请选择要自定义的按钮==",
            "Button1",
            "Button2",
            "Button3",
            "Button4",
            "Button5",
            "Button6",
            "Button7",
            "Button8"
            });

            this.CmbButtons.SelectedIndex = 0;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (CmbButtons.SelectedIndex == 0)
            {
                MessageBox.Show("请选择要自定义的按钮", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(TxtButtonName.Text))
            {
                MessageBox.Show("请选择输入按钮名称", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // TODO 其他检测


            var command = new CustomCommand
            {
                Name = TxtButtonName.Text,
                Url = TxtUrl.Text,
                ExePath = TxtExePath.Text,
                Message = TxtMessage.Text
            };
            Commands[CmbButtons.SelectedIndex - 1] = command;
            File.WriteAllText(Common.DataFilePath, JsonConvert.SerializeObject(Commands));
            MessageBox.Show("OK", "提示");
            DialogResult = DialogResult.OK;
        }

        private void CmbButtons_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbButtons.SelectedIndex > 0)
            {
                var command = Commands[CmbButtons.SelectedIndex - 1];
                if (command != null)
                {
                    // 展示当前的参数
                    TxtButtonName.Text = command.Name;
                    TxtUrl.Text = command.Url;
                    TxtExePath.Text = command.ExePath;
                    TxtMessage.Text = command.Message;
                }
            }
        }
    }
}
