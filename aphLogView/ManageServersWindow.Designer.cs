namespace aphLogView
{
    partial class ManageServersWindow
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
            this.lstServerDetails = new System.Windows.Forms.ListBox();
            this.btnServerAdd = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtServerPassword = new System.Windows.Forms.TextBox();
            this.txtServerUser = new System.Windows.Forms.TextBox();
            this.txtServerHost = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtServerName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstServerDetails
            // 
            this.lstServerDetails.FormattingEnabled = true;
            this.lstServerDetails.Location = new System.Drawing.Point(12, 12);
            this.lstServerDetails.Name = "lstServerDetails";
            this.lstServerDetails.Size = new System.Drawing.Size(180, 173);
            this.lstServerDetails.TabIndex = 0;
            this.lstServerDetails.SelectedValueChanged += new System.EventHandler(this.lstServerDetails_SelectedValueChanged);
            // 
            // btnServerAdd
            // 
            this.btnServerAdd.Location = new System.Drawing.Point(12, 191);
            this.btnServerAdd.Name = "btnServerAdd";
            this.btnServerAdd.Size = new System.Drawing.Size(180, 23);
            this.btnServerAdd.TabIndex = 1;
            this.btnServerAdd.Text = "Add Server";
            this.btnServerAdd.UseVisualStyleBackColor = true;
            this.btnServerAdd.Click += new System.EventHandler(this.btnServerAdd_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(134, 123);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 2;
            this.btnConfirm.Text = "Update";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(215, 123);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtServerPassword);
            this.groupBox1.Controls.Add(this.txtServerUser);
            this.groupBox1.Controls.Add(this.txtServerHost);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtServerName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnConfirm);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Location = new System.Drawing.Point(198, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(305, 173);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Server Details";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Username:";
            // 
            // txtServerPassword
            // 
            this.txtServerPassword.Location = new System.Drawing.Point(70, 97);
            this.txtServerPassword.Name = "txtServerPassword";
            this.txtServerPassword.PasswordChar = '*';
            this.txtServerPassword.Size = new System.Drawing.Size(220, 20);
            this.txtServerPassword.TabIndex = 9;
            // 
            // txtServerUser
            // 
            this.txtServerUser.Location = new System.Drawing.Point(70, 71);
            this.txtServerUser.Name = "txtServerUser";
            this.txtServerUser.Size = new System.Drawing.Size(220, 20);
            this.txtServerUser.TabIndex = 8;
            // 
            // txtServerHost
            // 
            this.txtServerHost.Location = new System.Drawing.Point(70, 45);
            this.txtServerHost.Name = "txtServerHost";
            this.txtServerHost.Size = new System.Drawing.Size(220, 20);
            this.txtServerHost.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Hostname:";
            // 
            // txtServerName
            // 
            this.txtServerName.Location = new System.Drawing.Point(70, 19);
            this.txtServerName.Name = "txtServerName";
            this.txtServerName.Size = new System.Drawing.Size(220, 20);
            this.txtServerName.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name:";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(428, 191);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ManageServersWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 229);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnServerAdd);
            this.Controls.Add(this.lstServerDetails);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ManageServersWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Manage Servers";
            this.Load += new System.EventHandler(this.ManageServersWindow_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstServerDetails;
        private System.Windows.Forms.Button btnServerAdd;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtServerName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtServerPassword;
        private System.Windows.Forms.TextBox txtServerUser;
        private System.Windows.Forms.TextBox txtServerHost;
        private System.Windows.Forms.Label label2;

    }
}