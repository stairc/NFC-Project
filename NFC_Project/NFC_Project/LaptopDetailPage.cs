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
    public partial class LaptopDetailPage : Form
    {
        Laptop SelectedLaptop;
        List<Rental> RentalList;

        public LaptopDetailPage(Laptop l, List<Rental> rentals)
        {
            InitializeComponent();

            SelectedLaptop = l;
            RentalList = rentals;

            AssignLaptopData();
            AssignRentalData();
        }

        public void AssignRentalData()
        {
            Rental current = GetCurrentLaptopRental(SelectedLaptop.LaptopID);
            Rental last = GetMostRecentRental(SelectedLaptop.LaptopID);

            lbl_RentalStatus.Text = (current == null) ? "Available" : "Rented";
            lbl_TimesRented.Text = RentalList.Count.ToString();

            if (current != null)
            {
                lbl_CurrentRental.Text = current.RentalID.ToString();
                lbl_CurrentHolder.Text = current.UniqueID;
            }
            else
            {
                lbl_CurrentRental.Text = "--";
                lbl_CurrentHolder.Text = "--";
            }

            if (last != null)
            {
                lbl_PreviousHolder.Text = last.UniqueID;
                lbl_PreviousRental.Text = last.RentalID.ToString();
            }
            else
            {
                lbl_PreviousHolder.Text = "--";
                lbl_PreviousRental.Text = "--";
            }
        }

        public void AssignLaptopData()
        {
            lbl_ID.Text = SelectedLaptop.LaptopID;
            lbl_SerialNum.Text = SelectedLaptop.SerialNumber;
            lbl_DeviceType.Text = SelectedLaptop.Type.ToString();
            lbl_OS.Text = SelectedLaptop.OSVersion.ToString();
            lbl_brand.Text = SelectedLaptop.Brand;
            lbl_Model.Text = SelectedLaptop.Model;
            lbl_Processor.Text = SelectedLaptop.Processor;
            lbl_RAM.Text = SelectedLaptop.RAM;
            lbl_Memory.Text = SelectedLaptop.Memory;
            lbl_Resolution.Text = SelectedLaptop.Resolution;
            lbl_ScreenSize.Text = SelectedLaptop.ScreenSize;
            lbl_DateAdded.Text = SelectedLaptop.DateAdded.ToShortDateString();
            lbl_inService.Text = (SelectedLaptop.InService) ? "Yes" : "No";
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
    }
}
