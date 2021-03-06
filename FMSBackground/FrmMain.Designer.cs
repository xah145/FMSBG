﻿namespace FMSBackground
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.menu_System = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_System_Password = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_System_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Window = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Window_CloseAll = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Window_CloseOther = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Help = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Help_About = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Help_Help = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Help_Register = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMain = new System.Windows.Forms.ToolStrip();
            this.tool_User = new System.Windows.Forms.ToolStripButton();
            this.tool_OU = new System.Windows.Forms.ToolStripButton();
            this.tool_Role = new System.Windows.Forms.ToolStripButton();
            this.tool_Function = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tool_Quit = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblCurrentUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssLink = new System.Windows.Forms.ToolStripStatusLabel();
            this.dockPanel = new WeifenLuo.WinFormsUI.Docking.DockPanel();
            this.menuMain.SuspendLayout();
            this.toolMain.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuMain
            // 
            this.menuMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_System,
            this.menu_Window,
            this.menu_Help});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuMain.Size = new System.Drawing.Size(1031, 28);
            this.menuMain.TabIndex = 7;
            this.menuMain.Text = "menuStrip1";
            // 
            // menu_System
            // 
            this.menu_System.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_System_Password,
            this.menu_System_Exit});
            this.menu_System.Name = "menu_System";
            this.menu_System.Size = new System.Drawing.Size(70, 24);
            this.menu_System.Text = "系统(&S)";
            // 
            // menu_System_Password
            // 
            this.menu_System_Password.Name = "menu_System_Password";
            this.menu_System_Password.Size = new System.Drawing.Size(163, 26);
            this.menu_System_Password.Text = "修改密码(&P)";
            this.menu_System_Password.Visible = false;
            // 
            // menu_System_Exit
            // 
            this.menu_System_Exit.Name = "menu_System_Exit";
            this.menu_System_Exit.Size = new System.Drawing.Size(163, 26);
            this.menu_System_Exit.Text = "退出(&X)";
            // 
            // menu_Window
            // 
            this.menu_Window.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_Window_CloseAll,
            this.menu_Window_CloseOther});
            this.menu_Window.Name = "menu_Window";
            this.menu_Window.Size = new System.Drawing.Size(76, 24);
            this.menu_Window.Text = "窗口(&W)";
            // 
            // menu_Window_CloseAll
            // 
            this.menu_Window_CloseAll.Name = "menu_Window_CloseAll";
            this.menu_Window_CloseAll.Size = new System.Drawing.Size(226, 26);
            this.menu_Window_CloseAll.Text = "关闭所有窗口(&A)";
            // 
            // menu_Window_CloseOther
            // 
            this.menu_Window_CloseOther.Name = "menu_Window_CloseOther";
            this.menu_Window_CloseOther.Size = new System.Drawing.Size(226, 26);
            this.menu_Window_CloseOther.Text = "除此之外全部关闭(&O)";
            // 
            // menu_Help
            // 
            this.menu_Help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_Help_About,
            this.menu_Help_Help,
            this.menu_Help_Register});
            this.menu_Help.Name = "menu_Help";
            this.menu_Help.Size = new System.Drawing.Size(73, 24);
            this.menu_Help.Text = "帮助(&H)";
            // 
            // menu_Help_About
            // 
            this.menu_Help_About.Name = "menu_Help_About";
            this.menu_Help_About.Size = new System.Drawing.Size(181, 26);
            this.menu_Help_About.Text = "关于(&A)";
            this.menu_Help_About.Click += new System.EventHandler(this.menu_Help_About_Click);
            // 
            // menu_Help_Help
            // 
            this.menu_Help_Help.Name = "menu_Help_Help";
            this.menu_Help_Help.Size = new System.Drawing.Size(181, 26);
            this.menu_Help_Help.Text = "帮助(&F)";
            // 
            // menu_Help_Register
            // 
            this.menu_Help_Register.Name = "menu_Help_Register";
            this.menu_Help_Register.Size = new System.Drawing.Size(181, 26);
            this.menu_Help_Register.Text = "注册(&R)";
            this.menu_Help_Register.Visible = false;
            // 
            // toolMain
            // 
            this.toolMain.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tool_User,
            this.tool_OU,
            this.tool_Role,
            this.tool_Function,
            this.toolStripSeparator1,
            this.tool_Quit});
            this.toolMain.Location = new System.Drawing.Point(0, 28);
            this.toolMain.Name = "toolMain";
            this.toolMain.Size = new System.Drawing.Size(1031, 39);
            this.toolMain.TabIndex = 8;
            this.toolMain.Text = "toolStrip1";
            // 
            // tool_User
            // 
            this.tool_User.Image = ((System.Drawing.Image)(resources.GetObject("tool_User.Image")));
            this.tool_User.ImageTransparentColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tool_User.Name = "tool_User";
            this.tool_User.Size = new System.Drawing.Size(105, 36);
            this.tool_User.Text = "用户管理";
            // 
            // tool_OU
            // 
            this.tool_OU.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tool_OU.Name = "tool_OU";
            this.tool_OU.Size = new System.Drawing.Size(103, 36);
            this.tool_OU.Text = "组织机构管理";
            // 
            // tool_Role
            // 
            this.tool_Role.ImageTransparentColor = System.Drawing.Color.White;
            this.tool_Role.Name = "tool_Role";
            this.tool_Role.Size = new System.Drawing.Size(73, 36);
            this.tool_Role.Text = "角色管理";
            // 
            // tool_Function
            // 
            this.tool_Function.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tool_Function.Name = "tool_Function";
            this.tool_Function.Size = new System.Drawing.Size(73, 36);
            this.tool_Function.Text = "功能管理";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // tool_Quit
            // 
            this.tool_Quit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tool_Quit.Name = "tool_Quit";
            this.tool_Quit.Size = new System.Drawing.Size(73, 36);
            this.tool_Quit.Text = "退出系统";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblCurrentUser,
            this.tssLink});
            this.statusStrip1.Location = new System.Drawing.Point(0, 657);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1031, 25);
            this.statusStrip1.TabIndex = 15;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblCurrentUser
            // 
            this.lblCurrentUser.Name = "lblCurrentUser";
            this.lblCurrentUser.Size = new System.Drawing.Size(233, 20);
            this.lblCurrentUser.Text = "                                                        ";
            // 
            // tssLink
            // 
            this.tssLink.IsLink = true;
            this.tssLink.Name = "tssLink";
            this.tssLink.RightToLeftAutoMirrorImage = true;
            this.tssLink.Size = new System.Drawing.Size(778, 20);
            this.tssLink.Spring = true;
            this.tssLink.Text = "版权所有:城建智能建筑学院";
            this.tssLink.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dockPanel
            // 
            this.dockPanel.ActiveAutoHideContent = null;
            this.dockPanel.DefaultFloatWindowSize = new System.Drawing.Size(150, 150);
            this.dockPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dockPanel.DockBottomPortion = 150D;
            this.dockPanel.DockLeftPortion = 200D;
            this.dockPanel.DockRightPortion = 200D;
            this.dockPanel.DockTopPortion = 150D;
            this.dockPanel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.dockPanel.Location = new System.Drawing.Point(0, 67);
            this.dockPanel.Margin = new System.Windows.Forms.Padding(4);
            this.dockPanel.Name = "dockPanel";
            this.dockPanel.RightToLeftLayout = true;
            this.dockPanel.Size = new System.Drawing.Size(1031, 590);
            this.dockPanel.TabIndex = 18;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 682);
            this.Controls.Add(this.dockPanel);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolMain);
            this.Controls.Add(this.menuMain);
            this.IsMdiContainer = true;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMain";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.toolMain.ResumeLayout(false);
            this.toolMain.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem menu_System;
        private System.Windows.Forms.ToolStripMenuItem menu_System_Password;
        private System.Windows.Forms.ToolStripMenuItem menu_System_Exit;
        private System.Windows.Forms.ToolStripMenuItem menu_Window;
        private System.Windows.Forms.ToolStripMenuItem menu_Window_CloseAll;
        private System.Windows.Forms.ToolStripMenuItem menu_Window_CloseOther;
        private System.Windows.Forms.ToolStripMenuItem menu_Help;
        private System.Windows.Forms.ToolStripMenuItem menu_Help_About;
        private System.Windows.Forms.ToolStripMenuItem menu_Help_Help;
        private System.Windows.Forms.ToolStripMenuItem menu_Help_Register;
        private System.Windows.Forms.ToolStrip toolMain;
        private System.Windows.Forms.ToolStripButton tool_User;
        private System.Windows.Forms.ToolStripButton tool_OU;
        private System.Windows.Forms.ToolStripButton tool_Role;
        private System.Windows.Forms.ToolStripButton tool_Function;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tool_Quit;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblCurrentUser;
        private System.Windows.Forms.ToolStripStatusLabel tssLink;
        private WeifenLuo.WinFormsUI.Docking.DockPanel dockPanel;
    }
}