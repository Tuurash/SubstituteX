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
            this.metroUserControl1 = new MetroFramework.Controls.MetroUserControl();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.btnBackup = new System.Windows.Forms.Button();
            this.txtDBName = new MetroFramework.Controls.MetroTextBox();
            this.txtServerName = new MetroFramework.Controls.MetroTextBox();
            this.lblDBname = new MetroFramework.Controls.MetroLabel();
            this.lblServerName = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1.SuspendLayout();
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
            this.metroPanel1.Controls.Add(this.btnBackup);
            this.metroPanel1.Controls.Add(this.txtDBName);
            this.metroPanel1.Controls.Add(this.txtServerName);
            this.metroPanel1.Controls.Add(this.lblDBname);
            this.metroPanel1.Controls.Add(this.lblServerName);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(23, 29);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(507, 441);
            this.metroPanel1.TabIndex = 1;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // btnBackup
            // 
            this.btnBackup.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnBackup.Location = new System.Drawing.Point(255, 234);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(107, 41);
            this.btnBackup.TabIndex = 7;
            this.btnBackup.Text = "Backup";
            this.btnBackup.UseVisualStyleBackColor = true;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // txtDBName
            // 
            this.txtDBName.Location = new System.Drawing.Point(232, 181);
            this.txtDBName.Name = "txtDBName";
            this.txtDBName.Size = new System.Drawing.Size(130, 23);
            this.txtDBName.TabIndex = 5;
            // 
            // txtServerName
            // 
            this.txtServerName.Location = new System.Drawing.Point(232, 133);
            this.txtServerName.Name = "txtServerName";
            this.txtServerName.Size = new System.Drawing.Size(130, 23);
            this.txtServerName.TabIndex = 4;
            // 
            // lblDBname
            // 
            this.lblDBname.AutoSize = true;
            this.lblDBname.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblDBname.Location = new System.Drawing.Point(124, 181);
            this.lblDBname.Name = "lblDBname";
            this.lblDBname.Size = new System.Drawing.Size(66, 19);
            this.lblDBname.TabIndex = 5;
            this.lblDBname.Text = "Database";
            this.lblDBname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblServerName
            // 
            this.lblServerName.AutoSize = true;
            this.lblServerName.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblServerName.Location = new System.Drawing.Point(143, 133);
            this.lblServerName.Name = "lblServerName";
            this.lblServerName.Size = new System.Drawing.Size(47, 19);
            this.lblServerName.TabIndex = 2;
            this.lblServerName.Text = "Server";
            this.lblServerName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 493);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.metroUserControl1);
            this.Name = "Index";
            this.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.SystemShadow;
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroUserControl metroUserControl1;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTextBox txtDBName;
        private MetroFramework.Controls.MetroTextBox txtServerName;
        private MetroFramework.Controls.MetroLabel lblDBname;
        private MetroFramework.Controls.MetroLabel lblServerName;
        private System.Windows.Forms.Button btnBackup;
    }
}

