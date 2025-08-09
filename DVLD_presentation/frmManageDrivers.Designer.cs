namespace DVLD_presentation
{
    partial class frmManageDrivers
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textDriversFilter = new System.Windows.Forms.TextBox();
            this.cb_DriversFilter = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_ManageDrivers = new System.Windows.Forms.DataGridView();
            this.lblNumberOfRecords = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ManageDrivers)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(267, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 37);
            this.label1.TabIndex = 57;
            this.label1.Text = "Manage Drivers";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD_presentation.Properties.Resources.Driver_Main;
            this.pictureBox1.Location = new System.Drawing.Point(309, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(177, 133);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 58;
            this.pictureBox1.TabStop = false;
            // 
            // textDriversFilter
            // 
            this.textDriversFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDriversFilter.Location = new System.Drawing.Point(210, 234);
            this.textDriversFilter.Name = "textDriversFilter";
            this.textDriversFilter.Size = new System.Drawing.Size(171, 22);
            this.textDriversFilter.TabIndex = 62;
            this.textDriversFilter.Visible = false;
            this.textDriversFilter.TextChanged += new System.EventHandler(this.textDriversFilter_TextChanged);
            // 
            // cb_DriversFilter
            // 
            this.cb_DriversFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_DriversFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_DriversFilter.FormattingEnabled = true;
            this.cb_DriversFilter.Items.AddRange(new object[] {
            "None",
            "Driver ID",
            "Person ID",
            "National No",
            "Full Name",
            "Created Date",
            "Number Of Active License"});
            this.cb_DriversFilter.Location = new System.Drawing.Point(93, 233);
            this.cb_DriversFilter.Name = "cb_DriversFilter";
            this.cb_DriversFilter.Size = new System.Drawing.Size(111, 23);
            this.cb_DriversFilter.TabIndex = 61;
            this.cb_DriversFilter.SelectedIndexChanged += new System.EventHandler(this.cb_UsersFilter_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 18);
            this.label2.TabIndex = 60;
            this.label2.Text = "Filter By:";
            // 
            // dgv_ManageDrivers
            // 
            this.dgv_ManageDrivers.AllowUserToAddRows = false;
            this.dgv_ManageDrivers.AllowUserToDeleteRows = false;
            this.dgv_ManageDrivers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgv_ManageDrivers.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_ManageDrivers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ManageDrivers.GridColor = System.Drawing.SystemColors.Control;
            this.dgv_ManageDrivers.Location = new System.Drawing.Point(12, 259);
            this.dgv_ManageDrivers.Name = "dgv_ManageDrivers";
            this.dgv_ManageDrivers.ReadOnly = true;
            this.dgv_ManageDrivers.Size = new System.Drawing.Size(776, 267);
            this.dgv_ManageDrivers.TabIndex = 59;
            // 
            // lblNumberOfRecords
            // 
            this.lblNumberOfRecords.AutoSize = true;
            this.lblNumberOfRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfRecords.Location = new System.Drawing.Point(119, 530);
            this.lblNumberOfRecords.Name = "lblNumberOfRecords";
            this.lblNumberOfRecords.Size = new System.Drawing.Size(14, 15);
            this.lblNumberOfRecords.TabIndex = 64;
            this.lblNumberOfRecords.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 529);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 16);
            this.label3.TabIndex = 63;
            this.label3.Text = "# Of Records:";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::DVLD_presentation.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(625, 532);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(163, 39);
            this.btnClose.TabIndex = 65;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // frmManageDrivers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 575);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblNumberOfRecords);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textDriversFilter);
            this.Controls.Add(this.cb_DriversFilter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgv_ManageDrivers);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "frmManageDrivers";
            this.Text = "frmManageDrivers";
            this.Load += new System.EventHandler(this.frmManageDrivers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ManageDrivers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textDriversFilter;
        private System.Windows.Forms.ComboBox cb_DriversFilter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_ManageDrivers;
        private System.Windows.Forms.Label lblNumberOfRecords;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnClose;
    }
}