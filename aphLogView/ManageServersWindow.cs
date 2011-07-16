using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using aphLogView.Shared.Configuration;
using aphLogView.Shared.Servers;

namespace aphLogView
{
    public partial class ManageServersWindow : Form
    {
        protected Server CurrentServer
        {
            get { return (Server) lstServerDetails.SelectedItem; }
        }
        protected BindingList<Server> Servers { get; set; }

        public ManageServersWindow()
        {
            InitializeComponent();
            Servers = new BindingList<Server>();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            SetFormState(false);
            ClearForm();

            lstServerDetails.ClearSelected();
        }

        public void ClearForm()
        {
            txtServerName.Text = "";
            txtServerHost.Text = "";
            txtServerUser.Text = "";
            txtServerPassword.Text = "";
        }

        private void SetFormState(bool enabled)
        {
            txtServerName.Enabled = enabled;
            txtServerHost.Enabled = enabled;
            txtServerUser.Enabled = enabled;
            txtServerPassword.Enabled = enabled;

            btnConfirm.Enabled = enabled;
            btnCancel.Enabled = enabled;
        }

        private void SetFormValues(Server details)
        {
            if (details != null)
            {
                txtServerName.Text = details.Name;
                txtServerHost.Text = details.Host;
                txtServerUser.Text = details.Username;
                txtServerPassword.Text = details.Password;
            }
            else
            {
                ClearForm();
                SetFormState(false);
            }
        }

        private void ManageServersWindow_Load(object sender, EventArgs e)
        {
            SetFormState(false);

            lstServerDetails.DisplayMember = "Name";
            lstServerDetails.DataSource = Servers;

            RebindServerList();
        }

        private void RebindServerList()
        {
            Servers.Clear();
            Config.SortServers();
            foreach (var details in Config.Servers)
            {
                Servers.Add(details);
            }
        }

        private void btnServerAdd_Click(object sender, EventArgs e)
        {
            var newDetails = new Server();

            int idx = 1;
            do
            {
                newDetails.Name = string.Format("Unnamed Server {0}", idx);
                idx++;
            } while (Config.GetServerDetails(newDetails.Name) != null);

            Config.AddServer(newDetails);
            RebindServerList();
            lstServerDetails.SelectedItem = newDetails;

            SetFormValues(newDetails);
            SetFormState(true);

            txtServerName.Select();
            txtServerName.SelectAll();
        }

        private void lstServerDetails_SelectedValueChanged(object sender, EventArgs e)
        {
            SetFormState(true);
            SetFormValues(CurrentServer);
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (CurrentServer != null)
            {
                var updatedItem = CurrentServer;
                CurrentServer.Name = txtServerName.Text;
                CurrentServer.Host = txtServerHost.Text;
                CurrentServer.Username = txtServerUser.Text;
                CurrentServer.Password = txtServerPassword.Text;

                RebindServerList();

                lstServerDetails.SelectedItem = updatedItem;
                SetFormValues(CurrentServer);
                SetFormState(true);
            }
            else
            {
                ClearForm();
                SetFormState(false);
                lstServerDetails.ClearSelected();
            }
        }
    }
}
