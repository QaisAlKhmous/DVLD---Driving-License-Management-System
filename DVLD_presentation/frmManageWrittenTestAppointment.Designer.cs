namespace DVLD_presentation
{
    partial class frmManageWrittenTestAppointment
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvTestAppointments = new System.Windows.Forms.DataGridView();
            this.btnAddAppointment = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNumberOfRecords = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.takeTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ctrlLocalDrivingLicenseAppInfo1 = new DVLD_presentation.ctrlLocalDrivingLicenseAppInfo();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTestAppointments)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD_presentation.Properties.Resources.Written_Test_512;
            this.pictureBox1.Location = new System.Drawing.Point(308, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(148, 118);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 43;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(220, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 29);
            this.label1.TabIndex = 44;
            this.label1.Text = "Writtent Test Appointments";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 522);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 18);
            this.label2.TabIndex = 52;
            this.label2.Text = "Appointments:";
            // 
            // dgvTestAppointments
            // 
            this.dgvTestAppointments.AllowUserToAddRows = false;
            this.dgvTestAppointments.AllowUserToDeleteRows = false;
            this.dgvTestAppointments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTestAppointments.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvTestAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTestAppointments.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvTestAppointments.GridColor = System.Drawing.SystemColors.Control;
            this.dgvTestAppointments.Location = new System.Drawing.Point(12, 561);
            this.dgvTestAppointments.Name = "dgvTestAppointments";
            this.dgvTestAppointments.ReadOnly = true;
            this.dgvTestAppointments.Size = new System.Drawing.Size(725, 149);
            this.dgvTestAppointments.TabIndex = 53;
            // 
            // btnAddAppointment
            // 
            this.btnAddAppointment.Image = global::DVLD_presentation.Properties.Resources.AddAppointment_32;
            this.btnAddAppointment.Location = new System.Drawing.Point(692, 514);
            this.btnAddAppointment.Name = "btnAddAppointment";
            this.btnAddAppointment.Size = new System.Drawing.Size(45, 37);
            this.btnAddAppointment.TabIndex = 54;
            this.btnAddAppointment.UseVisualStyleBackColor = true;
            this.btnAddAppointment.Click += new System.EventHandler(this.btnAddAppointment_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 713);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 16);
            this.label3.TabIndex = 55;
            this.label3.Text = "# Of Records:";
            // 
            // lblNumberOfRecords
            // 
            this.lblNumberOfRecords.AutoSize = true;
            this.lblNumberOfRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfRecords.Location = new System.Drawing.Point(113, 713);
            this.lblNumberOfRecords.Name = "lblNumberOfRecords";
            this.lblNumberOfRecords.Size = new System.Drawing.Size(14, 15);
            this.lblNumberOfRecords.TabIndex = 56;
            this.lblNumberOfRecords.Text = "0";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.takeTestToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 70);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Image = global::DVLD_presentation.Properties.Resources.edit_32;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click_1);
            // 
            // takeTestToolStripMenuItem
            // 
            this.takeTestToolStripMenuItem.Image = global::DVLD_presentation.Properties.Resources.Test_Type_64;
            this.takeTestToolStripMenuItem.Name = "takeTestToolStripMenuItem";
            this.takeTestToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.takeTestToolStripMenuItem.Text = "Take Test";
            this.takeTestToolStripMenuItem.Click += new System.EventHandler(this.takeTestToolStripMenuItem_Click_1);
            // 
            // ctrlLocalDrivingLicenseAppInfo1
            // 
            this.ctrlLocalDrivingLicenseAppInfo1.Location = new System.Drawing.Point(12, 174);
            this.ctrlLocalDrivingLicenseAppInfo1.Name = "ctrlLocalDrivingLicenseAppInfo1";
            this.ctrlLocalDrivingLicenseAppInfo1.Size = new System.Drawing.Size(735, 345);
            this.ctrlLocalDrivingLicenseAppInfo1.TabIndex = 45;
            // 
            // frmManageWrittenTestAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 744);
            this.Controls.Add(this.lblNumberOfRecords);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAddAppointment);
            this.Controls.Add(this.dgvTestAppointments);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ctrlLocalDrivingLicenseAppInfo1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmManageWrittenTestAppointment";
            this.Text = "frmManageWrittenTestAppointment";
            this.Load += new System.EventHandler(this.frmManageWrittenTestAppointment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTestAppointments)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private ctrlLocalDrivingLicenseAppInfo ctrlLocalDrivingLicenseAppInfo1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvTestAppointments;
        private System.Windows.Forms.Button btnAddAppointment;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNumberOfRecords;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem takeTestToolStripMenuItem;
    }
}