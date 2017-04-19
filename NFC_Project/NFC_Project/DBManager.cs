using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Oracle.ManagedDataAccess.Client;
using System.Data.SqlClient;
using NFC_Project.DataContainers;

namespace NFC_Project
{
    public class DBManager
    {
       
        const string ConnString = "Data Source=DESKTOP-PASOB3I\\SQLEXPRESS;Initial Catalog=NFCTest;Integrated Security=True";
        const string UserName = "nfc2";
        const string Password = "nfc2Tw0";

        SqlConnection con;

        public DBManager()
        {
            con = new SqlConnection();
            con.ConnectionString = ConnString;
        }

        public void TestConnection()
        {
            con.Open();

            System.Windows.Forms.MessageBox.Show("Connection to Server Successful. Connection is: " + con.State.ToString());

            con.Close();
        }

        public void AddLaptop(Laptop l)
        {
            string cmdString = "INSERT INTO Laptop VALUES (@Laptop_ID,@Serial_Num,@Device_Type,@Brand,@Model,@Processor,@RAM,@Resolution,@Size,@Date_Added,@Memory,@OSVersion)";

            using (SqlConnection connection = new SqlConnection(ConnString))
            {
                using (SqlCommand cmd = new SqlCommand(cmdString))
                {
                    cmd.Connection = connection;
                    cmd.Parameters.Add("@Laptop_ID", System.Data.SqlDbType.VarChar, 255).Value = l.LaptopID;
                    cmd.Parameters.Add("@Serial_Num", System.Data.SqlDbType.VarChar, 255).Value = l.SerialNumber;
                    cmd.Parameters.Add("@Device_Type", System.Data.SqlDbType.Int, 255).Value = (int)l.Type;
                    cmd.Parameters.Add("@Brand", System.Data.SqlDbType.VarChar, 255).Value = l.Brand;
                    cmd.Parameters.Add("@Model", System.Data.SqlDbType.VarChar, 255).Value = l.Model;
                    cmd.Parameters.Add("@Processor", System.Data.SqlDbType.VarChar, 255).Value = l.Processor;
                    cmd.Parameters.Add("@RAM", System.Data.SqlDbType.VarChar, 255).Value = l.RAM;
                    cmd.Parameters.Add("@Resolution", System.Data.SqlDbType.VarChar, 255).Value = l.Resolution;
                    cmd.Parameters.Add("@Size", System.Data.SqlDbType.VarChar, 255).Value = l.ScreenSize;
                    cmd.Parameters.Add("@Date_Added", System.Data.SqlDbType.VarChar, 255).Value = l.DateAdded.Ticks.ToString();
                    cmd.Parameters.Add("@Memory", System.Data.SqlDbType.VarChar, 255).Value = l.Memory;
                    cmd.Parameters.Add("@OSVersion", System.Data.SqlDbType.VarChar, 255).Value = (int)l.OSVersion;

                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();

                }
            }
        }

        public List<Laptop> GetAllLaptops()
        {
            List<Laptop> results = new List<Laptop>();
            string cmdString = "SELECT * FROM Laptop";


            using (SqlConnection connection = new SqlConnection(ConnString))
            {
                using (SqlCommand cmd = new SqlCommand(cmdString, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                string id = reader.GetString(0);
                                string serial = reader.GetString(1);
                                int devicetype = reader.GetInt32(2);
                                string brand = reader.GetString(3);
                                string model = reader.GetString(4);
                                string processor = reader.GetString(5);
                                string ram = reader.GetString(6);
                                string reso = reader.GetString(7);
                                string size = reader.GetString(8);
                                long dateadded = long.Parse(reader.GetString(9));
                                string mem = reader.GetString(10);
                                int OS = reader.GetInt32(11);

                                Laptop l = new Laptop(id, serial, (Laptop.DeviceTypes)devicetype, brand, model, processor, ram, reso, size, new DateTime(dateadded), true, mem, (Laptop.OperatingSystems)OS);
                                results.Add(l);
                            }
                        }
                    }

                }
            }

            return results;
        }

        public void AddRental(Rental r)
        {
            string cmdString = "INSERT INTO Rental VALUES (@Rental_ID,@Unique_ID,@Laptop_ID,@Check_Out_Date,@Return_Date)";

            using (SqlConnection connection = new SqlConnection(ConnString))
            {
                using (SqlCommand cmd = new SqlCommand(cmdString))
                {
                    cmd.Connection = connection;
                    cmd.Parameters.Add("@Rental_ID", System.Data.SqlDbType.VarChar, 255).Value = r.RentalID.ToString();
                    cmd.Parameters.Add("@Unique_ID", System.Data.SqlDbType.VarChar, 255).Value = r.UniqueID;
                    cmd.Parameters.Add("@Laptop_ID", System.Data.SqlDbType.VarChar, 255).Value = r.LaptopID;
                    cmd.Parameters.Add("@Check_Out_Date", System.Data.SqlDbType.VarChar, 255).Value = r.CheckOutDate.Ticks.ToString();
                    cmd.Parameters.Add("@Return_Date", System.Data.SqlDbType.VarChar, 255).Value = r.ReturnDate.Ticks.ToString();

                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();

                }
            }
        }

        public List<Rental> GetAllRentals()
        {
            List<Rental> results = new List<Rental>();
            string cmdString = "SELECT * FROM Rental";


            using (SqlConnection connection = new SqlConnection(ConnString))
            {
                using (SqlCommand cmd = new SqlCommand(cmdString, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                string id = reader.GetString(0);
                                string unique = reader.GetString(1);
                                string laptop = reader.GetString(2);
                                string checkout = reader.GetString(3);
                                string returnd = reader.GetString(4);

                                Rental r = new Rental(id, unique, laptop, long.Parse(checkout), long.Parse(returnd));
                                results.Add(r);
                            }
                        }
                    }

                }
            }

            return results;
        }

        public void UpdateRental(Rental r)
        {
            string cmdString = "UPDATE Rental SET Return_Date = @rd WHERE Rental_ID = @rid";

            using (SqlConnection connection = new SqlConnection(ConnString))
            {
                using (SqlCommand cmd = new SqlCommand(cmdString))
                {
                    cmd.Connection = connection;
                    cmd.Parameters.Add("@rid", System.Data.SqlDbType.VarChar, 255).Value = r.RentalID.ToString();
                    cmd.Parameters.Add("@rd", System.Data.SqlDbType.VarChar, 255).Value = r.ReturnDate.Ticks.ToString();

                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();

                }
            }
        }

    }
}
