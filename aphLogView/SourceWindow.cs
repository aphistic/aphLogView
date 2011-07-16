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
using aphLogView.Shared.Data;
using aphLogView.Shared.LogSources;
using aphLogView.Shared.Servers;

namespace aphLogView
{
    public partial class SourceWindow : Form
    {
        private LogSource _source = null;
        private readonly BindingList<Server> _servers = new BindingList<Server>();

        private bool _serverChanged = false;
        private bool _databaseChanged = false;

        public SourceWindow()
        {
            InitializeComponent();

            ddlSourceServer.DisplayMember = "Name";
            ddlSourceServer.DataSource = _servers;
        }

        public void LoadSource(LogSource source)
        {
            btnConfirm.Text = Resources.Button_Update;
            _source = source;

            RefreshSource();
        }
        public LogSource GetSource()
        {
            var windowSource = new LogSource
                                   {
                                       Name = txtSourceName.Text,
                                       Server = (Server) ddlSourceServer.SelectedItem,
                                       Database = (string) ddlSourceDatabase.SelectedItem,
                                       Table = (string) ddlSourceTable.SelectedItem
                                   };
            return windowSource;
        }

        private void RefreshSource()
        {
            if (_source != null)
            {
                txtSourceName.Text = _source.Name;

                RefreshServerList();
                ddlSourceServer.SelectedItem = _source.Server;
                _serverChanged = false;

                RefreshDatabaseList();
                ddlSourceDatabase.SelectedItem = _source.Database;
                _databaseChanged = false;

                RefreshTableList();
                ddlSourceTable.SelectedItem = _source.Table;
            }
        }

        private void RefreshServerList()
        {
            var selected = (Server) ddlSourceServer.SelectedItem;

            Config.SortServers();

            _servers.Clear();
            foreach (var server in Config.Servers)
            {
                _servers.Add(server);
            }

            ddlSourceServer.SelectedItem = selected;
        }
        private void RefreshDatabaseList()
        {
            var server = (Server) ddlSourceServer.SelectedItem;
            if (server != null)
            {
                using (var db = new DataConnection
                                    {
                                        Host = server.Host,
                                        Username = server.Username,
                                        Password = server.Password
                                    })
                {
                    try
                    {
                        db.Open();

                        ddlSourceDatabase.DataSource = null;
                        ddlSourceDatabase.DataSource = db.GetDatabases();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(this, string.Format("Error connecting to server:\n{0}", ex.Message),
                                        "Unable To Connect", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
        }

        private void RefreshTableList()
        {
            var databaseName = (string) ddlSourceDatabase.SelectedItem;
            var server = (Server) ddlSourceServer.SelectedItem;
            if (server != null && !string.IsNullOrEmpty(databaseName))
            {
                using (var db = new DataConnection
                                    {
                                        Host = server.Host,
                                        Username = server.Username,
                                        Password = server.Password,
                                        Database = databaseName
                                    })
                {
                    try
                    {
                        db.Open();

                        ddlSourceTable.DataSource = null;
                        ddlSourceTable.DataSource = db.GetTables();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(this, string.Format("Error connecting to server:\n{0}", ex.Message),
                                        "Unable To Connect", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
        }

        private void ClearDatabaseSelection()
        {
            ddlSourceDatabase.DataSource = null;
            ClearTableSelection();
        }
        private void ClearTableSelection()
        {
            ddlSourceTable.DataSource = null;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSourceName.Text))
            {
                MessageBox.Show(this, Resources.SourceWindow_Warning_EnterName,
                    Resources.SourceWindow_Warning_Title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnServerManage_Click(object sender, EventArgs e)
        {
            var serversWindow = new ManageServersWindow();
            serversWindow.ShowDialog(this);

            RefreshServerList();
            RefreshSource();
        }

        private void ddlSourceDatabase_DropDown(object sender, EventArgs e)
        {
            if (ddlSourceServer.SelectedItem == null)
            {
                ddlSourceDatabase.DataSource = null;
                ddlSourceDatabase.Items.Clear();
                return;
            }

            if (_serverChanged)
            {
                RefreshDatabaseList();
                ddlSourceDatabase.SelectedIndex = -1;

                _serverChanged = false;
            }
        }

        private void ddlSourceServer_SelectedIndexChanged(object sender, EventArgs e)
        {
            _serverChanged = true;
            ClearDatabaseSelection();
        }

        private void ddlSourceDatabase_SelectedIndexChanged(object sender, EventArgs e)
        {
            _databaseChanged = true;
            ClearTableSelection();
        }

        private void ddlSourceTable_DropDown(object sender, EventArgs e)
        {
            var databaseName = (string) ddlSourceDatabase.SelectedItem;
            if (string.IsNullOrEmpty(databaseName))
            {
                ddlSourceTable.DataSource = null;
                ddlSourceTable.Items.Clear();
                return;
            }

            if (_databaseChanged)
            {
                RefreshTableList();
                ddlSourceTable.SelectedIndex = -1;

                _databaseChanged = false;
            }
        }
    }
}
