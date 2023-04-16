﻿namespace Netch.Forms
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
            components = new System.ComponentModel.Container();
            MenuStrip = new MenuStrip();
            ServerToolStripMenuItem = new ToolStripMenuItem();
            ImportServersFromClipboardToolStripMenuItem = new ToolStripMenuItem();
            ModeToolStripMenuItem = new ToolStripMenuItem();
            CreateProcessModeToolStripMenuItem = new ToolStripMenuItem();
            CreateRouteTableRuleToolStripMenuItem = new ToolStripMenuItem();
            ReloadModesToolStripMenuItem = new ToolStripMenuItem();
            SubscriptionToolStripMenuItem = new ToolStripMenuItem();
            ManageSubscriptionsToolStripMenuItem = new ToolStripMenuItem();
            UpdateServersToolStripMenuItem = new ToolStripMenuItem();
            OptionsToolStripMenuItem = new ToolStripMenuItem();
            OpenDirectoryToolStripMenuItem = new ToolStripMenuItem();
            ShowHideConsoleToolStripMenuItem = new ToolStripMenuItem();
            CleanDNSCacheToolStripMenuItem = new ToolStripMenuItem();
            UninstallServiceToolStripMenuItem = new ToolStripMenuItem();
            RemoveNetchFirewallRulesToolStripMenuItem = new ToolStripMenuItem();
            HelpToolStripMenuItem = new ToolStripMenuItem();
            CheckForUpdateToolStripMenuItem = new ToolStripMenuItem();
            FAQToolStripMenuItem = new ToolStripMenuItem();
            ForceExitToolStripMenuItem = new ToolStripMenuItem();
            AboutToolStripButton = new ToolStripButton();
            NewVersionLabel = new ToolStripLabel();
            VersionLabel = new ToolStripLabel();
            accountToolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            logoutToolStripMenuItem1 = new ToolStripMenuItem();
            refreshToolStripMenuItem1 = new ToolStripMenuItem();
            ConfigurationGroupBox = new GroupBox();
            configLayoutPanel = new TableLayoutPanel();
            ProfileLabel = new Label();
            ModeLabel = new Label();
            ProfileNameText = new TextBox();
            ModeComboBox = new ComboBox();
            ServerComboBox = new ComboBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            EditServerPictureBox = new PictureBox();
            CopyLinkPictureBox = new PictureBox();
            DeleteServerPictureBox = new PictureBox();
            SpeedPictureBox = new PictureBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            EditModePictureBox = new PictureBox();
            DeleteModePictureBox = new PictureBox();
            ServerLabel = new Label();
            StatusStrip = new StatusStrip();
            StatusLabel = new ToolStripStatusLabel();
            UsedBandwidthLabel = new ToolStripStatusLabel();
            DownloadSpeedLabel = new ToolStripStatusLabel();
            UploadSpeedLabel = new ToolStripStatusLabel();
            blankToolStripStatusLabel = new ToolStripStatusLabel();
            HttpStatusLabel = new ToolStripStatusLabel();
            NatTypeStatusLabel = new ToolStripStatusLabel();
            NatTypeStatusLightLabel = new ToolStripStatusLabel();
            ControlButton = new Button();
            NotifyIcon = new NotifyIcon(components);
            NotifyMenu = new ContextMenuStrip(components);
            ShowMainFormToolStripButton = new ToolStripMenuItem();
            ExitToolStripButton = new ToolStripMenuItem();
            SettingsButton = new Button();
            ProfileGroupBox = new GroupBox();
            ProfileTable = new TableLayoutPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            ButtomControlContainerControl = new ContainerControl();
            MenuStrip.SuspendLayout();
            ConfigurationGroupBox.SuspendLayout();
            configLayoutPanel.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)EditServerPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CopyLinkPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DeleteServerPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SpeedPictureBox).BeginInit();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)EditModePictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DeleteModePictureBox).BeginInit();
            StatusStrip.SuspendLayout();
            NotifyMenu.SuspendLayout();
            ProfileGroupBox.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ButtomControlContainerControl.SuspendLayout();
            SuspendLayout();
            // 
            // MenuStrip
            // 
            MenuStrip.BackColor = SystemColors.Control;
            MenuStrip.ImageScalingSize = new Size(20, 20);
            MenuStrip.Items.AddRange(new ToolStripItem[] { ServerToolStripMenuItem, ModeToolStripMenuItem, SubscriptionToolStripMenuItem, OptionsToolStripMenuItem, HelpToolStripMenuItem, ForceExitToolStripMenuItem, AboutToolStripButton, NewVersionLabel, VersionLabel, accountToolStripMenuItem1 });
            MenuStrip.Location = new Point(0, 0);
            MenuStrip.Name = "MenuStrip";
            MenuStrip.RenderMode = ToolStripRenderMode.Professional;
            MenuStrip.Size = new Size(971, 32);
            MenuStrip.TabIndex = 0;
            // 
            // ServerToolStripMenuItem
            // 
            ServerToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ImportServersFromClipboardToolStripMenuItem });
            ServerToolStripMenuItem.Margin = new Padding(3, 0, 0, 1);
            ServerToolStripMenuItem.Name = "ServerToolStripMenuItem";
            ServerToolStripMenuItem.Size = new Size(79, 28);
            ServerToolStripMenuItem.Text = "Server";
            ServerToolStripMenuItem.Visible = false;
            // 
            // ImportServersFromClipboardToolStripMenuItem
            // 
            ImportServersFromClipboardToolStripMenuItem.Name = "ImportServersFromClipboardToolStripMenuItem";
            ImportServersFromClipboardToolStripMenuItem.Size = new Size(376, 34);
            ImportServersFromClipboardToolStripMenuItem.Text = "Import Servers From Clipboard";
            ImportServersFromClipboardToolStripMenuItem.Click += ImportServersFromClipboardToolStripMenuItem_Click;
            // 
            // ModeToolStripMenuItem
            // 
            ModeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { CreateProcessModeToolStripMenuItem, CreateRouteTableRuleToolStripMenuItem, ReloadModesToolStripMenuItem });
            ModeToolStripMenuItem.Margin = new Padding(0, 0, 0, 1);
            ModeToolStripMenuItem.Name = "ModeToolStripMenuItem";
            ModeToolStripMenuItem.Size = new Size(77, 28);
            ModeToolStripMenuItem.Text = "Mode";
            ModeToolStripMenuItem.Visible = false;
            // 
            // CreateProcessModeToolStripMenuItem
            // 
            CreateProcessModeToolStripMenuItem.Name = "CreateProcessModeToolStripMenuItem";
            CreateProcessModeToolStripMenuItem.Size = new Size(317, 34);
            CreateProcessModeToolStripMenuItem.Text = "Create Process Mode";
            CreateProcessModeToolStripMenuItem.Click += CreateProcessModeToolStripButton_Click;
            // 
            // CreateRouteTableRuleToolStripMenuItem
            // 
            CreateRouteTableRuleToolStripMenuItem.Name = "CreateRouteTableRuleToolStripMenuItem";
            CreateRouteTableRuleToolStripMenuItem.Size = new Size(317, 34);
            CreateRouteTableRuleToolStripMenuItem.Text = "Create Route Table Rule";
            CreateRouteTableRuleToolStripMenuItem.Click += createRouteTableModeToolStripMenuItem_Click;
            // 
            // ReloadModesToolStripMenuItem
            // 
            ReloadModesToolStripMenuItem.Name = "ReloadModesToolStripMenuItem";
            ReloadModesToolStripMenuItem.Size = new Size(317, 34);
            ReloadModesToolStripMenuItem.Text = "Reload Modes";
            ReloadModesToolStripMenuItem.Click += ReloadModesToolStripMenuItem_Click;
            // 
            // SubscriptionToolStripMenuItem
            // 
            SubscriptionToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ManageSubscriptionsToolStripMenuItem, UpdateServersToolStripMenuItem });
            SubscriptionToolStripMenuItem.Margin = new Padding(0, 0, 0, 1);
            SubscriptionToolStripMenuItem.Name = "SubscriptionToolStripMenuItem";
            SubscriptionToolStripMenuItem.Size = new Size(134, 28);
            SubscriptionToolStripMenuItem.Text = "Subscription";
            SubscriptionToolStripMenuItem.Visible = false;
            // 
            // ManageSubscriptionsToolStripMenuItem
            // 
            ManageSubscriptionsToolStripMenuItem.Name = "ManageSubscriptionsToolStripMenuItem";
            ManageSubscriptionsToolStripMenuItem.Size = new Size(302, 34);
            ManageSubscriptionsToolStripMenuItem.Text = "Manage Subscriptions";
            ManageSubscriptionsToolStripMenuItem.Click += ManageSubscriptionLinksToolStripMenuItem_Click;
            // 
            // UpdateServersToolStripMenuItem
            // 
            UpdateServersToolStripMenuItem.Name = "UpdateServersToolStripMenuItem";
            UpdateServersToolStripMenuItem.Size = new Size(302, 34);
            UpdateServersToolStripMenuItem.Text = "Update Servers";
            UpdateServersToolStripMenuItem.Click += UpdateServersFromSubscriptionLinksToolStripMenuItem_Click;
            // 
            // OptionsToolStripMenuItem
            // 
            OptionsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { OpenDirectoryToolStripMenuItem, ShowHideConsoleToolStripMenuItem, CleanDNSCacheToolStripMenuItem, UninstallServiceToolStripMenuItem, RemoveNetchFirewallRulesToolStripMenuItem });
            OptionsToolStripMenuItem.Margin = new Padding(0, 0, 0, 1);
            OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem";
            OptionsToolStripMenuItem.Size = new Size(95, 28);
            OptionsToolStripMenuItem.Text = "Options";
            OptionsToolStripMenuItem.Visible = false;
            // 
            // OpenDirectoryToolStripMenuItem
            // 
            OpenDirectoryToolStripMenuItem.Name = "OpenDirectoryToolStripMenuItem";
            OpenDirectoryToolStripMenuItem.Size = new Size(358, 34);
            OpenDirectoryToolStripMenuItem.Text = "Open Directory";
            OpenDirectoryToolStripMenuItem.Click += OpenDirectoryToolStripMenuItem_Click;
            // 
            // ShowHideConsoleToolStripMenuItem
            // 
            ShowHideConsoleToolStripMenuItem.Name = "ShowHideConsoleToolStripMenuItem";
            ShowHideConsoleToolStripMenuItem.Size = new Size(358, 34);
            ShowHideConsoleToolStripMenuItem.Text = "Show/Hide Console";
            ShowHideConsoleToolStripMenuItem.Click += ShowHideConsoleToolStripMenuItem_Click;
            // 
            // CleanDNSCacheToolStripMenuItem
            // 
            CleanDNSCacheToolStripMenuItem.Name = "CleanDNSCacheToolStripMenuItem";
            CleanDNSCacheToolStripMenuItem.Size = new Size(358, 34);
            CleanDNSCacheToolStripMenuItem.Text = "Clean DNS Cache";
            CleanDNSCacheToolStripMenuItem.Click += CleanDNSCacheToolStripMenuItem_Click;
            // 
            // UninstallServiceToolStripMenuItem
            // 
            UninstallServiceToolStripMenuItem.Name = "UninstallServiceToolStripMenuItem";
            UninstallServiceToolStripMenuItem.Size = new Size(358, 34);
            UninstallServiceToolStripMenuItem.Text = "Uninstall NF Service";
            UninstallServiceToolStripMenuItem.Click += UninstallServiceToolStripMenuItem_Click;
            // 
            // RemoveNetchFirewallRulesToolStripMenuItem
            // 
            RemoveNetchFirewallRulesToolStripMenuItem.Name = "RemoveNetchFirewallRulesToolStripMenuItem";
            RemoveNetchFirewallRulesToolStripMenuItem.Size = new Size(358, 34);
            RemoveNetchFirewallRulesToolStripMenuItem.Text = "Remove Netch Firewall Rules";
            RemoveNetchFirewallRulesToolStripMenuItem.Click += RemoveNetchFirewallRulesToolStripMenuItem_Click;
            // 
            // HelpToolStripMenuItem
            // 
            HelpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { CheckForUpdateToolStripMenuItem, FAQToolStripMenuItem });
            HelpToolStripMenuItem.Margin = new Padding(0, 0, 0, 1);
            HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
            HelpToolStripMenuItem.Size = new Size(67, 28);
            HelpToolStripMenuItem.Text = "Help";
            HelpToolStripMenuItem.Visible = false;
            // 
            // CheckForUpdateToolStripMenuItem
            // 
            CheckForUpdateToolStripMenuItem.Name = "CheckForUpdateToolStripMenuItem";
            CheckForUpdateToolStripMenuItem.Size = new Size(258, 34);
            CheckForUpdateToolStripMenuItem.Text = "Check for update";
            CheckForUpdateToolStripMenuItem.Click += CheckForUpdatesToolStripMenuItem_Click;
            // 
            // FAQToolStripMenuItem
            // 
            FAQToolStripMenuItem.Name = "FAQToolStripMenuItem";
            FAQToolStripMenuItem.Size = new Size(258, 34);
            FAQToolStripMenuItem.Text = "FAQ";
            FAQToolStripMenuItem.Click += fAQToolStripMenuItem_Click;
            // 
            // ForceExitToolStripMenuItem
            // 
            ForceExitToolStripMenuItem.Name = "ForceExitToolStripMenuItem";
            ForceExitToolStripMenuItem.Size = new Size(57, 28);
            ForceExitToolStripMenuItem.Text = "Exit";
            ForceExitToolStripMenuItem.Click += ForceExitToolStripMenuItem_Click;
            // 
            // AboutToolStripButton
            // 
            AboutToolStripButton.Alignment = ToolStripItemAlignment.Right;
            AboutToolStripButton.AutoToolTip = false;
            AboutToolStripButton.Margin = new Padding(0, 0, 3, 1);
            AboutToolStripButton.Name = "AboutToolStripButton";
            AboutToolStripButton.Size = new Size(68, 28);
            AboutToolStripButton.Text = "About";
            AboutToolStripButton.Visible = false;
            AboutToolStripButton.Click += AboutToolStripButton_Click;
            // 
            // NewVersionLabel
            // 
            NewVersionLabel.Alignment = ToolStripItemAlignment.Right;
            NewVersionLabel.BackColor = Color.Transparent;
            NewVersionLabel.ForeColor = Color.Red;
            NewVersionLabel.IsLink = true;
            NewVersionLabel.LinkBehavior = LinkBehavior.NeverUnderline;
            NewVersionLabel.LinkColor = Color.Red;
            NewVersionLabel.Name = "NewVersionLabel";
            NewVersionLabel.Size = new Size(196, 24);
            NewVersionLabel.Text = "New version available";
            NewVersionLabel.Visible = false;
            NewVersionLabel.Click += NewVersionLabel_Click;
            // 
            // VersionLabel
            // 
            VersionLabel.Alignment = ToolStripItemAlignment.Right;
            VersionLabel.BackColor = Color.Transparent;
            VersionLabel.ForeColor = Color.Red;
            VersionLabel.IsLink = true;
            VersionLabel.LinkBehavior = LinkBehavior.NeverUnderline;
            VersionLabel.Name = "VersionLabel";
            VersionLabel.Size = new Size(37, 24);
            VersionLabel.Text = "xxx";
            VersionLabel.Visible = false;
            VersionLabel.Click += VersionLabel_Click;
            // 
            // accountToolStripMenuItem1
            // 
            accountToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem2, logoutToolStripMenuItem1, refreshToolStripMenuItem1 });
            accountToolStripMenuItem1.Name = "accountToolStripMenuItem1";
            accountToolStripMenuItem1.Size = new Size(97, 28);
            accountToolStripMenuItem1.Text = "Account";
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(169, 34);
            toolStripMenuItem2.Text = "login";
            toolStripMenuItem2.Click += toolStripMenuItem2_Click;
            // 
            // logoutToolStripMenuItem1
            // 
            logoutToolStripMenuItem1.Name = "logoutToolStripMenuItem1";
            logoutToolStripMenuItem1.Size = new Size(169, 34);
            logoutToolStripMenuItem1.Text = "logout";
            // 
            // refreshToolStripMenuItem1
            // 
            refreshToolStripMenuItem1.Name = "refreshToolStripMenuItem1";
            refreshToolStripMenuItem1.Size = new Size(169, 34);
            refreshToolStripMenuItem1.Text = "refresh";
            // 
            // ConfigurationGroupBox
            // 
            ConfigurationGroupBox.Controls.Add(configLayoutPanel);
            ConfigurationGroupBox.Location = new Point(12, 35);
            ConfigurationGroupBox.Name = "ConfigurationGroupBox";
            ConfigurationGroupBox.Size = new Size(761, 72);
            ConfigurationGroupBox.TabIndex = 1;
            ConfigurationGroupBox.TabStop = false;
            ConfigurationGroupBox.Text = "Configuration";
            // 
            // configLayoutPanel
            // 
            configLayoutPanel.AutoSize = true;
            configLayoutPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            configLayoutPanel.ColumnCount = 3;
            configLayoutPanel.ColumnStyles.Add(new ColumnStyle());
            configLayoutPanel.ColumnStyles.Add(new ColumnStyle());
            configLayoutPanel.ColumnStyles.Add(new ColumnStyle());
            configLayoutPanel.Controls.Add(ProfileLabel, 0, 2);
            configLayoutPanel.Controls.Add(ModeLabel, 0, 1);
            configLayoutPanel.Controls.Add(ProfileNameText, 1, 2);
            configLayoutPanel.Controls.Add(ModeComboBox, 1, 1);
            configLayoutPanel.Controls.Add(ServerComboBox, 1, 0);
            configLayoutPanel.Controls.Add(tableLayoutPanel2, 2, 0);
            configLayoutPanel.Controls.Add(tableLayoutPanel3, 2, 1);
            configLayoutPanel.Controls.Add(ServerLabel, 0, 0);
            configLayoutPanel.Dock = DockStyle.Fill;
            configLayoutPanel.Location = new Point(3, 27);
            configLayoutPanel.Name = "configLayoutPanel";
            configLayoutPanel.RowCount = 3;
            configLayoutPanel.RowStyles.Add(new RowStyle());
            configLayoutPanel.RowStyles.Add(new RowStyle());
            configLayoutPanel.RowStyles.Add(new RowStyle());
            configLayoutPanel.Size = new Size(755, 42);
            configLayoutPanel.TabIndex = 15;
            // 
            // ProfileLabel
            // 
            ProfileLabel.Anchor = AnchorStyles.Left;
            ProfileLabel.AutoSize = true;
            ProfileLabel.Location = new Point(3, 82);
            ProfileLabel.Name = "ProfileLabel";
            ProfileLabel.Size = new Size(65, 24);
            ProfileLabel.TabIndex = 10;
            ProfileLabel.Text = "Profile";
            ProfileLabel.Visible = false;
            // 
            // ModeLabel
            // 
            ModeLabel.Anchor = AnchorStyles.Left;
            ModeLabel.AutoSize = true;
            ModeLabel.Location = new Point(3, 45);
            ModeLabel.Name = "ModeLabel";
            ModeLabel.Size = new Size(61, 24);
            ModeLabel.TabIndex = 3;
            ModeLabel.Text = "Mode";
            ModeLabel.Visible = false;
            // 
            // ProfileNameText
            // 
            ProfileNameText.Dock = DockStyle.Fill;
            ProfileNameText.Location = new Point(74, 79);
            ProfileNameText.Name = "ProfileNameText";
            ProfileNameText.Size = new Size(546, 31);
            ProfileNameText.TabIndex = 11;
            ProfileNameText.Visible = false;
            // 
            // ModeComboBox
            // 
            ModeComboBox.Dock = DockStyle.Fill;
            ModeComboBox.DrawMode = DrawMode.OwnerDrawFixed;
            ModeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            ModeComboBox.FormattingEnabled = true;
            ModeComboBox.IntegralHeight = false;
            ModeComboBox.Location = new Point(74, 41);
            ModeComboBox.Name = "ModeComboBox";
            ModeComboBox.Size = new Size(546, 32);
            ModeComboBox.TabIndex = 2;
            ModeComboBox.Visible = false;
            ModeComboBox.DrawItem += ComboBox_DrawItem;
            ModeComboBox.SelectionChangeCommitted += ModeComboBox_SelectionChangeCommitted;
            // 
            // ServerComboBox
            // 
            ServerComboBox.Dock = DockStyle.Fill;
            ServerComboBox.DrawMode = DrawMode.OwnerDrawFixed;
            ServerComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            ServerComboBox.FormattingEnabled = true;
            ServerComboBox.IntegralHeight = false;
            ServerComboBox.Location = new Point(74, 3);
            ServerComboBox.MaxDropDownItems = 16;
            ServerComboBox.Name = "ServerComboBox";
            ServerComboBox.Size = new Size(546, 32);
            ServerComboBox.TabIndex = 1;
            ServerComboBox.DrawItem += ComboBox_DrawItem;
            ServerComboBox.SelectionChangeCommitted += ServerComboBox_SelectionChangeCommitted;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.Controls.Add(EditServerPictureBox, 0, 0);
            tableLayoutPanel2.Controls.Add(CopyLinkPictureBox, 3, 0);
            tableLayoutPanel2.Controls.Add(DeleteServerPictureBox, 1, 0);
            tableLayoutPanel2.Controls.Add(SpeedPictureBox, 2, 0);
            tableLayoutPanel2.Location = new Point(626, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(94, 24);
            tableLayoutPanel2.TabIndex = 12;
            // 
            // EditServerPictureBox
            // 
            EditServerPictureBox.BackColor = SystemColors.Control;
            EditServerPictureBox.Cursor = Cursors.Hand;
            EditServerPictureBox.Enabled = false;
            EditServerPictureBox.Image = Properties.Resources.edit;
            EditServerPictureBox.Location = new Point(3, 3);
            EditServerPictureBox.Name = "EditServerPictureBox";
            EditServerPictureBox.Size = new Size(16, 16);
            EditServerPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            EditServerPictureBox.TabIndex = 7;
            EditServerPictureBox.TabStop = false;
            EditServerPictureBox.Visible = false;
            EditServerPictureBox.Click += EditServerPictureBox_Click;
            // 
            // CopyLinkPictureBox
            // 
            CopyLinkPictureBox.Cursor = Cursors.Hand;
            CopyLinkPictureBox.Image = Properties.Resources.CopyLink;
            CopyLinkPictureBox.Location = new Point(72, 3);
            CopyLinkPictureBox.Name = "CopyLinkPictureBox";
            CopyLinkPictureBox.Size = new Size(18, 18);
            CopyLinkPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            CopyLinkPictureBox.TabIndex = 14;
            CopyLinkPictureBox.TabStop = false;
            CopyLinkPictureBox.Visible = false;
            CopyLinkPictureBox.Click += CopyLinkPictureBox_Click;
            // 
            // DeleteServerPictureBox
            // 
            DeleteServerPictureBox.Cursor = Cursors.Hand;
            DeleteServerPictureBox.Enabled = false;
            DeleteServerPictureBox.Image = Properties.Resources.delete;
            DeleteServerPictureBox.Location = new Point(26, 3);
            DeleteServerPictureBox.Name = "DeleteServerPictureBox";
            DeleteServerPictureBox.Size = new Size(16, 16);
            DeleteServerPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            DeleteServerPictureBox.TabIndex = 8;
            DeleteServerPictureBox.TabStop = false;
            DeleteServerPictureBox.Visible = false;
            DeleteServerPictureBox.Click += DeleteServerPictureBox_Click;
            // 
            // SpeedPictureBox
            // 
            SpeedPictureBox.Cursor = Cursors.Hand;
            SpeedPictureBox.Image = Properties.Resources.speed;
            SpeedPictureBox.Location = new Point(49, 3);
            SpeedPictureBox.Name = "SpeedPictureBox";
            SpeedPictureBox.Size = new Size(16, 16);
            SpeedPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            SpeedPictureBox.TabIndex = 9;
            SpeedPictureBox.TabStop = false;
            SpeedPictureBox.Click += SpeedPictureBox_Click;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 4;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.Controls.Add(EditModePictureBox, 0, 0);
            tableLayoutPanel3.Controls.Add(DeleteModePictureBox, 1, 0);
            tableLayoutPanel3.Location = new Point(626, 41);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(94, 24);
            tableLayoutPanel3.TabIndex = 13;
            tableLayoutPanel3.Visible = false;
            // 
            // EditModePictureBox
            // 
            EditModePictureBox.Cursor = Cursors.Hand;
            EditModePictureBox.Image = Properties.Resources.edit;
            EditModePictureBox.Location = new Point(3, 3);
            EditModePictureBox.Name = "EditModePictureBox";
            EditModePictureBox.Size = new Size(16, 16);
            EditModePictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            EditModePictureBox.TabIndex = 12;
            EditModePictureBox.TabStop = false;
            EditModePictureBox.Visible = false;
            EditModePictureBox.Click += EditModePictureBox_Click;
            // 
            // DeleteModePictureBox
            // 
            DeleteModePictureBox.Cursor = Cursors.Hand;
            DeleteModePictureBox.Image = Properties.Resources.delete;
            DeleteModePictureBox.Location = new Point(26, 3);
            DeleteModePictureBox.Name = "DeleteModePictureBox";
            DeleteModePictureBox.Size = new Size(16, 16);
            DeleteModePictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            DeleteModePictureBox.TabIndex = 13;
            DeleteModePictureBox.TabStop = false;
            DeleteModePictureBox.Visible = false;
            DeleteModePictureBox.Click += DeleteModePictureBox_Click;
            // 
            // ServerLabel
            // 
            ServerLabel.Anchor = AnchorStyles.Left;
            ServerLabel.AutoSize = true;
            ServerLabel.Location = new Point(3, 7);
            ServerLabel.Name = "ServerLabel";
            ServerLabel.Size = new Size(63, 24);
            ServerLabel.TabIndex = 0;
            ServerLabel.Text = "Server";
            // 
            // StatusStrip
            // 
            StatusStrip.ImageScalingSize = new Size(20, 20);
            StatusStrip.Items.AddRange(new ToolStripItem[] { StatusLabel, UsedBandwidthLabel, DownloadSpeedLabel, UploadSpeedLabel, blankToolStripStatusLabel, HttpStatusLabel, NatTypeStatusLabel, NatTypeStatusLightLabel });
            StatusStrip.Location = new Point(0, 138);
            StatusStrip.Name = "StatusStrip";
            StatusStrip.Size = new Size(971, 31);
            StatusStrip.SizingGrip = false;
            StatusStrip.TabIndex = 2;
            // 
            // StatusLabel
            // 
            StatusLabel.BackColor = Color.Transparent;
            StatusLabel.Name = "StatusLabel";
            StatusLabel.Size = new Size(261, 24);
            StatusLabel.Text = "Status: Waiting for command";
            // 
            // UsedBandwidthLabel
            // 
            UsedBandwidthLabel.Name = "UsedBandwidthLabel";
            UsedBandwidthLabel.Size = new Size(100, 24);
            UsedBandwidthLabel.Text = "Used: 0 KB";
            UsedBandwidthLabel.Visible = false;
            // 
            // DownloadSpeedLabel
            // 
            DownloadSpeedLabel.Name = "DownloadSpeedLabel";
            DownloadSpeedLabel.Size = new Size(82, 24);
            DownloadSpeedLabel.Text = "↓: 0 KB/s";
            DownloadSpeedLabel.Visible = false;
            // 
            // UploadSpeedLabel
            // 
            UploadSpeedLabel.Name = "UploadSpeedLabel";
            UploadSpeedLabel.Size = new Size(82, 24);
            UploadSpeedLabel.Text = "↑: 0 KB/s";
            UploadSpeedLabel.Visible = false;
            // 
            // blankToolStripStatusLabel
            // 
            blankToolStripStatusLabel.Name = "blankToolStripStatusLabel";
            blankToolStripStatusLabel.Size = new Size(621, 24);
            blankToolStripStatusLabel.Spring = true;
            // 
            // HttpStatusLabel
            // 
            HttpStatusLabel.Name = "HttpStatusLabel";
            HttpStatusLabel.Size = new Size(59, 24);
            HttpStatusLabel.Text = "HTTP:";
            HttpStatusLabel.TextAlign = ContentAlignment.BottomLeft;
            HttpStatusLabel.Visible = false;
            HttpStatusLabel.Click += TcpStatusLabel_Click;
            // 
            // NatTypeStatusLabel
            // 
            NatTypeStatusLabel.Name = "NatTypeStatusLabel";
            NatTypeStatusLabel.Size = new Size(52, 24);
            NatTypeStatusLabel.Text = "NAT:";
            NatTypeStatusLabel.TextAlign = ContentAlignment.BottomLeft;
            NatTypeStatusLabel.Click += NatTypeStatusLabel_Click;
            // 
            // NatTypeStatusLightLabel
            // 
            NatTypeStatusLightLabel.ActiveLinkColor = Color.Red;
            NatTypeStatusLightLabel.DisplayStyle = ToolStripItemDisplayStyle.Text;
            NatTypeStatusLightLabel.ForeColor = Color.Red;
            NatTypeStatusLightLabel.Margin = new Padding(0, 0, 0, 1);
            NatTypeStatusLightLabel.Name = "NatTypeStatusLightLabel";
            NatTypeStatusLightLabel.Size = new Size(22, 30);
            NatTypeStatusLightLabel.Text = "⬤";
            NatTypeStatusLightLabel.TextAlign = ContentAlignment.BottomCenter;
            NatTypeStatusLightLabel.Click += NatTypeStatusLabel_Click;
            // 
            // ControlButton
            // 
            ControlButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            ControlButton.Location = new Point(775, 28);
            ControlButton.Name = "ControlButton";
            ControlButton.Size = new Size(75, 27);
            ControlButton.TabIndex = 3;
            ControlButton.Text = "Start";
            ControlButton.UseVisualStyleBackColor = true;
            ControlButton.Click += ControlButton_Click;
            // 
            // NotifyIcon
            // 
            NotifyIcon.ContextMenuStrip = NotifyMenu;
            NotifyIcon.Text = "Netch";
            NotifyIcon.Visible = true;
            NotifyIcon.MouseDoubleClick += NotifyIcon_MouseDoubleClick;
            // 
            // NotifyMenu
            // 
            NotifyMenu.ImageScalingSize = new Size(20, 20);
            NotifyMenu.Items.AddRange(new ToolStripItem[] { ShowMainFormToolStripButton, ExitToolStripButton });
            NotifyMenu.Name = "NotifyMenu";
            NotifyMenu.ShowItemToolTips = false;
            NotifyMenu.Size = new Size(127, 64);
            // 
            // ShowMainFormToolStripButton
            // 
            ShowMainFormToolStripButton.Name = "ShowMainFormToolStripButton";
            ShowMainFormToolStripButton.Size = new Size(126, 30);
            ShowMainFormToolStripButton.Text = "Show";
            ShowMainFormToolStripButton.Click += ShowMainFormToolStripButton_Click;
            // 
            // ExitToolStripButton
            // 
            ExitToolStripButton.Name = "ExitToolStripButton";
            ExitToolStripButton.Size = new Size(126, 30);
            ExitToolStripButton.Text = "Exit";
            ExitToolStripButton.Click += ExitToolStripButton_Click;
            // 
            // SettingsButton
            // 
            SettingsButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            SettingsButton.Location = new Point(856, 27);
            SettingsButton.Name = "SettingsButton";
            SettingsButton.Size = new Size(72, 27);
            SettingsButton.TabIndex = 4;
            SettingsButton.Text = "Settings";
            SettingsButton.UseVisualStyleBackColor = true;
            SettingsButton.Visible = false;
            SettingsButton.Click += SettingsButton_Click;
            // 
            // ProfileGroupBox
            // 
            ProfileGroupBox.Controls.Add(ProfileTable);
            ProfileGroupBox.ForeColor = SystemColors.ControlText;
            ProfileGroupBox.Location = new Point(3, 90);
            ProfileGroupBox.Name = "ProfileGroupBox";
            ProfileGroupBox.Size = new Size(755, 218);
            ProfileGroupBox.TabIndex = 13;
            ProfileGroupBox.TabStop = false;
            ProfileGroupBox.Text = "Profiles";
            ProfileGroupBox.Visible = false;
            // 
            // ProfileTable
            // 
            ProfileTable.AutoSize = true;
            ProfileTable.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ProfileTable.ColumnCount = 2;
            ProfileTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            ProfileTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            ProfileTable.Dock = DockStyle.Fill;
            ProfileTable.Location = new Point(3, 27);
            ProfileTable.Name = "ProfileTable";
            ProfileTable.RowCount = 1;
            ProfileTable.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            ProfileTable.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            ProfileTable.Size = new Size(749, 188);
            ProfileTable.TabIndex = 0;
            ProfileTable.Visible = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel1.Controls.Add(ButtomControlContainerControl);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(12, 35);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(950, 331);
            flowLayoutPanel1.TabIndex = 14;
            // 
            // ButtomControlContainerControl
            // 
            ButtomControlContainerControl.Controls.Add(SettingsButton);
            ButtomControlContainerControl.Controls.Add(ControlButton);
            ButtomControlContainerControl.Controls.Add(ProfileGroupBox);
            ButtomControlContainerControl.Location = new Point(3, 3);
            ButtomControlContainerControl.Name = "ButtomControlContainerControl";
            ButtomControlContainerControl.Size = new Size(944, 325);
            ButtomControlContainerControl.TabIndex = 14;
            ButtomControlContainerControl.TabStop = false;
            ButtomControlContainerControl.Text = "groupBox1";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(971, 169);
            Controls.Add(ConfigurationGroupBox);
            Controls.Add(MenuStrip);
            Controls.Add(StatusStrip);
            Controls.Add(flowLayoutPanel1);
            Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Netch";
            FormClosing += MainForm_FormClosing;
            Load += MainForm_Load;
            MenuStrip.ResumeLayout(false);
            MenuStrip.PerformLayout();
            ConfigurationGroupBox.ResumeLayout(false);
            ConfigurationGroupBox.PerformLayout();
            configLayoutPanel.ResumeLayout(false);
            configLayoutPanel.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)EditServerPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)CopyLinkPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)DeleteServerPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)SpeedPictureBox).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)EditModePictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)DeleteModePictureBox).EndInit();
            StatusStrip.ResumeLayout(false);
            StatusStrip.PerformLayout();
            NotifyMenu.ResumeLayout(false);
            ProfileGroupBox.ResumeLayout(false);
            ProfileGroupBox.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            ButtomControlContainerControl.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.ToolStripMenuItem CreateRouteTableRuleToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem RemoveNetchFirewallRulesToolStripMenuItem;

        private System.Windows.Forms.ToolStripButton AboutToolStripButton;
        private System.Windows.Forms.ToolStripMenuItem CleanDNSCacheToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel configLayoutPanel;
        private System.Windows.Forms.GroupBox ConfigurationGroupBox;
        private System.Windows.Forms.Button ControlButton;
        private System.Windows.Forms.PictureBox CopyLinkPictureBox;
        private System.Windows.Forms.ToolStripMenuItem CreateProcessModeToolStripMenuItem;
        private System.Windows.Forms.PictureBox DeleteModePictureBox;
        private System.Windows.Forms.PictureBox DeleteServerPictureBox;
        private System.Windows.Forms.ToolStripStatusLabel DownloadSpeedLabel;
        private System.Windows.Forms.PictureBox EditModePictureBox;
        private System.Windows.Forms.PictureBox EditServerPictureBox;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripButton;
        private System.Windows.Forms.ToolStripMenuItem ForceExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ImportServersFromClipboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ManageSubscriptionsToolStripMenuItem;
        private System.Windows.Forms.MenuStrip MenuStrip;
        public System.Windows.Forms.ComboBox ModeComboBox;
        private System.Windows.Forms.Label ModeLabel;
        private System.Windows.Forms.ToolStripMenuItem ModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel NatTypeStatusLabel;
        private System.Windows.Forms.NotifyIcon NotifyIcon;
        private System.Windows.Forms.ContextMenuStrip NotifyMenu;
        private System.Windows.Forms.ToolStripMenuItem OpenDirectoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OptionsToolStripMenuItem;
        private System.Windows.Forms.GroupBox ProfileGroupBox;
        private System.Windows.Forms.Label ProfileLabel;
        private System.Windows.Forms.TextBox ProfileNameText;
        private System.Windows.Forms.TableLayoutPanel ProfileTable;
        private System.Windows.Forms.ToolStripMenuItem CheckForUpdateToolStripMenuItem;
        private System.Windows.Forms.ComboBox ServerComboBox;
        private System.Windows.Forms.Label ServerLabel;
        private System.Windows.Forms.ToolStripMenuItem ServerToolStripMenuItem;
        private System.Windows.Forms.Button SettingsButton;
        private System.Windows.Forms.ToolStripMenuItem ShowMainFormToolStripButton;
        private System.Windows.Forms.PictureBox SpeedPictureBox;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel;
        private System.Windows.Forms.StatusStrip StatusStrip;
        private System.Windows.Forms.ToolStripMenuItem SubscriptionToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.ToolStripMenuItem UninstallServiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UpdateServersToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel UploadSpeedLabel;
        private System.Windows.Forms.ToolStripStatusLabel UsedBandwidthLabel;
        private System.Windows.Forms.ToolStripLabel NewVersionLabel;
        private System.Windows.Forms.ToolStripLabel VersionLabel;
        private System.Windows.Forms.ToolStripStatusLabel NatTypeStatusLightLabel;
        private System.Windows.Forms.ToolStripStatusLabel blankToolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem FAQToolStripMenuItem;

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ContainerControl ButtomControlContainerControl;
        private System.Windows.Forms.ToolStripMenuItem ShowHideConsoleToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel HttpStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem ReloadModesToolStripMenuItem;
        private ToolStripMenuItem loginToolStripMenuItem;
        private ToolStripMenuItem accountToolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem logoutToolStripMenuItem1;
        private ToolStripMenuItem refreshToolStripMenuItem1;
    }
}