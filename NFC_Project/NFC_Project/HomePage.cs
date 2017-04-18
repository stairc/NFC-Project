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
using Oracle.ManagedDataAccess.Client;

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

            CheckOutLaptopPanel.Visible = false;
            ReturnLaptopPanel.Visible = false;
            AddLaptopPanel.Visible = false;
            CheckInventoryPanel.Visible = false;

            DBManager db = new DBManager();
            db.Connect();
        }

        private void AddTestData()
        {
            //UserList.Add(new User("staircd", "Cameron", "Stair", "staircd@miamioh.edu", "5135601882"));
            //UserList.Add(new User("stairlj", "Landen", "Stair", "stairlj@miamioh.edu", "5135601991"));

            RentalList.Add(new Rental("046A2AAAD72C80", "11111111111111"));
            RentalList.Add(new Rental(Guid.NewGuid().ToString(), "046A2AAAD72C80", "98765432109876", new DateTime(2017, 4, 15).Ticks, new DateTime(2017, 4, 16).Ticks));

            LaptopList.Add(new Laptop("11111111111111", "9999-9999", Laptop.DeviceTypes.Laptop, "Dell", "Insperon", "i7", "8GB", "720p", "15.2 in.", DateTime.Today, true, "1TB", "Windows 10"));
            LaptopList.Add(new Laptop("12345678901234", "1559-7895", Laptop.DeviceTypes.Laptop, "Dell", "Insperon", "i7", "8GB", "720p", "15.2 in.", DateTime.Today, true, "1TB", "Windows 10"));
            LaptopList.Add(new Laptop("98765432109876", "1111-1234", Laptop.DeviceTypes.Laptop, "Dell", "Insperon", "i7", "8GB", "720p", "15.2 in.", DateTime.Today.AddDays(-5), true, "1TB", "Windows 10"));

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
            ResetCheckOutPage();
        }
        private void btn_Return_Back_Click(object sender, EventArgs e)
        {
            this.ReturnLaptopPanel.Visible = false;
            this.HomePagePanel.Visible = true;
        }
        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            this.HomePagePanel.Visible = false;
            this.ReturnLaptopPanel.Visible = true;
            ResetReturnPage();
        }
        private void btn_CheckInventory_Back_Click(object sender, EventArgs e)
        {
            this.HomePagePanel.Visible = true;
            this.CheckInventoryPanel.Visible = false;
        }
        private void btnInventory_Click(object sender, EventArgs e)
        {
            this.HomePagePanel.Visible = false;
            this.CheckInventoryPanel.Visible = true;

            tab_CheckInventory_TabControl.SelectedIndex = 0;

            btn_CheckOut_RefeshData_Click(null, null);
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
        private void tbxCheckOut_UserSerialNum_TextChanged(object sender, EventArgs e)
        {
            if (tbx_CheckOut_UserSerialNum.TextLength == 14)
            {
                lbl_CheckOut_UserFound.Text = "Miami ID Scanned Succesfully";
                btn_CheckOut_RescanID.Visible = true;
                tbx_CheckOut_UserSerialNum.Enabled = false;
                DisableCheckOutUserFields();
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
            if (tbx_CheckOut_UserSerialNum.Text == "Scan Miami ID")
            {
                tbx_CheckOut_UserSerialNum.Text = "";
                lbl_CheckOut_UserFound.Visible = true;
            }
        }
        private void tbxCheckOut_UniqueID_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(tbx_CheckOut_UserSerialNum.Text))
            {
                tbx_CheckOut_UserSerialNum.Text = "Scan Miami ID";
                lbl_CheckOut_UserFound.Visible = false;
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
            tbx_CheckOut_SerialNum.Text = "Scan Laptop ID Tag";
            tbx_CheckOut_UserSerialNum.Text = "Scan Miami ID";
            tbx_CheckOut_UserSerialNum.Enabled = true;
            lbl_CheckOut_ReadyToScanNFC.Visible = false;
            lbl_CheckOut_ReadyToScanNFC.Text = "Ready to Scan NFC Chip";
            lbl_CheckOut_UserFound.Text = "Ready to Scan Miami ID";
            lbl_CheckOut_UserFound.Visible = false;
            btn_CheckOut_Rescan.Visible = false;
            tbx_CheckOut_SerialNum.Enabled = true;
            btn_CheckOut_RescanID.Visible = false;
            ResetCheckOutUserFields();
        }

        private void btn_CheckOut_RescanID_Click(object sender, EventArgs e)
        {
            if (tbx_CheckOut_UserSerialNum.Text != "Scan Miami ID" &&
                !String.IsNullOrWhiteSpace(tbx_CheckOut_UserSerialNum.Text))
            {
                tbx_CheckOut_UserSerialNum.Text = "";
                tbx_CheckOut_UserSerialNum.Enabled = true;
                tbx_CheckOut_UserSerialNum.Focus();
                lbl_CheckOut_UserFound.Text = "Ready to Scan Miami ID";
                EnableCheckOutUSerFields();
                btn_CheckOut_RescanID.Visible = false;
            }

        }

        private void btn_CheckOut_ProcessCheckOut_Click(object sender, EventArgs e)
        {
            if (tbx_CheckOut_SerialNum.Text != "" &&
                tbx_CheckOut_SerialNum.Text != "Scan Laptop ID Tag" &&
                tbx_CheckOut_UserSerialNum.Text != "Scan Miami ID" &&
                tbx_CheckOut_UserSerialNum.Text != "")
            {
                string laptop = tbx_CheckOut_SerialNum.Text;
                bool LaptopExists = false;

                foreach (Laptop l in LaptopList)
                {
                    if (l.LaptopID == laptop)
                    {
                        LaptopExists = true;
                    }
                }

                if (LaptopExists)
                {

                    if (!IsLaptopRentedOut(laptop))
                    {
                        string id = tbx_CheckOut_UserSerialNum.Text.Trim();
                        User MatchedUser = null;

                        //foreach (User u in UserList)
                        //{
                        //    if (id == u.UniqueID)
                        //    {
                        //        MatchedUser = u;
                        //    }
                        //}

                        if (id != "")
                        //if (MatchedUser != null)
                        {
                            Rental newRent = new Rental(id, tbx_CheckOut_SerialNum.Text);
                            RentalList.Add(newRent);
                            MessageBox.Show("Laptop Successfully Checked Out", "Success", MessageBoxButtons.OK);
                            btn_CheckOut_Back_Click(null, null);
                        }
                        else
                        {
                            if (IsUserDataValid())
                            {
                                //TODO: FIX THIS SHIT
                                //User u = new User(tbxCheckOut_UniqueID.Text, tbx_CheckOut_FirstName.Text, tbx_CheckOut_LastName.Text, tbx_CheckOut_UserEmail.Text, tbx_CheckOut_UserPhone.Text);
                                //UserList.Add(u);

                                Rental newRent = new Rental(id, tbx_CheckOut_SerialNum.Text);
                                RentalList.Add(newRent);

                                MessageBox.Show("A new user has been successfully added to the system and the laptop has been checked out.", "Success", MessageBoxButtons.OK);
                                btn_CheckOut_Back_Click(null, null);
                            }
                            else
                            {
                                MessageBox.Show("The user data you have entered is not valid.", "Error", MessageBoxButtons.OK);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Laptop is currently rented out by another user.", "Error", MessageBoxButtons.OK);
                    }
                   
                }
                else
                {
                    MessageBox.Show("The laptop you have scanned does not exist. Please add it to the system and then try again.", "Laptop Does Not Exist", MessageBoxButtons.OK);
                }
                
            }
            else
            {
                MessageBox.Show("Please enter a unique ID and scan the laptop ID tag.", "Data Invalid", MessageBoxButtons.OK);
            }
        }

        private void btn_CheckOut_UserLogin_Click(object sender, EventArgs e)
        {
            //TODO: Implement PHP user checking here
        }

        private bool IsUserDataValid()
        {
            if (tbx_CheckOut_UserUniqueID.Text == "Enter Unique ID" ||
                tbx_CheckOut_UserPassword.Text == "Enter Password" ||
                String.IsNullOrWhiteSpace(tbx_CheckOut_UserUniqueID.Text) ||
                String.IsNullOrWhiteSpace(tbx_CheckOut_UserPassword.Text))
            {
                return false;
            }

            return true;
        }

        private void DisableCheckOutUserFields()
        {
            tbx_CheckOut_UserUniqueID.Enabled = false;
            tbx_CheckOut_UserPassword.Enabled = false;
        }
        private void EnableCheckOutUSerFields()
        {
            tbx_CheckOut_UserUniqueID.Enabled = true;
            tbx_CheckOut_UserPassword.Enabled = true;
        }
        private void ResetCheckOutUserFields()
        {
            tbx_CheckOut_UserUniqueID.Text = "Enter Unique ID";
            tbx_CheckOut_UserPassword.Text = "Enter Password";
        }

        private void tbx_CheckOut_FirstName_Enter(object sender, EventArgs e)
        {
            if (tbx_CheckOut_UserUniqueID.Text == "Enter Unique ID")
            {
                tbx_CheckOut_UserUniqueID.Text = "";
            }
        }
        private void tbx_CheckOut_FirstName_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(tbx_CheckOut_UserUniqueID.Text))
            {
                tbx_CheckOut_UserUniqueID.Text = "Enter Unique ID";
            }
        }
        private void tbx_CheckOut_LastName_Enter(object sender, EventArgs e)
        {
            if (tbx_CheckOut_UserPassword.Text == "Enter Password")
            {
                tbx_CheckOut_UserPassword.Text = "";
                tbx_CheckOut_UserPassword.UseSystemPasswordChar = true;
            }
        }
        private void tbx_CheckOut_LastName_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(tbx_CheckOut_UserPassword.Text))
            {
                tbx_CheckOut_UserPassword.Text = "Enter Password";
                tbx_CheckOut_UserPassword.UseSystemPasswordChar = false;
            }
        }

        /// Add Laptop Page Methods //////////////////////////////
        private void ResetAddLaptopPage()
        {
            // Reset the add laptop page for next use

            btn_AddLaptop_Rescan.Visible = false;
            lbl_AddLaptop_ScanStatus.Visible = false;
            lbl_AddLaptop_ScanStatus.Text = "Ready to Scan NFC Chip";
            tbx_AddLaptop_LaptopID.Enabled = true;
            tbx_AddLaptop_LaptopID.Text = "Scan Laptop ID Tag";

            DisableAddLaptopTextFields();
        }

        private void ResetAddLaptopTextFields()
        {
            // Resets the add laptop text fields for next use

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
            // Disables text entry until a valid laptop tag is scanned
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
            // Enables laptop fields for edit after a valid ID is entered
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
            // Detect when a laptop tag is scanned
            if (tbx_AddLaptop_LaptopID.TextLength == 14)
            {
                // Check if the laptop exists in the system
                bool LaptopExists = false;
                foreach (Laptop item in LaptopList)
                {
                    if (tbx_AddLaptop_LaptopID.Text == item.LaptopID)
                    {
                        LaptopExists = true;
                    }
                }

                if (!LaptopExists) // Laptop does not exist
                {
                    // Allow rescan if needed
                    lbl_AddLaptop_ScanStatus.Text = "Laptop ID Scanned Succesfully";
                    btn_AddLaptop_Rescan.Visible = true;
                    tbx_AddLaptop_LaptopID.Enabled = false;

                    // Allow data entry into fields
                    EnableAddLaptopTextFields();
                }
                else // Laptop already exists
                {
                    // Alert user and reset Laptop ID textbox
                    MessageBox.Show("That laptop ID is already in use by another laptop. Please scan a different tag.", "ID In Use", MessageBoxButtons.OK);
                    btn_AddLaptop_Rescan_Click(null, null);
                }
                
            }
        }
        private void btn_AddLaptop_Rescan_Click(object sender, EventArgs e)
        {
            // Reset laptop scanning process
            tbx_AddLaptop_LaptopID.Enabled = true;
            lbl_AddLaptop_ScanStatus.Text = "Ready to Scan NFC Chip";
            tbx_AddLaptop_LaptopID.Text = "";
            btn_AddLaptop_Rescan.Visible = false;
            tbx_AddLaptop_LaptopID.Focus();

            DisableAddLaptopTextFields();
            ResetAddLaptopTextFields();
        }

        // Methods to handle focusing of the textboxes
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

        private void CreateLaptopObject()
        {
            // Create a new laptop object and add it to the laptop list

            bool service = (rdo_AddLaptop_InService_Yes.Checked) ? true : false;

            Laptop l = new Laptop(tbx_AddLaptop_LaptopID.Text, tbx_AddLaptop_SerialNum.Text, Laptop.DeviceTypes.Other,  //tbx_AddLaptop_Condition.Text,
                                  tbx_AddLaptop_Brand.Text, tbx_AddLaptop_Model.Text, tbx_AddLaptop_Processor.Text, tbx_AddLaptop_RAM.Text,
                                  tbx_AddLaptop_Resolution.Text, tbx_AddLaptop_Size.Text, dtp_AddLaptop_DateAdded.Value,
                                  service, tbx_AddLaptop_Memory.Text, tbx_AddLaptop_OSVersion.Text);

            //TODO: Add laptop to database instead of list
            LaptopList.Add(l);
        }
        private bool IsAddNewLaptopDataValid()
        {
            // TODO: IMPLEMENT LAPTOP DATA VALIDATION
            return true;
        }

        private void btn_AddLaptop_SubmitButton_Click(object sender, EventArgs e)
        {
            // Check if new data is valid for laptop
            if (IsAddNewLaptopDataValid())
            {

                // Create the laptop object and notify user
                CreateLaptopObject();
                MessageBox.Show("Laptop added to system successfully.", "Success", MessageBoxButtons.OK);
                btn_AddLaptop_Back_Click(null, null);
            }
        }

        /// Return Laptop Page Methods //////////////////////////////////////////

        private void ResetReturnPage()
        {
            // Resets the return page to original form for next use
            lbl_Return_ScanStatus.Visible = false;
            tbx_Return_LaptopID.Text = "Scan Laptop ID Tag";
            lbl_Return_ScanStatus.Text = "Ready to Scan NFC Chip";
            btn_Return_Rescan.Visible = false;
            tbx_Return_LaptopID.Enabled = true;

            lbl_Return_CheckoutText.Visible = false;
            lbl_Return_OverdueText.Visible = false;
            lbl_Return_RentalIDText.Visible = false;
            lbl_Return_UserText.Visible = false;
        }

        // Methods to handle the focus of the textboxes
        private void tbx_Return_LaptopID_Enter(object sender, EventArgs e)
        {
            if (tbx_Return_LaptopID.Text == "Scan Laptop ID Tag")
            {
                tbx_Return_LaptopID.Text = "";
                lbl_Return_ScanStatus.Visible = true;
            }
        }
        private void tbx_Return_LaptopID_Leave(object sender, EventArgs e)
        {
            if (tbx_Return_LaptopID.Text == "")
            {
                tbx_Return_LaptopID.Text = "Scan Laptop ID Tag";
                lbl_Return_ScanStatus.Visible = false;
            }
        }

        private void btn_Return_Rescan_Click(object sender, EventArgs e)
        {
            // Resets the textbox and alert text for a rescan
            tbx_Return_LaptopID.Enabled = true;
            lbl_Return_ScanStatus.Text = "Ready to Scan NFC Chip";
            tbx_Return_LaptopID.Text = "";
            btn_Return_Rescan.Visible = false;
            tbx_Return_LaptopID.Focus();

            lbl_Return_CheckoutText.Visible = false;
            lbl_Return_OverdueText.Visible = false;
            lbl_Return_RentalIDText.Visible = false;
            lbl_Return_UserText.Visible = false;
        }

        private void tbx_Return_LaptopID_TextChanged(object sender, EventArgs e)
        {
            // Check if the text is 14 characters long and is therefore a scanned code
            if (tbx_Return_LaptopID.TextLength == 14)
            {
                tbx_Return_LaptopID.Enabled = false;

                // Find the rental assocaited with the laptop
                Rental r = null;
                foreach (Rental item in RentalList)
                {
                    if (item.LaptopID == tbx_Return_LaptopID.Text &&
                        item.ReturnDate == DateTime.MaxValue)
                    {
                        r = item;
                    }
                }

                // Check if rental was found
                if (r != null)
                {
                    btn_Return_Rescan.Visible = true;
                    lbl_Return_ScanStatus.Text = "Rental Found Successfully";
                    
                    // Populate the data fields with the rental information
                    lbl_Return_UserText.Text = r.UniqueID;
                    lbl_Return_UserText.Visible = true;
                    lbl_Return_CheckoutText.Text = r.CheckOutDate.ToShortDateString();
                    lbl_Return_CheckoutText.Visible = true;
                    lbl_Return_OverdueText.Text = (r.IsOverDue) ? "Yes" : "No";
                    lbl_Return_OverdueText.Visible = true;
                    lbl_Return_RentalIDText.Text = r.RentalID.ToString();
                    lbl_Return_RentalIDText.Visible = true;
                }
                else // rental not found
                {
                    // Alert user that rental was not found
                    MessageBox.Show("The laptop you specified either does not exist or is not currently checked out.", "Error", MessageBoxButtons.OK);
                    btn_Return_Rescan_Click(null, null);
                }
            }
        }

        private void btn_Return_ProcessReturn_Click(object sender, EventArgs e)
        {
            // Make sure a Laptop ID has been entered
            if (tbx_Return_LaptopID.Enabled == false)
            {
                // Find rental to be closed
                string guid = lbl_Return_RentalIDText.Text;

                foreach (Rental item in RentalList)
                {
                    if (item.RentalID.ToString() == guid)
                    {
                        // rental found - close rental, notify user and return to main page
                        item.ReturnDate = DateTime.Now;
                        MessageBox.Show("Yout laptop has been succssfully checked back in.", "Success", MessageBoxButtons.OK);
                        btn_Return_Back_Click(null, null);
                    }
                }
            }
        }

        /// Check Inventory Page Methods ////////////////////////////////////////

        private void PopulateAllLaptopTable()
        {
            // Check current rows in the table and get data for correct table creation
            int rows = tbl_CheckInventory_AllLaptopsDisplayTable.RowCount;
            int laptops = LaptopList.Count;

            // Check if there are no laptops in system
            if (laptops == 0)
            {
                tbl_CheckInventory_AllLaptopsDisplayTable.RowStyles.Clear();
                tbl_CheckInventory_AllLaptopsDisplayTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));

                // remove rows from already populated table
                if (rows > 1)
                {
                    tbl_CheckInventory_AllLaptopsDisplayTable.RowCount = 1;

                    int numControls = tbl_CheckInventory_AllLaptopsDisplayTable.Controls.Count;

                    for (int i = numControls - 1; i > 3; i--)
                    {
                        tbl_CheckInventory_AllLaptopsDisplayTable.Controls.RemoveAt(i);
                    }
                }

                // add new row for "No Data" text
                tbl_CheckInventory_AllLaptopsDisplayTable.RowCount = 2;
                tbl_CheckInventory_AllLaptopsDisplayTable.RowStyles.Add(new RowStyle(SizeType.AutoSize));

                // Create and display "No data" text in the table
                Label noItemsAvailable = new Label();
                noItemsAvailable.Text = "No Data To Display";
                noItemsAvailable.Anchor = AnchorStyles.None;
                tbl_CheckInventory_AllLaptopsDisplayTable.CellBorderStyle = TableLayoutPanelCellBorderStyle.None;
                tbl_CheckInventory_AllLaptopsDisplayTable.SetColumnSpan(noItemsAvailable, 4);
                tbl_CheckInventory_AllLaptopsDisplayTable.Controls.Add(noItemsAvailable, 0, 1);
            }
            else if (laptops > 0) // there are laptops in the system
            {
                // remove rows from already populated table
                if (rows > 1)
                {
                    tbl_CheckInventory_AllLaptopsDisplayTable.RowCount = 1;

                    int numControls = tbl_CheckInventory_AllLaptopsDisplayTable.Controls.Count;

                    for (int i = numControls - 1; i > 3; i--)
                    {
                        tbl_CheckInventory_AllLaptopsDisplayTable.Controls.RemoveAt(i);
                    }
                }

                // Add all laptops to table
                int currentRow = 1;
                for (int i = 0; i < laptops; i++)
                {
                    AddEntryToAllLaptopTable(i, currentRow);
                    currentRow++;
                }

                // Add placeholder row at bottom
                tbl_CheckInventory_AllLaptopsDisplayTable.RowCount = tbl_CheckInventory_AllLaptopsDisplayTable.RowCount + 1;
                tbl_CheckInventory_AllLaptopsDisplayTable.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                tbl_CheckInventory_AllLaptopsDisplayTable.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;

            }
        }
        private void AddEntryToAllLaptopTable(int laptopIndex, int row)
        {
            Laptop l = LaptopList[laptopIndex];


            // Create labels
            Label serial = new Label()
            {
                Text = l.LaptopID,
                Anchor = AnchorStyles.None,
                TextAlign = ContentAlignment.MiddleCenter,
                Cursor = Cursors.Hand
            };
            tbl_CheckInventory_AllLaptopsDisplayTable.SetRow(serial, row);
            tbl_CheckInventory_AllLaptopsDisplayTable.SetColumn(serial, 0);

            Label dateAdded = new Label()
            {
                Text = l.DateAdded.ToShortDateString(),
                Anchor = AnchorStyles.None,
                TextAlign = ContentAlignment.MiddleCenter
            };
            tbl_CheckInventory_AllLaptopsDisplayTable.SetRow(dateAdded, row);
            tbl_CheckInventory_AllLaptopsDisplayTable.SetColumn(dateAdded, 1);

            Label inService = new Label()
            {
                Text = (l.InService == true) ? "Yes" : "No",
                Anchor = AnchorStyles.None,
                TextAlign = ContentAlignment.MiddleCenter
            };
            tbl_CheckInventory_AllLaptopsDisplayTable.SetRow(inService, row);
            tbl_CheckInventory_AllLaptopsDisplayTable.SetColumn(inService, 2);

            Label currentState = new Label()
            {
                Text = (IsLaptopRentedOut(l.LaptopID)) ? "Rented Out" : "Inventory",
                Anchor = AnchorStyles.None,
                TextAlign = ContentAlignment.MiddleCenter
            };
            tbl_CheckInventory_AllLaptopsDisplayTable.SetRow(currentState, row);
            tbl_CheckInventory_AllLaptopsDisplayTable.SetColumn(currentState, 3);

            //Add labels into a new row on the table
            tbl_CheckInventory_AllLaptopsDisplayTable.RowCount = tbl_CheckInventory_AllLaptopsDisplayTable.RowCount + 1;
            tbl_CheckInventory_AllLaptopsDisplayTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tbl_CheckInventory_AllLaptopsDisplayTable.Controls.Add(serial);
            tbl_CheckInventory_AllLaptopsDisplayTable.Controls.Add(dateAdded);
            tbl_CheckInventory_AllLaptopsDisplayTable.Controls.Add(inService);
            tbl_CheckInventory_AllLaptopsDisplayTable.Controls.Add(currentState);

        }

        private void PopulateRentedLaptopTable()
        {
            // Check current rows in the table and remove extra ones
            int rows = tbl_CheckInventory_RentedLaptopsDisplayTable.RowCount;

            // Get data for correct table creation
            List<string> rentedLaptopIDs = GetListOfCurrentlyRentedLaptops();
            int laptops = rentedLaptopIDs.Count;

            // Check if there are no currently rented laptops
            if (laptops == 0)
            {
                tbl_CheckInventory_RentedLaptopsDisplayTable.RowStyles.Clear();
                tbl_CheckInventory_RentedLaptopsDisplayTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));

                // remove rows from already populated table
                if (rows > 1)
                {
                    tbl_CheckInventory_RentedLaptopsDisplayTable.RowCount = 1;

                    int numControls = tbl_CheckInventory_RentedLaptopsDisplayTable.Controls.Count;

                    for (int i = numControls - 1; i > 3; i--)
                    {
                        tbl_CheckInventory_RentedLaptopsDisplayTable.Controls.RemoveAt(i);
                    }
                }

                // add new row for "no data" text
                tbl_CheckInventory_RentedLaptopsDisplayTable.RowCount = 2;
                tbl_CheckInventory_RentedLaptopsDisplayTable.RowStyles.Add(new RowStyle(SizeType.AutoSize));

                // create and display "no data" text
                Label noItemsAvailable = new Label();
                noItemsAvailable.Text = "No Data To Display";
                noItemsAvailable.Anchor = AnchorStyles.None;
                tbl_CheckInventory_RentedLaptopsDisplayTable.CellBorderStyle = TableLayoutPanelCellBorderStyle.None;
                tbl_CheckInventory_RentedLaptopsDisplayTable.SetColumnSpan(noItemsAvailable, 4);
                tbl_CheckInventory_RentedLaptopsDisplayTable.Controls.Add(noItemsAvailable, 0, 1);
            }
            else if (laptops > 0) //there are rented laptops
            {
                // remove rows from already populated table
                if (rows > 1)
                {
                    tbl_CheckInventory_RentedLaptopsDisplayTable.RowCount = 1;

                    int numControls = tbl_CheckInventory_RentedLaptopsDisplayTable.Controls.Count;

                    for (int i = numControls - 1; i > 3; i--)
                    {
                        tbl_CheckInventory_RentedLaptopsDisplayTable.Controls.RemoveAt(i);
                    }
                }

                // Add all laptops to table
                int currentRow = 1;
                for (int i = 0; i < laptops; i++)
                {
                    AddEntryToRentedLaptopTable(rentedLaptopIDs[i], currentRow);
                    currentRow++;
                }

                // Add placeholder row at bottom
                tbl_CheckInventory_RentedLaptopsDisplayTable.RowCount = tbl_CheckInventory_RentedLaptopsDisplayTable.RowCount + 1;
                tbl_CheckInventory_RentedLaptopsDisplayTable.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                tbl_CheckInventory_RentedLaptopsDisplayTable.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;

            }
        }
        private void AddEntryToRentedLaptopTable(string laptopID, int row)
        {
            Rental r = GetCurrentLaptopRental(laptopID);


            // Create labels
            Label serial = new Label()
            {
                Text = r.LaptopID,
                Anchor = AnchorStyles.None,
                TextAlign = ContentAlignment.MiddleCenter,
                Cursor = Cursors.Hand
            };
            tbl_CheckInventory_RentedLaptopsDisplayTable.SetRow(serial, row);
            tbl_CheckInventory_RentedLaptopsDisplayTable.SetColumn(serial, 0);

            Label rentalID = new Label()
            {
                Text = r.RentalID.ToString(),
                Anchor = AnchorStyles.None,
                TextAlign = ContentAlignment.MiddleCenter,
                AutoSize = true
            };
            tbl_CheckInventory_RentedLaptopsDisplayTable.SetRow(rentalID, row);
            tbl_CheckInventory_RentedLaptopsDisplayTable.SetColumn(rentalID, 1);

            Label laptopHolder = new Label()
            {
                Text = r.UniqueID,
                Anchor = AnchorStyles.None,
                TextAlign = ContentAlignment.MiddleCenter
            };
            tbl_CheckInventory_RentedLaptopsDisplayTable.SetRow(laptopHolder, row);
            tbl_CheckInventory_RentedLaptopsDisplayTable.SetColumn(laptopHolder, 2);

            Button email = new Button()
            {
                Text = "Send Reminder Email",
                Anchor = AnchorStyles.None,
                TextAlign = ContentAlignment.MiddleCenter,
                Margin = new Padding(0),
                AutoSize = true
            };
            email.Click += Email_Click;
            tbl_CheckInventory_RentedLaptopsDisplayTable.SetRow(email, row);
            tbl_CheckInventory_RentedLaptopsDisplayTable.SetColumn(email, 3);

            //Add labels into a new row on the table
            tbl_CheckInventory_RentedLaptopsDisplayTable.RowCount = tbl_CheckInventory_RentedLaptopsDisplayTable.RowCount + 1;
            tbl_CheckInventory_RentedLaptopsDisplayTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tbl_CheckInventory_RentedLaptopsDisplayTable.Controls.Add(serial);
            tbl_CheckInventory_RentedLaptopsDisplayTable.Controls.Add(rentalID);
            tbl_CheckInventory_RentedLaptopsDisplayTable.Controls.Add(laptopHolder);
            tbl_CheckInventory_RentedLaptopsDisplayTable.Controls.Add(email);
        }

        private void PopulateAvailableLaptopTable()
        {
            // Check current rows in the table and remove extra ones
            int rows = tbl_CheckInventory_RentedLaptopsDisplayTable.RowCount;

            // Get data for correct table creation
            List<string> availableLaptopIDs = GetListOfCurrentlyAvailableLaptops();
            int laptops = availableLaptopIDs.Count;

            // Check if there are available no laptops
            if (laptops == 0)
            {
                tbl_CheckInventory_AvailableLaptopDisplayTable.RowStyles.Clear();
                tbl_CheckInventory_AvailableLaptopDisplayTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));

                // remove rows from already populated table
                if (rows > 1)
                {
                    tbl_CheckInventory_AvailableLaptopDisplayTable.RowCount = 1;

                    int numControls = tbl_CheckInventory_AvailableLaptopDisplayTable.Controls.Count;

                    for (int i = numControls - 1; i > 3; i--)
                    {
                        tbl_CheckInventory_AvailableLaptopDisplayTable.Controls.RemoveAt(i);
                    }
                }

                // add row for "no data" text
                tbl_CheckInventory_AvailableLaptopDisplayTable.RowCount = 2;
                tbl_CheckInventory_AvailableLaptopDisplayTable.RowStyles.Add(new RowStyle(SizeType.AutoSize));

                // create and display "no data" text
                Label noItemsAvailable = new Label();
                noItemsAvailable.Text = "No Data To Display";
                noItemsAvailable.Anchor = AnchorStyles.None;
                tbl_CheckInventory_AvailableLaptopDisplayTable.CellBorderStyle = TableLayoutPanelCellBorderStyle.None;
                tbl_CheckInventory_AvailableLaptopDisplayTable.SetColumnSpan(noItemsAvailable, 4);
                tbl_CheckInventory_AvailableLaptopDisplayTable.Controls.Add(noItemsAvailable, 0, 1);
            }
            else if (laptops > 0) // laptops are available
            {
                // remove rows from already populated table
                if (rows > 1)
                {
                    tbl_CheckInventory_AvailableLaptopDisplayTable.RowCount = 1;

                    int numControls = tbl_CheckInventory_AvailableLaptopDisplayTable.Controls.Count;

                    for (int i = numControls - 1; i > 3; i--)
                    {
                        tbl_CheckInventory_AvailableLaptopDisplayTable.Controls.RemoveAt(i);
                    }
                }

                // Add all laptops to table
                int currentRow = 1;
                for (int i = 0; i < laptops; i++)
                {
                    AddEntryToAvailableLaptopTable(availableLaptopIDs[i], currentRow);
                    currentRow++;
                }

                // Add placeholder row at bottom
                tbl_CheckInventory_AvailableLaptopDisplayTable.RowCount = tbl_CheckInventory_AvailableLaptopDisplayTable.RowCount + 1;
                tbl_CheckInventory_AvailableLaptopDisplayTable.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                tbl_CheckInventory_AvailableLaptopDisplayTable.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;

            }
        }
        private void AddEntryToAvailableLaptopTable(string laptopID, int row)
        {
            Laptop l = GetLaptopData(laptopID);
            Rental r = GetMostRecentRental(laptopID);


            // Create labels
            Label serial = new Label()
            {
                Text = l.LaptopID,
                Anchor = AnchorStyles.None,
                TextAlign = ContentAlignment.MiddleCenter,
                Cursor = Cursors.Hand
            };
            tbl_CheckInventory_AvailableLaptopDisplayTable.SetRow(serial, row);
            tbl_CheckInventory_AvailableLaptopDisplayTable.SetColumn(serial, 0);

            Label rentalID = new Label()
            {
                Text = (r == null) ? "--" : r.RentalID.ToString(),
                Anchor = AnchorStyles.None,
                TextAlign = ContentAlignment.MiddleCenter,
                AutoSize = true
            };
            tbl_CheckInventory_AvailableLaptopDisplayTable.SetRow(rentalID, row);
            tbl_CheckInventory_AvailableLaptopDisplayTable.SetColumn(rentalID, 1);

            Label lastUser = new Label()
            {
                Text = (r == null) ? "--" : r.UniqueID,
                Anchor = AnchorStyles.None,
                TextAlign = ContentAlignment.MiddleCenter
            };
            tbl_CheckInventory_AvailableLaptopDisplayTable.SetRow(lastUser, row);
            tbl_CheckInventory_AvailableLaptopDisplayTable.SetColumn(lastUser, 2);

            Label condition = new Label()
            {
                Text =  "TODO", //l.Condition,
                Anchor = AnchorStyles.None,
                TextAlign = ContentAlignment.MiddleCenter
            };
            tbl_CheckInventory_AvailableLaptopDisplayTable.SetRow(condition, row);
            tbl_CheckInventory_AvailableLaptopDisplayTable.SetColumn(condition, 3);

            //Add labels into a new row on the table
            tbl_CheckInventory_AvailableLaptopDisplayTable.RowCount = tbl_CheckInventory_AvailableLaptopDisplayTable.RowCount + 1;
            tbl_CheckInventory_AvailableLaptopDisplayTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tbl_CheckInventory_AvailableLaptopDisplayTable.Controls.Add(serial);
            tbl_CheckInventory_AvailableLaptopDisplayTable.Controls.Add(rentalID);
            tbl_CheckInventory_AvailableLaptopDisplayTable.Controls.Add(lastUser);
            tbl_CheckInventory_AvailableLaptopDisplayTable.Controls.Add(condition);
        }

        private void btn_CheckOut_RefeshData_Click(object sender, EventArgs e)
        {
            // refresh the data in the tables

            // delete current row styles in the tables
            // Correct row styles will be added for each item in the Populate methods
            tbl_CheckInventory_AvailableLaptopDisplayTable.RowStyles.Clear();
            tbl_CheckInventory_AllLaptopsDisplayTable.RowStyles.Clear();
            tbl_CheckInventory_RentedLaptopsDisplayTable.RowStyles.Clear();

            // Create row style for header row
            tbl_CheckInventory_AvailableLaptopDisplayTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tbl_CheckInventory_AllLaptopsDisplayTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tbl_CheckInventory_RentedLaptopsDisplayTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));

            // Populate individual tables with records
            PopulateAllLaptopTable();
            PopulateRentedLaptopTable();
            PopulateAvailableLaptopTable();
        }

        private void Email_Click(object sender, EventArgs e)
        {
            // TODO: Implement this
            MessageBox.Show("Implement this");

            // Get unique id from Miami ID

            // Create email address for that unique id

            // Create email using STMP

            // Send Email
        }

        /////////////////////////////////////////////////////////////////////////
        /// Helper Methods
        /// 

        public Rental GetCurrentLaptopRental(string id)
        {
            foreach (Rental item in RentalList)
            {
                if (item.ReturnDate == DateTime.MaxValue &&
                    item.LaptopID == id)
                {
                    return item;
                }
            }

            return null;
        }

        public Rental GetMostRecentRental(string id)
        {
            Rental mostRecentRental = null;

            foreach (Rental item in RentalList)
            {
                if (item.ReturnDate != DateTime.MaxValue &&
                    item.LaptopID == id)
                {
                    if (mostRecentRental == null || item.ReturnDate > mostRecentRental.ReturnDate)
                    {
                        mostRecentRental = item;
                    }

                }
            }

            return mostRecentRental;
        }

        public bool IsLaptopRentedOut(string id)
        {
            Rental r = GetCurrentLaptopRental(id);

            if (r == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public List<string> GetListOfCurrentlyRentedLaptops()
        {
            List<string> laptops = new List<string>();

            foreach (Laptop item in LaptopList)
            {
                if (IsLaptopRentedOut(item.LaptopID))
                {
                    laptops.Add(item.LaptopID);
                }
            }

            return laptops;
        }

        public List<string> GetListOfCurrentlyAvailableLaptops()
        {
            List<string> laptops = new List<string>();

            foreach (Laptop item in LaptopList)
            {
                if (!IsLaptopRentedOut(item.LaptopID) && item.InService)
                {
                    laptops.Add(item.LaptopID);
                }
            }

            return laptops;
        }

        public Laptop GetLaptopData(string laptopID)
        {
            foreach (Laptop item in LaptopList)
            {
                if (item.LaptopID == laptopID)
                {
                    return item;
                }
            }

            return null;
        }
    }
}
