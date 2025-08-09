namespace DVLD_presentation
{
    partial class frmManageLocalDrivingLicenseApplication
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
            this.lblNumberOfRecords = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvLDLApps = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.label1 = new System.Windows.Forms.Label();
            this.textLDLAppsFilter = new System.Windows.Forms.TextBox();
            this.cb_LDLAppsFilter = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_Status = new System.Windows.Forms.ComboBox();
            this.btnAddNewLDLApp = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.itemShowDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.itemEditApp = new System.Windows.Forms.ToolStripMenuItem();
            this.itemDeleteApp = new System.Windows.Forms.ToolStripMenuItem();
            this.itemCancelApp = new System.Windows.Forms.ToolStripMenuItem();
            this.itemScheduleTest = new System.Windows.Forms.ToolStripMenuItem();
            this.itemVisionTest = new System.Windows.Forms.ToolStripMenuItem();
            this.itemWrittenTest = new System.Windows.Forms.ToolStripMenuItem();
            this.itemStreetTest = new System.Windows.Forms.ToolStripMenuItem();
            this.itemIssueDrivingLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.itemShowLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.itemShowLicenseHistory = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLDLApps)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNumberOfRecords
            // 
            this.lblNumberOfRecords.AutoSize = true;
            this.lblNumberOfRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfRecords.Location = new System.Drawing.Point(120, 450);
            this.lblNumberOfRecords.Name = "lblNumberOfRecords";
            this.lblNumberOfRecords.Size = new System.Drawing.Size(14, 15);
            this.lblNumberOfRecords.TabIndex = 59;
            this.lblNumberOfRecords.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 449);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 16);
            this.label3.TabIndex = 58;
            this.label3.Text = "# Of Records:";
            // 
            // dgvLDLApps
            // 
            this.dgvLDLApps.AllowUserToAddRows = false;
            this.dgvLDLApps.AllowUserToDeleteRows = false;
            this.dgvLDLApps.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLDLApps.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvLDLApps.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvLDLApps.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvLDLApps.Location = new System.Drawing.Point(13, 227);
            this.dgvLDLApps.Name = "dgvLDLApps";
            this.dgvLDLApps.ReadOnly = true;
            this.dgvLDLApps.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvLDLApps.Size = new System.Drawing.Size(1066, 205);
            this.dgvLDLApps.TabIndex = 56;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemShowDetails,
            this.toolStripSeparator1,
            this.itemEditApp,
            this.itemDeleteApp,
            this.toolStripSeparator2,
            this.itemCancelApp,
            this.toolStripSeparator3,
            this.itemScheduleTest,
            this.toolStripSeparator4,
            this.itemIssueDrivingLicense,
            this.toolStripSeparator5,
            this.itemShowLicense,
            this.toolStripSeparator6,
            this.itemShowLicenseHistory});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(262, 344);
            this.contextMenuStrip1.Opened += new System.EventHandler(this.contextMenuStrip1_Opened);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(258, 6);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(258, 6);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(258, 6);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(258, 6);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(258, 6);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(258, 6);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(351, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(460, 31);
            this.label1.TabIndex = 55;
            this.label1.Text = "Local Driving License Applications";
            // 
            // textLDLAppsFilter
            // 
            this.textLDLAppsFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLDLAppsFilter.Location = new System.Drawing.Point(223, 199);
            this.textLDLAppsFilter.Name = "textLDLAppsFilter";
            this.textLDLAppsFilter.Size = new System.Drawing.Size(171, 22);
            this.textLDLAppsFilter.TabIndex = 64;
            this.textLDLAppsFilter.Visible = false;
            this.textLDLAppsFilter.TextChanged += new System.EventHandler(this.textLDLAppsFilter_TextChanged);
            this.textLDLAppsFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textLDLAppsFilter_KeyPress);
            // 
            // cb_LDLAppsFilter
            // 
            this.cb_LDLAppsFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_LDLAppsFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_LDLAppsFilter.FormattingEnabled = true;
            this.cb_LDLAppsFilter.Items.AddRange(new object[] {
            "None",
            "L.D.L.AppID",
            "National No.",
            "Full Name",
            "Status"});
            this.cb_LDLAppsFilter.Location = new System.Drawing.Point(96, 198);
            this.cb_LDLAppsFilter.Name = "cb_LDLAppsFilter";
            this.cb_LDLAppsFilter.Size = new System.Drawing.Size(121, 23);
            this.cb_LDLAppsFilter.TabIndex = 63;
            this.cb_LDLAppsFilter.SelectedIndexChanged += new System.EventHandler(this.cb_LDLAppsFilter_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 18);
            this.label2.TabIndex = 62;
            this.label2.Text = "Filter By:";
            // 
            // cb_Status
            // 
            this.cb_Status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Status.FormattingEnabled = true;
            this.cb_Status.Items.AddRange(new object[] {
            "None",
            "New",
            "Cancelled",
            "Completed"});
            this.cb_Status.Location = new System.Drawing.Point(224, 199);
            this.cb_Status.Name = "cb_Status";
            this.cb_Status.Size = new System.Drawing.Size(78, 21);
            this.cb_Status.TabIndex = 66;
            this.cb_Status.Visible = false;
            this.cb_Status.SelectedIndexChanged += new System.EventHandler(this.cb_Status_SelectedIndexChanged);
            // 
            // btnAddNewLDLApp
            // 
            this.btnAddNewLDLApp.Image = global::DVLD_presentation.Properties.Resources.New_Application_64;
            this.btnAddNewLDLApp.Location = new System.Drawing.Point(1004, 151);
            this.btnAddNewLDLApp.Name = "btnAddNewLDLApp";
            this.btnAddNewLDLApp.Size = new System.Drawing.Size(75, 71);
            this.btnAddNewLDLApp.TabIndex = 65;
            this.btnAddNewLDLApp.UseVisualStyleBackColor = true;
            this.btnAddNewLDLApp.Click += new System.EventHandler(this.btnAddNewLDLApp_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DVLD_presentation.Properties.Resources.Local_32;
            this.pictureBox2.Location = new System.Drawing.Point(623, 48);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(42, 33);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 61;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD_presentation.Properties.Resources.Applications1;
            this.pictureBox1.Location = new System.Drawing.Point(487, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(167, 136);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 60;
            this.pictureBox1.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::DVLD_presentation.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(919, 436);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(160, 39);
            this.btnClose.TabIndex = 57;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // itemShowDetails
            // 
            this.itemShowDetails.Image = global::DVLD_presentation.Properties.Resources.PersonDetails_32;
            this.itemShowDetails.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.itemShowDetails.Name = "itemShowDetails";
            this.itemShowDetails.Size = new System.Drawing.Size(261, 38);
            this.itemShowDetails.Text = "Show Application Details";
            // 
            // itemEditApp
            // 
            this.itemEditApp.Image = global::DVLD_presentation.Properties.Resources.edit_32;
            this.itemEditApp.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.itemEditApp.Name = "itemEditApp";
            this.itemEditApp.Size = new System.Drawing.Size(261, 38);
            this.itemEditApp.Text = "Edit Application";
            this.itemEditApp.Click += new System.EventHandler(this.itemEditApp_Click);
            // 
            // itemDeleteApp
            // 
            this.itemDeleteApp.Image = global::DVLD_presentation.Properties.Resources.Delete_32_2;
            this.itemDeleteApp.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.itemDeleteApp.Name = "itemDeleteApp";
            this.itemDeleteApp.Size = new System.Drawing.Size(261, 38);
            this.itemDeleteApp.Text = "Delete Application";
            this.itemDeleteApp.Click += new System.EventHandler(this.itemDeleteApp_Click);
            // 
            // itemCancelApp
            // 
            this.itemCancelApp.Image = global::DVLD_presentation.Properties.Resources.Delete_32;
            this.itemCancelApp.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.itemCancelApp.Name = "itemCancelApp";
            this.itemCancelApp.Size = new System.Drawing.Size(261, 38);
            this.itemCancelApp.Text = "Cancel Application";
            this.itemCancelApp.Click += new System.EventHandler(this.cancelApplicationToolStripMenuItem_Click);
            // 
            // itemScheduleTest
            // 
            this.itemScheduleTest.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemVisionTest,
            this.itemWrittenTest,
            this.itemStreetTest});
            this.itemScheduleTest.Image = global::DVLD_presentation.Properties.Resources.Schedule_Test_32;
            this.itemScheduleTest.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.itemScheduleTest.Name = "itemScheduleTest";
            this.itemScheduleTest.Size = new System.Drawing.Size(261, 38);
            this.itemScheduleTest.Text = "Schedule Test";
            // 
            // itemVisionTest
            // 
            this.itemVisionTest.Image = global::DVLD_presentation.Properties.Resources.Vision_Test_Schdule;
            this.itemVisionTest.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.itemVisionTest.Name = "itemVisionTest";
            this.itemVisionTest.Size = new System.Drawing.Size(203, 38);
            this.itemVisionTest.Text = "Schedule Vision Test";
            this.itemVisionTest.Click += new System.EventHandler(this.itemVisionTest_Click);
            // 
            // itemWrittenTest
            // 
            this.itemWrittenTest.Image = global::DVLD_presentation.Properties.Resources.Written_Test_32_Sechdule;
            this.itemWrittenTest.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.itemWrittenTest.Name = "itemWrittenTest";
            this.itemWrittenTest.Size = new System.Drawing.Size(203, 38);
            this.itemWrittenTest.Text = "Schedule Written Test";
            this.itemWrittenTest.Click += new System.EventHandler(this.itemWrittenTest_Click);
            // 
            // itemStreetTest
            // 
            this.itemStreetTest.Image = global::DVLD_presentation.Properties.Resources.Street_Test_32;
            this.itemStreetTest.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.itemStreetTest.Name = "itemStreetTest";
            this.itemStreetTest.Size = new System.Drawing.Size(203, 38);
            this.itemStreetTest.Text = "Schedule Street Test";
            this.itemStreetTest.Click += new System.EventHandler(this.itemStreetTest_Click);
            // 
            // itemIssueDrivingLicense
            // 
            this.itemIssueDrivingLicense.Image = global::DVLD_presentation.Properties.Resources.IssueDrivingLicense_32;
            this.itemIssueDrivingLicense.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.itemIssueDrivingLicense.Name = "itemIssueDrivingLicense";
            this.itemIssueDrivingLicense.Size = new System.Drawing.Size(261, 38);
            this.itemIssueDrivingLicense.Text = "Issue Driving License (First Time)";
            this.itemIssueDrivingLicense.Click += new System.EventHandler(this.itemIssueDrivingLicense_Click);
            // 
            // itemShowLicense
            // 
            this.itemShowLicense.Image = global::DVLD_presentation.Properties.Resources.License_View_32;
            this.itemShowLicense.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.itemShowLicense.Name = "itemShowLicense";
            this.itemShowLicense.Size = new System.Drawing.Size(261, 38);
            this.itemShowLicense.Text = "Show License";
            this.itemShowLicense.Click += new System.EventHandler(this.itemShowLicense_Click);
            // 
            // itemShowLicenseHistory
            // 
            this.itemShowLicenseHistory.Image = global::DVLD_presentation.Properties.Resources.PersonLicenseHistory_32;
            this.itemShowLicenseHistory.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.itemShowLicenseHistory.Name = "itemShowLicenseHistory";
            this.itemShowLicenseHistory.Size = new System.Drawing.Size(261, 38);
            this.itemShowLicenseHistory.Text = "Show Person License History";
            this.itemShowLicenseHistory.Click += new System.EventHandler(this.itemShowLicenseHistory_Click);
            // 
            // frmManageLocalDrivingLicenseApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 487);
            this.Controls.Add(this.cb_Status);
            this.Controls.Add(this.btnAddNewLDLApp);
            this.Controls.Add(this.textLDLAppsFilter);
            this.Controls.Add(this.cb_LDLAppsFilter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblNumberOfRecords);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvLDLApps);
            this.Controls.Add(this.label1);
            this.Name = "frmManageLocalDrivingLicenseApplication";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmManageLocalDrivingLicenseApplication";
            this.Load += new System.EventHandler(this.frmManageLocalDrivingLicenseApplication_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLDLApps)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblNumberOfRecords;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvLDLApps;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textLDLAppsFilter;
        private System.Windows.Forms.ComboBox cb_LDLAppsFilter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddNewLDLApp;
        private System.Windows.Forms.ComboBox cb_Status;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem itemShowDetails;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem itemEditApp;
        private System.Windows.Forms.ToolStripMenuItem itemDeleteApp;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem itemCancelApp;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem itemScheduleTest;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem itemIssueDrivingLicense;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem itemShowLicense;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem itemShowLicenseHistory;
        private System.Windows.Forms.ToolStripMenuItem itemVisionTest;
        private System.Windows.Forms.ToolStripMenuItem itemWrittenTest;
        private System.Windows.Forms.ToolStripMenuItem itemStreetTest;
    }
}