using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD_businessLogic;

namespace DVLD_presentation
{
    public partial class ctrlPersonDetailsWithFilter : UserControl
    {
        public int PersonID;

        public ctrlPersonDetailsWithFilter()
        {
            InitializeComponent();
        }

        

        private void btnFindPerson_Click(object sender, EventArgs e)
        {
            if(txtPeople.Text!="")
            if (cb_PeopleFilter.SelectedIndex == 1)
            {
                ctrlPersonInformation1.FillControl(int.Parse(txtPeople.Text));
                    PersonID=ctrlPersonInformation1._PersonID;
                   
            }
            else
            {
                ctrlPersonInformation1.FillControl(txtPeople.Text);
                    PersonID = ctrlPersonInformation1._PersonID;
                }
            
        }

      

        private void btnAddNewPerson_Click(object sender, EventArgs e)
        {
            frmAddUpdatePerson frm = new frmAddUpdatePerson(-1);
            frm.RefreshDataUser += ctrlPersonInformation1.FillControl;
            frm.ShowDialog();
            PersonID = ctrlPersonInformation1._PersonID;


        }

        public void DisableFindBy(int PersonID)
        {
            cb_PeopleFilter.SelectedIndex = 1;
            txtPeople.Text =PersonID.ToString();    
            gbFindBy.Enabled = false;
        }

        public void FindPerson(int PersonID)
        {
            this.PersonID = PersonID;
            ctrlPersonInformation1.FillControl(PersonID);
            

        }

        private void txtPeople_TextChanged(object sender, EventArgs e)
        {

        }

        private void ctrlPersonDetailsWithFilter_Load(object sender, EventArgs e)
        {
            cb_PeopleFilter.SelectedIndex = 0;
        }

        private void cb_PeopleFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtPeople.Text = "";
        }

        private void ctrlPersonInformation1_Load(object sender, EventArgs e)
        {

        }
    }
}
