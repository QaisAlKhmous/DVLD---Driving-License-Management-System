namespace DVLD_presentation
{
    partial class ctrlDriverLicenses
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
            this.tcDriverLicenses = new System.Windows.Forms.TabControl();
            this.tpLocal = new System.Windows.Forms.TabPage();
            this.tbInternational = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNumberOfRecodrs = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.dgvInternationalLicenses = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvLocalLicenses = new System.Windows.Forms.DataGridView();
            this.tcDriverLicenses.SuspendLayout();
            this.tpLocal.SuspendLayout();
            this.tbInternational.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInternationalLicenses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalLicenses)).BeginInit();
            this.SuspendLayout();
            // 
            // tcDriverLicenses
            // 
            this.tcDriverLicenses.Controls.Add(this.tpLocal);
            this.tcDriverLicenses.Controls.Add(this.tbInternational);
            this.tcDriverLicenses.Location = new System.Drawing.Point(6, 21);
            this.tcDriverLicenses.Name = "tcDriverLicenses";
            this.tcDriverLicenses.SelectedIndex = 0;
            this.tcDriverLicenses.Size = new System.Drawing.Size(751, 303);
            this.tcDriverLicenses.TabIndex = 0;
            this.tcDriverLicenses.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tpLocal
            // 
            this.tpLocal.Controls.Add(this.dgvLocalLicenses);
            this.tpLocal.Controls.Add(this.label2);
            this.tpLocal.Location = new System.Drawing.Point(4, 25);
            this.tpLocal.Name = "tpLocal";
            this.tpLocal.Padding = new System.Windows.Forms.Padding(3);
            this.tpLocal.Size = new System.Drawing.Size(743, 274);
            this.tpLocal.TabIndex = 0;
            this.tpLocal.Text = "Local";
            this.tpLocal.UseVisualStyleBackColor = true;
            // 
            // tbInternational
            // 
            this.tbInternational.Controls.Add(this.dgvInternationalLicenses);
            this.tbInternational.Controls.Add(this.lblTitle);
            this.tbInternational.Location = new System.Drawing.Point(4, 25);
            this.tbInternational.Name = "tbInternational";
            this.tbInternational.Padding = new System.Windows.Forms.Padding(3);
            this.tbInternational.Size = new System.Drawing.Size(743, 274);
            this.tbInternational.TabIndex = 1;
            this.tbInternational.Text = "International";
            this.tbInternational.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblNumberOfRecodrs);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tcDriverLicenses);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(763, 356);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Driver Licenses";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 327);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "# Records:";
            // 
            // lblNumberOfRecodrs
            // 
            this.lblNumberOfRecodrs.AutoSize = true;
            this.lblNumberOfRecodrs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfRecodrs.Location = new System.Drawing.Point(104, 329);
            this.lblNumberOfRecodrs.Name = "lblNumberOfRecodrs";
            this.lblNumberOfRecodrs.Size = new System.Drawing.Size(21, 15);
            this.lblNumberOfRecodrs.TabIndex = 2;
            this.lblNumberOfRecodrs.Text = "??";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(3, 14);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(203, 16);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "International License History";
            // 
            // dgvInternationalLicenses
            // 
            this.dgvInternationalLicenses.AllowUserToAddRows = false;
            this.dgvInternationalLicenses.AllowUserToDeleteRows = false;
            this.dgvInternationalLicenses.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvInternationalLicenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInternationalLicenses.GridColor = System.Drawing.Color.White;
            this.dgvInternationalLicenses.Location = new System.Drawing.Point(6, 33);
            this.dgvInternationalLicenses.Name = "dgvInternationalLicenses";
            this.dgvInternationalLicenses.ReadOnly = true;
            this.dgvInternationalLicenses.Size = new System.Drawing.Size(731, 235);
            this.dgvInternationalLicenses.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Local License History";
            // 
            // dgvLocalLicenses
            // 
            this.dgvLocalLicenses.AllowUserToAddRows = false;
            this.dgvLocalLicenses.AllowUserToDeleteRows = false;
            this.dgvLocalLicenses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLocalLicenses.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvLocalLicenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLocalLicenses.GridColor = System.Drawing.Color.White;
            this.dgvLocalLicenses.Location = new System.Drawing.Point(6, 31);
            this.dgvLocalLicenses.Name = "dgvLocalLicenses";
            this.dgvLocalLicenses.ReadOnly = true;
            this.dgvLocalLicenses.Size = new System.Drawing.Size(731, 235);
            this.dgvLocalLicenses.TabIndex = 5;
            // 
            // ctrlDriverLicenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "ctrlDriverLicenses";
            this.Size = new System.Drawing.Size(769, 360);
            this.tcDriverLicenses.ResumeLayout(false);
            this.tpLocal.ResumeLayout(false);
            this.tpLocal.PerformLayout();
            this.tbInternational.ResumeLayout(false);
            this.tbInternational.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInternationalLicenses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalLicenses)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcDriverLicenses;
        private System.Windows.Forms.TabPage tpLocal;
        private System.Windows.Forms.TabPage tbInternational;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblNumberOfRecodrs;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dgvInternationalLicenses;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvLocalLicenses;
    }
}
