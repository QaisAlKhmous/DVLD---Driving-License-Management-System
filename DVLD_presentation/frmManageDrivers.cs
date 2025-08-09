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
    public partial class frmManageDrivers : Form
    {
        public frmManageDrivers()
        {
            InitializeComponent();
        }

        private DataTable _Drivers;
        private DataView _DriversView;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cb_UsersFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            textDriversFilter.Text = null;
            textDriversFilter.KeyPress -= textPeopleFilter_KeyPress;
               
                textDriversFilter.Visible = true;
                if (cb_DriversFilter.SelectedIndex == 1 || cb_DriversFilter.SelectedIndex == 2|| cb_DriversFilter.SelectedIndex == 6)
                    textDriversFilter.KeyPress += textPeopleFilter_KeyPress;

        }


        private void textPeopleFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow digits (0-9) and backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true; // Ignore the input
            }
        }

        private void _RefreshDriversData()
        {

            _Drivers=clsDriver.GetAllDrivers();
            _DriversView=_Drivers.DefaultView;
            dgv_ManageDrivers.DataSource= _Drivers;
            lblNumberOfRecords.Text=dgv_ManageDrivers.RowCount.ToString();
        }

        private void frmManageDrivers_Load(object sender, EventArgs e)
        {
            _RefreshDriversData();
        }

        private void textDriversFilter_TextChanged(object sender, EventArgs e)
        {
            _DriversView.RowFilter = "";
            if (textDriversFilter.Text != "")

            {
                string column = cb_DriversFilter.Text.Replace(" ", "");

                _DriversView.RowFilter = $"CONVERT({column}, 'System.String') LIKE '{textDriversFilter.Text}%'";
            }
            dgv_ManageDrivers.DataSource = _DriversView;
            lblNumberOfRecords.Text = dgv_ManageDrivers.RowCount.ToString();
        }
    }
}
