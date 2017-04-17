using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFC_Project.DataContainers
{
    public class User
    {
        public string UniqueID { get; set; }
        public string StudentSerialNum { get; set; }

        public User(string id, string serial)
        {
            UniqueID = id;
            StudentSerialNum = serial;
        }
    }
}
