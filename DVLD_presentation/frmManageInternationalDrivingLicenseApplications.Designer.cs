namespace DVLD_presentation
{
    partial class frmManageInternationalDrivingLicenseApplications
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
            this.cb_Status = new System.Windows.Forms.ComboBox();
            this.textLDLAppsFilter = new System.Windows.Forms.TextBox();
            this.cb_LDLAppsFilter = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNumberOfRecords = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvIDLApps = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnAddNewLDLApp = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.showPersonDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showLicenseDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showLicensesHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIDLApps)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_Status
            // 
            this.cb_Status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Status.FormattingEnabled = true;
            this.cb_Status.Items.AddRange(new object[] {
            "All",
            "Yes",
            "No"});
            this.cb_Status.Location = new System.Drawing.Point(220, 199);
            this.cb_Status.Name = "cb_Status";
            this.cb_Status.Size = new System.Drawing.Size(78, 21);
            this.cb_Status.TabIndex = 78;
            this.cb_Status.Visible = false;
            this.cb_Status.SelectedIndexChanged += new System.EventHandler(this.cb_Status_SelectedIndexChanged);
            // 
            // textLDLAppsFilter
            // 
            this.textLDLAppsFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLDLAppsFilter.Location = new System.Drawing.Point(219, 199);
            this.textLDLAppsFilter.Name = "textLDLAppsFilter";
            this.textLDLAppsFilter.Size = new System.Drawing.Size(171, 22);
            this.textLDLAppsFilter.TabIndex = 76;
            this.textLDLAppsFilter.Visible = false;
            this.textLDLAppsFilter.TextChanged += new System.EventHandler(this.textLDLAppsFilter_TextChanged);
            // 
            // cb_LDLAppsFilter
            // 
            this.cb_LDLAppsFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_LDLAppsFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_LDLAppsFilter.FormattingEnabled = true;
            this.cb_LDLAppsFilter.Items.AddRange(new object[] {
            "None",
            "I.License ID",
            "Application ID",
            "Driver ID",
            "L.License ID",
            "Issue Date",
            "Expiration Date",
            "Is Active"});
            this.cb_LDLAppsFilter.Location = new System.Drawing.Point(92, 198);
            this.cb_LDLAppsFilter.Name = "cb_LDLAppsFilter";
            this.cb_LDLAppsFilter.Size = new System.Drawing.Size(121, 23);
            this.cb_LDLAppsFilter.TabIndex = 75;
            this.cb_LDLAppsFilter.SelectedIndexChanged += new System.EventHandler(this.cb_LDLAppsFilter_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 18);
            this.label2.TabIndex = 74;
            this.label2.Text = "Filter By:";
            // 
            // lblNumberOfRecords
            // 
            this.lblNumberOfRecords.AutoSize = true;
            this.lblNumberOfRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfRecords.Location = new System.Drawing.Point(116, 450);
            this.lblNumberOfRecords.Name = "lblNumberOfRecords";
            this.lblNumberOfRecords.Size = new System.Drawing.Size(14, 15);
            this.lblNumberOfRecords.TabIndex = 71;
            this.lblNumberOfRecords.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 449);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 16);
            this.label3.TabIndex = 70;
            this.label3.Text = "# Of Records:";
            // 
            // dgvIDLApps
            // 
            this.dgvIDLApps.AllowUserToAddRows = false;
            this.dgvIDLApps.AllowUserToDeleteRows = false;
            this.dgvIDLApps.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvIDLApps.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvIDLApps.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvIDLApps.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvIDLApps.Location = new System.Drawing.Point(9, 227);
            this.dgvIDLApps.Name = "dgvIDLApps";
            this.dgvIDLApps.ReadOnly = true;
            this.dgvIDLApps.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvIDLApps.Size = new System.Drawing.Size(1066, 205);
            this.dgvIDLApps.TabIndex = 68;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(294, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(553, 31);
            this.label1.TabIndex = 67;
            this.label1.Text = "International Driving License Applications";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showPersonDetailsToolStripMenuItem,
            this.showLicenseDetailsToolStripMenuItem,
            this.showLicensesHistoryToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(208, 140);
            // 
            // btnAddNewLDLApp
            // 
            this.btnAddNewLDLApp.Image = global::DVLD_presentation.Properties.Resources.New_Application_64;
            this.btnAddNewLDLApp.Location = new System.Drawing.Point(1000, 151);
            this.btnAddNewLDLApp.Name = "btnAddNewLDLApp";
            this.btnAddNewLDLApp.Size = new System.Drawing.Size(75, 71);
            this.btnAddNewLDLApp.TabIndex = 77;
            this.btnAddNewLDLApp.UseVisualStyleBackColor = true;
            this.btnAddNewLDLApp.Click += new System.EventHandler(this.btnAddNewLDLApp_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DVLD_presentation.Properties.Resources.International_32;
            this.pictureBox2.Location = new System.Drawing.Point(619, 48);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(42, 33);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 73;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD_presentation.Properties.Resources.Applications1;
            this.pictureBox1.Location = new System.Drawing.Point(483, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(167, 136);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 72;
            this.pictureBox1.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::DVLD_presentation.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(915, 436);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(160, 39);
            this.btnClose.TabIndex = 69;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // showPersonDetailsToolStripMenuItem
            // 
            this.showPersonDetailsToolStripMenuItem.Image = global::DVLD_presentation.Properties.Resources.PersonDetails_32;
            this.showPersonDetailsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.showPersonDetailsToolStripMenuItem.Name = "showPersonDetailsToolStripMenuItem";
            this.showPersonDetailsToolStripMenuItem.Size = new System.Drawing.Size(207, 38);
            this.showPersonDetailsToolStripMenuItem.Text = "Show Person Details";
            this.showPersonDetailsToolStripMenuItem.Click += new System.EventHandler(this.showPersonDetailsToolStripMenuItem_Click);
            // 
            // showLicenseDetailsToolStripMenuItem
            // 
            this.showLicenseDetailsToolStripMenuItem.Image = global::DVLD_presentation.Properties.Resources.License_View_32;
            this.showLicenseDetailsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.showLicenseDetailsToolStripMenuItem.Name = "showLicenseDetailsToolStripMenuItem";
            this.showLicenseDetailsToolStripMenuItem.Size = new System.Drawing.Size(207, 38);
            this.showLicenseDetailsToolStripMenuItem.Text = "Show License Details";
            this.showLicenseDetailsToolStripMenuItem.Click += new System.EventHandler(this.showLicenseDetailsToolStripMenuItem_Click);
            // 
            // showLicensesHistoryToolStripMenuItem
            // 
            this.showLicensesHistoryToolStripMenuItem.Image = global::DVLD_presentation.Properties.Resources.PersonLicenseHistory_32;
            this.showLicensesHistoryToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.showLicensesHistoryToolStripMenuItem.Name = "showLicensesHistoryToolStripMenuItem";
            this.showLicensesHistoryToolStripMenuItem.Size = new System.Drawing.Size(207, 38);
            this.showLicensesHistoryToolStripMenuItem.Text = "Show Licenses History";
            this.showLicensesHistoryToolStripMenuItem.Click += new System.EventHandler(this.showLicensesHistoryToolStripMenuItem_Click);
            // 
            // frmManageInternationalDrivingLicenseApplications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 480);
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
            this.Controls.Add(this.dgvIDLApps);
            this.Controls.Add(this.label1);
            this.Name = "frmManageInternationalDrivingLicenseApplications";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmManageInternationalDrivingLicenseApplications";
            this.Load += new System.EventHandler(this.frmManageInternationalDrivingLicenseApplications_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIDLApps)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_Status;
        private System.Windows.Forms.Button btnAddNewLDLApp;
        private System.Windows.Forms.TextBox textLDLAppsFilter;
        private System.Windows.Forms.ComboBox cb_LDLAppsFilter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblNumberOfRecords;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvIDLApps;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showPersonDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showLicenseDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showLicensesHistoryToolStripMenuItem;
    }
}