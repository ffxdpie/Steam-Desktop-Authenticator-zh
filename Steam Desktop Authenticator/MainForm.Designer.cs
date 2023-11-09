namespace Steam_Desktop_Authenticator
{

    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnSteamLogin = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCopy = new System.Windows.Forms.Button();
            this.pbTimeout = new System.Windows.Forms.ProgressBar();
            this.txtLoginToken = new System.Windows.Forms.TextBox();
            this.plist = new System.Windows.Forms.ListBox();
            this.timerSteamGuard = new System.Windows.Forms.Timer(this.components);
            this.btnTradeConfirmations = new System.Windows.Forms.Button();
            this.btnManageEncryption = new System.Windows.Forms.Button();
            this.groupAccount = new System.Windows.Forms.GroupBox();
            this.labelVersion = new System.Windows.Forms.Label();
            this.labelUpdate = new System.Windows.Forms.LinkLabel();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuImportAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.menuQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLoginAgain = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.menuRemoveAccountFromManifest = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDeactivateAuthenticator = new System.Windows.Forms.ToolStripMenuItem();
            this.trayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.menuStripTray = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.trayRestore = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.trayAccountList = new System.Windows.Forms.ToolStripComboBox();
            this.trayTradeConfirmations = new System.Windows.Forms.ToolStripMenuItem();
            this.trayCopySteamGuard = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.trayQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.timerTradesPopup = new System.Windows.Forms.Timer(this.components);
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtAccSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.groupAccount.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.menuStripTray.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSteamLogin
            // 
            this.btnSteamLogin.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.btnSteamLogin.Location = new System.Drawing.Point(-1, 0);
            this.btnSteamLogin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSteamLogin.Name = "btnSteamLogin";
            this.btnSteamLogin.Size = new System.Drawing.Size(189, 66);
            this.btnSteamLogin.TabIndex = 1;
            this.btnSteamLogin.Text = "设置新账号";
            this.btnSteamLogin.UseVisualStyleBackColor = true;
            this.btnSteamLogin.Click += new System.EventHandler(this.btnSteamLogin_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtLoginToken);
            this.groupBox1.Controls.Add(this.btnCopy);
            this.groupBox1.Controls.Add(this.pbTimeout);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.groupBox1.Location = new System.Drawing.Point(16, 120);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(474, 89);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "登录令牌";
            // 
            // btnCopy
            // 
            this.btnCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopy.Location = new System.Drawing.Point(400, 20);
            this.btnCopy.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(66, 37);
            this.btnCopy.TabIndex = 2;
            this.btnCopy.Text = "复制";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // pbTimeout
            // 
            this.pbTimeout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbTimeout.Location = new System.Drawing.Point(7, 63);
            this.pbTimeout.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pbTimeout.Maximum = 30;
            this.pbTimeout.Name = "pbTimeout";
            this.pbTimeout.Size = new System.Drawing.Size(459, 20);
            this.pbTimeout.TabIndex = 1;
            this.pbTimeout.Value = 30;
            // 
            // txtLoginToken
            // 
            this.txtLoginToken.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLoginToken.BackColor = System.Drawing.SystemColors.Window;
            this.txtLoginToken.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLoginToken.Font = new System.Drawing.Font("微软雅黑", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoginToken.Location = new System.Drawing.Point(9, 20);
            this.txtLoginToken.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtLoginToken.Name = "txtLoginToken";
            this.txtLoginToken.ReadOnly = true;
            this.txtLoginToken.Size = new System.Drawing.Size(383, 43);
            this.txtLoginToken.TabIndex = 0;
            this.txtLoginToken.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // plist
            // 
            this.plist.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.plist.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plist.FormattingEnabled = true;
            this.plist.ItemHeight = 36;
            this.plist.Location = new System.Drawing.Point(15, 334);
            this.plist.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.plist.Name = "plist";
            this.plist.Size = new System.Drawing.Size(473, 364);
            this.plist.TabIndex = 3;
            this.plist.SelectedIndexChanged += new System.EventHandler(this.plist_SelectedIndexChanged);
            this.plist.SelectedValueChanged += new System.EventHandler(this.listAccounts_SelectedValueChanged);
            this.plist.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listAccounts_KeyDown);
            // 
            // timerSteamGuard
            // 
            this.timerSteamGuard.Enabled = true;
            this.timerSteamGuard.Interval = 1000;
            this.timerSteamGuard.Tick += new System.EventHandler(this.timerSteamGuard_Tick);
            // 
            // btnTradeConfirmations
            // 
            this.btnTradeConfirmations.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTradeConfirmations.Enabled = false;
            this.btnTradeConfirmations.Location = new System.Drawing.Point(8, 24);
            this.btnTradeConfirmations.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnTradeConfirmations.Name = "btnTradeConfirmations";
            this.btnTradeConfirmations.Size = new System.Drawing.Size(459, 68);
            this.btnTradeConfirmations.TabIndex = 4;
            this.btnTradeConfirmations.Text = "交易确认";
            this.btnTradeConfirmations.UseVisualStyleBackColor = true;
            this.btnTradeConfirmations.Click += new System.EventHandler(this.btnTradeConfirmations_Click);
            // 
            // btnManageEncryption
            // 
            this.btnManageEncryption.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnManageEncryption.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.btnManageEncryption.Location = new System.Drawing.Point(285, 0);
            this.btnManageEncryption.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnManageEncryption.Name = "btnManageEncryption";
            this.btnManageEncryption.Size = new System.Drawing.Size(189, 66);
            this.btnManageEncryption.TabIndex = 6;
            this.btnManageEncryption.Text = "管理加密";
            this.btnManageEncryption.UseVisualStyleBackColor = true;
            this.btnManageEncryption.Click += new System.EventHandler(this.btnManageEncryption_Click);
            // 
            // groupAccount
            // 
            this.groupAccount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupAccount.Controls.Add(this.btnTradeConfirmations);
            this.groupAccount.Location = new System.Drawing.Point(16, 230);
            this.groupAccount.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupAccount.Name = "groupAccount";
            this.groupAccount.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupAccount.Size = new System.Drawing.Size(474, 98);
            this.groupAccount.TabIndex = 7;
            this.groupAccount.TabStop = false;
            this.groupAccount.Text = "账号";
            this.groupAccount.Enter += new System.EventHandler(this.groupAccount_Enter);
            // 
            // labelVersion
            // 
            this.labelVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelVersion.BackColor = System.Drawing.Color.Transparent;
            this.labelVersion.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVersion.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelVersion.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.labelVersion.Location = new System.Drawing.Point(404, 750);
            this.labelVersion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(86, 16);
            this.labelVersion.TabIndex = 8;
            this.labelVersion.Text = "v0.0.0";
            this.labelVersion.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.labelVersion.Click += new System.EventHandler(this.labelVersion_Click);
            // 
            // labelUpdate
            // 
            this.labelUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelUpdate.BackColor = System.Drawing.Color.Transparent;
            this.labelUpdate.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUpdate.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelUpdate.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.labelUpdate.Location = new System.Drawing.Point(11, 738);
            this.labelUpdate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUpdate.Name = "labelUpdate";
            this.labelUpdate.Size = new System.Drawing.Size(98, 28);
            this.labelUpdate.TabIndex = 9;
            this.labelUpdate.TabStop = true;
            this.labelUpdate.Text = "点击升级";
            this.labelUpdate.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.labelUpdate.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.labelUpdate_LinkClicked);
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menuStrip.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.accountToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(11, 3, 0, 3);
            this.menuStrip.Size = new System.Drawing.Size(503, 34);
            this.menuStrip.TabIndex = 10;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuImportAccount,
            this.toolStripSeparator1,
            this.menuSettings,
            this.menuQuit});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(62, 28);
            this.fileToolStripMenuItem.Text = "文件";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // menuImportAccount
            // 
            this.menuImportAccount.Name = "menuImportAccount";
            this.menuImportAccount.Size = new System.Drawing.Size(270, 34);
            this.menuImportAccount.Text = "导入账号";
            this.menuImportAccount.Click += new System.EventHandler(this.menuImportAccount_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(267, 6);
            // 
            // menuSettings
            // 
            this.menuSettings.Name = "menuSettings";
            this.menuSettings.Size = new System.Drawing.Size(270, 34);
            this.menuSettings.Text = "设置";
            this.menuSettings.Click += new System.EventHandler(this.menuSettings_Click);
            // 
            // menuQuit
            // 
            this.menuQuit.Name = "menuQuit";
            this.menuQuit.Size = new System.Drawing.Size(270, 34);
            this.menuQuit.Text = "退出";
            this.menuQuit.Click += new System.EventHandler(this.menuQuit_Click);
            // 
            // accountToolStripMenuItem
            // 
            this.accountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuLoginAgain,
            this.toolStripSeparator4,
            this.menuRemoveAccountFromManifest,
            this.menuDeactivateAuthenticator});
            this.accountToolStripMenuItem.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            this.accountToolStripMenuItem.Size = new System.Drawing.Size(98, 28);
            this.accountToolStripMenuItem.Text = "选择账号";
            this.accountToolStripMenuItem.Click += new System.EventHandler(this.accountToolStripMenuItem_Click);
            // 
            // menuLoginAgain
            // 
            this.menuLoginAgain.Name = "menuLoginAgain";
            this.menuLoginAgain.Size = new System.Drawing.Size(270, 34);
            this.menuLoginAgain.Text = "重新登录";
            this.menuLoginAgain.Click += new System.EventHandler(this.menuLoginAgain_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(267, 6);
            // 
            // menuRemoveAccountFromManifest
            // 
            this.menuRemoveAccountFromManifest.Name = "menuRemoveAccountFromManifest";
            this.menuRemoveAccountFromManifest.Size = new System.Drawing.Size(270, 34);
            this.menuRemoveAccountFromManifest.Text = "从清单中移除";
            this.menuRemoveAccountFromManifest.Click += new System.EventHandler(this.menuRemoveAccountFromManifest_Click);
            // 
            // menuDeactivateAuthenticator
            // 
            this.menuDeactivateAuthenticator.Name = "menuDeactivateAuthenticator";
            this.menuDeactivateAuthenticator.Size = new System.Drawing.Size(270, 34);
            this.menuDeactivateAuthenticator.Text = "停用身份验证器";
            this.menuDeactivateAuthenticator.Click += new System.EventHandler(this.menuDeactivateAuthenticator_Click);
            // 
            // trayIcon
            // 
            this.trayIcon.ContextMenuStrip = this.menuStripTray;
            this.trayIcon.Text = "Steam 桌面令牌";
            this.trayIcon.Visible = true;
            this.trayIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.trayIcon_MouseDoubleClick);
            // 
            // menuStripTray
            // 
            this.menuStripTray.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStripTray.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trayRestore,
            this.toolStripSeparator2,
            this.trayAccountList,
            this.trayTradeConfirmations,
            this.trayCopySteamGuard,
            this.toolStripSeparator3,
            this.trayQuit});
            this.menuStripTray.Name = "contextMenuStripTray";
            this.menuStripTray.Size = new System.Drawing.Size(312, 174);
            // 
            // trayRestore
            // 
            this.trayRestore.Name = "trayRestore";
            this.trayRestore.Size = new System.Drawing.Size(311, 30);
            this.trayRestore.Text = "恢复窗口";
            this.trayRestore.Click += new System.EventHandler(this.trayRestore_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(308, 6);
            // 
            // trayAccountList
            // 
            this.trayAccountList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.trayAccountList.Items.AddRange(new object[] {
            "test1",
            "test2"});
            this.trayAccountList.Name = "trayAccountList";
            this.trayAccountList.Size = new System.Drawing.Size(121, 32);
            this.trayAccountList.SelectedIndexChanged += new System.EventHandler(this.trayAccountList_SelectedIndexChanged);
            // 
            // trayTradeConfirmations
            // 
            this.trayTradeConfirmations.Name = "trayTradeConfirmations";
            this.trayTradeConfirmations.Size = new System.Drawing.Size(311, 30);
            this.trayTradeConfirmations.Text = "交易确认";
            this.trayTradeConfirmations.Click += new System.EventHandler(this.trayTradeConfirmations_Click);
            // 
            // trayCopySteamGuard
            // 
            this.trayCopySteamGuard.Name = "trayCopySteamGuard";
            this.trayCopySteamGuard.Size = new System.Drawing.Size(311, 30);
            this.trayCopySteamGuard.Text = "将 SG 代码复制到剪贴板";
            this.trayCopySteamGuard.Click += new System.EventHandler(this.trayCopySteamGuard_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(308, 6);
            // 
            // trayQuit
            // 
            this.trayQuit.Name = "trayQuit";
            this.trayQuit.Size = new System.Drawing.Size(311, 30);
            this.trayQuit.Text = "退出";
            this.trayQuit.Click += new System.EventHandler(this.trayQuit_Click);
            // 
            // timerTradesPopup
            // 
            this.timerTradesPopup.Enabled = true;
            this.timerTradesPopup.Interval = 5000;
            this.timerTradesPopup.Tick += new System.EventHandler(this.timerTradesPopup_Tick);
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStatus.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblStatus.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(298, 5);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(199, 19);
            this.lblStatus.TabIndex = 11;
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtAccSearch
            // 
            this.txtAccSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAccSearch.Location = new System.Drawing.Point(73, 704);
            this.txtAccSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtAccSearch.Name = "txtAccSearch";
            this.txtAccSearch.Size = new System.Drawing.Size(415, 31);
            this.txtAccSearch.TabIndex = 12;
            this.txtAccSearch.TextChanged += new System.EventHandler(this.txtAccSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 707);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 24);
            this.label1.TabIndex = 13;
            this.label1.Text = "筛选:";
            // 
            // panelButtons
            // 
            this.panelButtons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelButtons.BackColor = System.Drawing.Color.Transparent;
            this.panelButtons.Controls.Add(this.btnManageEncryption);
            this.panelButtons.Controls.Add(this.btnSteamLogin);
            this.panelButtons.Location = new System.Drawing.Point(19, 37);
            this.panelButtons.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(474, 66);
            this.panelButtons.TabIndex = 14;
            this.panelButtons.SizeChanged += new System.EventHandler(this.panelButtons_SizeChanged);
            // 
            // MainForm
            // 
            this.AcceptButton = this.btnCopy;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(503, 785);
            this.Controls.Add(this.panelButtons);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAccSearch);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.labelUpdate);
            this.Controls.Add(this.labelVersion);
            this.Controls.Add(this.groupAccount);
            this.Controls.Add(this.plist);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(423, 415);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Steam 桌面令牌";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupAccount.ResumeLayout(false);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.menuStripTray.ResumeLayout(false);
            this.panelButtons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSteamLogin;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ProgressBar pbTimeout;
        private System.Windows.Forms.TextBox txtLoginToken;
        private System.Windows.Forms.ListBox plist;
        private System.Windows.Forms.Timer timerSteamGuard;
        private System.Windows.Forms.Button btnTradeConfirmations;
        private System.Windows.Forms.Button btnManageEncryption;
        private System.Windows.Forms.GroupBox groupAccount;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.LinkLabel labelUpdate;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuQuit;
        private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuRemoveAccountFromManifest;
        private System.Windows.Forms.ToolStripMenuItem menuLoginAgain;
        private System.Windows.Forms.NotifyIcon trayIcon;
        private System.Windows.Forms.ContextMenuStrip menuStripTray;
        private System.Windows.Forms.ToolStripMenuItem trayRestore;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem trayTradeConfirmations;
        private System.Windows.Forms.ToolStripMenuItem trayCopySteamGuard;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem trayQuit;
        private System.Windows.Forms.Timer timerTradesPopup;
        private System.Windows.Forms.ToolStripComboBox trayAccountList;
        private System.Windows.Forms.ToolStripMenuItem menuImportAccount;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtAccSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem menuSettings;
        private System.Windows.Forms.ToolStripMenuItem menuDeactivateAuthenticator;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Panel panelButtons;
    }
}

