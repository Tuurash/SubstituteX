namespace SubstituteX_preAlpha_V1
{
    partial class Index
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Index));
            this.metroUserControl1 = new MetroFramework.Controls.MetroUserControl();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.chkHasPass = new MetroFramework.Controls.MetroCheckBox();
            this.btnBrowse = new MetroFramework.Controls.MetroButton();
            this.txtBrowse = new MetroFramework.Controls.MetroTextBox();
            this.btnScheduler = new MetroFramework.Controls.MetroButton();
            this.PanelSecheduler = new MetroFramework.Controls.MetroPanel();
            this.lblSchedulerStatus = new System.Windows.Forms.Label();
            this.btnStopSchedule = new MetroFramework.Controls.MetroButton();
            this.btnStartSchedule = new MetroFramework.Controls.MetroButton();
            this.lblSetTimer = new System.Windows.Forms.Label();
            this.txtInterval = new System.Windows.Forms.TextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtCustomString = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnBackup = new System.Windows.Forms.Button();
            this.txtDBName = new MetroFramework.Controls.MetroTextBox();
            this.txtServerName = new MetroFramework.Controls.MetroTextBox();
            this.lblServerName = new MetroFramework.Controls.MetroLabel();
            this.BackupTimer = new System.Windows.Forms.Timer(this.components);
            this.PanelAuthentication = new MetroFramework.Controls.MetroPanel();
            this.lblPassword = new MetroFramework.Controls.MetroLabel();
            this.txtPass = new MetroFramework.Controls.MetroTextBox();
            this.txtUserName = new MetroFramework.Controls.MetroTextBox();
            this.lblUserName = new MetroFramework.Controls.MetroLabel();
            this.btnClose = new MetroFramework.Controls.MetroButton();
            this.btnConnect = new MetroFramework.Controls.MetroButton();
            this.metroPanel1.SuspendLayout();
            this.PanelSecheduler.SuspendLayout();
            this.PanelAuthentication.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroUserControl1
            // 
            this.metroUserControl1.Location = new System.Drawing.Point(614, 412);
            this.metroUserControl1.Name = "metroUserControl1";
            this.metroUserControl1.Size = new System.Drawing.Size(150, 150);
            this.metroUserControl1.TabIndex = 0;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.PanelAuthentication);
            this.metroPanel1.Controls.Add(this.chkHasPass);
            this.metroPanel1.Controls.Add(this.btnBrowse);
            this.metroPanel1.Controls.Add(this.txtBrowse);
            this.metroPanel1.Controls.Add(this.btnScheduler);
            this.metroPanel1.Controls.Add(this.PanelSecheduler);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.txtCustomString);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.Controls.Add(this.btnBackup);
            this.metroPanel1.Controls.Add(this.txtDBName);
            this.metroPanel1.Controls.Add(this.txtServerName);
            this.metroPanel1.Controls.Add(this.lblServerName);
            this.metroPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(23, 37);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(481, 456);
            this.metroPanel1.TabIndex = 1;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // chkHasPass
            // 
            this.chkHasPass.AutoSize = true;
            this.chkHasPass.Location = new System.Drawing.Point(335, 151);
            this.chkHasPass.Name = "chkHasPass";
            this.chkHasPass.Size = new System.Drawing.Size(126, 15);
            this.chkHasPass.TabIndex = 16;
            this.chkHasPass.Text = "SQL Authentication";
            this.chkHasPass.UseVisualStyleBackColor = true;
            this.chkHasPass.CheckedChanged += new System.EventHandler(this.chkHasPass_CheckedChanged);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(346, 229);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(83, 23);
            this.btnBrowse.TabIndex = 15;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtBrowse
            // 
            this.txtBrowse.Location = new System.Drawing.Point(71, 229);
            this.txtBrowse.Name = "txtBrowse";
            this.txtBrowse.Size = new System.Drawing.Size(269, 23);
            this.txtBrowse.TabIndex = 14;
            // 
            // btnScheduler
            // 
            this.btnScheduler.Location = new System.Drawing.Point(71, 300);
            this.btnScheduler.Name = "btnScheduler";
            this.btnScheduler.Size = new System.Drawing.Size(93, 45);
            this.btnScheduler.TabIndex = 13;
            this.btnScheduler.Text = "Schedule \r\nAuto Backup";
            this.btnScheduler.Click += new System.EventHandler(this.btnScheduler_Click);
            // 
            // PanelSecheduler
            // 
            this.PanelSecheduler.Controls.Add(this.lblSchedulerStatus);
            this.PanelSecheduler.Controls.Add(this.btnStopSchedule);
            this.PanelSecheduler.Controls.Add(this.btnStartSchedule);
            this.PanelSecheduler.Controls.Add(this.lblSetTimer);
            this.PanelSecheduler.Controls.Add(this.txtInterval);
            this.PanelSecheduler.HorizontalScrollbarBarColor = true;
            this.PanelSecheduler.HorizontalScrollbarHighlightOnWheel = false;
            this.PanelSecheduler.HorizontalScrollbarSize = 10;
            this.PanelSecheduler.Location = new System.Drawing.Point(170, 300);
            this.PanelSecheduler.Name = "PanelSecheduler";
            this.PanelSecheduler.Size = new System.Drawing.Size(259, 100);
            this.PanelSecheduler.TabIndex = 12;
            this.PanelSecheduler.VerticalScrollbarBarColor = true;
            this.PanelSecheduler.VerticalScrollbarHighlightOnWheel = false;
            this.PanelSecheduler.VerticalScrollbarSize = 10;
            // 
            // lblSchedulerStatus
            // 
            this.lblSchedulerStatus.AutoSize = true;
            this.lblSchedulerStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblSchedulerStatus.Location = new System.Drawing.Point(12, 77);
            this.lblSchedulerStatus.Name = "lblSchedulerStatus";
            this.lblSchedulerStatus.Size = new System.Drawing.Size(0, 13);
            this.lblSchedulerStatus.TabIndex = 6;
            // 
            // btnStopSchedule
            // 
            this.btnStopSchedule.Location = new System.Drawing.Point(163, 52);
            this.btnStopSchedule.Name = "btnStopSchedule";
            this.btnStopSchedule.Size = new System.Drawing.Size(44, 23);
            this.btnStopSchedule.TabIndex = 5;
            this.btnStopSchedule.Text = "Stop";
            this.btnStopSchedule.Click += new System.EventHandler(this.btnStopSchedule_Click);
            // 
            // btnStartSchedule
            // 
            this.btnStartSchedule.Location = new System.Drawing.Point(102, 52);
            this.btnStartSchedule.Name = "btnStartSchedule";
            this.btnStartSchedule.Size = new System.Drawing.Size(44, 23);
            this.btnStartSchedule.TabIndex = 4;
            this.btnStartSchedule.Text = "Start";
            this.btnStartSchedule.Click += new System.EventHandler(this.btnStartSchedule_Click);
            // 
            // lblSetTimer
            // 
            this.lblSetTimer.AutoSize = true;
            this.lblSetTimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSetTimer.Location = new System.Drawing.Point(26, 28);
            this.lblSetTimer.Name = "lblSetTimer";
            this.lblSetTimer.Size = new System.Drawing.Size(61, 13);
            this.lblSetTimer.TabIndex = 3;
            this.lblSetTimer.Text = "Set Interval";
            this.lblSetTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtInterval
            // 
            this.txtInterval.Location = new System.Drawing.Point(102, 25);
            this.txtInterval.Name = "txtInterval";
            this.txtInterval.Size = new System.Drawing.Size(105, 20);
            this.txtInterval.TabIndex = 2;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(71, 159);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(125, 25);
            this.metroLabel2.TabIndex = 10;
            this.metroLabel2.Text = "Custom String";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCustomString
            // 
            this.txtCustomString.Location = new System.Drawing.Point(73, 187);
            this.txtCustomString.Name = "txtCustomString";
            this.txtCustomString.Size = new System.Drawing.Size(358, 23);
            this.txtCustomString.TabIndex = 9;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(73, 120);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(85, 25);
            this.metroLabel1.TabIndex = 8;
            this.metroLabel1.Text = "DataBase";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBackup
            // 
            this.btnBackup.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnBackup.Location = new System.Drawing.Point(322, 300);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(107, 41);
            this.btnBackup.TabIndex = 7;
            this.btnBackup.Text = "Backup";
            this.btnBackup.UseVisualStyleBackColor = true;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // txtDBName
            // 
            this.txtDBName.Location = new System.Drawing.Point(199, 122);
            this.txtDBName.Name = "txtDBName";
            this.txtDBName.Size = new System.Drawing.Size(232, 23);
            this.txtDBName.TabIndex = 5;
            // 
            // txtServerName
            // 
            this.txtServerName.Location = new System.Drawing.Point(199, 74);
            this.txtServerName.Name = "txtServerName";
            this.txtServerName.Size = new System.Drawing.Size(232, 23);
            this.txtServerName.TabIndex = 4;
            // 
            // lblServerName
            // 
            this.lblServerName.AutoSize = true;
            this.lblServerName.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblServerName.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblServerName.Location = new System.Drawing.Point(73, 72);
            this.lblServerName.Name = "lblServerName";
            this.lblServerName.Size = new System.Drawing.Size(61, 25);
            this.lblServerName.TabIndex = 2;
            this.lblServerName.Text = "Server";
            this.lblServerName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BackupTimer
            // 
            this.BackupTimer.Tick += new System.EventHandler(this.BackupTimer_Tick);
            // 
            // PanelAuthentication
            // 
            this.PanelAuthentication.Controls.Add(this.lblPassword);
            this.PanelAuthentication.Controls.Add(this.txtPass);
            this.PanelAuthentication.Controls.Add(this.txtUserName);
            this.PanelAuthentication.Controls.Add(this.lblUserName);
            this.PanelAuthentication.Controls.Add(this.btnClose);
            this.PanelAuthentication.Controls.Add(this.btnConnect);
            this.PanelAuthentication.HorizontalScrollbarBarColor = true;
            this.PanelAuthentication.HorizontalScrollbarHighlightOnWheel = false;
            this.PanelAuthentication.HorizontalScrollbarSize = 10;
            this.PanelAuthentication.Location = new System.Drawing.Point(51, 4);
            this.PanelAuthentication.Name = "PanelAuthentication";
            this.PanelAuthentication.Size = new System.Drawing.Size(410, 219);
            this.PanelAuthentication.TabIndex = 19;
            this.PanelAuthentication.VerticalScrollbarBarColor = true;
            this.PanelAuthentication.VerticalScrollbarHighlightOnWheel = false;
            this.PanelAuthentication.VerticalScrollbarSize = 10;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblPassword.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblPassword.Location = new System.Drawing.Point(21, 116);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(87, 25);
            this.lblPassword.TabIndex = 12;
            this.lblPassword.Text = "Password";
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(124, 118);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(248, 23);
            this.txtPass.TabIndex = 11;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(124, 70);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(248, 23);
            this.txtUserName.TabIndex = 10;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblUserName.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblUserName.Location = new System.Drawing.Point(19, 68);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(99, 25);
            this.lblUserName.TabIndex = 9;
            this.lblUserName.Text = "User Name";
            this.lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(320, 183);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(59, 23);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Back";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(21, 183);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(100, 23);
            this.btnConnect.TabIndex = 6;
            this.btnConnect.Text = "Connect";
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 592);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.metroUserControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Index";
            this.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.SystemShadow;
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.PanelSecheduler.ResumeLayout(false);
            this.PanelSecheduler.PerformLayout();
            this.PanelAuthentication.ResumeLayout(false);
            this.PanelAuthentication.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroUserControl metroUserControl1;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTextBox txtDBName;
        private MetroFramework.Controls.MetroTextBox txtServerName;
        private MetroFramework.Controls.MetroLabel lblServerName;
        private System.Windows.Forms.Button btnBackup;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtCustomString;
        private MetroFramework.Controls.MetroPanel PanelSecheduler;
        private MetroFramework.Controls.MetroButton btnStopSchedule;
        private MetroFramework.Controls.MetroButton btnStartSchedule;
        private System.Windows.Forms.Label lblSetTimer;
        private System.Windows.Forms.TextBox txtInterval;
        private System.Windows.Forms.Timer BackupTimer;
        private System.Windows.Forms.Label lblSchedulerStatus;
        private MetroFramework.Controls.MetroButton btnScheduler;
        private MetroFramework.Controls.MetroButton btnBrowse;
        private MetroFramework.Controls.MetroTextBox txtBrowse;
        private MetroFramework.Controls.MetroCheckBox chkHasPass;
        private MetroFramework.Controls.MetroPanel PanelAuthentication;
        private MetroFramework.Controls.MetroLabel lblPassword;
        private MetroFramework.Controls.MetroTextBox txtPass;
        private MetroFramework.Controls.MetroTextBox txtUserName;
        private MetroFramework.Controls.MetroLabel lblUserName;
        private MetroFramework.Controls.MetroButton btnClose;
        private MetroFramework.Controls.MetroButton btnConnect;
    }
}

