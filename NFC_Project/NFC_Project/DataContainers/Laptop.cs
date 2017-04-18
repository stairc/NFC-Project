﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFC_Project.DataContainers
{
    public class Laptop
    {
        public string LaptopID { get; set; }
        public string SerialNumber { get; set; }
        public string Condition { get; set; } // Change to type of device // Add to table
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Processor { get; set; } //
        public string RAM { get; set; } //
        public string Resolution { get; set; }
        public string ScreenSize { get; set; }
        public DateTime DateAdded { get; set; }
        public bool InService { get; set; }
        public string Memory { get; set; }
        public string OSVersion { get; set; } //

        public Laptop(string id, string serial, string cond, string brand,
                      string model, string processor, string ram, string resolution,
                      string size, DateTime date, bool service, string mem, string os)
        {
            LaptopID = id;
            SerialNumber = serial;
            Condition = cond;
            Brand = brand;
            Model = model;
            Processor = processor;
            RAM = ram;
            Resolution = resolution;
            ScreenSize = size;
            DateAdded = date;
            InService = service;
            Memory = mem;
            OSVersion = os;
        }
    }
}
