namespace DVLD_presentation
{
    partial class ManagePeopleForm
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
            this.dgv_ManagePeople = new System.Windows.Forms.DataGridView();
            this.cmsPeople = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmShowPersondetails = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cmAddPerson = new System.Windows.Forms.ToolStripMenuItem();
            this.cmEditPerson = new System.Windows.Forms.ToolStripMenuItem();
            this.cmDeletePerson = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.sendEmailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phoneCallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_PeopleFilter = new System.Windows.Forms.ComboBox();
            this.textPeopleFilter = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNumberOfRecords = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAddPerson = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ManagePeople)).BeginInit();
            this.cmsPeople.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_ManagePeople
            // 
            this.dgv_ManagePeople.AllowUserToAddRows = false;
            this.dgv_ManagePeople.AllowUserToDeleteRows = false;
            this.dgv_ManagePeople.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ManagePeople.ContextMenuStrip = this.cmsPeople;
            this.dgv_ManagePeople.Location = new System.Drawing.Point(12, 190);
            this.dgv_ManagePeople.Name = "dgv_ManagePeople";
            this.dgv_ManagePeople.ReadOnly = true;
            this.dgv_ManagePeople.Size = new System.Drawing.Size(1336, 215);
            this.dgv_ManagePeople.TabIndex = 0;
            // 
            // cmsPeople
            // 
            this.cmsPeople.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmShowPersondetails,
            this.toolStripSeparator1,
            this.cmAddPerson,
            this.cmEditPerson,
            this.cmDeletePerson,
            this.toolStripSeparator2,
            this.sendEmailToolStripMenuItem,
            this.phoneCallToolStripMenuItem});
            this.cmsPeople.Name = "cmsPeople";
            this.cmsPeople.Size = new System.Drawing.Size(181, 170);
            // 
            // cmShowPersondetails
            // 
            this.cmShowPersondetails.Image = global::DVLD_presentation.Properties.Resources.PersonDetails_32;
            this.cmShowPersondetails.Name = "cmShowPersondetails";
            this.cmShowPersondetails.Size = new System.Drawing.Size(180, 22);
            this.cmShowPersondetails.Text = "Show Details";
            this.cmShowPersondetails.Click += new System.EventHandler(this.cmShowPersondetails_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // cmAddPerson
            // 
            this.cmAddPerson.Image = global::DVLD_presentation.Properties.Resources.Add_Person_401;
            this.cmAddPerson.Name = "cmAddPerson";
            this.cmAddPerson.Size = new System.Drawing.Size(180, 22);
            this.cmAddPerson.Text = "Add New Person";
            this.cmAddPerson.Click += new System.EventHandler(this.cmAddPerson_Click);
            // 
            // cmEditPerson
            // 
            this.cmEditPerson.Image = global::DVLD_presentation.Properties.Resources.edit_32;
            this.cmEditPerson.Name = "cmEditPerson";
            this.cmEditPerson.Size = new System.Drawing.Size(180, 22);
            this.cmEditPerson.Text = "Edit";
            this.cmEditPerson.Click += new System.EventHandler(this.cmEditPerson_Click);
            // 
            // cmDeletePerson
            // 
            this.cmDeletePerson.Image = global::DVLD_presentation.Properties.Resources.Delete_32;
            this.cmDeletePerson.Name = "cmDeletePerson";
            this.cmDeletePerson.Size = new System.Drawing.Size(180, 22);
            this.cmDeletePerson.Text = "Delete";
            this.cmDeletePerson.Click += new System.EventHandler(this.cmDeletePerson_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // sendEmailToolStripMenuItem
            // 
            this.sendEmailToolStripMenuItem.Image = global::DVLD_presentation.Properties.Resources.send_email_32;
            this.sendEmailToolStripMenuItem.Name = "sendEmailToolStripMenuItem";
            this.sendEmailToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sendEmailToolStripMenuItem.Text = "Send Email";
            // 
            // phoneCallToolStripMenuItem
            // 
            this.phoneCallToolStripMenuItem.Image = global::DVLD_presentation.Properties.Resources.call_32;
            this.phoneCallToolStripMenuItem.Name = "phoneCallToolStripMenuItem";
            this.phoneCallToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.phoneCallToolStripMenuItem.Text = "Phone Call";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(613, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Manage People";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Filter By:";
            // 
            // cb_PeopleFilter
            // 
            this.cb_PeopleFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_PeopleFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_PeopleFilter.FormattingEnabled = true;
            this.cb_PeopleFilter.Items.AddRange(new object[] {
            "None",
            "PersonID",
            "NationalNo",
            "FirstName",
            "SecondName",
            "ThirdName",
            "LastName",
            "Gender",
            "Phone",
            "Email",
            "Noationality"});
            this.cb_PeopleFilter.Location = new System.Drawing.Point(93, 160);
            this.cb_PeopleFilter.Name = "cb_PeopleFilter";
            this.cb_PeopleFilter.Size = new System.Drawing.Size(121, 23);
            this.cb_PeopleFilter.TabIndex = 4;
            this.cb_PeopleFilter.SelectedIndexChanged += new System.EventHandler(this.cb_PeopleFilter_SelectedIndexChanged);
            // 
            // textPeopleFilter
            // 
            this.textPeopleFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPeopleFilter.Location = new System.Drawing.Point(220, 161);
            this.textPeopleFilter.Name = "textPeopleFilter";
            this.textPeopleFilter.Size = new System.Drawing.Size(171, 22);
            this.textPeopleFilter.TabIndex = 5;
            this.textPeopleFilter.Visible = false;
            this.textPeopleFilter.TextChanged += new System.EventHandler(this.textPeopleFilter_TextChanged);
            this.textPeopleFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textPeopleFilter_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 425);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "# Of Records:";
            // 
            // lblNumberOfRecords
            // 
            this.lblNumberOfRecords.AutoSize = true;
            this.lblNumberOfRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfRecords.Location = new System.Drawing.Point(122, 426);
            this.lblNumberOfRecords.Name = "lblNumberOfRecords";
            this.lblNumberOfRecords.Size = new System.Drawing.Size(14, 15);
            this.lblNumberOfRecords.TabIndex = 7;
            this.lblNumberOfRecords.Text = "0";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::DVLD_presentation.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(1232, 411);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(116, 39);
            this.btnClose.TabIndex = 37;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAddPerson
            // 
            this.btnAddPerson.Image = global::DVLD_presentation.Properties.Resources.Add_Person_40;
            this.btnAddPerson.Location = new System.Drawing.Point(1261, 129);
            this.btnAddPerson.Name = "btnAddPerson";
            this.btnAddPerson.Size = new System.Drawing.Size(66, 55);
            this.btnAddPerson.TabIndex = 8;
            this.btnAddPerson.UseVisualStyleBackColor = true;
            this.btnAddPerson.Click += new System.EventHandler(this.btnAddPerson_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD_presentation.Properties.Resources.People_400;
            this.pictureBox1.Location = new System.Drawing.Point(634, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(151, 105);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // ManagePeopleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1360, 462);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAddPerson);
            this.Controls.Add(this.lblNumberOfRecords);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textPeopleFilter);
            this.Controls.Add(this.cb_PeopleFilter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_ManagePeople);
            this.Name = "ManagePeopleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManagePeopleForm";
            this.Load += new System.EventHandler(this.ManagePeopleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ManagePeople)).EndInit();
            this.cmsPeople.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_ManagePeople;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_PeopleFilter;
        private System.Windows.Forms.TextBox textPeopleFilter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNumberOfRecords;
        private System.Windows.Forms.Button btnAddPerson;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ContextMenuStrip cmsPeople;
        private System.Windows.Forms.ToolStripMenuItem cmShowPersondetails;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem sendEmailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cmAddPerson;
        private System.Windows.Forms.ToolStripMenuItem cmDeletePerson;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem phoneCallToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cmEditPerson;
    }
}