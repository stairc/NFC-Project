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
using System.DirectoryServices;
using System.DirectoryServices.AccountManagement;
using System.DirectoryServices.Protocols;
using System.Net.Mail;

namespace NFC_Project
{
    public partial class HomePage : Form
    {

        public List<Laptop> LaptopList;
        public List<Rental> RentalList;

        public HomePage()
        {
            InitializeComponent();

            LaptopList = new List<Laptop>();
            RentalList = new List<Rental>();

            AddTestData();

            CheckOutLaptopPanel.Visible = false;
            ReturnLaptopPanel.Visible = false;
            AddLaptopPanel.Visible = false;
            CheckInventoryPanel.Visible = false;


            // TEST STUFF IS BELOW
            //DBManager db = new DBManager();
            //db.Connect();

            //LaptopDetailPage page = new LaptopDetailPage();
           // page.Show();
        }

        private void AddTestData()
        {
            //UserList.Add(new User("staircd", "Cameron", "Stair", "staircd@miamioh.edu", "5135601882"));
            //UserList.Add(new User("stairlj", "Landen", "Stair", "stairlj@miamioh.edu", "5135601991"));

            RentalList.Add(new Rental("046A2AAAD72C80", "11111111111111"));
            RentalList.Add(new Rental(Guid.NewGuid().ToString(), "046A2AAAD72C80", "98765432109876", new DateTime(2017, 4, 15).Ticks, new DateTime(2017, 4, 16).Ticks));

            LaptopList.Add(new Laptop("11111111111111", "9999-9999", Laptop.DeviceTypes.Laptop, "Dell", "Insperon", "i7", "8GB", "720p", "15.2 in.", DateTime.Today, true, "1TB", Laptop.OperatingSystems.Windows));
            LaptopList.Add(new Laptop("12345678901234", "1559-7895", Laptop.DeviceTypes.Laptop, "Dell", "Insperon", "i7", "8GB", "720p", "15.2 in.", DateTime.Today, true, "1TB", Laptop.OperatingSystems.Windows));
            LaptopList.Add(new Laptop("98765432109876", "1111-1234", Laptop.DeviceTypes.Laptop, "Dell", "Insperon", "i7", "8GB", "720p", "15.2 in.", DateTime.Today.AddDays(-5), true, "1TB", Laptop.OperatingSystems.Windows));

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
                tbx_CheckOut_UserUniqueID.Enabled == false)
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

                        if (id != "" && id != "Scan Miami ID")
                        {
                            if (!UserAlreadyHasLaptop(id))
                            {
                                Rental newRent = new Rental(id, tbx_CheckOut_SerialNum.Text);
                                RentalList.Add(newRent);
                                MessageBox.Show("Laptop Successfully Checked Out", "Success", MessageBoxButtons.OK);
                                btn_CheckOut_Back_Click(null, null);
                            }
                            else
                            {
                                MessageBox.Show("You already have a laptop rented out. Return your current laptop before renting a new one.", "Error", MessageBoxButtons.OK);
                            }
                           
                        }
                        else
                        {
                            if (IsUserDataValid())
                            {
                                id = tbx_CheckOut_UserUniqueID.Text;

                                if (!UserAlreadyHasLaptop(id))
                                {
                                   
                                    Rental newRent = new Rental(id, tbx_CheckOut_SerialNum.Text);
                                    RentalList.Add(newRent);

                                    MessageBox.Show("Laptop Successfully Checked Out", "Success", MessageBoxButtons.OK);
                                    btn_CheckOut_Back_Click(null, null);
                                }
                                else
                                {
                                    MessageBox.Show("You already have a laptop rented out. Return your current laptop before renting a new one.", "Error", MessageBoxButtons.OK);
                                }

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
                MessageBox.Show("Please the laptop ID tag and either scan your Miami ID or login with your unique ID and password.", "Data Invalid", MessageBoxButtons.OK);
            }
        }

        private void btn_CheckOut_UserLogin_Click(object sender, EventArgs e)
        {
            string username = tbx_CheckOut_UserUniqueID.Text;
            string pass = tbx_CheckOut_UserPassword.Text;

            if (tbx_CheckOut_UserPassword.Text != "Enter Password" && !String.IsNullOrWhiteSpace(tbx_CheckOut_UserPassword.Text))
            {
                if (LDAPAuthenticate(username, pass))
                {
                    tbx_CheckOut_UserSerialNum.Enabled = false;
                    tbx_CheckOut_UserUniqueID.Enabled = false;
                    tbx_CheckOut_UserPassword.Enabled = false;
                    lbl_CheckOut_UserFound.Visible = true;
                    lbl_CheckOut_UserFound.Text = "User succesfully Authenticated.";
                }
                else
                {

                }
            }            
            
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

        /// Add Laptop Page Methods //////////////////////////////////////////////////////////////////
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
            cbo_AddLaptop_DeviceType.SelectedIndex = 0;
            tbx_AddLaptop_Memory.Text = "Laptop Memory";
            tbx_AddLaptop_Model.Text = "Laptop Model";
            cbo_AddLaptop_OS.Text = "";
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
            cbo_AddLaptop_DeviceType.Enabled = false;
            tbx_AddLaptop_Memory.Enabled = false;
            tbx_AddLaptop_Model.Enabled = false;
            cbo_AddLaptop_OS.Enabled = false;
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
            cbo_AddLaptop_DeviceType.Enabled = true;
            tbx_AddLaptop_Memory.Enabled = true;
            tbx_AddLaptop_Model.Enabled = true;
            cbo_AddLaptop_OS.Enabled = true;
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

        private void CreateLaptopObject()
        {
            // Create a new laptop object and add it to the laptop list

            bool service = (rdo_AddLaptop_InService_Yes.Checked) ? true : false;

            // Determine laptop type selection
            Laptop.DeviceTypes type = Laptop.DeviceTypes.Other;
            switch (cbo_AddLaptop_DeviceType.SelectedIndex)
            {
                case 0:
                    type = Laptop.DeviceTypes.AllInOne;
                    break;
                case 1:
                    type = Laptop.DeviceTypes.Laptop;
                    break;
                case 2:
                    type = Laptop.DeviceTypes.SurfacePro;
                    break;
                case 3:
                    type = Laptop.DeviceTypes.iPad;
                    break;
                case 4:
                    type = Laptop.DeviceTypes.Other;
                    break;
                default:
                    break;
            }

            // Detemine os selection
            Laptop.OperatingSystems os = Laptop.OperatingSystems.Other;
            switch (cbo_AddLaptop_DeviceType.SelectedIndex)
            {
                case 0:
                    os = Laptop.OperatingSystems.Windows;
                    break;
                case 1:
                    os = Laptop.OperatingSystems.MacOS;
                    break;
                case 2:
                    os = Laptop.OperatingSystems.iOS;
                    break;
                case 3:
                    os = Laptop.OperatingSystems.ChromeOS;
                    break;
                case 4:
                    os = Laptop.OperatingSystems.Other;
                    break;
                default:
                    break;
            }

            Laptop l = new Laptop(tbx_AddLaptop_LaptopID.Text, tbx_AddLaptop_SerialNum.Text, type,
                                  tbx_AddLaptop_Brand.Text, tbx_AddLaptop_Model.Text, tbx_AddLaptop_Processor.Text, tbx_AddLaptop_RAM.Text,
                                  tbx_AddLaptop_Resolution.Text, tbx_AddLaptop_Size.Text, dtp_AddLaptop_DateAdded.Value,
                                  service, tbx_AddLaptop_Memory.Text, os);

            //TODO: Add laptop to database instead of list
            LaptopList.Add(l);
        }
        private bool IsAddNewLaptopDataValid()
        {
            if (tbx_AddLaptop_SerialNum.Text == "Laptop Serial Number" ||
                String.IsNullOrWhiteSpace(tbx_AddLaptop_SerialNum.Text))
            {
                return false;
            }

            if (tbx_AddLaptop_Brand.Text == "Laptop Brand" ||
                String.IsNullOrWhiteSpace(tbx_AddLaptop_Brand.Text))
            {
                return false;
            }

            if (tbx_AddLaptop_Model.Text == "Laptop Model" ||
                String.IsNullOrWhiteSpace(tbx_AddLaptop_Model.Text))
            {
                return false;
            }

            if (tbx_AddLaptop_Processor.Text == "Laptop Processor" ||
                String.IsNullOrWhiteSpace(tbx_AddLaptop_Processor.Text))
            {
                return false;
            }

            if (tbx_AddLaptop_RAM.Text == "Laptop RAM" ||
                String.IsNullOrWhiteSpace(tbx_AddLaptop_RAM.Text))
            {
                return false;
            }

            if (tbx_AddLaptop_Resolution.Text == "Laptop Resolution" ||
                String.IsNullOrWhiteSpace(tbx_AddLaptop_Resolution.Text))
            {
                return false;
            }

            if (tbx_AddLaptop_Size.Text == "Laptop Screen Size" ||
                String.IsNullOrWhiteSpace(tbx_AddLaptop_Size.Text))
            {
                return false;
            }

            if (tbx_AddLaptop_Memory.Text == "Laptop Memory" ||
                String.IsNullOrWhiteSpace(tbx_AddLaptop_Memory.Text))
            {
                return false;
            }

            if (!rdo_AddLaptop_InService_No.Checked &&
                !rdo_AddLaptop_InService_Yes.Checked)
            {
                return false;
            }

            if (cbo_AddLaptop_DeviceType.SelectedIndex > 6)
            {
                return false;
            }

            if (cbo_AddLaptop_OS.SelectedIndex > 6)
            {
                return false;
            }



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
            else
            {
                MessageBox.Show("The data you entered for the new laptop is invalid. All fields must be filled in. Enter a dash ( - ) if you wish to leave the field empty.", "Invalid Data");
            }
        }

        /// Return Laptop Page Methods ////////////////////////////////////////////////////////////////

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

        /// Check Inventory Page Methods ///////////////////////////////////////////////////////////////

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

                    for (int i = numControls - 1; i > 4; i--)
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

                    for (int i = numControls - 1; i > 4; i--)
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

            serial.Click += Serial_Click;

            Label type = new Label()
            {
                Text = l.Type.ToString(),
                Anchor = AnchorStyles.None,
                TextAlign = ContentAlignment.MiddleCenter
            };
            tbl_CheckInventory_AllLaptopsDisplayTable.SetRow(type, row);
            tbl_CheckInventory_AllLaptopsDisplayTable.SetColumn(type, 1);

            Label processor = new Label()
            {
                Text = l.Processor,
                Anchor = AnchorStyles.None,
                TextAlign = ContentAlignment.MiddleCenter
            };
            tbl_CheckInventory_AllLaptopsDisplayTable.SetRow(processor, row);
            tbl_CheckInventory_AllLaptopsDisplayTable.SetColumn(processor, 2);

            Label ram = new Label()
            {
                Text = l.RAM,
                Anchor = AnchorStyles.None,
                TextAlign = ContentAlignment.MiddleCenter
            };
            tbl_CheckInventory_AllLaptopsDisplayTable.SetRow(ram, row);
            tbl_CheckInventory_AllLaptopsDisplayTable.SetColumn(ram, 3);

            Label os = new Label()
            {
                Text = l.OSVersion.ToString(),
                Anchor = AnchorStyles.None,
                TextAlign = ContentAlignment.MiddleCenter
            };
            tbl_CheckInventory_AllLaptopsDisplayTable.SetRow(os, row);
            tbl_CheckInventory_AllLaptopsDisplayTable.SetColumn(os, 4);

            //Add labels into a new row on the table
            tbl_CheckInventory_AllLaptopsDisplayTable.RowCount = tbl_CheckInventory_AllLaptopsDisplayTable.RowCount + 1;
            tbl_CheckInventory_AllLaptopsDisplayTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tbl_CheckInventory_AllLaptopsDisplayTable.Controls.Add(serial);
            tbl_CheckInventory_AllLaptopsDisplayTable.Controls.Add(type);
            tbl_CheckInventory_AllLaptopsDisplayTable.Controls.Add(processor);
            tbl_CheckInventory_AllLaptopsDisplayTable.Controls.Add(ram);
            tbl_CheckInventory_AllLaptopsDisplayTable.Controls.Add(os);

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

            serial.Click += Serial_Click;

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

                    for (int i = numControls - 1; i > 4; i--)
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

                    for (int i = numControls - 1; i > 4; i--)
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

                // Update counter in top left corner
                lbl_CheckInventory_AvailableLaptopCount.Text = laptops.ToString();

                // Add placeholder row at bottom
                tbl_CheckInventory_AvailableLaptopDisplayTable.RowCount = tbl_CheckInventory_AvailableLaptopDisplayTable.RowCount + 1;
                tbl_CheckInventory_AvailableLaptopDisplayTable.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                tbl_CheckInventory_AvailableLaptopDisplayTable.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;

            }
        }
        private void AddEntryToAvailableLaptopTable(string laptopID, int row)
        {
            Laptop l = GetLaptopData(laptopID);

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

            serial.Click += Serial_Click;

            Label type = new Label()
            {
                Text = l.Type.ToString(),
                Anchor = AnchorStyles.None,
                TextAlign = ContentAlignment.MiddleCenter
            };
            tbl_CheckInventory_AvailableLaptopDisplayTable.SetRow(type, row);
            tbl_CheckInventory_AvailableLaptopDisplayTable.SetColumn(type, 1);

            Label processor = new Label()
            {
                Text = l.Processor,
                Anchor = AnchorStyles.None,
                TextAlign = ContentAlignment.MiddleCenter
            };
            tbl_CheckInventory_AvailableLaptopDisplayTable.SetRow(processor, row);
            tbl_CheckInventory_AvailableLaptopDisplayTable.SetColumn(processor, 2);

            Label ram = new Label()
            {
                Text = l.RAM,
                Anchor = AnchorStyles.None,
                TextAlign = ContentAlignment.MiddleCenter
            };
            tbl_CheckInventory_AvailableLaptopDisplayTable.SetRow(ram, row);
            tbl_CheckInventory_AvailableLaptopDisplayTable.SetColumn(ram, 3);

            Label os = new Label()
            {
                Text = l.OSVersion.ToString(),
                Anchor = AnchorStyles.None,
                TextAlign = ContentAlignment.MiddleCenter
            };
            tbl_CheckInventory_AvailableLaptopDisplayTable.SetRow(os, row);
            tbl_CheckInventory_AvailableLaptopDisplayTable.SetColumn(os, 4);

            //Add labels into a new row on the table
            tbl_CheckInventory_AvailableLaptopDisplayTable.RowCount = tbl_CheckInventory_AvailableLaptopDisplayTable.RowCount + 1;
            tbl_CheckInventory_AvailableLaptopDisplayTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tbl_CheckInventory_AvailableLaptopDisplayTable.Controls.Add(serial);
            tbl_CheckInventory_AvailableLaptopDisplayTable.Controls.Add(type);
            tbl_CheckInventory_AvailableLaptopDisplayTable.Controls.Add(processor);
            tbl_CheckInventory_AvailableLaptopDisplayTable.Controls.Add(ram);
            tbl_CheckInventory_AvailableLaptopDisplayTable.Controls.Add(os);
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

            // Get unique id from Miami ID
            int row = tbl_CheckInventory_RentedLaptopsDisplayTable.GetRow((Button)sender);
            string userID = ((Label)tbl_CheckInventory_RentedLaptopsDisplayTable.GetControlFromPosition(2, row)).Text;

            if (IsUserIDUniqueID(userID))
            {
                // Create email address for that unique id
                string email = userID + "@miamioh.edu";

                var fromAddress = new MailAddress("cameronstair@gmail.com", "FSB IT SERVICES");
                var toAddress = new MailAddress(email, "User");
                const string fromPassword = "A1b2c1d2e!";
                const string subject = "Reminder: Return Laptop";
                const string body = "This is a reminder to please return your rented laptop to FSB IT Services.\n\nThank you!";

                var smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new System.Net.NetworkCredential(fromAddress.Address, fromPassword)
                };
                using (var message = new MailMessage(fromAddress, toAddress)
                {
                    Subject = subject,
                    Body = body
                })
                {
                    smtp.Send(message);
                    MessageBox.Show("Email Successfully Sent.");
                }

            }
            else
            {
                MessageBox.Show("User ID is not in unique ID format. Cannot generate email.");
            }


        }

        private void Serial_Click(object sender, EventArgs e)
        {
            Laptop data = GetLaptopData(((Label)sender).Text);
            List<Rental> rentals = GetAssocciatedRentals(((Label)sender).Text);

            LaptopDetailPage detail = new LaptopDetailPage(data, rentals);
            detail.Show(this);
        }

        /////////////////////////////////////////////////////////////////////////
        /// Helper Methods
        /// 

        public bool UserAlreadyHasLaptop(string userID)
        {
            foreach (Rental item in RentalList)
            {
                if (item.UniqueID == userID && item.ReturnDate == DateTime.MaxValue)
                {
                    return true;
                }
            }

            return false;
        }

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

        public List<Rental> GetAssocciatedRentals(string laptopID)
        {
            List<Rental> r = new List<Rental>();

            foreach (Rental item in RentalList)
            {
                if (item.LaptopID == laptopID)
                {
                    r.Add(item);
                }
            }

            return r;
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

        public bool LDAPAuthenticate(string user, string pass)
        {
            DirectoryEntry entry = new DirectoryEntry("LDAP://directory.miamioh.edu/dc=muohio,dc=edu");
            entry.AuthenticationType = AuthenticationTypes.None;

            DirectorySearcher des = new DirectorySearcher(entry, "(uid=" + user + ")");

            var result = des.FindAll();

            if (result.Count > 0)
            {
                // Return true for now
                // TODO: Write code to actually authenticate user based on password and not just uniqueid
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool IsUserIDUniqueID(string id)
        {
            if (id.Length == 14)
            {
                return false;
            }

            return true;
        }
    }
}
