namespace DVLD_presentation
{
    partial class ctrlPersonDetailsWithFilter
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbFindBy = new System.Windows.Forms.GroupBox();
            this.btnAddNewPerson = new System.Windows.Forms.Button();
            this.btnFindPerson = new System.Windows.Forms.Button();
            this.txtPeople = new System.Windows.Forms.TextBox();
            this.cb_PeopleFilter = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.ctrlPersonInformation1 = new DVLD_presentation.ctrlPersonInformation();
            this.gbFindBy.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbFindBy
            // 
            this.gbFindBy.Controls.Add(this.btnAddNewPerson);
            this.gbFindBy.Controls.Add(this.btnFindPerson);
            this.gbFindBy.Controls.Add(this.txtPeople);
            this.gbFindBy.Controls.Add(this.cb_PeopleFilter);
            this.gbFindBy.Controls.Add(this.label1);
            this.gbFindBy.Location = new System.Drawing.Point(3, 3);
            this.gbFindBy.Name = "gbFindBy";
            this.gbFindBy.Size = new System.Drawing.Size(626, 47);
            this.gbFindBy.TabIndex = 1;
            this.gbFindBy.TabStop = false;
            this.gbFindBy.Text = "Filter";
            // 
            // btnAddNewPerson
            // 
            this.btnAddNewPerson.BackgroundImage = global::DVLD_presentation.Properties.Resources.Add_Person_402;
            this.btnAddNewPerson.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddNewPerson.Location = new System.Drawing.Point(508, 13);
            this.btnAddNewPerson.Name = "btnAddNewPerson";
            this.btnAddNewPerson.Size = new System.Drawing.Size(34, 30);
            this.btnAddNewPerson.TabIndex = 8;
            this.btnAddNewPerson.UseVisualStyleBackColor = true;
            this.btnAddNewPerson.Click += new System.EventHandler(this.btnAddNewPerson_Click);
            // 
            // btnFindPerson
            // 
            this.btnFindPerson.BackgroundImage = global::DVLD_presentation.Properties.Resources.SearchPerson;
            this.btnFindPerson.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFindPerson.Location = new System.Drawing.Point(468, 13);
            this.btnFindPerson.Name = "btnFindPerson";
            this.btnFindPerson.Size = new System.Drawing.Size(34, 30);
            this.btnFindPerson.TabIndex = 7;
            this.btnFindPerson.UseVisualStyleBackColor = true;
            this.btnFindPerson.Click += new System.EventHandler(this.btnFindPerson_Click);
            // 
            // txtPeople
            // 
            this.txtPeople.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPeople.Location = new System.Drawing.Point(282, 17);
            this.txtPeople.Name = "txtPeople";
            this.txtPeople.Size = new System.Drawing.Size(180, 22);
            this.txtPeople.TabIndex = 6;
            this.txtPeople.TextChanged += new System.EventHandler(this.txtPeople_TextChanged);
            // 
            // cb_PeopleFilter
            // 
            this.cb_PeopleFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_PeopleFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_PeopleFilter.FormattingEnabled = true;
            this.cb_PeopleFilter.Items.AddRange(new object[] {
            "NationalNo",
            "PersonID"});
            this.cb_PeopleFilter.Location = new System.Drawing.Point(90, 17);
            this.cb_PeopleFilter.Name = "cb_PeopleFilter";
            this.cb_PeopleFilter.Size = new System.Drawing.Size(186, 23);
            this.cb_PeopleFilter.TabIndex = 5;
            this.cb_PeopleFilter.SelectedIndexChanged += new System.EventHandler(this.cb_PeopleFilter_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Find By:";
            // 
            // ctrlPersonInformation1
            // 
            this.ctrlPersonInformation1.Location = new System.Drawing.Point(0, 56);
            this.ctrlPersonInformation1.Name = "ctrlPersonInformation1";
            this.ctrlPersonInformation1.Size = new System.Drawing.Size(630, 266);
            this.ctrlPersonInformation1.TabIndex = 0;
            this.ctrlPersonInformation1.Load += new System.EventHandler(this.ctrlPersonInformation1_Load);
            // 
            // ctrlPersonDetailsWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbFindBy);
            this.Controls.Add(this.ctrlPersonInformation1);
            this.Name = "ctrlPersonDetailsWithFilter";
            this.Size = new System.Drawing.Size(632, 322);
            this.Load += new System.EventHandler(this.ctrlPersonDetailsWithFilter_Load);
            this.gbFindBy.ResumeLayout(false);
            this.gbFindBy.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlPersonInformation ctrlPersonInformation1;
        private System.Windows.Forms.GroupBox gbFindBy;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox cb_PeopleFilter;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.TextBox txtPeople;
        private System.Windows.Forms.Button btnFindPerson;
        private System.Windows.Forms.Button btnAddNewPerson;
    }
}
