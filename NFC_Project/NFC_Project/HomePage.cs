using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NFC_Project.DataContainers;

namespace NFC_Project
{
    public partial class HomePage : Form
    {

        public List<Laptop> LaptopList;
        public List<Rental> RentalList;
        public List<User> UserList;

        public HomePage()
        {
            InitializeComponent();

            LaptopList = new List<Laptop>();
            RentalList = new List<Rental>();
            UserList = new List<User>();

            AddTestData();
        }

        private void AddTestData()
        {
            UserList.Add(new User("staircd", "Cameron", "Stair", "staircd@miamioh.edu", "5135601882"));
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        /// Naviagtion Methods ////////////////////////////////////
        private void btnAddLaptop_Click(object sender, EventArgs e)
        {
            this.HomePagePanel.Visible = false;
            this.AddLaptopPanel.Visible = true;

            ResetAddLaptopPage();
        }
        private void btn_AddLaptop_Back_Click(object sender, EventArgs e)
        {
            this.HomePagePanel.Visible = true;
            this.AddLaptopPanel.Visible = false;
        }
        private void btn_CheckOut_Back_Click(object sender, EventArgs e)
        {
            this.CheckOutLaptopPanel.Visible = false;
            this.HomePagePanel.Visible = true;
            ResetCheckOutPage();
        }
        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            this.HomePagePanel.Visible = false;
            this.CheckOutLaptopPanel.Visible = true;
            DisableCheckOutUserFields();
        }

        /// Check Out Page Methods ////////////////////////////////
        private void tbx_CheckOut_SerialNum_TextChanged(object sender, EventArgs e)
        {
            if (tbx_CheckOut_SerialNum.TextLength == 14)
            {
                lbl_CheckOut_ReadyToScanNFC.Text = "Laptop ID Scanned Succesfully";
                btn_CheckOut_Rescan.Visible = true;
                tbx_CheckOut_SerialNum.Enabled = false;
            }

        }
        private void tbx_CheckOut_SerialNum_Enter(object sender, EventArgs e)
        {
            if (tbx_CheckOut_SerialNum.Text == "Scan Laptop ID Tag")
            {
                tbx_CheckOut_SerialNum.Text = "";
                lbl_CheckOut_ReadyToScanNFC.Visible = true;
            }
        }
        private void tbx_CheckOut_SerialNum_Leave(object sender, EventArgs e)
        {
            if (tbx_CheckOut_SerialNum.Text == "")
            {
                tbx_CheckOut_SerialNum.Text = "Scan Laptop ID Tag";
                lbl_CheckOut_ReadyToScanNFC.Visible = false;
            }
        }
        private void tbxCheckOut_UniqueID_Enter(object sender, EventArgs e)
        {
            if (tbxCheckOut_UniqueID.Text == "Enter Unique ID")
            {
                tbxCheckOut_UniqueID.Text = "";
            }
        }
        private void tbxCheckOut_UniqueID_Leave(object sender, EventArgs e)
        {
            if (tbxCheckOut_UniqueID.Text == "")
            {
                tbxCheckOut_UniqueID.Text = "Enter Unique ID";
            }
        }
        private void btn_CheckOut_Rescan_Click(object sender, EventArgs e)
        {
            tbx_CheckOut_SerialNum.Enabled = true;
            lbl_CheckOut_ReadyToScanNFC.Text = "Ready to Scan NFC Chip";
            tbx_CheckOut_SerialNum.Text = "";
            btn_CheckOut_Rescan.Visible = false;
            tbx_CheckOut_SerialNum.Focus();
        }
        private void ResetCheckOutPage()
        {
            tbx_CheckOut_SerialNum.Text = "Laptop Serial Number";
            tbxCheckOut_UniqueID.Text = "Enter Unique ID";
            lbl_CheckOut_ReadyToScanNFC.Visible = false;
            lbl_CheckOut_ReadyToScanNFC.Text = "Ready to Scan NFC Chip";
            btn_CheckOut_Rescan.Visible = false;
            tbx_CheckOut_SerialNum.Enabled = true;
            DisableCheckOutUserFields();
            ResetCheckOutUserFields();
        }

        private void btn_CheckOut_LookupUser_Click(object sender, EventArgs e)
        {
            string id = tbxCheckOut_UniqueID.Text.Trim();
            User MatchedUser = null;

            foreach (User u in UserList)
            {
                if (id == u.UniqueID)
                {
                    MatchedUser = u;
                }
            }

            if (MatchedUser != null)
            {
                lbl_CheckOut_UserFound.Visible = true;
                lbl_CheckOut_UserFound.Text = "User Found Successfully";
                AssignUserDataToFields(MatchedUser);
            }
            else
            {
                lbl_CheckOut_UserFound.Visible = true;
                lbl_CheckOut_UserFound.Text = "User Does Not Exist - Enter Information";
                ResetCheckOutUserFields();
                EnableCheckOutUSerFields();
            }

        }

        private void DisableCheckOutUserFields()
        {
            tbx_CheckOut_FirstName.Enabled = false;
            tbx_CheckOut_LastName.Enabled = false;
            tbx_CheckOut_UserEmail.Enabled = false;
            tbx_CheckOut_UserPhone.Enabled = false;
        }
        private void EnableCheckOutUSerFields()
        {
            tbx_CheckOut_FirstName.Enabled = true;
            tbx_CheckOut_LastName.Enabled = true;
            tbx_CheckOut_UserEmail.Enabled = true;
            tbx_CheckOut_UserPhone.Enabled = true;
        }
        private void ResetCheckOutUserFields()
        {
            tbx_CheckOut_FirstName.Text = "Enter First Name";
            tbx_CheckOut_LastName.Text = "Enter Last Name";
            tbx_CheckOut_UserEmail.Text = "Enter Email";
            tbx_CheckOut_UserPhone.Text = "Enter Phone Number";
        }

        private void AssignUserDataToFields(User user)
        {
            tbx_CheckOut_FirstName.Text = user.FirstName;
            tbx_CheckOut_LastName.Text = user.LastName;
            tbx_CheckOut_UserEmail.Text = user.EmailAddress;
            tbx_CheckOut_UserPhone.Text = user.PhoneNumber;
        }

        private void tbx_CheckOut_FirstName_Enter(object sender, EventArgs e)
        {
            if (tbx_CheckOut_FirstName.Text == "Enter First Name")
            {
                tbx_CheckOut_FirstName.Text = "";
            }
        }
        private void tbx_CheckOut_FirstName_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(tbx_CheckOut_FirstName.Text))
            {
                tbx_CheckOut_FirstName.Text = "Enter First Name";
            }
        }
        private void tbx_CheckOut_LastName_Enter(object sender, EventArgs e)
        {
            if (tbx_CheckOut_LastName.Text == "Enter Last Name")
            {
                tbx_CheckOut_LastName.Text = "";
            }
        }
        private void tbx_CheckOut_LastName_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(tbx_CheckOut_LastName.Text))
            {
                tbx_CheckOut_LastName.Text = "Enter Last Name";
            }
        }
        private void tbx_CheckOut_UserEmail_Enter(object sender, EventArgs e)
        {
            if (tbx_CheckOut_UserEmail.Text == "Enter Email")
            {
                tbx_CheckOut_UserEmail.Text = "";
            }
        }
        private void tbx_CheckOut_UserEmail_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(tbx_CheckOut_UserEmail.Text))
            {
                tbx_CheckOut_UserEmail.Text = "Enter Email";
            }
        }
        private void tbx_CheckOut_UserPhone_Enter(object sender, EventArgs e)
        {
            if (tbx_CheckOut_UserPhone.Text == "Enter Phone Number")
            {
                tbx_CheckOut_UserPhone.Text = "";
            }
        }
        private void tbx_CheckOut_UserPhone_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(tbx_CheckOut_UserPhone.Text))
            {
                tbx_CheckOut_UserPhone.Text = "Enter Phone Number";
            }
        }

        /// Add Laptop Page Methods //////////////////////////////
        private void ResetAddLaptopPage()
        {
            btn_AddLaptop_Rescan.Visible = false;
            lbl_AddLaptop_ScanStatus.Visible = false;
            lbl_AddLaptop_ScanStatus.Text = "Ready to Scan NFC Chip";
            tbx_AddLaptop_LaptopID.Enabled = true;
            tbx_AddLaptop_LaptopID.Text = "Scan Laptop ID Tag";

            DisableAddLaptopTextFields();
        }

        private void ResetAddLaptopTextFields()
        {
            tbx_AddLaptop_Brand.Text = "Laptop Brand";
            tbx_AddLaptop_Condition.Text = "Laptop Condition";
            tbx_AddLaptop_Memory.Text = "Laptop Memory";
            tbx_AddLaptop_Model.Text = "Laptop Model";
            tbx_AddLaptop_OSVersion.Text = "Laptop OS Version";
            tbx_AddLaptop_Processor.Text = "Laptop Processor";
            tbx_AddLaptop_RAM.Text = "Laptop RAM";
            tbx_AddLaptop_Resolution.Text = "Laptop Resolution";
            tbx_AddLaptop_Size.Text = "Laptop Screen Size";
            rdo_AddLaptop_InService_No.Checked = false;
            rdo_AddLaptop_InService_Yes.Checked = false;
            dtp_AddLaptop_DateAdded.Value = DateTime.Today;
            tbx_AddLaptop_SerialNum.Text = "Laptop Serial Number";
        }
        private void DisableAddLaptopTextFields()
        {
            tbx_AddLaptop_Brand.Enabled = false;
            tbx_AddLaptop_Condition.Enabled = false;
            tbx_AddLaptop_Memory.Enabled = false;
            tbx_AddLaptop_Model.Enabled = false;
            tbx_AddLaptop_OSVersion.Enabled = false;
            tbx_AddLaptop_Processor.Enabled = false;
            tbx_AddLaptop_RAM.Enabled = false;
            tbx_AddLaptop_Resolution.Enabled = false;
            tbx_AddLaptop_Size.Enabled = false;
            rdo_AddLaptop_InService_No.Enabled = false;
            rdo_AddLaptop_InService_Yes.Enabled = false;
            dtp_AddLaptop_DateAdded.Enabled = false;
            tbx_AddLaptop_SerialNum.Enabled = false;
        }
        private void EnableAddLaptopTextFields()
        {
            tbx_AddLaptop_Brand.Enabled = true;
            tbx_AddLaptop_Condition.Enabled = true;
            tbx_AddLaptop_Memory.Enabled = true;
            tbx_AddLaptop_Model.Enabled = true;
            tbx_AddLaptop_OSVersion.Enabled = true;
            tbx_AddLaptop_Processor.Enabled = true;
            tbx_AddLaptop_RAM.Enabled = true;
            tbx_AddLaptop_Resolution.Enabled = true;
            tbx_AddLaptop_Size.Enabled = true;
            rdo_AddLaptop_InService_No.Enabled = true;
            rdo_AddLaptop_InService_Yes.Enabled = true;
            dtp_AddLaptop_DateAdded.Enabled = true;
            tbx_AddLaptop_SerialNum.Enabled = true;
        }

        private void tbx_AddLaptop_LaptopID_TextChanged(object sender, EventArgs e)
        {
            if (tbx_AddLaptop_LaptopID.TextLength == 14)
            {
                lbl_AddLaptop_ScanStatus.Text = "Laptop ID Scanned Succesfully";
                btn_AddLaptop_Rescan.Visible = true;
                tbx_AddLaptop_LaptopID.Enabled = false;

                EnableAddLaptopTextFields();
            }
        }
        private void tbx_AddLaptop_LaptopID_Enter(object sender, EventArgs e)
        {
            if (tbx_AddLaptop_LaptopID.Text == "Scan Laptop ID Tag")
            {
                tbx_AddLaptop_LaptopID.Text = "";
                lbl_AddLaptop_ScanStatus.Visible = true;
            }
        }
        private void tbx_AddLaptop_LaptopID_Leave(object sender, EventArgs e)
        {
            if (tbx_AddLaptop_LaptopID.Text == "")
            {
                tbx_AddLaptop_LaptopID.Text = "Scan Laptop ID";
                lbl_AddLaptop_ScanStatus.Visible = false;
            }
        }
        private void btn_AddLaptop_Rescan_Click(object sender, EventArgs e)
        {
            tbx_AddLaptop_LaptopID.Enabled = true;
            lbl_AddLaptop_ScanStatus.Text = "Ready to Scan NFC Chip";
            tbx_AddLaptop_LaptopID.Text = "";
            btn_AddLaptop_Rescan.Visible = false;
            tbx_AddLaptop_LaptopID.Focus();

            DisableAddLaptopTextFields();
            ResetAddLaptopTextFields();
        }

        private void tbx_AddLaptop_SerialNum_Enter(object sender, EventArgs e)
        {
            if (tbx_AddLaptop_SerialNum.Text == "Laptop Serial Number")
            {
                tbx_AddLaptop_SerialNum.Text = "";
            }
        }
        private void tbx_AddLaptop_SerialNum_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(tbx_AddLaptop_SerialNum.Text))
            {
                tbx_AddLaptop_SerialNum.Text = "Laptop Serial Number";
            }
        }
        private void tbx_AddLaptop_Brand_Enter(object sender, EventArgs e)
        {
            if (tbx_AddLaptop_Brand.Text == "Laptop Brand")
            {
                tbx_AddLaptop_Brand.Text = "";
            }
        }
        private void tbx_AddLaptop_Brand_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(tbx_AddLaptop_Brand.Text))
            {
                tbx_AddLaptop_Brand.Text = "Laptop Brand";
            }
        }
        private void tbx_AddLaptop_Model_Enter(object sender, EventArgs e)
        {
            if (tbx_AddLaptop_Model.Text == "Laptop Model")
            {
                tbx_AddLaptop_Model.Text = "";
            }
        }
        private void tbx_AddLaptop_Model_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(tbx_AddLaptop_Model.Text))
            {
                tbx_AddLaptop_Model.Text = "Laptop Model";
            }
        }
        private void tbx_AddLaptop_Processor_Enter(object sender, EventArgs e)
        {
            if (tbx_AddLaptop_Processor.Text == "Laptop Processor")
            {
                tbx_AddLaptop_Processor.Text = "";
            }
        }
        private void tbx_AddLaptop_Processor_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(tbx_AddLaptop_Processor.Text))
            {
                tbx_AddLaptop_Processor.Text = "Laptop Processor";
            }
        }
        private void tbx_AddLaptop_RAM_Enter(object sender, EventArgs e)
        {
            if (tbx_AddLaptop_RAM.Text == "Laptop RAM")
            {
                tbx_AddLaptop_RAM.Text = "";
            }
        }
        private void tbx_AddLaptop_RAM_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(tbx_AddLaptop_RAM.Text))
            {
                tbx_AddLaptop_RAM.Text = "Laptop RAM";
            }
        }
        private void tbx_AddLaptop_Resolution_Enter(object sender, EventArgs e)
        {
            if (tbx_AddLaptop_Resolution.Text == "Laptop Resolution")
            {
                tbx_AddLaptop_Resolution.Text = "";
            }
        }
        private void tbx_AddLaptop_Resolution_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(tbx_AddLaptop_Resolution.Text))
            {
                tbx_AddLaptop_Resolution.Text = "Laptop Resolution";
            }
        }
        private void tbx_AddLaptop_Size_Enter(object sender, EventArgs e)
        {
            if (tbx_AddLaptop_Size.Text == "Laptop Screen Size")
            {
                tbx_AddLaptop_Size.Text = "";
            }
        }
        private void tbx_AddLaptop_Size_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(tbx_AddLaptop_Size.Text))
            {
                tbx_AddLaptop_Size.Text = "Laptop Screen Size";
            }
        }
        private void tbx_AddLaptop_Condition_Enter(object sender, EventArgs e)
        {
            if (tbx_AddLaptop_Condition.Text == "Laptop Condition")
            {
                tbx_AddLaptop_Condition.Text = "";
            }
        }
        private void tbx_AddLaptop_Condition_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(tbx_AddLaptop_Condition.Text))
            {
                tbx_AddLaptop_Condition.Text = "Laptop Condition";
            }
        }
        private void tbx_AddLaptop_Memory_Enter(object sender, EventArgs e)
        {
            if (tbx_AddLaptop_Memory.Text == "Laptop Memory")
            {
                tbx_AddLaptop_Memory.Text = "";
            }
        }
        private void tbx_AddLaptop_Memory_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(tbx_AddLaptop_Memory.Text))
            {
                tbx_AddLaptop_Memory.Text = "Laptop Memory";
            }
        }
        private void tbx_AddLaptop_OSVersion_Enter(object sender, EventArgs e)
        {
            if (tbx_AddLaptop_OSVersion.Text == "Laptop OS Version")
            {
                tbx_AddLaptop_OSVersion.Text = "";
            }
        }
        private void tbx_AddLaptop_OSVersion_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(tbx_AddLaptop_OSVersion.Text))
            {
                tbx_AddLaptop_OSVersion.Text = "Laptop OS Version";
            }
        }


    }
}
