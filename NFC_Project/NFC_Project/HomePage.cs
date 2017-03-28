using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NFC_Project
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

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
        }

        private void tbx_CheckOut_SerialNum_TextChanged(object sender, EventArgs e)
        {
            if (tbx_CheckOut_SerialNum.TextLength == 14)
            {
                lbl_CheckOut_ReadyToScanNFC.Text = "Serial Number Scanned Succesfully";
                btn_CheckOut_Rescan.Visible = true;
                tbx_CheckOut_SerialNum.Enabled = false;
            }

        }

        private void tbx_CheckOut_SerialNum_Enter(object sender, EventArgs e)
        {
            if (tbx_CheckOut_SerialNum.Text == "Laptop Serial Number")
            {
                tbx_CheckOut_SerialNum.Text = "";
                lbl_CheckOut_ReadyToScanNFC.Visible = true;
            }
        }

        private void tbx_CheckOut_SerialNum_Leave(object sender, EventArgs e)
        {
            if (tbx_CheckOut_SerialNum.Text == "")
            {
                tbx_CheckOut_SerialNum.Text = "Laptop Serial Number";
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
        }
    }
}
