﻿namespace NFC_Project
{
    partial class HomePage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.btnCheckIn = new System.Windows.Forms.Button();
            this.btnAddLaptop = new System.Windows.Forms.Button();
            this.btnInventory = new System.Windows.Forms.Button();
            this.HomePagePanel = new System.Windows.Forms.Panel();
            this.CheckOutLaptopPanel = new System.Windows.Forms.Panel();
            this.btn_CheckOut_Rescan = new System.Windows.Forms.Button();
            this.lbl_CheckOut_ReadyToScanNFC = new System.Windows.Forms.Label();
            this.btn_CheckOut_Back = new System.Windows.Forms.Button();
            this.btn_CheckOut_ProcessCheckOut = new System.Windows.Forms.Button();
            this.tbx_CheckOut_SerialNum = new System.Windows.Forms.TextBox();
            this.tbxCheckOut_UniqueID = new System.Windows.Forms.TextBox();
            this.lblCheckOutTitle = new System.Windows.Forms.Label();
            this.AddLaptopPanel = new System.Windows.Forms.Panel();
            this.btn_AddLaptop_Back = new System.Windows.Forms.Button();
            this.lbl_AddLaptop_Title = new System.Windows.Forms.Label();
            this.tbx_AddLaptop_SerialNumber = new System.Windows.Forms.TextBox();
            this.tbx_AddLaptop_Condition = new System.Windows.Forms.TextBox();
            this.tbx_AddLaptop_Brand = new System.Windows.Forms.TextBox();
            this.tbx_AddLaptop_Model = new System.Windows.Forms.TextBox();
            this.tbx_AddLaptop_Processor = new System.Windows.Forms.TextBox();
            this.tbx_AddLaptop_RAM = new System.Windows.Forms.TextBox();
            this.tbx_AddLaptop_Resolution = new System.Windows.Forms.TextBox();
            this.tbx_AddLaptop_Size = new System.Windows.Forms.TextBox();
            this.tbx_AddLaptop_OSVersion = new System.Windows.Forms.TextBox();
            this.tbx_AddLaptop_Memory = new System.Windows.Forms.TextBox();
            this.pnl_AddLaptop_InServicePanel = new System.Windows.Forms.Panel();
            this.rdo_AddLaptop_InService_Yes = new System.Windows.Forms.RadioButton();
            this.rdo_AddLaptop_InService_No = new System.Windows.Forms.RadioButton();
            this.dtp_AddLaptop_DateAdded = new System.Windows.Forms.DateTimePicker();
            this.lbl_AddLaptop_InServiceLabel = new System.Windows.Forms.Label();
            this.btn_AddLaptop_SubmitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_CheckOut_ScanStatus = new System.Windows.Forms.Label();
            this.btn_AddLaptop_Rescan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.HomePagePanel.SuspendLayout();
            this.CheckOutLaptopPanel.SuspendLayout();
            this.AddLaptopPanel.SuspendLayout();
            this.pnl_AddLaptop_InServicePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(164, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(521, 235);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.BackColor = System.Drawing.Color.White;
            this.btnCheckOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCheckOut.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnCheckOut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnCheckOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCheckOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckOut.Location = new System.Drawing.Point(288, 225);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(262, 74);
            this.btnCheckOut.TabIndex = 2;
            this.btnCheckOut.Text = "Check Out Laptop";
            this.btnCheckOut.UseVisualStyleBackColor = false;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.BackColor = System.Drawing.Color.White;
            this.btnCheckIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCheckIn.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnCheckIn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnCheckIn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCheckIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckIn.Location = new System.Drawing.Point(288, 318);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(262, 74);
            this.btnCheckIn.TabIndex = 3;
            this.btnCheckIn.Text = "Return Laptop";
            this.btnCheckIn.UseVisualStyleBackColor = false;
            // 
            // btnAddLaptop
            // 
            this.btnAddLaptop.BackColor = System.Drawing.Color.White;
            this.btnAddLaptop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddLaptop.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnAddLaptop.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnAddLaptop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAddLaptop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddLaptop.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddLaptop.Location = new System.Drawing.Point(288, 409);
            this.btnAddLaptop.Name = "btnAddLaptop";
            this.btnAddLaptop.Size = new System.Drawing.Size(262, 74);
            this.btnAddLaptop.TabIndex = 4;
            this.btnAddLaptop.Text = "Add Laptop To System";
            this.btnAddLaptop.UseVisualStyleBackColor = false;
            this.btnAddLaptop.Click += new System.EventHandler(this.btnAddLaptop_Click);
            // 
            // btnInventory
            // 
            this.btnInventory.BackColor = System.Drawing.Color.White;
            this.btnInventory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInventory.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnInventory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnInventory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventory.Location = new System.Drawing.Point(288, 501);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(262, 74);
            this.btnInventory.TabIndex = 5;
            this.btnInventory.Text = "Check Inventory";
            this.btnInventory.UseVisualStyleBackColor = false;
            // 
            // HomePagePanel
            // 
            this.HomePagePanel.Controls.Add(this.btnInventory);
            this.HomePagePanel.Controls.Add(this.btnAddLaptop);
            this.HomePagePanel.Controls.Add(this.btnCheckIn);
            this.HomePagePanel.Controls.Add(this.btnCheckOut);
            this.HomePagePanel.Controls.Add(this.pictureBox1);
            this.HomePagePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HomePagePanel.Location = new System.Drawing.Point(0, 0);
            this.HomePagePanel.Name = "HomePagePanel";
            this.HomePagePanel.Size = new System.Drawing.Size(841, 617);
            this.HomePagePanel.TabIndex = 6;
            // 
            // CheckOutLaptopPanel
            // 
            this.CheckOutLaptopPanel.Controls.Add(this.btn_CheckOut_Rescan);
            this.CheckOutLaptopPanel.Controls.Add(this.lbl_CheckOut_ReadyToScanNFC);
            this.CheckOutLaptopPanel.Controls.Add(this.btn_CheckOut_Back);
            this.CheckOutLaptopPanel.Controls.Add(this.btn_CheckOut_ProcessCheckOut);
            this.CheckOutLaptopPanel.Controls.Add(this.tbx_CheckOut_SerialNum);
            this.CheckOutLaptopPanel.Controls.Add(this.tbxCheckOut_UniqueID);
            this.CheckOutLaptopPanel.Controls.Add(this.lblCheckOutTitle);
            this.CheckOutLaptopPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CheckOutLaptopPanel.Location = new System.Drawing.Point(0, 0);
            this.CheckOutLaptopPanel.Name = "CheckOutLaptopPanel";
            this.CheckOutLaptopPanel.Size = new System.Drawing.Size(841, 617);
            this.CheckOutLaptopPanel.TabIndex = 6;
            this.CheckOutLaptopPanel.Visible = false;
            // 
            // btn_CheckOut_Rescan
            // 
            this.btn_CheckOut_Rescan.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CheckOut_Rescan.Location = new System.Drawing.Point(538, 296);
            this.btn_CheckOut_Rescan.Name = "btn_CheckOut_Rescan";
            this.btn_CheckOut_Rescan.Size = new System.Drawing.Size(75, 20);
            this.btn_CheckOut_Rescan.TabIndex = 6;
            this.btn_CheckOut_Rescan.Text = "Rescan";
            this.btn_CheckOut_Rescan.UseVisualStyleBackColor = true;
            this.btn_CheckOut_Rescan.Visible = false;
            this.btn_CheckOut_Rescan.Click += new System.EventHandler(this.btn_CheckOut_Rescan_Click);
            // 
            // lbl_CheckOut_ReadyToScanNFC
            // 
            this.lbl_CheckOut_ReadyToScanNFC.AutoSize = true;
            this.lbl_CheckOut_ReadyToScanNFC.ForeColor = System.Drawing.Color.Red;
            this.lbl_CheckOut_ReadyToScanNFC.Location = new System.Drawing.Point(291, 323);
            this.lbl_CheckOut_ReadyToScanNFC.Name = "lbl_CheckOut_ReadyToScanNFC";
            this.lbl_CheckOut_ReadyToScanNFC.Size = new System.Drawing.Size(126, 13);
            this.lbl_CheckOut_ReadyToScanNFC.TabIndex = 5;
            this.lbl_CheckOut_ReadyToScanNFC.Text = "Ready to Scan NFC Chip";
            this.lbl_CheckOut_ReadyToScanNFC.Visible = false;
            // 
            // btn_CheckOut_Back
            // 
            this.btn_CheckOut_Back.BackColor = System.Drawing.Color.White;
            this.btn_CheckOut_Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_CheckOut_Back.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn_CheckOut_Back.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btn_CheckOut_Back.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_CheckOut_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CheckOut_Back.Location = new System.Drawing.Point(12, 12);
            this.btn_CheckOut_Back.Name = "btn_CheckOut_Back";
            this.btn_CheckOut_Back.Size = new System.Drawing.Size(75, 29);
            this.btn_CheckOut_Back.TabIndex = 4;
            this.btn_CheckOut_Back.Text = "← Go Back";
            this.btn_CheckOut_Back.UseVisualStyleBackColor = false;
            this.btn_CheckOut_Back.Click += new System.EventHandler(this.btn_CheckOut_Back_Click);
            // 
            // btn_CheckOut_ProcessCheckOut
            // 
            this.btn_CheckOut_ProcessCheckOut.BackColor = System.Drawing.Color.White;
            this.btn_CheckOut_ProcessCheckOut.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn_CheckOut_ProcessCheckOut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btn_CheckOut_ProcessCheckOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_CheckOut_ProcessCheckOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CheckOut_ProcessCheckOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CheckOut_ProcessCheckOut.Location = new System.Drawing.Point(291, 476);
            this.btn_CheckOut_ProcessCheckOut.Name = "btn_CheckOut_ProcessCheckOut";
            this.btn_CheckOut_ProcessCheckOut.Size = new System.Drawing.Size(241, 55);
            this.btn_CheckOut_ProcessCheckOut.TabIndex = 3;
            this.btn_CheckOut_ProcessCheckOut.Text = "Check Out";
            this.btn_CheckOut_ProcessCheckOut.UseVisualStyleBackColor = false;
            // 
            // tbx_CheckOut_SerialNum
            // 
            this.tbx_CheckOut_SerialNum.Location = new System.Drawing.Point(291, 296);
            this.tbx_CheckOut_SerialNum.Name = "tbx_CheckOut_SerialNum";
            this.tbx_CheckOut_SerialNum.Size = new System.Drawing.Size(241, 20);
            this.tbx_CheckOut_SerialNum.TabIndex = 2;
            this.tbx_CheckOut_SerialNum.Text = "Laptop Serial Number";
            this.tbx_CheckOut_SerialNum.TextChanged += new System.EventHandler(this.tbx_CheckOut_SerialNum_TextChanged);
            this.tbx_CheckOut_SerialNum.Enter += new System.EventHandler(this.tbx_CheckOut_SerialNum_Enter);
            this.tbx_CheckOut_SerialNum.Leave += new System.EventHandler(this.tbx_CheckOut_SerialNum_Leave);
            // 
            // tbxCheckOut_UniqueID
            // 
            this.tbxCheckOut_UniqueID.Location = new System.Drawing.Point(291, 141);
            this.tbxCheckOut_UniqueID.Name = "tbxCheckOut_UniqueID";
            this.tbxCheckOut_UniqueID.Size = new System.Drawing.Size(241, 20);
            this.tbxCheckOut_UniqueID.TabIndex = 1;
            this.tbxCheckOut_UniqueID.Text = "Enter Unique ID";
            this.tbxCheckOut_UniqueID.Enter += new System.EventHandler(this.tbxCheckOut_UniqueID_Enter);
            this.tbxCheckOut_UniqueID.Leave += new System.EventHandler(this.tbxCheckOut_UniqueID_Leave);
            // 
            // lblCheckOutTitle
            // 
            this.lblCheckOutTitle.AutoSize = true;
            this.lblCheckOutTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckOutTitle.Location = new System.Drawing.Point(273, 22);
            this.lblCheckOutTitle.Name = "lblCheckOutTitle";
            this.lblCheckOutTitle.Size = new System.Drawing.Size(290, 39);
            this.lblCheckOutTitle.TabIndex = 0;
            this.lblCheckOutTitle.Text = "Check Out Laptop";
            // 
            // AddLaptopPanel
            // 
            this.AddLaptopPanel.Controls.Add(this.btn_AddLaptop_Rescan);
            this.AddLaptopPanel.Controls.Add(this.lbl_CheckOut_ScanStatus);
            this.AddLaptopPanel.Controls.Add(this.label1);
            this.AddLaptopPanel.Controls.Add(this.btn_AddLaptop_SubmitButton);
            this.AddLaptopPanel.Controls.Add(this.dtp_AddLaptop_DateAdded);
            this.AddLaptopPanel.Controls.Add(this.pnl_AddLaptop_InServicePanel);
            this.AddLaptopPanel.Controls.Add(this.tbx_AddLaptop_Memory);
            this.AddLaptopPanel.Controls.Add(this.tbx_AddLaptop_OSVersion);
            this.AddLaptopPanel.Controls.Add(this.tbx_AddLaptop_Size);
            this.AddLaptopPanel.Controls.Add(this.tbx_AddLaptop_Resolution);
            this.AddLaptopPanel.Controls.Add(this.tbx_AddLaptop_RAM);
            this.AddLaptopPanel.Controls.Add(this.tbx_AddLaptop_Processor);
            this.AddLaptopPanel.Controls.Add(this.tbx_AddLaptop_Model);
            this.AddLaptopPanel.Controls.Add(this.tbx_AddLaptop_Brand);
            this.AddLaptopPanel.Controls.Add(this.tbx_AddLaptop_Condition);
            this.AddLaptopPanel.Controls.Add(this.tbx_AddLaptop_SerialNumber);
            this.AddLaptopPanel.Controls.Add(this.btn_AddLaptop_Back);
            this.AddLaptopPanel.Controls.Add(this.lbl_AddLaptop_Title);
            this.AddLaptopPanel.Location = new System.Drawing.Point(0, 0);
            this.AddLaptopPanel.Name = "AddLaptopPanel";
            this.AddLaptopPanel.Size = new System.Drawing.Size(841, 617);
            this.AddLaptopPanel.TabIndex = 6;
            this.AddLaptopPanel.Visible = false;
            // 
            // btn_AddLaptop_Back
            // 
            this.btn_AddLaptop_Back.BackColor = System.Drawing.Color.White;
            this.btn_AddLaptop_Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AddLaptop_Back.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn_AddLaptop_Back.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btn_AddLaptop_Back.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_AddLaptop_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddLaptop_Back.Location = new System.Drawing.Point(12, 12);
            this.btn_AddLaptop_Back.Name = "btn_AddLaptop_Back";
            this.btn_AddLaptop_Back.Size = new System.Drawing.Size(75, 29);
            this.btn_AddLaptop_Back.TabIndex = 4;
            this.btn_AddLaptop_Back.Text = "← Go Back";
            this.btn_AddLaptop_Back.UseVisualStyleBackColor = false;
            this.btn_AddLaptop_Back.Click += new System.EventHandler(this.btn_AddLaptop_Back_Click);
            // 
            // lbl_AddLaptop_Title
            // 
            this.lbl_AddLaptop_Title.AutoSize = true;
            this.lbl_AddLaptop_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AddLaptop_Title.Location = new System.Drawing.Point(291, 31);
            this.lbl_AddLaptop_Title.Name = "lbl_AddLaptop_Title";
            this.lbl_AddLaptop_Title.Size = new System.Drawing.Size(269, 39);
            this.lbl_AddLaptop_Title.TabIndex = 0;
            this.lbl_AddLaptop_Title.Text = "Add New Laptop";
            // 
            // tbx_AddLaptop_SerialNumber
            // 
            this.tbx_AddLaptop_SerialNumber.Location = new System.Drawing.Point(320, 99);
            this.tbx_AddLaptop_SerialNumber.Name = "tbx_AddLaptop_SerialNumber";
            this.tbx_AddLaptop_SerialNumber.Size = new System.Drawing.Size(201, 20);
            this.tbx_AddLaptop_SerialNumber.TabIndex = 5;
            this.tbx_AddLaptop_SerialNumber.Text = "Scan Serial Number";
            // 
            // tbx_AddLaptop_Condition
            // 
            this.tbx_AddLaptop_Condition.Location = new System.Drawing.Point(153, 212);
            this.tbx_AddLaptop_Condition.Name = "tbx_AddLaptop_Condition";
            this.tbx_AddLaptop_Condition.Size = new System.Drawing.Size(246, 20);
            this.tbx_AddLaptop_Condition.TabIndex = 6;
            this.tbx_AddLaptop_Condition.Text = "Laptop Condition";
            // 
            // tbx_AddLaptop_Brand
            // 
            this.tbx_AddLaptop_Brand.Location = new System.Drawing.Point(153, 257);
            this.tbx_AddLaptop_Brand.Name = "tbx_AddLaptop_Brand";
            this.tbx_AddLaptop_Brand.Size = new System.Drawing.Size(246, 20);
            this.tbx_AddLaptop_Brand.TabIndex = 7;
            this.tbx_AddLaptop_Brand.Text = "Laptop Brand";
            // 
            // tbx_AddLaptop_Model
            // 
            this.tbx_AddLaptop_Model.Location = new System.Drawing.Point(153, 305);
            this.tbx_AddLaptop_Model.Name = "tbx_AddLaptop_Model";
            this.tbx_AddLaptop_Model.Size = new System.Drawing.Size(246, 20);
            this.tbx_AddLaptop_Model.TabIndex = 8;
            this.tbx_AddLaptop_Model.Text = "Laptop Model";
            // 
            // tbx_AddLaptop_Processor
            // 
            this.tbx_AddLaptop_Processor.Location = new System.Drawing.Point(153, 350);
            this.tbx_AddLaptop_Processor.Name = "tbx_AddLaptop_Processor";
            this.tbx_AddLaptop_Processor.Size = new System.Drawing.Size(246, 20);
            this.tbx_AddLaptop_Processor.TabIndex = 9;
            this.tbx_AddLaptop_Processor.Text = "Laptop Processor";
            // 
            // tbx_AddLaptop_RAM
            // 
            this.tbx_AddLaptop_RAM.Location = new System.Drawing.Point(153, 399);
            this.tbx_AddLaptop_RAM.Name = "tbx_AddLaptop_RAM";
            this.tbx_AddLaptop_RAM.Size = new System.Drawing.Size(246, 20);
            this.tbx_AddLaptop_RAM.TabIndex = 10;
            this.tbx_AddLaptop_RAM.Text = "Laptop RAM";
            // 
            // tbx_AddLaptop_Resolution
            // 
            this.tbx_AddLaptop_Resolution.Location = new System.Drawing.Point(439, 212);
            this.tbx_AddLaptop_Resolution.Name = "tbx_AddLaptop_Resolution";
            this.tbx_AddLaptop_Resolution.Size = new System.Drawing.Size(246, 20);
            this.tbx_AddLaptop_Resolution.TabIndex = 11;
            this.tbx_AddLaptop_Resolution.Text = "Laptop Resolution";
            // 
            // tbx_AddLaptop_Size
            // 
            this.tbx_AddLaptop_Size.Location = new System.Drawing.Point(439, 257);
            this.tbx_AddLaptop_Size.Name = "tbx_AddLaptop_Size";
            this.tbx_AddLaptop_Size.Size = new System.Drawing.Size(246, 20);
            this.tbx_AddLaptop_Size.TabIndex = 12;
            this.tbx_AddLaptop_Size.Text = "Laptop Screen Size";
            // 
            // tbx_AddLaptop_OSVersion
            // 
            this.tbx_AddLaptop_OSVersion.Location = new System.Drawing.Point(439, 305);
            this.tbx_AddLaptop_OSVersion.Name = "tbx_AddLaptop_OSVersion";
            this.tbx_AddLaptop_OSVersion.Size = new System.Drawing.Size(246, 20);
            this.tbx_AddLaptop_OSVersion.TabIndex = 13;
            this.tbx_AddLaptop_OSVersion.Text = "Laptop OS Version";
            // 
            // tbx_AddLaptop_Memory
            // 
            this.tbx_AddLaptop_Memory.Location = new System.Drawing.Point(439, 399);
            this.tbx_AddLaptop_Memory.Name = "tbx_AddLaptop_Memory";
            this.tbx_AddLaptop_Memory.Size = new System.Drawing.Size(246, 20);
            this.tbx_AddLaptop_Memory.TabIndex = 15;
            this.tbx_AddLaptop_Memory.Text = "Laptop Memory";
            // 
            // pnl_AddLaptop_InServicePanel
            // 
            this.pnl_AddLaptop_InServicePanel.Controls.Add(this.lbl_AddLaptop_InServiceLabel);
            this.pnl_AddLaptop_InServicePanel.Controls.Add(this.rdo_AddLaptop_InService_No);
            this.pnl_AddLaptop_InServicePanel.Controls.Add(this.rdo_AddLaptop_InService_Yes);
            this.pnl_AddLaptop_InServicePanel.Location = new System.Drawing.Point(153, 427);
            this.pnl_AddLaptop_InServicePanel.Name = "pnl_AddLaptop_InServicePanel";
            this.pnl_AddLaptop_InServicePanel.Size = new System.Drawing.Size(190, 48);
            this.pnl_AddLaptop_InServicePanel.TabIndex = 16;
            // 
            // rdo_AddLaptop_InService_Yes
            // 
            this.rdo_AddLaptop_InService_Yes.AutoSize = true;
            this.rdo_AddLaptop_InService_Yes.Location = new System.Drawing.Point(4, 28);
            this.rdo_AddLaptop_InService_Yes.Name = "rdo_AddLaptop_InService_Yes";
            this.rdo_AddLaptop_InService_Yes.Size = new System.Drawing.Size(43, 17);
            this.rdo_AddLaptop_InService_Yes.TabIndex = 0;
            this.rdo_AddLaptop_InService_Yes.TabStop = true;
            this.rdo_AddLaptop_InService_Yes.Text = "Yes";
            this.rdo_AddLaptop_InService_Yes.UseVisualStyleBackColor = true;
            // 
            // rdo_AddLaptop_InService_No
            // 
            this.rdo_AddLaptop_InService_No.AutoSize = true;
            this.rdo_AddLaptop_InService_No.Location = new System.Drawing.Point(53, 28);
            this.rdo_AddLaptop_InService_No.Name = "rdo_AddLaptop_InService_No";
            this.rdo_AddLaptop_InService_No.Size = new System.Drawing.Size(39, 17);
            this.rdo_AddLaptop_InService_No.TabIndex = 1;
            this.rdo_AddLaptop_InService_No.TabStop = true;
            this.rdo_AddLaptop_InService_No.Text = "No";
            this.rdo_AddLaptop_InService_No.UseVisualStyleBackColor = true;
            // 
            // dtp_AddLaptop_DateAdded
            // 
            this.dtp_AddLaptop_DateAdded.Location = new System.Drawing.Point(439, 350);
            this.dtp_AddLaptop_DateAdded.Name = "dtp_AddLaptop_DateAdded";
            this.dtp_AddLaptop_DateAdded.Size = new System.Drawing.Size(246, 20);
            this.dtp_AddLaptop_DateAdded.TabIndex = 17;
            // 
            // lbl_AddLaptop_InServiceLabel
            // 
            this.lbl_AddLaptop_InServiceLabel.AutoSize = true;
            this.lbl_AddLaptop_InServiceLabel.Location = new System.Drawing.Point(-3, 9);
            this.lbl_AddLaptop_InServiceLabel.Name = "lbl_AddLaptop_InServiceLabel";
            this.lbl_AddLaptop_InServiceLabel.Size = new System.Drawing.Size(97, 13);
            this.lbl_AddLaptop_InServiceLabel.TabIndex = 2;
            this.lbl_AddLaptop_InServiceLabel.Text = "Laptop In Service?";
            // 
            // btn_AddLaptop_SubmitButton
            // 
            this.btn_AddLaptop_SubmitButton.BackColor = System.Drawing.Color.White;
            this.btn_AddLaptop_SubmitButton.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn_AddLaptop_SubmitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btn_AddLaptop_SubmitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_AddLaptop_SubmitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddLaptop_SubmitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddLaptop_SubmitButton.Location = new System.Drawing.Point(302, 524);
            this.btn_AddLaptop_SubmitButton.Name = "btn_AddLaptop_SubmitButton";
            this.btn_AddLaptop_SubmitButton.Size = new System.Drawing.Size(241, 55);
            this.btn_AddLaptop_SubmitButton.TabIndex = 18;
            this.btn_AddLaptop_SubmitButton.Text = "Add Laptop";
            this.btn_AddLaptop_SubmitButton.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(333, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 25);
            this.label1.TabIndex = 19;
            this.label1.Text = "Laptop Information";
            // 
            // lbl_CheckOut_ScanStatus
            // 
            this.lbl_CheckOut_ScanStatus.AutoSize = true;
            this.lbl_CheckOut_ScanStatus.ForeColor = System.Drawing.Color.Red;
            this.lbl_CheckOut_ScanStatus.Location = new System.Drawing.Point(320, 126);
            this.lbl_CheckOut_ScanStatus.Name = "lbl_CheckOut_ScanStatus";
            this.lbl_CheckOut_ScanStatus.Size = new System.Drawing.Size(126, 13);
            this.lbl_CheckOut_ScanStatus.TabIndex = 20;
            this.lbl_CheckOut_ScanStatus.Text = "Ready to Scan NFC Chip";
            // 
            // btn_AddLaptop_Rescan
            // 
            this.btn_AddLaptop_Rescan.Location = new System.Drawing.Point(527, 99);
            this.btn_AddLaptop_Rescan.Name = "btn_AddLaptop_Rescan";
            this.btn_AddLaptop_Rescan.Size = new System.Drawing.Size(75, 20);
            this.btn_AddLaptop_Rescan.TabIndex = 21;
            this.btn_AddLaptop_Rescan.Text = "Rescan";
            this.btn_AddLaptop_Rescan.UseVisualStyleBackColor = true;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(841, 617);
            this.Controls.Add(this.AddLaptopPanel);
            this.Controls.Add(this.HomePagePanel);
            this.Controls.Add(this.CheckOutLaptopPanel);
            this.Name = "HomePage";
            this.Text = "FSB NFC Laptop Rental";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.HomePagePanel.ResumeLayout(false);
            this.CheckOutLaptopPanel.ResumeLayout(false);
            this.CheckOutLaptopPanel.PerformLayout();
            this.AddLaptopPanel.ResumeLayout(false);
            this.AddLaptopPanel.PerformLayout();
            this.pnl_AddLaptop_InServicePanel.ResumeLayout(false);
            this.pnl_AddLaptop_InServicePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.Button btnCheckIn;
        private System.Windows.Forms.Button btnAddLaptop;
        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.Panel HomePagePanel;
        private System.Windows.Forms.Panel CheckOutLaptopPanel;
        private System.Windows.Forms.Label lblCheckOutTitle;
        private System.Windows.Forms.TextBox tbxCheckOut_UniqueID;
        private System.Windows.Forms.TextBox tbx_CheckOut_SerialNum;
        private System.Windows.Forms.Button btn_CheckOut_ProcessCheckOut;
        private System.Windows.Forms.Button btn_CheckOut_Back;
        private System.Windows.Forms.Label lbl_CheckOut_ReadyToScanNFC;
        private System.Windows.Forms.Button btn_CheckOut_Rescan;
        private System.Windows.Forms.Panel AddLaptopPanel;
        private System.Windows.Forms.Label lbl_AddLaptop_Title;
        private System.Windows.Forms.Button btn_AddLaptop_Back;
        private System.Windows.Forms.DateTimePicker dtp_AddLaptop_DateAdded;
        private System.Windows.Forms.Panel pnl_AddLaptop_InServicePanel;
        private System.Windows.Forms.Label lbl_AddLaptop_InServiceLabel;
        private System.Windows.Forms.RadioButton rdo_AddLaptop_InService_No;
        private System.Windows.Forms.RadioButton rdo_AddLaptop_InService_Yes;
        private System.Windows.Forms.TextBox tbx_AddLaptop_Memory;
        private System.Windows.Forms.TextBox tbx_AddLaptop_OSVersion;
        private System.Windows.Forms.TextBox tbx_AddLaptop_Size;
        private System.Windows.Forms.TextBox tbx_AddLaptop_Resolution;
        private System.Windows.Forms.TextBox tbx_AddLaptop_RAM;
        private System.Windows.Forms.TextBox tbx_AddLaptop_Processor;
        private System.Windows.Forms.TextBox tbx_AddLaptop_Model;
        private System.Windows.Forms.TextBox tbx_AddLaptop_Brand;
        private System.Windows.Forms.TextBox tbx_AddLaptop_Condition;
        private System.Windows.Forms.TextBox tbx_AddLaptop_SerialNumber;
        private System.Windows.Forms.Button btn_AddLaptop_Rescan;
        private System.Windows.Forms.Label lbl_CheckOut_ScanStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_AddLaptop_SubmitButton;
    }
}

