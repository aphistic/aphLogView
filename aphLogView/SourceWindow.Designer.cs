namespace aphLogView
{
    partial class SourceWindow
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.ddlSourceServer = new System.Windows.Forms.ComboBox();
            this.btnServerManage = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSourceName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ddlSourceDatabase = new System.Windows.Forms.ComboBox();
            this.ddlSourceTable = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(285, 138);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(204, 138);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 1;
            this.btnConfirm.Text = "Create";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // ddlSourceServer
            // 
            this.ddlSourceServer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlSourceServer.FormattingEnabled = true;
            this.ddlSourceServer.Location = new System.Drawing.Point(74, 38);
            this.ddlSourceServer.Name = "ddlSourceServer";
            this.ddlSourceServer.Size = new System.Drawing.Size(205, 21);
            this.ddlSourceServer.TabIndex = 2;
            this.ddlSourceServer.SelectedIndexChanged += new System.EventHandler(this.ddlSourceServer_SelectedIndexChanged);
            // 
            // btnServerManage
            // 
            this.btnServerManage.Location = new System.Drawing.Point(285, 36);
            this.btnServerManage.Name = "btnServerManage";
            this.btnServerManage.Size = new System.Drawing.Size(75, 23);
            this.btnServerManage.TabIndex = 3;
            this.btnServerManage.Text = "Manage...";
            this.btnServerManage.UseVisualStyleBackColor = true;
            this.btnServerManage.Click += new System.EventHandler(this.btnServerManage_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Server:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Name:";
            // 
            // txtSourceName
            // 
            this.txtSourceName.Location = new System.Drawing.Point(74, 12);
            this.txtSourceName.Name = "txtSourceName";
            this.txtSourceName.Size = new System.Drawing.Size(286, 20);
            this.txtSourceName.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Database:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Table:";
            // 
            // ddlSourceDatabase
            // 
            this.ddlSourceDatabase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlSourceDatabase.FormattingEnabled = true;
            this.ddlSourceDatabase.Location = new System.Drawing.Point(74, 65);
            this.ddlSourceDatabase.Name = "ddlSourceDatabase";
            this.ddlSourceDatabase.Size = new System.Drawing.Size(286, 21);
            this.ddlSourceDatabase.TabIndex = 9;
            this.ddlSourceDatabase.DropDown += new System.EventHandler(this.ddlSourceDatabase_DropDown);
            this.ddlSourceDatabase.SelectedIndexChanged += new System.EventHandler(this.ddlSourceDatabase_SelectedIndexChanged);
            // 
            // ddlSourceTable
            // 
            this.ddlSourceTable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlSourceTable.FormattingEnabled = true;
            this.ddlSourceTable.Location = new System.Drawing.Point(74, 92);
            this.ddlSourceTable.Name = "ddlSourceTable";
            this.ddlSourceTable.Size = new System.Drawing.Size(286, 21);
            this.ddlSourceTable.TabIndex = 10;
            this.ddlSourceTable.DropDown += new System.EventHandler(this.ddlSourceTable_DropDown);
            // 
            // SourceWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 177);
            this.Controls.Add(this.ddlSourceTable);
            this.Controls.Add(this.ddlSourceDatabase);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSourceName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnServerManage);
            this.Controls.Add(this.ddlSourceServer);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SourceWindow";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Log Source";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.ComboBox ddlSourceServer;
        private System.Windows.Forms.Button btnServerManage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSourceName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ddlSourceDatabase;
        private System.Windows.Forms.ComboBox ddlSourceTable;
    }
}