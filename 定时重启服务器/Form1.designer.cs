namespace WinRemoteDesktop
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblweek = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbltime = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRestart = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssl1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.Btn_RemoteDesktop = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.远程桌面ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.最小化ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.TsExit = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.Btn_Exit = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Btn_Set = new System.Windows.Forms.Button();
            this.BtnCustom8 = new System.Windows.Forms.Button();
            this.BtnCustom4 = new System.Windows.Forms.Button();
            this.BtnCustom7 = new System.Windows.Forms.Button();
            this.BtnCustom6 = new System.Windows.Forms.Button();
            this.BtnCustom3 = new System.Windows.Forms.Button();
            this.BtnCustom5 = new System.Windows.Forms.Button();
            this.BtnCustom2 = new System.Windows.Forms.Button();
            this.BtnCustom1 = new System.Windows.Forms.Button();
            this.Btn_Stop = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.Btn_star = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Btn_Delete = new System.Windows.Forms.Button();
            this.chkBoxIe = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblweek
            // 
            this.lblweek.BackColor = System.Drawing.Color.Transparent;
            this.lblweek.Font = new System.Drawing.Font("宋体", 12.75F, System.Drawing.FontStyle.Bold);
            this.lblweek.ForeColor = System.Drawing.Color.Red;
            this.lblweek.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblweek.Location = new System.Drawing.Point(353, 19);
            this.lblweek.Name = "lblweek";
            this.lblweek.Size = new System.Drawing.Size(68, 23);
            this.lblweek.TabIndex = 2;
            this.lblweek.Text = "星期四";
            this.lblweek.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblweek.UseMnemonic = false;
            // 
            // lblDate
            // 
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Font = new System.Drawing.Font("宋体", 12.75F, System.Drawing.FontStyle.Bold);
            this.lblDate.ForeColor = System.Drawing.Color.Red;
            this.lblDate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblDate.Location = new System.Drawing.Point(73, 19);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(156, 23);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "2021年4月28";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDate.UseMnemonic = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("华文行楷", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(116, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(314, 34);
            this.label2.TabIndex = 0;
            this.label2.Text = "每周二凌晨三点重启服务器";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbltime);
            this.groupBox1.Controls.Add(this.lblDate);
            this.groupBox1.Controls.Add(this.lblweek);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 10F);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox1.Location = new System.Drawing.Point(27, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(488, 56);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "当前时间";
            // 
            // lbltime
            // 
            this.lbltime.BackColor = System.Drawing.Color.Transparent;
            this.lbltime.Font = new System.Drawing.Font("宋体", 12.75F, System.Drawing.FontStyle.Bold);
            this.lbltime.ForeColor = System.Drawing.Color.Red;
            this.lbltime.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbltime.Location = new System.Drawing.Point(235, 19);
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(112, 23);
            this.lbltime.TabIndex = 1;
            this.lbltime.Text = "13:55:55";
            this.lbltime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbltime.UseMnemonic = false;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("宋体", 12.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(99, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(248, 34);
            this.label3.TabIndex = 0;
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.UseMnemonic = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnRestart);
            this.groupBox2.Font = new System.Drawing.Font("宋体", 10F);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox2.Location = new System.Drawing.Point(27, 108);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(488, 56);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "重启时间";
            // 
            // btnRestart
            // 
            this.btnRestart.Location = new System.Drawing.Point(389, 14);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(93, 34);
            this.btnRestart.TabIndex = 1;
            this.btnRestart.Text = "立即重启(&R)";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Font = new System.Drawing.Font("宋体", 10F);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox3.Location = new System.Drawing.Point(27, 168);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(488, 69);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "重启倒计时";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("宋体", 12.75F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(9, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(473, 49);
            this.label5.TabIndex = 0;
            this.label5.Text = "1";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.UseMnemonic = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.checkBox1.Location = new System.Drawing.Point(436, 20);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(90, 16);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "开机启动(&C)";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.tssl1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 425);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(524, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(68, 17);
            this.toolStripStatusLabel1.Text = "作者：冰封";
            // 
            // tssl1
            // 
            this.tssl1.Name = "tssl1";
            this.tssl1.Size = new System.Drawing.Size(441, 17);
            this.tssl1.Spring = true;
            this.tssl1.Text = "状态显示";
            this.tssl1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Btn_RemoteDesktop
            // 
            this.Btn_RemoteDesktop.BackColor = System.Drawing.SystemColors.Highlight;
            this.Btn_RemoteDesktop.Location = new System.Drawing.Point(27, 357);
            this.Btn_RemoteDesktop.Name = "Btn_RemoteDesktop";
            this.Btn_RemoteDesktop.Size = new System.Drawing.Size(86, 36);
            this.Btn_RemoteDesktop.TabIndex = 2;
            this.Btn_RemoteDesktop.Text = "远程桌面(&D)";
            this.Btn_RemoteDesktop.UseVisualStyleBackColor = false;
            this.Btn_RemoteDesktop.Click += new System.EventHandler(this.Btn_start_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.远程桌面ToolStripMenuItem,
            this.最小化ToolStripMenuItem,
            this.TsMenu,
            this.TsExit});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(125, 92);
            // 
            // 远程桌面ToolStripMenuItem
            // 
            this.远程桌面ToolStripMenuItem.Name = "远程桌面ToolStripMenuItem";
            this.远程桌面ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.远程桌面ToolStripMenuItem.Text = "远程桌面";
            this.远程桌面ToolStripMenuItem.Click += new System.EventHandler(this.Btn_start_Click);
            // 
            // 最小化ToolStripMenuItem
            // 
            this.最小化ToolStripMenuItem.Name = "最小化ToolStripMenuItem";
            this.最小化ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.最小化ToolStripMenuItem.Text = "最小化";
            this.最小化ToolStripMenuItem.Click += new System.EventHandler(this.最小化ToolStripMenuItem_Click);
            // 
            // TsMenu
            // 
            this.TsMenu.Name = "TsMenu";
            this.TsMenu.Size = new System.Drawing.Size(124, 22);
            this.TsMenu.Text = "显示";
            this.TsMenu.Click += new System.EventHandler(this.TsMenu_Click);
            // 
            // TsExit
            // 
            this.TsExit.Name = "TsExit";
            this.TsExit.Size = new System.Drawing.Size(124, 22);
            this.TsExit.Text = "退出";
            this.TsExit.Click += new System.EventHandler(this.TsExit_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "自动重启工具";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            // 
            // Btn_Exit
            // 
            this.Btn_Exit.Location = new System.Drawing.Point(446, 357);
            this.Btn_Exit.Name = "Btn_Exit";
            this.Btn_Exit.Size = new System.Drawing.Size(69, 36);
            this.Btn_Exit.TabIndex = 2;
            this.Btn_Exit.Text = "退出(&Q)";
            this.Btn_Exit.UseVisualStyleBackColor = true;
            this.Btn_Exit.Click += new System.EventHandler(this.Btn_Exit_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.Btn_Set);
            this.groupBox4.Controls.Add(this.BtnCustom8);
            this.groupBox4.Controls.Add(this.BtnCustom4);
            this.groupBox4.Controls.Add(this.BtnCustom7);
            this.groupBox4.Controls.Add(this.BtnCustom6);
            this.groupBox4.Controls.Add(this.BtnCustom3);
            this.groupBox4.Controls.Add(this.BtnCustom5);
            this.groupBox4.Controls.Add(this.BtnCustom2);
            this.groupBox4.Controls.Add(this.BtnCustom1);
            this.groupBox4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox4.Location = new System.Drawing.Point(27, 252);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(488, 100);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "自定义区域";
            // 
            // Btn_Set
            // 
            this.Btn_Set.Location = new System.Drawing.Point(436, 24);
            this.Btn_Set.Name = "Btn_Set";
            this.Btn_Set.Size = new System.Drawing.Size(46, 30);
            this.Btn_Set.TabIndex = 4;
            this.Btn_Set.Text = "设置";
            this.Btn_Set.UseVisualStyleBackColor = true;
            this.Btn_Set.Click += new System.EventHandler(this.Btn_Set_Click);
            // 
            // BtnCustom8
            // 
            this.BtnCustom8.Location = new System.Drawing.Point(330, 58);
            this.BtnCustom8.Name = "BtnCustom8";
            this.BtnCustom8.Size = new System.Drawing.Size(100, 30);
            this.BtnCustom8.TabIndex = 3;
            this.BtnCustom8.Text = "button8";
            this.BtnCustom8.UseVisualStyleBackColor = true;
            this.BtnCustom8.Click += new System.EventHandler(this.CustomCommandButton_Click);
            // 
            // BtnCustom4
            // 
            this.BtnCustom4.Location = new System.Drawing.Point(330, 24);
            this.BtnCustom4.Name = "BtnCustom4";
            this.BtnCustom4.Size = new System.Drawing.Size(100, 30);
            this.BtnCustom4.TabIndex = 3;
            this.BtnCustom4.Text = "button4";
            this.BtnCustom4.UseVisualStyleBackColor = true;
            this.BtnCustom4.Click += new System.EventHandler(this.CustomCommandButton_Click);
            // 
            // BtnCustom7
            // 
            this.BtnCustom7.Location = new System.Drawing.Point(224, 58);
            this.BtnCustom7.Name = "BtnCustom7";
            this.BtnCustom7.Size = new System.Drawing.Size(100, 30);
            this.BtnCustom7.TabIndex = 2;
            this.BtnCustom7.Text = "button7";
            this.BtnCustom7.UseVisualStyleBackColor = true;
            this.BtnCustom7.Click += new System.EventHandler(this.CustomCommandButton_Click);
            // 
            // BtnCustom6
            // 
            this.BtnCustom6.Location = new System.Drawing.Point(118, 58);
            this.BtnCustom6.Name = "BtnCustom6";
            this.BtnCustom6.Size = new System.Drawing.Size(100, 30);
            this.BtnCustom6.TabIndex = 1;
            this.BtnCustom6.Text = "button6";
            this.BtnCustom6.UseVisualStyleBackColor = true;
            this.BtnCustom6.Click += new System.EventHandler(this.CustomCommandButton_Click);
            // 
            // BtnCustom3
            // 
            this.BtnCustom3.Location = new System.Drawing.Point(224, 24);
            this.BtnCustom3.Name = "BtnCustom3";
            this.BtnCustom3.Size = new System.Drawing.Size(100, 30);
            this.BtnCustom3.TabIndex = 2;
            this.BtnCustom3.Text = "button3";
            this.BtnCustom3.UseVisualStyleBackColor = true;
            this.BtnCustom3.Click += new System.EventHandler(this.CustomCommandButton_Click);
            // 
            // BtnCustom5
            // 
            this.BtnCustom5.Location = new System.Drawing.Point(12, 58);
            this.BtnCustom5.Name = "BtnCustom5";
            this.BtnCustom5.Size = new System.Drawing.Size(100, 30);
            this.BtnCustom5.TabIndex = 0;
            this.BtnCustom5.Text = "button5";
            this.BtnCustom5.UseVisualStyleBackColor = true;
            this.BtnCustom5.Click += new System.EventHandler(this.CustomCommandButton_Click);
            // 
            // BtnCustom2
            // 
            this.BtnCustom2.Location = new System.Drawing.Point(118, 24);
            this.BtnCustom2.Name = "BtnCustom2";
            this.BtnCustom2.Size = new System.Drawing.Size(100, 30);
            this.BtnCustom2.TabIndex = 1;
            this.BtnCustom2.Text = "button2";
            this.BtnCustom2.UseVisualStyleBackColor = true;
            this.BtnCustom2.Click += new System.EventHandler(this.CustomCommandButton_Click);
            // 
            // BtnCustom1
            // 
            this.BtnCustom1.Location = new System.Drawing.Point(12, 24);
            this.BtnCustom1.Name = "BtnCustom1";
            this.BtnCustom1.Size = new System.Drawing.Size(100, 30);
            this.BtnCustom1.TabIndex = 0;
            this.BtnCustom1.Text = "button1";
            this.BtnCustom1.UseVisualStyleBackColor = true;
            this.BtnCustom1.Click += new System.EventHandler(this.CustomCommandButton_Click);
            // 
            // Btn_Stop
            // 
            this.Btn_Stop.Location = new System.Drawing.Point(119, 357);
            this.Btn_Stop.Name = "Btn_Stop";
            this.Btn_Stop.Size = new System.Drawing.Size(70, 36);
            this.Btn_Stop.TabIndex = 2;
            this.Btn_Stop.Text = "取消计时";
            this.Btn_Stop.UseVisualStyleBackColor = true;
            this.Btn_Stop.Click += new System.EventHandler(this.Btn_Stop_Click);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Btn_star
            // 
            this.Btn_star.Location = new System.Drawing.Point(195, 357);
            this.Btn_star.Name = "Btn_star";
            this.Btn_star.Size = new System.Drawing.Size(70, 36);
            this.Btn_star.TabIndex = 2;
            this.Btn_star.Text = "重新计时";
            this.Btn_star.UseVisualStyleBackColor = true;
            this.Btn_star.Click += new System.EventHandler(this.Btn_star_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(27, 399);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(238, 21);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "d:\\vol\\vol1";
            this.textBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.textBox1_MouseDoubleClick);
            // 
            // Btn_Delete
            // 
            this.Btn_Delete.Location = new System.Drawing.Point(271, 397);
            this.Btn_Delete.Name = "Btn_Delete";
            this.Btn_Delete.Size = new System.Drawing.Size(70, 23);
            this.Btn_Delete.TabIndex = 8;
            this.Btn_Delete.Text = "删除空目录";
            this.Btn_Delete.UseVisualStyleBackColor = true;
            this.Btn_Delete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // chkBoxIe
            // 
            this.chkBoxIe.BackColor = System.Drawing.SystemColors.ControlLight;
            this.chkBoxIe.Checked = true;
            this.chkBoxIe.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBoxIe.ForeColor = System.Drawing.Color.Red;
            this.chkBoxIe.Location = new System.Drawing.Point(272, 359);
            this.chkBoxIe.Name = "chkBoxIe";
            this.chkBoxIe.Size = new System.Drawing.Size(79, 32);
            this.chkBoxIe.TabIndex = 9;
            this.chkBoxIe.Text = "是否为IE";
            this.chkBoxIe.UseVisualStyleBackColor = false;
            // 
            // checkBox3
            // 
            this.checkBox3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.checkBox3.Enabled = false;
            this.checkBox3.ForeColor = System.Drawing.Color.Red;
            this.checkBox3.Location = new System.Drawing.Point(357, 361);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(79, 32);
            this.checkBox3.TabIndex = 9;
            this.checkBox3.Text = "按钮5-8";
            this.checkBox3.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(355, 402);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 12);
            this.label1.TabIndex = 10;
            this.label1.Text = "按钮5~8功能懒得做，没用";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 447);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.chkBoxIe);
            this.Controls.Add(this.Btn_Delete);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Btn_Exit);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.Btn_star);
            this.Controls.Add(this.Btn_Stop);
            this.Controls.Add(this.Btn_RemoteDesktop);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "每周自动重启计算机";
            this.MinimumSizeChanged += new System.EventHandler(this.最小化ToolStripMenuItem_Click);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblweek;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Label lbltime;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel tssl1;
        private System.Windows.Forms.Button Btn_RemoteDesktop;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TsMenu;
        private System.Windows.Forms.ToolStripMenuItem TsExit;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ToolStripMenuItem 最小化ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 远程桌面ToolStripMenuItem;
        private System.Windows.Forms.Button Btn_Exit;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button Btn_Stop;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button Btn_star;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Btn_Delete;
        private System.Windows.Forms.Button BtnCustom8;
        private System.Windows.Forms.Button BtnCustom4;
        private System.Windows.Forms.Button BtnCustom7;
        private System.Windows.Forms.Button BtnCustom6;
        private System.Windows.Forms.Button BtnCustom3;
        private System.Windows.Forms.Button BtnCustom5;
        private System.Windows.Forms.Button BtnCustom2;
        private System.Windows.Forms.Button BtnCustom1;
        private System.Windows.Forms.Button Btn_Set;
        private System.Windows.Forms.CheckBox chkBoxIe;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Label label1;
    }
}

