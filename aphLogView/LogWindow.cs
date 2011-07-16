using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using aphLogView.Shared.Configuration;
using aphLogView.Shared.Data;
using aphLogView.Shared.LogSources;

namespace aphLogView
{
    public partial class LogWindow : Form
    {
        private Timer _refreshTimer;
        private DataConnection _conn;

        private LogSource _source = null;
        public LogSource Source
        {
            get { return _source; }
        }

        public LogWindow()
        {
            InitializeComponent();

            _refreshTimer = new Timer {Interval = Config.RefreshTime*1000};
            _refreshTimer.Tick += new EventHandler(RefreshTimerTick);
        }

        ~LogWindow()
        {
            _refreshTimer.Stop();
            if (_conn != null)
            {
                _conn.Dispose();
            }
        }

        void RefreshTimerTick(object sender, EventArgs e)
        {
            if (_conn == null) return;

            RefreshLogView();
        }

        private void RefreshLogView()
        {
            dgvLogEntries.DataSource = _conn.GetLatestEntries(Config.LogHistory);
        }

        public void LoadSource(LogSource source)
        {
            _source = source;

            Text = source.Name;

            _conn = new DataConnection
                        {
                            Host = _source.Server.Host,
                            Username = _source.Server.Username,
                            Password = _source.Server.Password,
                            Database = _source.Database,
                            Table = _source.Table
                        };
            _conn.Open();

            RefreshLogView();

            _refreshTimer.Start();
        }

        private void dgvLogEntries_SelectionChanged(object sender, EventArgs e)
        {
            if (sender is DataGridView)
            {
                var dgv = (DataGridView) sender;
                if (dgv.SelectedRows.Count > 0)
                {
                    var item = (LogEntry) dgv.SelectedRows[0].DataBoundItem;

                    lblDate.Text = item.Date.ToString();
                    lblLogger.Text = item.Logger;
                    lblLevel.Text = item.Level.ToString();
                    lblThread.Text = item.Thread;

                    txtMessage.Text = item.Message;
                    txtException.Text = item.Exception;
                }
            }
        }

        private void txtMessage_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtException_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void dgvLogEntries_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            var dgv = (DataGridView)sender;

            if (e.RowIndex >= 0)
            {
                var row = dgv.Rows[e.RowIndex];
                var item = (LogEntry)row.DataBoundItem;
                if (item != null)
                {
                    row.DefaultCellStyle.SelectionBackColor = LogLevelHelper.GetLogLevelColor(item.Level);
                    row.DefaultCellStyle.BackColor = LogLevelHelper.GetLogLevelColor(item.Level);
                }
            }
        }
    }
}
