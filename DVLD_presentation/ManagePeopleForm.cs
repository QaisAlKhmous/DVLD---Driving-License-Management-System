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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DVLD_presentation
{
    public partial class ManagePeopleForm : Form
    {
        public ManagePeopleForm()
        {
            InitializeComponent();
        }


        private void RefreshPeopleData()
        {
            dgv_ManagePeople.DataSource = clsPerson.GetAllPeople();
            lblNumberOfRecords.Text = dgv_ManagePeople.RowCount.ToString();
        }
        

        private void ManagePeopleForm_Load(object sender, EventArgs e)
        {
            RefreshPeopleData();


            cb_PeopleFilter.SelectedIndex = 0;
              
            
        }

        private void cb_PeopleFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
          
            textPeopleFilter.Text = null;
            textPeopleFilter.Visible = true;
            textPeopleFilter.KeyPress -= textPeopleFilter_KeyPress;

            if (cb_PeopleFilter.SelectedIndex == 0)
                
            {
                textPeopleFilter.Visible = false;
                 
                    

            }
           

           if(cb_PeopleFilter.SelectedIndex == 1  ||  cb_PeopleFilter.SelectedIndex==8)
            {
                 
                
                textPeopleFilter.KeyPress += textPeopleFilter_KeyPress;
            }
           
        }

      

        private void textPeopleFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow digits (0-9) and backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true; // Ignore the input
            }
        }

      

        private void textPeopleFilter_TextChanged(object sender, EventArgs e)
        {
            if (textPeopleFilter.Text == "")
            {
                dgv_ManagePeople.DataSource = clsPerson.GetAllPeople();

            }
            else
            {
                switch (cb_PeopleFilter.SelectedIndex)
                {

                    case 0: RefreshPeopleData(); break;
                    case 1: dgv_ManagePeople.DataSource = clsPerson.FilterPeopleByPersonID(textPeopleFilter.Text); break;
                    case 2: dgv_ManagePeople.DataSource = clsPerson.FilterPeopleByNationalNo(textPeopleFilter.Text); break;
                    case 3: dgv_ManagePeople.DataSource = clsPerson.FilterPeopleByFirstName(textPeopleFilter.Text); break;
                    case 4: dgv_ManagePeople.DataSource = clsPerson.FilterPeopleBySecondName(textPeopleFilter.Text); break;
                    case 5: dgv_ManagePeople.DataSource = clsPerson.FilterPeopleByThirdName(textPeopleFilter.Text); break;
                    case 6: dgv_ManagePeople.DataSource = clsPerson.FilterPeopleByLastName(textPeopleFilter.Text); break;
                    case 7: dgv_ManagePeople.DataSource = clsPerson.FilterPeopleByGender(textPeopleFilter.Text); break;
                    case 8: dgv_ManagePeople.DataSource = clsPerson.FilterPeopleByPhone(textPeopleFilter.Text); break;
                    case 9: dgv_ManagePeople.DataSource = clsPerson.FilterPeopleByEmail(textPeopleFilter.Text); break;
                    case 10: dgv_ManagePeople.DataSource = clsPerson.FilterPeopleByNationality(textPeopleFilter.Text); break;

                }
            }
            lblNumberOfRecords.Text=dgv_ManagePeople.RowCount.ToString();   
            
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            frmAddUpdatePerson frm =new frmAddUpdatePerson(-1);
            frm.RefreshData += RefreshPeopleData;
            frm.ShowDialog();

            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private bool DeletePerson()
        {
            int personID = int.Parse(dgv_ManagePeople.CurrentRow.Cells[0].Value.ToString());
          if(  MessageBox.Show($"Are You Sure You Want To Delete This Person [{personID}]", "Confirm Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2)==DialogResult.OK )

            {
                clsPerson.DeletePerson(personID);

                if (clsPerson.isPersonExistsByID(personID))
                {
                    MessageBox.Show("Person Was Not Deleted Because It Has Data Linked To It!","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                
                return true;
            }
            return false;

        }

        private void cmDeletePerson_Click(object sender, EventArgs e)
        {

            if (DeletePerson())
            {
                RefreshPeopleData();
                MessageBox.Show("Person Deleted Successfuly!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void cmEditPerson_Click(object sender, EventArgs e)
        {
            int personID = int.Parse(dgv_ManagePeople.CurrentRow.Cells[0].Value.ToString());
            
            frmAddUpdatePerson frm = new frmAddUpdatePerson(personID);
            frm.RefreshData += RefreshPeopleData;
            frm.ShowDialog();
        }

        private void cmShowPersondetails_Click(object sender, EventArgs e)
        {
            int personID = int.Parse(dgv_ManagePeople.CurrentRow.Cells[0].Value.ToString());
            frmPersonDetails frm = new frmPersonDetails(personID);  
            frm.ShowDialog();
            RefreshPeopleData();
        }

        private void cmAddPerson_Click(object sender, EventArgs e)
        {
            frmAddUpdatePerson frm = new frmAddUpdatePerson(-1);
            frm.RefreshData += RefreshPeopleData;
            frm.ShowDialog();
        }
    }
}

