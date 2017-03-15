using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFC_Project.DataContainers
{
    class Rental
    {
        public Guid RentalID { get; set; }
        public string UniqueID { get; set; }
        public string LaptopID { get; set; }
        public DateTime CheckOutDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public bool IsOverDue
        {
            get
            {
                if (DateTime.Today >= CheckOutDate.AddDays(5))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }


        // Constructor for creating a new rental instance at the time
        // that a rentee clicks "check out"
        public Rental(string id, string laptop)
        {
            RentalID = Guid.NewGuid();
            UniqueID = id;
            LaptopID = laptop;
            CheckOutDate = DateTime.Today;
            ReturnDate = DateTime.MaxValue;
        }

        // Constructor for creating a new rental instance from data recieved
        // from the SQL server
        public Rental(string guid, string id, string laptop, long checkOut, long returnDate)
        {
            RentalID = Guid.Parse(guid);
            UniqueID = id;
            LaptopID = laptop;
            CheckOutDate = new DateTime(checkOut);
            ReturnDate = new DateTime(returnDate);
        }
    }
}
