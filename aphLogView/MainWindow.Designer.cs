namespace aphLogView
{
    partial class MainWindow
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tvLogSources = new System.Windows.Forms.TreeView();
            this.cmsManageLogs = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuLogSourceAddGroup = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLogSourceRenameGroup = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLogSourceRemoveGroup = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuLogSourceAddSource = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLogSourceModifySource = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLogSourceRemoveSource = new System.Windows.Forms.ToolStripMenuItem();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.logTabs = new System.Windows.Forms.TabControl();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.cmsManageLogs.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(924, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 518);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(924, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // tvLogSources
            // 
            this.tvLogSources.ContextMenuStrip = this.cmsManageLogs;
            this.tvLogSources.Dock = System.Windows.Forms.DockStyle.Left;
            this.tvLogSources.LabelEdit = true;
            this.tvLogSources.Location = new System.Drawing.Point(0, 24);
            this.tvLogSources.Name = "tvLogSources";
            this.tvLogSources.Size = new System.Drawing.Size(235, 494);
            this.tvLogSources.TabIndex = 3;
            this.tvLogSources.BeforeLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.tvLogSources_BeforeLabelEdit);
            this.tvLogSources.BeforeSelect += new System.Windows.Forms.TreeViewCancelEventHandler(this.tvLogSources_BeforeSelect);
            this.tvLogSources.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvLogSources_NodeMouseDoubleClick);
            this.tvLogSources.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tvLogSources_MouseDown);
            // 
            // cmsManageLogs
            // 
            this.cmsManageLogs.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuLogSourceAddSource,
            this.mnuLogSourceModifySource,
            this.mnuLogSourceRemoveSource,
            this.toolStripSeparator1,
            this.mnuLogSourceAddGroup,
            this.mnuLogSourceRenameGroup,
            this.mnuLogSourceRemoveGroup});
            this.cmsManageLogs.Name = "cmsManageLogs";
            this.cmsManageLogs.Size = new System.Drawing.Size(184, 142);
            this.cmsManageLogs.Opening += new System.ComponentModel.CancelEventHandler(this.cmsManageLogs_Opening);
            // 
            // mnuLogSourceAddGroup
            // 
            this.mnuLogSourceAddGroup.Name = "mnuLogSourceAddGroup";
            this.mnuLogSourceAddGroup.Size = new System.Drawing.Size(183, 22);
            this.mnuLogSourceAddGroup.Text = "Add Group";
            this.mnuLogSourceAddGroup.Click += new System.EventHandler(this.mnuLogSourceAddGroup_Click);
            // 
            // mnuLogSourceRenameGroup
            // 
            this.mnuLogSourceRenameGroup.Name = "mnuLogSourceRenameGroup";
            this.mnuLogSourceRenameGroup.Size = new System.Drawing.Size(183, 22);
            this.mnuLogSourceRenameGroup.Text = "Rename Group";
            this.mnuLogSourceRenameGroup.Click += new System.EventHandler(this.mnuLogSourceRenameGroup_Click);
            // 
            // mnuLogSourceRemoveGroup
            // 
            this.mnuLogSourceRemoveGroup.Name = "mnuLogSourceRemoveGroup";
            this.mnuLogSourceRemoveGroup.Size = new System.Drawing.Size(183, 22);
            this.mnuLogSourceRemoveGroup.Text = "Remove Group";
            this.mnuLogSourceRemoveGroup.Click += new System.EventHandler(this.mnuLogSourceRemoveGroup_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(180, 6);
            // 
            // mnuLogSourceAddSource
            // 
            this.mnuLogSourceAddSource.Name = "mnuLogSourceAddSource";
            this.mnuLogSourceAddSource.Size = new System.Drawing.Size(183, 22);
            this.mnuLogSourceAddSource.Text = "Add Log Source...";
            this.mnuLogSourceAddSource.Click += new System.EventHandler(this.mnuLogSourceAddSource_Click);
            // 
            // mnuLogSourceModifySource
            // 
            this.mnuLogSourceModifySource.Name = "mnuLogSourceModifySource";
            this.mnuLogSourceModifySource.Size = new System.Drawing.Size(183, 22);
            this.mnuLogSourceModifySource.Text = "Modify Log Source...";
            this.mnuLogSourceModifySource.Click += new System.EventHandler(this.mnuLogSourceModifySource_Click);
            // 
            // mnuLogSourceRemoveSource
            // 
            this.mnuLogSourceRemoveSource.Name = "mnuLogSourceRemoveSource";
            this.mnuLogSourceRemoveSource.Size = new System.Drawing.Size(183, 22);
            this.mnuLogSourceRemoveSource.Text = "Remove Log Source";
            this.mnuLogSourceRemoveSource.Click += new System.EventHandler(this.mnuLogSourceRemoveSource_Click);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(235, 24);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 494);
            this.splitter1.TabIndex = 4;
            this.splitter1.TabStop = false;
            // 
            // logTabs
            // 
            this.logTabs.Dock = System.Windows.Forms.DockStyle.Top;
            this.logTabs.Location = new System.Drawing.Point(238, 24);
            this.logTabs.Name = "logTabs";
            this.logTabs.SelectedIndex = 0;
            this.logTabs.Size = new System.Drawing.Size(686, 22);
            this.logTabs.TabIndex = 6;
            this.logTabs.Visible = false;
            this.logTabs.SelectedIndexChanged += new System.EventHandler(this.logTabs_SelectedIndexChanged);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 540);
            this.Controls.Add(this.logTabs);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.tvLogSources);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "aphLogView";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.MdiChildActivate += new System.EventHandler(this.MainWindow_MdiChildActivate);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.cmsManageLogs.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.TreeView tvLogSources;
        private System.Windows.Forms.ContextMenuStrip cmsManageLogs;
        private System.Windows.Forms.ToolStripMenuItem mnuLogSourceAddSource;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.ToolStripMenuItem mnuLogSourceAddGroup;
        private System.Windows.Forms.ToolStripMenuItem mnuLogSourceRenameGroup;
        private System.Windows.Forms.ToolStripMenuItem mnuLogSourceRemoveGroup;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnuLogSourceModifySource;
        private System.Windows.Forms.ToolStripMenuItem mnuLogSourceRemoveSource;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.TabControl logTabs;

    }
}

