using DVLD_businessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_presentation
{
    public partial class ctrlApplicationBasicInfo : UserControl
    {

        clsPerson Applicant;
        public ctrlApplicationBasicInfo()
        {
            InitializeComponent();
        }


        public void FillControl(int ApplicationID)
        {
            //We can make a join query instead
            clsApplication app=clsApplication.Find(ApplicationID);
            clsApplicationType appType= clsApplicationType.Find(app.ApplicationTypeID);
             Applicant=clsPerson.FindByID(app.ApplicationPersonID);

            lblAppID.Text=app.ApplicationID.ToString();
            
            switch(app.ApplicationStatus)
            {
                case 1: lblAppStatus.Text = "New";break;
                case 2:lblAppStatus.Text = "Cancelled";break;
                case 3:lblAppStatus.Text = "Completed";break;
            }

            lblFees.Text=appType.ApplicationFees.ToString();    
            lblType.Text=appType.ApplicationTypeTitle.ToString();
            lblApplicant.Text = Applicant.FirstName + " " + Applicant.SecondName + " " + Applicant.ThirdName + " " + Applicant.LastName;
            lblDate.Text=app.ApplicationDate.ToString("d");
            lblStatusDate.Text=app.ApplicationStatus.ToString("d");
            lblCreatedByUser.Text=clsGlobalSettings._LogedInUser.UserName;


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmPersonDetails frm=new frmPersonDetails(Applicant.PersonID);
            frm.ShowDialog();
        }
    }
}
