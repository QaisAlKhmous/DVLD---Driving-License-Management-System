namespace DVLD_presentation
{
    partial class frmReplacmentForDamaged
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbLost = new System.Windows.Forms.RadioButton();
            this.rbDamaged = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblAppID = new System.Windows.Forms.Label();
            this.lblAppDate = new System.Windows.Forms.Label();
            this.lblAppFees = new System.Windows.Forms.Label();
            this.lblNewLicenseID = new System.Windows.Forms.Label();
            this.lblOldLicenseId = new System.Windows.Forms.Label();
            this.lblCreatedBy = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnRenew = new System.Windows.Forms.Button();
            this.lblLicenseHistory = new System.Windows.Forms.LinkLabel();
            this.lblLicenseInfo = new System.Windows.Forms.LinkLabel();
            this.ctrlDriverLicenseInfoWithFilter1 = new DVLD_presentation.ctrlDriverLicenseInfoWithFilter();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(176, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(496, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Replacment For Damaged License";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbLost);
            this.groupBox1.Controls.Add(this.rbDamaged);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(603, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(238, 89);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Replacment For:";
            // 
            // rbLost
            // 
            this.rbLost.AutoSize = true;
            this.rbLost.Location = new System.Drawing.Point(6, 47);
            this.rbLost.Name = "rbLost";
            this.rbLost.Size = new System.Drawing.Size(100, 20);
            this.rbLost.TabIndex = 1;
            this.rbLost.Text = "Lost License";
            this.rbLost.UseVisualStyleBackColor = true;
            // 
            // rbDamaged
            // 
            this.rbDamaged.AutoSize = true;
            this.rbDamaged.Location = new System.Drawing.Point(6, 21);
            this.rbDamaged.Name = "rbDamaged";
            this.rbDamaged.Size = new System.Drawing.Size(136, 20);
            this.rbDamaged.TabIndex = 0;
            this.rbDamaged.Text = "Damaged License";
            this.rbDamaged.UseVisualStyleBackColor = true;
            this.rbDamaged.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox6);
            this.groupBox2.Controls.Add(this.pictureBox5);
            this.groupBox2.Controls.Add(this.pictureBox4);
            this.groupBox2.Controls.Add(this.pictureBox3);
            this.groupBox2.Controls.Add(this.pictureBox2);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.lblCreatedBy);
            this.groupBox2.Controls.Add(this.lblOldLicenseId);
            this.groupBox2.Controls.Add(this.lblNewLicenseID);
            this.groupBox2.Controls.Add(this.lblAppFees);
            this.groupBox2.Controls.Add(this.lblAppDate);
            this.groupBox2.Controls.Add(this.lblAppID);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 556);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(829, 152);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Application Info For License Replacment";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "L.R Appliation ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Application Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Application Fees:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(397, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(181, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Replaced License ID:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(397, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Old License ID:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(397, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "Created By:";
            // 
            // lblAppID
            // 
            this.lblAppID.AutoSize = true;
            this.lblAppID.Location = new System.Drawing.Point(199, 49);
            this.lblAppID.Name = "lblAppID";
            this.lblAppID.Size = new System.Drawing.Size(39, 20);
            this.lblAppID.TabIndex = 6;
            this.lblAppID.Text = "[??]";
            // 
            // lblAppDate
            // 
            this.lblAppDate.AutoSize = true;
            this.lblAppDate.Location = new System.Drawing.Point(199, 85);
            this.lblAppDate.Name = "lblAppDate";
            this.lblAppDate.Size = new System.Drawing.Size(39, 20);
            this.lblAppDate.TabIndex = 7;
            this.lblAppDate.Text = "[??]";
            // 
            // lblAppFees
            // 
            this.lblAppFees.AutoSize = true;
            this.lblAppFees.Location = new System.Drawing.Point(199, 119);
            this.lblAppFees.Name = "lblAppFees";
            this.lblAppFees.Size = new System.Drawing.Size(39, 20);
            this.lblAppFees.TabIndex = 8;
            this.lblAppFees.Text = "[??]";
            // 
            // lblNewLicenseID
            // 
            this.lblNewLicenseID.AutoSize = true;
            this.lblNewLicenseID.Location = new System.Drawing.Point(621, 49);
            this.lblNewLicenseID.Name = "lblNewLicenseID";
            this.lblNewLicenseID.Size = new System.Drawing.Size(39, 20);
            this.lblNewLicenseID.TabIndex = 9;
            this.lblNewLicenseID.Text = "[??]";
            // 
            // lblOldLicenseId
            // 
            this.lblOldLicenseId.AutoSize = true;
            this.lblOldLicenseId.Location = new System.Drawing.Point(621, 85);
            this.lblOldLicenseId.Name = "lblOldLicenseId";
            this.lblOldLicenseId.Size = new System.Drawing.Size(39, 20);
            this.lblOldLicenseId.TabIndex = 10;
            this.lblOldLicenseId.Text = "[??]";
            // 
            // lblCreatedBy
            // 
            this.lblCreatedBy.AutoSize = true;
            this.lblCreatedBy.Location = new System.Drawing.Point(621, 119);
            this.lblCreatedBy.Name = "lblCreatedBy";
            this.lblCreatedBy.Size = new System.Drawing.Size(39, 20);
            this.lblCreatedBy.TabIndex = 11;
            this.lblCreatedBy.Text = "[??]";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD_presentation.Properties.Resources.Number_32;
            this.pictureBox1.Location = new System.Drawing.Point(163, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(21, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DVLD_presentation.Properties.Resources.Calendar_32;
            this.pictureBox2.Location = new System.Drawing.Point(163, 85);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(21, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::DVLD_presentation.Properties.Resources.money_32;
            this.pictureBox3.Location = new System.Drawing.Point(163, 119);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(21, 20);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 14;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::DVLD_presentation.Properties.Resources.Number_32;
            this.pictureBox4.Location = new System.Drawing.Point(581, 49);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(21, 20);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 15;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::DVLD_presentation.Properties.Resources.Number_32;
            this.pictureBox5.Location = new System.Drawing.Point(581, 85);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(21, 20);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 16;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::DVLD_presentation.Properties.Resources.Person_32;
            this.pictureBox6.Location = new System.Drawing.Point(581, 119);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(21, 20);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 17;
            this.pictureBox6.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::DVLD_presentation.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(469, 727);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(160, 39);
            this.btnClose.TabIndex = 60;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnRenew
            // 
            this.btnRenew.Enabled = false;
            this.btnRenew.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRenew.Image = global::DVLD_presentation.Properties.Resources.Renew_Driving_License_321;
            this.btnRenew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRenew.Location = new System.Drawing.Point(637, 727);
            this.btnRenew.Name = "btnRenew";
            this.btnRenew.Size = new System.Drawing.Size(214, 39);
            this.btnRenew.TabIndex = 61;
            this.btnRenew.Text = "Issue Replacment";
            this.btnRenew.UseVisualStyleBackColor = true;
            this.btnRenew.Click += new System.EventHandler(this.btnRenew_Click);
            // 
            // lblLicenseHistory
            // 
            this.lblLicenseHistory.AutoSize = true;
            this.lblLicenseHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLicenseHistory.Location = new System.Drawing.Point(18, 727);
            this.lblLicenseHistory.Name = "lblLicenseHistory";
            this.lblLicenseHistory.Size = new System.Drawing.Size(191, 24);
            this.lblLicenseHistory.TabIndex = 62;
            this.lblLicenseHistory.TabStop = true;
            this.lblLicenseHistory.Text = "Show License History";
            this.lblLicenseHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblLicenseHistory_LinkClicked);
            // 
            // lblLicenseInfo
            // 
            this.lblLicenseInfo.AutoSize = true;
            this.lblLicenseInfo.Enabled = false;
            this.lblLicenseInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLicenseInfo.Location = new System.Drawing.Point(224, 727);
            this.lblLicenseInfo.Name = "lblLicenseInfo";
            this.lblLicenseInfo.Size = new System.Drawing.Size(208, 24);
            this.lblLicenseInfo.TabIndex = 63;
            this.lblLicenseInfo.TabStop = true;
            this.lblLicenseInfo.Text = "Show New License Info";
            this.lblLicenseInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblLicenseInfo_LinkClicked);
            // 
            // ctrlDriverLicenseInfoWithFilter1
            // 
            this.ctrlDriverLicenseInfoWithFilter1.licenseID = 0;
            this.ctrlDriverLicenseInfoWithFilter1.Location = new System.Drawing.Point(12, 53);
            this.ctrlDriverLicenseInfoWithFilter1.Name = "ctrlDriverLicenseInfoWithFilter1";
            this.ctrlDriverLicenseInfoWithFilter1.Size = new System.Drawing.Size(839, 533);
            this.ctrlDriverLicenseInfoWithFilter1.TabIndex = 2;
            // 
            // frmReplacmentForDamaged
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 778);
            this.Controls.Add(this.lblLicenseInfo);
            this.Controls.Add(this.lblLicenseHistory);
            this.Controls.Add(this.btnRenew);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ctrlDriverLicenseInfoWithFilter1);
            this.Controls.Add(this.label1);
            this.Name = "frmReplacmentForDamaged";
            this.Text = "frmReplacmentForDamaged";
            this.Load += new System.EventHandler(this.frmReplacmentForDamaged_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private ctrlDriverLicenseInfoWithFilter ctrlDriverLicenseInfoWithFilter1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbLost;
        private System.Windows.Forms.RadioButton rbDamaged;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblCreatedBy;
        private System.Windows.Forms.Label lblOldLicenseId;
        private System.Windows.Forms.Label lblNewLicenseID;
        private System.Windows.Forms.Label lblAppFees;
        private System.Windows.Forms.Label lblAppDate;
        private System.Windows.Forms.Label lblAppID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnRenew;
        private System.Windows.Forms.LinkLabel lblLicenseHistory;
        private System.Windows.Forms.LinkLabel lblLicenseInfo;
    }
}