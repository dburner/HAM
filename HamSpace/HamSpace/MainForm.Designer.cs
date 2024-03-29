﻿namespace HamSpace
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.managedAppsListView = new System.Windows.Forms.ListView();
            this.nameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.installHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.uninstallHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.loadButton = new System.Windows.Forms.Button();
            this.installAppslistView = new System.Windows.Forms.ListView();
            this.appNameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.descriptionHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.installToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visitWebsiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Location = new System.Drawing.Point(12, 32);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(605, 351);
            this.tabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.managedAppsListView);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(597, 325);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Managed apps";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // managedAppsListView
            // 
            this.managedAppsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameHeader,
            this.installHeader,
            this.uninstallHeader});
            this.managedAppsListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.managedAppsListView.GridLines = true;
            this.managedAppsListView.Location = new System.Drawing.Point(3, 3);
            this.managedAppsListView.Name = "managedAppsListView";
            this.managedAppsListView.Size = new System.Drawing.Size(591, 319);
            this.managedAppsListView.TabIndex = 0;
            this.managedAppsListView.UseCompatibleStateImageBehavior = false;
            this.managedAppsListView.View = System.Windows.Forms.View.Details;
            // 
            // nameHeader
            // 
            this.nameHeader.Text = "Name";
            this.nameHeader.Width = 144;
            // 
            // installHeader
            // 
            this.installHeader.Text = "Install Location";
            this.installHeader.Width = 203;
            // 
            // uninstallHeader
            // 
            this.uninstallHeader.Text = "Uninstall string";
            this.uninstallHeader.Width = 223;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.descriptionTextBox);
            this.tabPage2.Controls.Add(this.loadButton);
            this.tabPage2.Controls.Add(this.installAppslistView);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(597, 325);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Install apps";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(448, 296);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(75, 23);
            this.loadButton.TabIndex = 2;
            this.loadButton.Text = "Load apps";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // installAppslistView
            // 
            this.installAppslistView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.appNameHeader,
            this.descriptionHeader});
            this.installAppslistView.FullRowSelect = true;
            this.installAppslistView.LargeImageList = this.imageList;
            this.installAppslistView.Location = new System.Drawing.Point(6, 6);
            this.installAppslistView.Name = "installAppslistView";
            this.installAppslistView.Size = new System.Drawing.Size(370, 313);
            this.installAppslistView.SmallImageList = this.imageList;
            this.installAppslistView.TabIndex = 0;
            this.installAppslistView.UseCompatibleStateImageBehavior = false;
            this.installAppslistView.View = System.Windows.Forms.View.Details;
            this.installAppslistView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.installAppslistView_MouseClick);
            // 
            // appNameHeader
            // 
            this.appNameHeader.Text = "Name";
            this.appNameHeader.Width = 126;
            // 
            // descriptionHeader
            // 
            this.descriptionHeader.Text = "Description";
            this.descriptionHeader.Width = 176;
            // 
            // imageList
            // 
            this.imageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList.ImageSize = new System.Drawing.Size(32, 32);
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // installToolStripMenuItem
            // 
            this.installToolStripMenuItem.Name = "installToolStripMenuItem";
            this.installToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.installToolStripMenuItem.Text = "Install";
            this.installToolStripMenuItem.Click += new System.EventHandler(this.installToolStripMenuItem_Click);
            // 
            // visitWebsiteToolStripMenuItem
            // 
            this.visitWebsiteToolStripMenuItem.Name = "visitWebsiteToolStripMenuItem";
            this.visitWebsiteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.visitWebsiteToolStripMenuItem.Text = "Visit website";
            this.visitWebsiteToolStripMenuItem.Click += new System.EventHandler(this.visitWebsiteToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel,
            this.toolStripProgressBar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 386);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(629, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(38, 17);
            this.toolStripStatusLabel.Text = "status";
            // 
            // toolStripProgressBar
            // 
            this.toolStripProgressBar.Name = "toolStripProgressBar";
            this.toolStripProgressBar.Size = new System.Drawing.Size(100, 16);
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(382, 6);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.ReadOnly = true;
            this.descriptionTextBox.Size = new System.Drawing.Size(209, 284);
            this.descriptionTextBox.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 408);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListView managedAppsListView;
        private System.Windows.Forms.ColumnHeader nameHeader;
        private System.Windows.Forms.ColumnHeader installHeader;
        private System.Windows.Forms.ColumnHeader uninstallHeader;
        private System.Windows.Forms.ListView installAppslistView;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.ColumnHeader appNameHeader;
        private System.Windows.Forms.ColumnHeader descriptionHeader;
        private System.Windows.Forms.ContextMenuStrip appInstallMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem installToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visitWebsiteToolStripMenuItem;

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar;
        private System.Windows.Forms.ImageList imageListX;
        private System.Windows.Forms.TextBox descriptionTextBox;

    }
}