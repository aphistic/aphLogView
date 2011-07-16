using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using aphLogView.Properties;
using aphLogView.Shared.Configuration;
using aphLogView.Shared.LogSources;

namespace aphLogView
{
    public partial class MainWindow : Form
    {
        private Dictionary<LogSource, LogWindow> _logWindows = new Dictionary<LogSource, LogWindow>();
        private Dictionary<LogSource, TabPage> _logPages = new Dictionary<LogSource, TabPage>();

        public MainWindow()
        {
            InitializeComponent();
            Config.Load();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            ReloadLogSources();
        }

        private void ReloadLogSources()
        {
            tvLogSources.Nodes.Clear();
            tvLogSources.Nodes.Add(LoadLogSourceGroup(Config.LogSources));

            if (tvLogSources.Nodes.Count > 0)
            {
                tvLogSources.Nodes[0].Expand();
            }
        }
        private TreeNode LoadLogSourceGroup(ILogSourceItem sourceItem)
        {
            var node = new TreeNode
                                {
                                    Text = sourceItem.Name,
                                    Tag = sourceItem
                                };
            if (sourceItem is LogSourceGroup)
            {
                var sourceGroup = (LogSourceGroup) sourceItem;
                foreach (var item in sourceGroup.Items)
                {
                    node.Nodes.Add(LoadLogSourceGroup(item));
                }
            }
            
            return node;
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            Config.Save();
        }

        private void tvLogSources_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
        }

        #region Log Windows
        private void DisplayLogSource(LogSource source)
        {
            if (_logPages.ContainsKey(source))
            {
                logTabs.SelectedTab = _logPages[source];
            }
            else
            {
                var logPage = new TabPage
                {
                    Text = source.Name,
                    Tag = source
                };
                _logPages.Add(source, logPage);
                logTabs.TabPages.Add(logPage);
            }
            if (_logWindows.ContainsKey(source))
            {
                _logWindows[source].Select();
            }
            else
            {
                var logWindow = new LogWindow {MdiParent = this};
                logWindow.LoadSource(source);
                logWindow.Closed += LogWindowClosed;
                _logWindows.Add(source, logWindow);
                logWindow.WindowState = FormWindowState.Maximized;
                logWindow.Show();    
            }

            logTabs.Visible = logTabs.TabCount > 0;
        }
        private void RemoveLogSource(LogSource source)
        {
            // Remove the pages and windows from the list
            // first so there isn't a stack overflow due
            // to a "close window" event infinite loop
            if (_logPages.ContainsKey(source))
            {
                var page = _logPages[source];
                _logPages.Remove(source);
                logTabs.TabPages.Remove(page);
            }
            if (_logWindows.ContainsKey(source))
            {
                var win = _logWindows[source];
                _logWindows.Remove(source);
                win.Close();
            }

            logTabs.Visible = logTabs.TabCount > 0;
        }
        private void LogWindowClosed(object sender, EventArgs e)
        {
            if (sender is LogWindow)
            {
                var logWin = (LogWindow) sender;
                RemoveLogSource(logWin.Source);
            }
        }
        private void MainWindow_MdiChildActivate(object sender, EventArgs e)
        {
            if (ActiveMdiChild is LogWindow)
            {
                var logWin = (LogWindow)ActiveMdiChild;
                if (logWin.Source != null)
                {
                    DisplayLogSource(logWin.Source);
                }
            }
        }
        private void logTabs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!_logPages.ContainsValue(logTabs.SelectedTab)) return;

            var source = (from src in _logPages
                          where src.Value == logTabs.SelectedTab
                          select src.Key).FirstOrDefault();
            if (source != null)
            {
                DisplayLogSource(source);
            }
        }
        #endregion

        #region Log Sources Tree
        private void tvLogSources_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                tvLogSources.SelectedNode = tvLogSources.GetNodeAt(e.X, e.Y);
            }
        }
        private void tvLogSources_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            var clickedNode = (ILogSourceItem) e.Node.Tag;

            if (clickedNode is LogSource)
            {
                DisplayLogSource((LogSource) clickedNode);
                
            }
        }
        private void tvLogSources_BeforeLabelEdit(object sender, NodeLabelEditEventArgs e)
        {
            var editItem = (ILogSourceItem) e.Node.Tag;
            if (editItem == null || editItem is LogSourceRoot)
            {
                e.CancelEdit = true;
            }
        }
        #endregion

        #region Log Sources Context Menu
        #region Group Options
        private void DisableLogSourceGroupOptions()
        {
            mnuLogSourceAddGroup.Enabled = false;
            mnuLogSourceRenameGroup.Enabled = false;
            mnuLogSourceRemoveGroup.Enabled = false;
        }
        private void EnableLogSourceGroupOptions()
        {
            mnuLogSourceAddGroup.Enabled = true;
            mnuLogSourceRenameGroup.Enabled = true;
            mnuLogSourceRemoveGroup.Enabled = true;
        }
        #endregion
        #region Source Options
        private void DisableLogSourceSourceOptions()
        {
            mnuLogSourceAddSource.Enabled = false;
            mnuLogSourceModifySource.Enabled = false;
            mnuLogSourceRemoveSource.Enabled = false;
        }
        private void EnableLogSourceSourceOptions()
        {
            mnuLogSourceAddSource.Enabled = true;
            mnuLogSourceModifySource.Enabled = true;
            mnuLogSourceRemoveSource.Enabled = true;
        }
        #endregion
        private void cmsManageLogs_Opening(object sender, CancelEventArgs e)
        {
            EnableLogSourceGroupOptions();
            EnableLogSourceSourceOptions();

            if (tvLogSources.SelectedNode != null)
            {
                var selectedItem = (ILogSourceItem) tvLogSources.SelectedNode.Tag;
                if (selectedItem == null)
                {
                    DisableLogSourceGroupOptions();
                    mnuLogSourceAddGroup.Enabled = true;

                    DisableLogSourceSourceOptions();
                    mnuLogSourceAddSource.Enabled = true;
                }
                else if (selectedItem is LogSourceGroup)
                {
                    EnableLogSourceGroupOptions();
                    
                    DisableLogSourceSourceOptions();
                    mnuLogSourceAddSource.Enabled = true;
                }
                else if (selectedItem is LogSource)
                {
                    DisableLogSourceGroupOptions();

                    EnableLogSourceSourceOptions();
                    mnuLogSourceAddSource.Enabled = false;
                }
            }
            else
            {
                e.Cancel = true;
            }
        }
        private void mnuLogSourceAddGroup_Click(object sender, EventArgs e)
        {
            if (tvLogSources.SelectedNode == null) return;

            var selectedItem = (ILogSourceItem) tvLogSources.SelectedNode.Tag;
            if (selectedItem != null && !(selectedItem is LogSourceGroup)) return;
            var selectedGroup = (LogSourceGroup) selectedItem;

            var newGroup = new LogSourceGroup
                               {
                                   Name = "New Group"
                               };
            selectedGroup.Items.Add(newGroup);

            var newNode = new TreeNode
                              {
                                  Text = newGroup.Name,
                                  Tag = newGroup
                              };
            tvLogSources.SelectedNode.Nodes.Add(newNode);
            tvLogSources.SelectedNode.Expand();
            tvLogSources.SelectedNode = newNode;
            newNode.BeginEdit();

            Config.Save();
        }
        private void mnuLogSourceRenameGroup_Click(object sender, EventArgs e)
        {
            if (tvLogSources.SelectedNode != null)
            {
                tvLogSources.SelectedNode.BeginEdit();
            }
        }
        private void mnuLogSourceRemoveGroup_Click(object sender, EventArgs e)
        {
            if (tvLogSources.SelectedNode != null)
            {
                if (MessageBox.Show(this, Resources.RemoveGroupConfirmation,
                                    Resources.RemoveGroupTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                                    MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    tvLogSources.SelectedNode.Remove();
                }
            }
        }
        private void mnuLogSourceAddSource_Click(object sender, EventArgs e)
        {
            if (tvLogSources.SelectedNode == null) return;

            var selectedItem = (ILogSourceItem) tvLogSources.SelectedNode.Tag;
            if (selectedItem != null && !(selectedItem is LogSourceGroup)) return;
            var selectedGroup = (LogSourceGroup) selectedItem;

            var winSource = new SourceWindow();
            if (winSource.ShowDialog(this) != DialogResult.OK) return;
            var newSource = winSource.GetSource();
            selectedGroup.Items.Add(newSource);

            var sourceNode = new TreeNode
                                 {
                                     Text = newSource.Name,
                                     Tag = newSource
                                 };


            tvLogSources.SelectedNode.Nodes.Add(sourceNode);
            tvLogSources.SelectedNode.Expand();

            Config.Save();
        }
        private void mnuLogSourceModifySource_Click(object sender, EventArgs e)
        {
            if (tvLogSources.SelectedNode == null) return;

            var selectedItem = (ILogSourceItem) tvLogSources.SelectedNode.Tag;
            if (!(selectedItem is LogSource)) return;
            var selectedSource = (LogSource) selectedItem;

            var sourceWindow = new SourceWindow();
            sourceWindow.LoadSource(selectedSource);

            if (sourceWindow.ShowDialog(this) == DialogResult.OK)
            {
                var updatedSource = sourceWindow.GetSource();
                selectedSource.Update(updatedSource);
            }
        }
        private void mnuLogSourceRemoveSource_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
