namespace DVLD_presentation
{
    partial class frmListDetailedLicenses
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
            this.dgvDetainedLicenses = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAddNewLDLApp = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsReleasedDetainedLicense = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetainedLicenses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
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
            this.cb_Status.Location = new System.Drawing.Point(225, 199);
            this.cb_Status.Name = "cb_Status";
            this.cb_Status.Size = new System.Drawing.Size(78, 21);
            this.cb_Status.TabIndex = 78;
            this.cb_Status.Visible = false;
            // 
            // textLDLAppsFilter
            // 
            this.textLDLAppsFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLDLAppsFilter.Location = new System.Drawing.Point(224, 199);
            this.textLDLAppsFilter.Name = "textLDLAppsFilter";
            this.textLDLAppsFilter.Size = new System.Drawing.Size(171, 22);
            this.textLDLAppsFilter.TabIndex = 76;
            this.textLDLAppsFilter.Visible = false;
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
            this.cb_LDLAppsFilter.Location = new System.Drawing.Point(97, 198);
            this.cb_LDLAppsFilter.Name = "cb_LDLAppsFilter";
            this.cb_LDLAppsFilter.Size = new System.Drawing.Size(121, 23);
            this.cb_LDLAppsFilter.TabIndex = 75;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 18);
            this.label2.TabIndex = 74;
            this.label2.Text = "Filter By:";
            // 
            // lblNumberOfRecords
            // 
            this.lblNumberOfRecords.AutoSize = true;
            this.lblNumberOfRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfRecords.Location = new System.Drawing.Point(121, 450);
            this.lblNumberOfRecords.Name = "lblNumberOfRecords";
            this.lblNumberOfRecords.Size = new System.Drawing.Size(14, 15);
            this.lblNumberOfRecords.TabIndex = 71;
            this.lblNumberOfRecords.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 449);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 16);
            this.label3.TabIndex = 70;
            this.label3.Text = "# Of Records:";
            // 
            // dgvDetainedLicenses
            // 
            this.dgvDetainedLicenses.AllowUserToAddRows = false;
            this.dgvDetainedLicenses.AllowUserToDeleteRows = false;
            this.dgvDetainedLicenses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetainedLicenses.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvDetainedLicenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDetainedLicenses.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvDetainedLicenses.Location = new System.Drawing.Point(14, 227);
            this.dgvDetainedLicenses.Name = "dgvDetainedLicenses";
            this.dgvDetainedLicenses.ReadOnly = true;
            this.dgvDetainedLicenses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvDetainedLicenses.Size = new System.Drawing.Size(1066, 205);
            this.dgvDetainedLicenses.TabIndex = 68;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(422, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 31);
            this.label1.TabIndex = 67;
            this.label1.Text = "List Detained License";
            // 
            // button1
            // 
            this.button1.Image = global::DVLD_presentation.Properties.Resources.Release_Detained_License_64;
            this.button1.Location = new System.Drawing.Point(924, 151);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 71);
            this.button1.TabIndex = 79;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAddNewLDLApp
            // 
            this.btnAddNewLDLApp.Image = global::DVLD_presentation.Properties.Resources.Detain_641;
            this.btnAddNewLDLApp.Location = new System.Drawing.Point(1005, 151);
            this.btnAddNewLDLApp.Name = "btnAddNewLDLApp";
            this.btnAddNewLDLApp.Size = new System.Drawing.Size(75, 71);
            this.btnAddNewLDLApp.TabIndex = 77;
            this.btnAddNewLDLApp.UseVisualStyleBackColor = true;
            this.btnAddNewLDLApp.Click += new System.EventHandler(this.btnAddNewLDLApp_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD_presentation.Properties.Resources.Detain_512;
            this.pictureBox1.Location = new System.Drawing.Point(488, 12);
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
            this.btnClose.Location = new System.Drawing.Point(920, 436);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(160, 39);
            this.btnClose.TabIndex = 69;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsReleasedDetainedLicense});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(206, 26);
            this.contextMenuStrip1.Opened += new System.EventHandler(this.contextMenuStrip1_Opened);
            // 
            // cmsReleasedDetainedLicense
            // 
            this.cmsReleasedDetainedLicense.Name = "cmsReleasedDetainedLicense";
            this.cmsReleasedDetainedLicense.Size = new System.Drawing.Size(205, 22);
            this.cmsReleasedDetainedLicense.Text = "Release Detained License";
            // 
            // frmListDetailedLicenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 479);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cb_Status);
            this.Controls.Add(this.btnAddNewLDLApp);
            this.Controls.Add(this.textLDLAppsFilter);
            this.Controls.Add(this.cb_LDLAppsFilter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblNumberOfRecords);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvDetainedLicenses);
            this.Controls.Add(this.label1);
            this.Name = "frmListDetailedLicenses";
            this.Text = "frmListDetailedLicenses";
            this.Load += new System.EventHandler(this.frmListDetailedLicenses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetainedLicenses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_Status;
        private System.Windows.Forms.Button btnAddNewLDLApp;
        private System.Windows.Forms.TextBox textLDLAppsFilter;
        private System.Windows.Forms.ComboBox cb_LDLAppsFilter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblNumberOfRecords;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvDetainedLicenses;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cmsReleasedDetainedLicense;
    }
}