namespace aphLogView
{
    partial class LogWindow
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgvLogEntries = new System.Windows.Forms.DataGridView();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thread = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Logger = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Level = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Message = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Exception = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblLogger = new System.Windows.Forms.Label();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.txtException = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblLevel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblThread = new System.Windows.Forms.Label();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogEntries)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(821, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 25);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dgvLogEntries);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(821, 533);
            this.splitContainer1.SplitterDistance = 235;
            this.splitContainer1.TabIndex = 1;
            // 
            // dgvLogEntries
            // 
            this.dgvLogEntries.AllowUserToAddRows = false;
            this.dgvLogEntries.AllowUserToDeleteRows = false;
            this.dgvLogEntries.AllowUserToResizeRows = false;
            this.dgvLogEntries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLogEntries.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date,
            this.Thread,
            this.Logger,
            this.Level,
            this.Message,
            this.Exception});
            this.dgvLogEntries.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLogEntries.Location = new System.Drawing.Point(0, 0);
            this.dgvLogEntries.MultiSelect = false;
            this.dgvLogEntries.Name = "dgvLogEntries";
            this.dgvLogEntries.ReadOnly = true;
            this.dgvLogEntries.RowHeadersVisible = false;
            this.dgvLogEntries.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLogEntries.Size = new System.Drawing.Size(821, 235);
            this.dgvLogEntries.TabIndex = 0;
            this.dgvLogEntries.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvLogEntries_CellFormatting);
            this.dgvLogEntries.SelectionChanged += new System.EventHandler(this.dgvLogEntries_SelectionChanged);
            // 
            // Date
            // 
            this.Date.DataPropertyName = "Date";
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Width = 110;
            // 
            // Thread
            // 
            this.Thread.DataPropertyName = "Thread";
            this.Thread.HeaderText = "Thread";
            this.Thread.Name = "Thread";
            this.Thread.ReadOnly = true;
            this.Thread.Width = 50;
            // 
            // Logger
            // 
            this.Logger.DataPropertyName = "Logger";
            this.Logger.HeaderText = "Logger";
            this.Logger.MinimumWidth = 15;
            this.Logger.Name = "Logger";
            this.Logger.ReadOnly = true;
            // 
            // Level
            // 
            this.Level.DataPropertyName = "Level";
            this.Level.FillWeight = 75F;
            this.Level.HeaderText = "Level";
            this.Level.Name = "Level";
            this.Level.ReadOnly = true;
            this.Level.Width = 75;
            // 
            // Message
            // 
            this.Message.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Message.DataPropertyName = "Message";
            this.Message.FillWeight = 1000F;
            this.Message.HeaderText = "Message";
            this.Message.Name = "Message";
            this.Message.ReadOnly = true;
            // 
            // Exception
            // 
            this.Exception.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Exception.DataPropertyName = "Exception";
            this.Exception.FillWeight = 1000F;
            this.Exception.HeaderText = "Exception";
            this.Exception.Name = "Exception";
            this.Exception.ReadOnly = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer2.Panel1MinSize = 250;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer2.Size = new System.Drawing.Size(821, 294);
            this.splitContainer2.SplitterDistance = 250;
            this.splitContainer2.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblDate, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblLogger, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblLevel, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblThread, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(250, 294);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Date:";
            // 
            // lblDate
            // 
            this.lblDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(58, 5);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(53, 13);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "Item Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Logger:";
            // 
            // lblLogger
            // 
            this.lblLogger.AutoSize = true;
            this.lblLogger.Location = new System.Drawing.Point(58, 18);
            this.lblLogger.Name = "lblLogger";
            this.lblLogger.Size = new System.Drawing.Size(63, 13);
            this.lblLogger.TabIndex = 3;
            this.lblLogger.Text = "Item Logger";
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.txtMessage);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.txtException);
            this.splitContainer3.Size = new System.Drawing.Size(567, 294);
            this.splitContainer3.SplitterDistance = 138;
            this.splitContainer3.TabIndex = 0;
            // 
            // txtMessage
            // 
            this.txtMessage.AcceptsReturn = true;
            this.txtMessage.AcceptsTab = true;
            this.txtMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMessage.Location = new System.Drawing.Point(0, 0);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtMessage.Size = new System.Drawing.Size(567, 138);
            this.txtMessage.TabIndex = 0;
            this.txtMessage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMessage_KeyPress);
            // 
            // txtException
            // 
            this.txtException.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtException.Location = new System.Drawing.Point(0, 0);
            this.txtException.Multiline = true;
            this.txtException.Name = "txtException";
            this.txtException.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtException.Size = new System.Drawing.Size(567, 152);
            this.txtException.TabIndex = 0;
            this.txtException.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtException_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Level:";
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Location = new System.Drawing.Point(58, 31);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(56, 13);
            this.lblLevel.TabIndex = 5;
            this.lblLevel.Text = "Item Level";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Thread:";
            // 
            // lblThread
            // 
            this.lblThread.AutoSize = true;
            this.lblThread.Location = new System.Drawing.Point(58, 44);
            this.lblThread.Name = "lblThread";
            this.lblThread.Size = new System.Drawing.Size(64, 13);
            this.lblThread.TabIndex = 7;
            this.lblThread.Text = "Item Thread";
            // 
            // LogWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 558);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "LogWindow";
            this.Text = "LogWindow";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogEntries)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.Panel2.PerformLayout();
            this.splitContainer3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgvLogEntries;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.TextBox txtException;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblLogger;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thread;
        private System.Windows.Forms.DataGridViewTextBoxColumn Logger;
        private System.Windows.Forms.DataGridViewTextBoxColumn Level;
        private System.Windows.Forms.DataGridViewTextBoxColumn Message;
        private System.Windows.Forms.DataGridViewTextBoxColumn Exception;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblThread;
    }
}