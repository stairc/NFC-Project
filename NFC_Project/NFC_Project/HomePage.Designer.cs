namespace NFC_Project
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
            this.CheckInventoryPanel = new System.Windows.Forms.Panel();
            this.lbl_CheckInventory_AvailableLaptopCount = new System.Windows.Forms.Label();
            this.lbl_CheckInventory_AvailalbeLaptopsTitle = new System.Windows.Forms.Label();
            this.btn_CheckOut_RefeshData = new System.Windows.Forms.Button();
            this.tab_CheckInventory_TabControl = new System.Windows.Forms.TabControl();
            this.tab_CheckInventory_AllLaptops = new System.Windows.Forms.TabPage();
            this.tbl_CheckInventory_AllLaptopsDisplayTable = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_CheckInventory_TableHeaders_DeviceType = new System.Windows.Forms.Label();
            this.lbl_CheckInventory_TableHeaders_OS = new System.Windows.Forms.Label();
            this.lbl_CheckInventory_TableHeaders_RAM = new System.Windows.Forms.Label();
            this.lbl_CheckInventory_TableHeaders_Processor = new System.Windows.Forms.Label();
            this.lbl_CheckInventory_TableHeaders_LaptopSerialNum = new System.Windows.Forms.Label();
            this.tab_CheckInventory_AvailableLaptops = new System.Windows.Forms.TabPage();
            this.tbl_CheckInventory_AvailableLaptopDisplayTable = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_CheckInventory_TableHeaders_DeviceType2 = new System.Windows.Forms.Label();
            this.lbl_CheckInventory_TableHeaders_LaptopSerialNumber_AvailableLaptops = new System.Windows.Forms.Label();
            this.lbl_CheckInventory_TableHeaders_Processor2 = new System.Windows.Forms.Label();
            this.lbl_CheckInventory_TableHeaders_RAM2 = new System.Windows.Forms.Label();
            this.lbl_CheckInventory_TableHeaders_OSVersion2 = new System.Windows.Forms.Label();
            this.tab_CheckInventory_RentedLaptops = new System.Windows.Forms.TabPage();
            this.tbl_CheckInventory_RentedLaptopsDisplayTable = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_CheckInventory_TableHeaders_SendReminder = new System.Windows.Forms.Label();
            this.lbl_CheckInventory_TableHeaders_LaptopUser = new System.Windows.Forms.Label();
            this.lbl_CheckInventory_TableHeaders_RentalID = new System.Windows.Forms.Label();
            this.lbl_CheckInventory_TableHeaders_LaptopSerialNumber_RentedLaptops = new System.Windows.Forms.Label();
            this.btn_CheckInventory_Back = new System.Windows.Forms.Button();
            this.lbl_CheckInventory_Title = new System.Windows.Forms.Label();
            this.CheckOutLaptopPanel = new System.Windows.Forms.Panel();
            this.btn_CheckOut_UserLogin = new System.Windows.Forms.Button();
            this.lbl_CheckOut_UserFound = new System.Windows.Forms.Label();
            this.lbl_CheckOut_UserInformation = new System.Windows.Forms.Label();
            this.btn_CheckOut_RescanID = new System.Windows.Forms.Button();
            this.tbx_CheckOut_UserPassword = new System.Windows.Forms.TextBox();
            this.tbx_CheckOut_UserUniqueID = new System.Windows.Forms.TextBox();
            this.btn_CheckOut_Rescan = new System.Windows.Forms.Button();
            this.lbl_CheckOut_ReadyToScanNFC = new System.Windows.Forms.Label();
            this.btn_CheckOut_Back = new System.Windows.Forms.Button();
            this.btn_CheckOut_ProcessCheckOut = new System.Windows.Forms.Button();
            this.tbx_CheckOut_SerialNum = new System.Windows.Forms.TextBox();
            this.tbx_CheckOut_UserSerialNum = new System.Windows.Forms.TextBox();
            this.lblCheckOutTitle = new System.Windows.Forms.Label();
            this.AddLaptopPanel = new System.Windows.Forms.Panel();
            this.tbx_AddLaptop_SerialNum = new System.Windows.Forms.TextBox();
            this.btn_AddLaptop_Rescan = new System.Windows.Forms.Button();
            this.lbl_AddLaptop_ScanStatus = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_AddLaptop_SubmitButton = new System.Windows.Forms.Button();
            this.dtp_AddLaptop_DateAdded = new System.Windows.Forms.DateTimePicker();
            this.pnl_AddLaptop_InServicePanel = new System.Windows.Forms.Panel();
            this.lbl_AddLaptop_InServiceLabel = new System.Windows.Forms.Label();
            this.rdo_AddLaptop_InService_No = new System.Windows.Forms.RadioButton();
            this.rdo_AddLaptop_InService_Yes = new System.Windows.Forms.RadioButton();
            this.tbx_AddLaptop_Memory = new System.Windows.Forms.TextBox();
            this.tbx_AddLaptop_OSVersion = new System.Windows.Forms.TextBox();
            this.tbx_AddLaptop_Size = new System.Windows.Forms.TextBox();
            this.tbx_AddLaptop_Resolution = new System.Windows.Forms.TextBox();
            this.tbx_AddLaptop_RAM = new System.Windows.Forms.TextBox();
            this.tbx_AddLaptop_Processor = new System.Windows.Forms.TextBox();
            this.tbx_AddLaptop_Model = new System.Windows.Forms.TextBox();
            this.tbx_AddLaptop_Brand = new System.Windows.Forms.TextBox();
            this.tbx_AddLaptop_Condition = new System.Windows.Forms.TextBox();
            this.tbx_AddLaptop_LaptopID = new System.Windows.Forms.TextBox();
            this.btn_AddLaptop_Back = new System.Windows.Forms.Button();
            this.lbl_AddLaptop_Title = new System.Windows.Forms.Label();
            this.ReturnLaptopPanel = new System.Windows.Forms.Panel();
            this.lbl_Return_ScanStatus = new System.Windows.Forms.Label();
            this.btn_Return_Rescan = new System.Windows.Forms.Button();
            this.pnl_ReturnLaptop_RentalInfoDisplayPanel = new System.Windows.Forms.Panel();
            this.lbl_Return_OverdueText = new System.Windows.Forms.Label();
            this.lbl_Return_RentalIDText = new System.Windows.Forms.Label();
            this.lbl_Return_CheckoutText = new System.Windows.Forms.Label();
            this.lbl_Return_Overdue = new System.Windows.Forms.Label();
            this.lbl_Return_RentalID = new System.Windows.Forms.Label();
            this.lbl_Return_Checkout = new System.Windows.Forms.Label();
            this.lbl_Return_UserText = new System.Windows.Forms.Label();
            this.lbl_Rental_User = new System.Windows.Forms.Label();
            this.lbl_RentalInfoTitle = new System.Windows.Forms.Label();
            this.tbx_Return_LaptopID = new System.Windows.Forms.TextBox();
            this.btn_Return_ProcessReturn = new System.Windows.Forms.Button();
            this.btn_Return_Back = new System.Windows.Forms.Button();
            this.lbl_Return_Title = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.HomePagePanel.SuspendLayout();
            this.CheckInventoryPanel.SuspendLayout();
            this.tab_CheckInventory_TabControl.SuspendLayout();
            this.tab_CheckInventory_AllLaptops.SuspendLayout();
            this.tbl_CheckInventory_AllLaptopsDisplayTable.SuspendLayout();
            this.tab_CheckInventory_AvailableLaptops.SuspendLayout();
            this.tbl_CheckInventory_AvailableLaptopDisplayTable.SuspendLayout();
            this.tab_CheckInventory_RentedLaptops.SuspendLayout();
            this.tbl_CheckInventory_RentedLaptopsDisplayTable.SuspendLayout();
            this.CheckOutLaptopPanel.SuspendLayout();
            this.AddLaptopPanel.SuspendLayout();
            this.pnl_AddLaptop_InServicePanel.SuspendLayout();
            this.ReturnLaptopPanel.SuspendLayout();
            this.pnl_ReturnLaptop_RentalInfoDisplayPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(164, 9);
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
            this.btnCheckOut.Location = new System.Drawing.Point(288, 231);
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
            this.btnCheckIn.Location = new System.Drawing.Point(288, 324);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(262, 74);
            this.btnCheckIn.TabIndex = 3;
            this.btnCheckIn.Text = "Return Laptop";
            this.btnCheckIn.UseVisualStyleBackColor = false;
            this.btnCheckIn.Click += new System.EventHandler(this.btnCheckIn_Click);
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
            this.btnAddLaptop.Location = new System.Drawing.Point(288, 415);
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
            this.btnInventory.Location = new System.Drawing.Point(288, 507);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(262, 74);
            this.btnInventory.TabIndex = 5;
            this.btnInventory.Text = "Check Inventory";
            this.btnInventory.UseVisualStyleBackColor = false;
            this.btnInventory.Click += new System.EventHandler(this.btnInventory_Click);
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
            // CheckInventoryPanel
            // 
            this.CheckInventoryPanel.Controls.Add(this.lbl_CheckInventory_AvailableLaptopCount);
            this.CheckInventoryPanel.Controls.Add(this.lbl_CheckInventory_AvailalbeLaptopsTitle);
            this.CheckInventoryPanel.Controls.Add(this.btn_CheckOut_RefeshData);
            this.CheckInventoryPanel.Controls.Add(this.tab_CheckInventory_TabControl);
            this.CheckInventoryPanel.Controls.Add(this.btn_CheckInventory_Back);
            this.CheckInventoryPanel.Controls.Add(this.lbl_CheckInventory_Title);
            this.CheckInventoryPanel.Location = new System.Drawing.Point(0, 0);
            this.CheckInventoryPanel.Name = "CheckInventoryPanel";
            this.CheckInventoryPanel.Size = new System.Drawing.Size(840, 616);
            this.CheckInventoryPanel.TabIndex = 6;
            // 
            // lbl_CheckInventory_AvailableLaptopCount
            // 
            this.lbl_CheckInventory_AvailableLaptopCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_CheckInventory_AvailableLaptopCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CheckInventory_AvailableLaptopCount.Location = new System.Drawing.Point(710, 87);
            this.lbl_CheckInventory_AvailableLaptopCount.Name = "lbl_CheckInventory_AvailableLaptopCount";
            this.lbl_CheckInventory_AvailableLaptopCount.Size = new System.Drawing.Size(39, 23);
            this.lbl_CheckInventory_AvailableLaptopCount.TabIndex = 9;
            this.lbl_CheckInventory_AvailableLaptopCount.Text = "10";
            this.lbl_CheckInventory_AvailableLaptopCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_CheckInventory_AvailalbeLaptopsTitle
            // 
            this.lbl_CheckInventory_AvailalbeLaptopsTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_CheckInventory_AvailalbeLaptopsTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CheckInventory_AvailalbeLaptopsTitle.Location = new System.Drawing.Point(505, 87);
            this.lbl_CheckInventory_AvailalbeLaptopsTitle.Name = "lbl_CheckInventory_AvailalbeLaptopsTitle";
            this.lbl_CheckInventory_AvailalbeLaptopsTitle.Size = new System.Drawing.Size(205, 23);
            this.lbl_CheckInventory_AvailalbeLaptopsTitle.TabIndex = 8;
            this.lbl_CheckInventory_AvailalbeLaptopsTitle.Text = "Currently Available Laptops:";
            this.lbl_CheckInventory_AvailalbeLaptopsTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_CheckOut_RefeshData
            // 
            this.btn_CheckOut_RefeshData.BackColor = System.Drawing.Color.White;
            this.btn_CheckOut_RefeshData.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn_CheckOut_RefeshData.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btn_CheckOut_RefeshData.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_CheckOut_RefeshData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CheckOut_RefeshData.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CheckOut_RefeshData.Location = new System.Drawing.Point(301, 547);
            this.btn_CheckOut_RefeshData.Name = "btn_CheckOut_RefeshData";
            this.btn_CheckOut_RefeshData.Size = new System.Drawing.Size(241, 55);
            this.btn_CheckOut_RefeshData.TabIndex = 7;
            this.btn_CheckOut_RefeshData.Text = "Refresh";
            this.btn_CheckOut_RefeshData.UseVisualStyleBackColor = false;
            this.btn_CheckOut_RefeshData.Click += new System.EventHandler(this.btn_CheckOut_RefeshData_Click);
            // 
            // tab_CheckInventory_TabControl
            // 
            this.tab_CheckInventory_TabControl.Controls.Add(this.tab_CheckInventory_AllLaptops);
            this.tab_CheckInventory_TabControl.Controls.Add(this.tab_CheckInventory_AvailableLaptops);
            this.tab_CheckInventory_TabControl.Controls.Add(this.tab_CheckInventory_RentedLaptops);
            this.tab_CheckInventory_TabControl.Location = new System.Drawing.Point(85, 103);
            this.tab_CheckInventory_TabControl.Name = "tab_CheckInventory_TabControl";
            this.tab_CheckInventory_TabControl.SelectedIndex = 0;
            this.tab_CheckInventory_TabControl.Size = new System.Drawing.Size(664, 428);
            this.tab_CheckInventory_TabControl.TabIndex = 6;
            // 
            // tab_CheckInventory_AllLaptops
            // 
            this.tab_CheckInventory_AllLaptops.Controls.Add(this.tbl_CheckInventory_AllLaptopsDisplayTable);
            this.tab_CheckInventory_AllLaptops.Location = new System.Drawing.Point(4, 22);
            this.tab_CheckInventory_AllLaptops.Name = "tab_CheckInventory_AllLaptops";
            this.tab_CheckInventory_AllLaptops.Padding = new System.Windows.Forms.Padding(3);
            this.tab_CheckInventory_AllLaptops.Size = new System.Drawing.Size(656, 402);
            this.tab_CheckInventory_AllLaptops.TabIndex = 1;
            this.tab_CheckInventory_AllLaptops.Text = "All Laptops";
            this.tab_CheckInventory_AllLaptops.UseVisualStyleBackColor = true;
            // 
            // tbl_CheckInventory_AllLaptopsDisplayTable
            // 
            this.tbl_CheckInventory_AllLaptopsDisplayTable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tbl_CheckInventory_AllLaptopsDisplayTable.ColumnCount = 5;
            this.tbl_CheckInventory_AllLaptopsDisplayTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.57143F));
            this.tbl_CheckInventory_AllLaptopsDisplayTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.85714F));
            this.tbl_CheckInventory_AllLaptopsDisplayTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.85714F));
            this.tbl_CheckInventory_AllLaptopsDisplayTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.85714F));
            this.tbl_CheckInventory_AllLaptopsDisplayTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.85714F));
            this.tbl_CheckInventory_AllLaptopsDisplayTable.Controls.Add(this.lbl_CheckInventory_TableHeaders_DeviceType, 0, 0);
            this.tbl_CheckInventory_AllLaptopsDisplayTable.Controls.Add(this.lbl_CheckInventory_TableHeaders_OS, 3, 0);
            this.tbl_CheckInventory_AllLaptopsDisplayTable.Controls.Add(this.lbl_CheckInventory_TableHeaders_RAM, 2, 0);
            this.tbl_CheckInventory_AllLaptopsDisplayTable.Controls.Add(this.lbl_CheckInventory_TableHeaders_Processor, 1, 0);
            this.tbl_CheckInventory_AllLaptopsDisplayTable.Controls.Add(this.lbl_CheckInventory_TableHeaders_LaptopSerialNum, 0, 0);
            this.tbl_CheckInventory_AllLaptopsDisplayTable.Location = new System.Drawing.Point(2, 2);
            this.tbl_CheckInventory_AllLaptopsDisplayTable.Name = "tbl_CheckInventory_AllLaptopsDisplayTable";
            this.tbl_CheckInventory_AllLaptopsDisplayTable.RowCount = 1;
            this.tbl_CheckInventory_AllLaptopsDisplayTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 400F));
            this.tbl_CheckInventory_AllLaptopsDisplayTable.Size = new System.Drawing.Size(653, 399);
            this.tbl_CheckInventory_AllLaptopsDisplayTable.TabIndex = 0;
            // 
            // lbl_CheckInventory_TableHeaders_DeviceType
            // 
            this.lbl_CheckInventory_TableHeaders_DeviceType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_CheckInventory_TableHeaders_DeviceType.AutoSize = true;
            this.lbl_CheckInventory_TableHeaders_DeviceType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CheckInventory_TableHeaders_DeviceType.Location = new System.Drawing.Point(189, 1);
            this.lbl_CheckInventory_TableHeaders_DeviceType.Name = "lbl_CheckInventory_TableHeaders_DeviceType";
            this.lbl_CheckInventory_TableHeaders_DeviceType.Size = new System.Drawing.Size(109, 400);
            this.lbl_CheckInventory_TableHeaders_DeviceType.TabIndex = 4;
            this.lbl_CheckInventory_TableHeaders_DeviceType.Text = "Device Type";
            this.lbl_CheckInventory_TableHeaders_DeviceType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_CheckInventory_TableHeaders_OS
            // 
            this.lbl_CheckInventory_TableHeaders_OS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_CheckInventory_TableHeaders_OS.AutoSize = true;
            this.lbl_CheckInventory_TableHeaders_OS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CheckInventory_TableHeaders_OS.Location = new System.Drawing.Point(537, 1);
            this.lbl_CheckInventory_TableHeaders_OS.Name = "lbl_CheckInventory_TableHeaders_OS";
            this.lbl_CheckInventory_TableHeaders_OS.Size = new System.Drawing.Size(112, 400);
            this.lbl_CheckInventory_TableHeaders_OS.TabIndex = 3;
            this.lbl_CheckInventory_TableHeaders_OS.Text = "Operating System";
            this.lbl_CheckInventory_TableHeaders_OS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_CheckInventory_TableHeaders_RAM
            // 
            this.lbl_CheckInventory_TableHeaders_RAM.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_CheckInventory_TableHeaders_RAM.AutoSize = true;
            this.lbl_CheckInventory_TableHeaders_RAM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CheckInventory_TableHeaders_RAM.Location = new System.Drawing.Point(421, 1);
            this.lbl_CheckInventory_TableHeaders_RAM.Name = "lbl_CheckInventory_TableHeaders_RAM";
            this.lbl_CheckInventory_TableHeaders_RAM.Size = new System.Drawing.Size(109, 400);
            this.lbl_CheckInventory_TableHeaders_RAM.TabIndex = 2;
            this.lbl_CheckInventory_TableHeaders_RAM.Text = "RAM";
            this.lbl_CheckInventory_TableHeaders_RAM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_CheckInventory_TableHeaders_Processor
            // 
            this.lbl_CheckInventory_TableHeaders_Processor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_CheckInventory_TableHeaders_Processor.AutoSize = true;
            this.lbl_CheckInventory_TableHeaders_Processor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CheckInventory_TableHeaders_Processor.Location = new System.Drawing.Point(305, 1);
            this.lbl_CheckInventory_TableHeaders_Processor.Name = "lbl_CheckInventory_TableHeaders_Processor";
            this.lbl_CheckInventory_TableHeaders_Processor.Size = new System.Drawing.Size(109, 400);
            this.lbl_CheckInventory_TableHeaders_Processor.TabIndex = 1;
            this.lbl_CheckInventory_TableHeaders_Processor.Text = "Processor";
            this.lbl_CheckInventory_TableHeaders_Processor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_CheckInventory_TableHeaders_LaptopSerialNum
            // 
            this.lbl_CheckInventory_TableHeaders_LaptopSerialNum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_CheckInventory_TableHeaders_LaptopSerialNum.AutoSize = true;
            this.lbl_CheckInventory_TableHeaders_LaptopSerialNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CheckInventory_TableHeaders_LaptopSerialNum.Location = new System.Drawing.Point(28, 194);
            this.lbl_CheckInventory_TableHeaders_LaptopSerialNum.Name = "lbl_CheckInventory_TableHeaders_LaptopSerialNum";
            this.lbl_CheckInventory_TableHeaders_LaptopSerialNum.Size = new System.Drawing.Size(129, 13);
            this.lbl_CheckInventory_TableHeaders_LaptopSerialNum.TabIndex = 0;
            this.lbl_CheckInventory_TableHeaders_LaptopSerialNum.Text = "Laptop Serial Number";
            this.lbl_CheckInventory_TableHeaders_LaptopSerialNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tab_CheckInventory_AvailableLaptops
            // 
            this.tab_CheckInventory_AvailableLaptops.Controls.Add(this.tbl_CheckInventory_AvailableLaptopDisplayTable);
            this.tab_CheckInventory_AvailableLaptops.Location = new System.Drawing.Point(4, 22);
            this.tab_CheckInventory_AvailableLaptops.Name = "tab_CheckInventory_AvailableLaptops";
            this.tab_CheckInventory_AvailableLaptops.Padding = new System.Windows.Forms.Padding(3);
            this.tab_CheckInventory_AvailableLaptops.Size = new System.Drawing.Size(656, 402);
            this.tab_CheckInventory_AvailableLaptops.TabIndex = 0;
            this.tab_CheckInventory_AvailableLaptops.Text = "Available Laptops";
            this.tab_CheckInventory_AvailableLaptops.UseVisualStyleBackColor = true;
            // 
            // tbl_CheckInventory_AvailableLaptopDisplayTable
            // 
            this.tbl_CheckInventory_AvailableLaptopDisplayTable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tbl_CheckInventory_AvailableLaptopDisplayTable.ColumnCount = 5;
            this.tbl_CheckInventory_AvailableLaptopDisplayTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.57143F));
            this.tbl_CheckInventory_AvailableLaptopDisplayTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.85714F));
            this.tbl_CheckInventory_AvailableLaptopDisplayTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.85714F));
            this.tbl_CheckInventory_AvailableLaptopDisplayTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.85714F));
            this.tbl_CheckInventory_AvailableLaptopDisplayTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.85714F));
            this.tbl_CheckInventory_AvailableLaptopDisplayTable.Controls.Add(this.lbl_CheckInventory_TableHeaders_DeviceType2, 1, 0);
            this.tbl_CheckInventory_AvailableLaptopDisplayTable.Controls.Add(this.lbl_CheckInventory_TableHeaders_LaptopSerialNumber_AvailableLaptops, 0, 0);
            this.tbl_CheckInventory_AvailableLaptopDisplayTable.Controls.Add(this.lbl_CheckInventory_TableHeaders_Processor2, 2, 0);
            this.tbl_CheckInventory_AvailableLaptopDisplayTable.Controls.Add(this.lbl_CheckInventory_TableHeaders_RAM2, 3, 0);
            this.tbl_CheckInventory_AvailableLaptopDisplayTable.Controls.Add(this.lbl_CheckInventory_TableHeaders_OSVersion2, 4, 0);
            this.tbl_CheckInventory_AvailableLaptopDisplayTable.Location = new System.Drawing.Point(2, 2);
            this.tbl_CheckInventory_AvailableLaptopDisplayTable.Name = "tbl_CheckInventory_AvailableLaptopDisplayTable";
            this.tbl_CheckInventory_AvailableLaptopDisplayTable.RowCount = 1;
            this.tbl_CheckInventory_AvailableLaptopDisplayTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 399F));
            this.tbl_CheckInventory_AvailableLaptopDisplayTable.Size = new System.Drawing.Size(653, 399);
            this.tbl_CheckInventory_AvailableLaptopDisplayTable.TabIndex = 1;
            // 
            // lbl_CheckInventory_TableHeaders_DeviceType2
            // 
            this.lbl_CheckInventory_TableHeaders_DeviceType2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_CheckInventory_TableHeaders_DeviceType2.AutoSize = true;
            this.lbl_CheckInventory_TableHeaders_DeviceType2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CheckInventory_TableHeaders_DeviceType2.Location = new System.Drawing.Point(189, 1);
            this.lbl_CheckInventory_TableHeaders_DeviceType2.Name = "lbl_CheckInventory_TableHeaders_DeviceType2";
            this.lbl_CheckInventory_TableHeaders_DeviceType2.Size = new System.Drawing.Size(109, 399);
            this.lbl_CheckInventory_TableHeaders_DeviceType2.TabIndex = 1;
            this.lbl_CheckInventory_TableHeaders_DeviceType2.Text = "Device Type";
            this.lbl_CheckInventory_TableHeaders_DeviceType2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_CheckInventory_TableHeaders_LaptopSerialNumber_AvailableLaptops
            // 
            this.lbl_CheckInventory_TableHeaders_LaptopSerialNumber_AvailableLaptops.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_CheckInventory_TableHeaders_LaptopSerialNumber_AvailableLaptops.AutoSize = true;
            this.lbl_CheckInventory_TableHeaders_LaptopSerialNumber_AvailableLaptops.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CheckInventory_TableHeaders_LaptopSerialNumber_AvailableLaptops.Location = new System.Drawing.Point(4, 1);
            this.lbl_CheckInventory_TableHeaders_LaptopSerialNumber_AvailableLaptops.Name = "lbl_CheckInventory_TableHeaders_LaptopSerialNumber_AvailableLaptops";
            this.lbl_CheckInventory_TableHeaders_LaptopSerialNumber_AvailableLaptops.Size = new System.Drawing.Size(178, 399);
            this.lbl_CheckInventory_TableHeaders_LaptopSerialNumber_AvailableLaptops.TabIndex = 0;
            this.lbl_CheckInventory_TableHeaders_LaptopSerialNumber_AvailableLaptops.Text = "Laptop Serial Number";
            this.lbl_CheckInventory_TableHeaders_LaptopSerialNumber_AvailableLaptops.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_CheckInventory_TableHeaders_Processor2
            // 
            this.lbl_CheckInventory_TableHeaders_Processor2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_CheckInventory_TableHeaders_Processor2.AutoSize = true;
            this.lbl_CheckInventory_TableHeaders_Processor2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CheckInventory_TableHeaders_Processor2.Location = new System.Drawing.Point(305, 1);
            this.lbl_CheckInventory_TableHeaders_Processor2.Name = "lbl_CheckInventory_TableHeaders_Processor2";
            this.lbl_CheckInventory_TableHeaders_Processor2.Size = new System.Drawing.Size(109, 399);
            this.lbl_CheckInventory_TableHeaders_Processor2.TabIndex = 3;
            this.lbl_CheckInventory_TableHeaders_Processor2.Text = "Processor";
            this.lbl_CheckInventory_TableHeaders_Processor2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_CheckInventory_TableHeaders_RAM2
            // 
            this.lbl_CheckInventory_TableHeaders_RAM2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_CheckInventory_TableHeaders_RAM2.AutoSize = true;
            this.lbl_CheckInventory_TableHeaders_RAM2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CheckInventory_TableHeaders_RAM2.Location = new System.Drawing.Point(421, 1);
            this.lbl_CheckInventory_TableHeaders_RAM2.Name = "lbl_CheckInventory_TableHeaders_RAM2";
            this.lbl_CheckInventory_TableHeaders_RAM2.Size = new System.Drawing.Size(109, 399);
            this.lbl_CheckInventory_TableHeaders_RAM2.TabIndex = 2;
            this.lbl_CheckInventory_TableHeaders_RAM2.Text = "RAM";
            this.lbl_CheckInventory_TableHeaders_RAM2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_CheckInventory_TableHeaders_OSVersion2
            // 
            this.lbl_CheckInventory_TableHeaders_OSVersion2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_CheckInventory_TableHeaders_OSVersion2.AutoSize = true;
            this.lbl_CheckInventory_TableHeaders_OSVersion2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CheckInventory_TableHeaders_OSVersion2.Location = new System.Drawing.Point(537, 1);
            this.lbl_CheckInventory_TableHeaders_OSVersion2.Name = "lbl_CheckInventory_TableHeaders_OSVersion2";
            this.lbl_CheckInventory_TableHeaders_OSVersion2.Size = new System.Drawing.Size(112, 399);
            this.lbl_CheckInventory_TableHeaders_OSVersion2.TabIndex = 4;
            this.lbl_CheckInventory_TableHeaders_OSVersion2.Text = "Operating System";
            this.lbl_CheckInventory_TableHeaders_OSVersion2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tab_CheckInventory_RentedLaptops
            // 
            this.tab_CheckInventory_RentedLaptops.Controls.Add(this.tbl_CheckInventory_RentedLaptopsDisplayTable);
            this.tab_CheckInventory_RentedLaptops.Location = new System.Drawing.Point(4, 22);
            this.tab_CheckInventory_RentedLaptops.Name = "tab_CheckInventory_RentedLaptops";
            this.tab_CheckInventory_RentedLaptops.Size = new System.Drawing.Size(656, 402);
            this.tab_CheckInventory_RentedLaptops.TabIndex = 2;
            this.tab_CheckInventory_RentedLaptops.Text = "Rented Laptops";
            this.tab_CheckInventory_RentedLaptops.UseVisualStyleBackColor = true;
            // 
            // tbl_CheckInventory_RentedLaptopsDisplayTable
            // 
            this.tbl_CheckInventory_RentedLaptopsDisplayTable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tbl_CheckInventory_RentedLaptopsDisplayTable.ColumnCount = 4;
            this.tbl_CheckInventory_RentedLaptopsDisplayTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tbl_CheckInventory_RentedLaptopsDisplayTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tbl_CheckInventory_RentedLaptopsDisplayTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tbl_CheckInventory_RentedLaptopsDisplayTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tbl_CheckInventory_RentedLaptopsDisplayTable.Controls.Add(this.lbl_CheckInventory_TableHeaders_SendReminder, 3, 0);
            this.tbl_CheckInventory_RentedLaptopsDisplayTable.Controls.Add(this.lbl_CheckInventory_TableHeaders_LaptopUser, 2, 0);
            this.tbl_CheckInventory_RentedLaptopsDisplayTable.Controls.Add(this.lbl_CheckInventory_TableHeaders_RentalID, 1, 0);
            this.tbl_CheckInventory_RentedLaptopsDisplayTable.Controls.Add(this.lbl_CheckInventory_TableHeaders_LaptopSerialNumber_RentedLaptops, 0, 0);
            this.tbl_CheckInventory_RentedLaptopsDisplayTable.Location = new System.Drawing.Point(2, 2);
            this.tbl_CheckInventory_RentedLaptopsDisplayTable.Name = "tbl_CheckInventory_RentedLaptopsDisplayTable";
            this.tbl_CheckInventory_RentedLaptopsDisplayTable.RowCount = 1;
            this.tbl_CheckInventory_RentedLaptopsDisplayTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 400F));
            this.tbl_CheckInventory_RentedLaptopsDisplayTable.Size = new System.Drawing.Size(653, 399);
            this.tbl_CheckInventory_RentedLaptopsDisplayTable.TabIndex = 2;
            // 
            // lbl_CheckInventory_TableHeaders_SendReminder
            // 
            this.lbl_CheckInventory_TableHeaders_SendReminder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_CheckInventory_TableHeaders_SendReminder.AutoSize = true;
            this.lbl_CheckInventory_TableHeaders_SendReminder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CheckInventory_TableHeaders_SendReminder.Location = new System.Drawing.Point(460, 1);
            this.lbl_CheckInventory_TableHeaders_SendReminder.Name = "lbl_CheckInventory_TableHeaders_SendReminder";
            this.lbl_CheckInventory_TableHeaders_SendReminder.Size = new System.Drawing.Size(189, 400);
            this.lbl_CheckInventory_TableHeaders_SendReminder.TabIndex = 3;
            this.lbl_CheckInventory_TableHeaders_SendReminder.Text = "Notification";
            this.lbl_CheckInventory_TableHeaders_SendReminder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_CheckInventory_TableHeaders_LaptopUser
            // 
            this.lbl_CheckInventory_TableHeaders_LaptopUser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_CheckInventory_TableHeaders_LaptopUser.AutoSize = true;
            this.lbl_CheckInventory_TableHeaders_LaptopUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CheckInventory_TableHeaders_LaptopUser.Location = new System.Drawing.Point(266, 1);
            this.lbl_CheckInventory_TableHeaders_LaptopUser.Name = "lbl_CheckInventory_TableHeaders_LaptopUser";
            this.lbl_CheckInventory_TableHeaders_LaptopUser.Size = new System.Drawing.Size(187, 400);
            this.lbl_CheckInventory_TableHeaders_LaptopUser.TabIndex = 2;
            this.lbl_CheckInventory_TableHeaders_LaptopUser.Text = "Laptop Holder";
            this.lbl_CheckInventory_TableHeaders_LaptopUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_CheckInventory_TableHeaders_RentalID
            // 
            this.lbl_CheckInventory_TableHeaders_RentalID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_CheckInventory_TableHeaders_RentalID.AutoSize = true;
            this.lbl_CheckInventory_TableHeaders_RentalID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CheckInventory_TableHeaders_RentalID.Location = new System.Drawing.Point(198, 1);
            this.lbl_CheckInventory_TableHeaders_RentalID.Name = "lbl_CheckInventory_TableHeaders_RentalID";
            this.lbl_CheckInventory_TableHeaders_RentalID.Size = new System.Drawing.Size(61, 400);
            this.lbl_CheckInventory_TableHeaders_RentalID.TabIndex = 1;
            this.lbl_CheckInventory_TableHeaders_RentalID.Text = "Rental ID";
            this.lbl_CheckInventory_TableHeaders_RentalID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_CheckInventory_TableHeaders_LaptopSerialNumber_RentedLaptops
            // 
            this.lbl_CheckInventory_TableHeaders_LaptopSerialNumber_RentedLaptops.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_CheckInventory_TableHeaders_LaptopSerialNumber_RentedLaptops.AutoSize = true;
            this.lbl_CheckInventory_TableHeaders_LaptopSerialNumber_RentedLaptops.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CheckInventory_TableHeaders_LaptopSerialNumber_RentedLaptops.Location = new System.Drawing.Point(4, 1);
            this.lbl_CheckInventory_TableHeaders_LaptopSerialNumber_RentedLaptops.Name = "lbl_CheckInventory_TableHeaders_LaptopSerialNumber_RentedLaptops";
            this.lbl_CheckInventory_TableHeaders_LaptopSerialNumber_RentedLaptops.Size = new System.Drawing.Size(187, 400);
            this.lbl_CheckInventory_TableHeaders_LaptopSerialNumber_RentedLaptops.TabIndex = 0;
            this.lbl_CheckInventory_TableHeaders_LaptopSerialNumber_RentedLaptops.Text = "Laptop Serial Number";
            this.lbl_CheckInventory_TableHeaders_LaptopSerialNumber_RentedLaptops.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_CheckInventory_Back
            // 
            this.btn_CheckInventory_Back.BackColor = System.Drawing.Color.White;
            this.btn_CheckInventory_Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_CheckInventory_Back.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn_CheckInventory_Back.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btn_CheckInventory_Back.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_CheckInventory_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CheckInventory_Back.Location = new System.Drawing.Point(12, 12);
            this.btn_CheckInventory_Back.Name = "btn_CheckInventory_Back";
            this.btn_CheckInventory_Back.Size = new System.Drawing.Size(75, 29);
            this.btn_CheckInventory_Back.TabIndex = 5;
            this.btn_CheckInventory_Back.Text = "← Go Back";
            this.btn_CheckInventory_Back.UseVisualStyleBackColor = false;
            this.btn_CheckInventory_Back.Click += new System.EventHandler(this.btn_CheckInventory_Back_Click);
            // 
            // lbl_CheckInventory_Title
            // 
            this.lbl_CheckInventory_Title.AutoSize = true;
            this.lbl_CheckInventory_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CheckInventory_Title.Location = new System.Drawing.Point(292, 22);
            this.lbl_CheckInventory_Title.Name = "lbl_CheckInventory_Title";
            this.lbl_CheckInventory_Title.Size = new System.Drawing.Size(263, 39);
            this.lbl_CheckInventory_Title.TabIndex = 0;
            this.lbl_CheckInventory_Title.Text = "Check Inventory";
            // 
            // CheckOutLaptopPanel
            // 
            this.CheckOutLaptopPanel.Controls.Add(this.btn_CheckOut_UserLogin);
            this.CheckOutLaptopPanel.Controls.Add(this.lbl_CheckOut_UserFound);
            this.CheckOutLaptopPanel.Controls.Add(this.lbl_CheckOut_UserInformation);
            this.CheckOutLaptopPanel.Controls.Add(this.btn_CheckOut_RescanID);
            this.CheckOutLaptopPanel.Controls.Add(this.tbx_CheckOut_UserPassword);
            this.CheckOutLaptopPanel.Controls.Add(this.tbx_CheckOut_UserUniqueID);
            this.CheckOutLaptopPanel.Controls.Add(this.btn_CheckOut_Rescan);
            this.CheckOutLaptopPanel.Controls.Add(this.lbl_CheckOut_ReadyToScanNFC);
            this.CheckOutLaptopPanel.Controls.Add(this.btn_CheckOut_Back);
            this.CheckOutLaptopPanel.Controls.Add(this.btn_CheckOut_ProcessCheckOut);
            this.CheckOutLaptopPanel.Controls.Add(this.tbx_CheckOut_SerialNum);
            this.CheckOutLaptopPanel.Controls.Add(this.tbx_CheckOut_UserSerialNum);
            this.CheckOutLaptopPanel.Controls.Add(this.lblCheckOutTitle);
            this.CheckOutLaptopPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CheckOutLaptopPanel.Location = new System.Drawing.Point(0, 0);
            this.CheckOutLaptopPanel.Name = "CheckOutLaptopPanel";
            this.CheckOutLaptopPanel.Size = new System.Drawing.Size(841, 617);
            this.CheckOutLaptopPanel.TabIndex = 6;
            this.CheckOutLaptopPanel.Visible = false;
            // 
            // btn_CheckOut_UserLogin
            // 
            this.btn_CheckOut_UserLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CheckOut_UserLogin.Location = new System.Drawing.Point(149, 407);
            this.btn_CheckOut_UserLogin.Name = "btn_CheckOut_UserLogin";
            this.btn_CheckOut_UserLogin.Size = new System.Drawing.Size(75, 21);
            this.btn_CheckOut_UserLogin.TabIndex = 14;
            this.btn_CheckOut_UserLogin.Text = "Login";
            this.btn_CheckOut_UserLogin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_CheckOut_UserLogin.UseVisualStyleBackColor = true;
            this.btn_CheckOut_UserLogin.Click += new System.EventHandler(this.btn_CheckOut_UserLogin_Click);
            // 
            // lbl_CheckOut_UserFound
            // 
            this.lbl_CheckOut_UserFound.AutoSize = true;
            this.lbl_CheckOut_UserFound.ForeColor = System.Drawing.Color.Red;
            this.lbl_CheckOut_UserFound.Location = new System.Drawing.Point(283, 276);
            this.lbl_CheckOut_UserFound.Name = "lbl_CheckOut_UserFound";
            this.lbl_CheckOut_UserFound.Size = new System.Drawing.Size(124, 13);
            this.lbl_CheckOut_UserFound.TabIndex = 13;
            this.lbl_CheckOut_UserFound.Text = "User Found Successfully";
            this.lbl_CheckOut_UserFound.Visible = false;
            // 
            // lbl_CheckOut_UserInformation
            // 
            this.lbl_CheckOut_UserInformation.AutoSize = true;
            this.lbl_CheckOut_UserInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CheckOut_UserInformation.Location = new System.Drawing.Point(146, 330);
            this.lbl_CheckOut_UserInformation.Name = "lbl_CheckOut_UserInformation";
            this.lbl_CheckOut_UserInformation.Size = new System.Drawing.Size(123, 25);
            this.lbl_CheckOut_UserInformation.TabIndex = 12;
            this.lbl_CheckOut_UserInformation.Text = "User Lookup";
            // 
            // btn_CheckOut_RescanID
            // 
            this.btn_CheckOut_RescanID.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CheckOut_RescanID.Location = new System.Drawing.Point(533, 250);
            this.btn_CheckOut_RescanID.Name = "btn_CheckOut_RescanID";
            this.btn_CheckOut_RescanID.Size = new System.Drawing.Size(75, 20);
            this.btn_CheckOut_RescanID.TabIndex = 11;
            this.btn_CheckOut_RescanID.Text = "Rescan";
            this.btn_CheckOut_RescanID.UseVisualStyleBackColor = true;
            this.btn_CheckOut_RescanID.Click += new System.EventHandler(this.btn_CheckOut_RescanID_Click);
            // 
            // tbx_CheckOut_UserPassword
            // 
            this.tbx_CheckOut_UserPassword.Location = new System.Drawing.Point(435, 373);
            this.tbx_CheckOut_UserPassword.Name = "tbx_CheckOut_UserPassword";
            this.tbx_CheckOut_UserPassword.Size = new System.Drawing.Size(241, 20);
            this.tbx_CheckOut_UserPassword.TabIndex = 8;
            this.tbx_CheckOut_UserPassword.Text = "Enter Password";
            this.tbx_CheckOut_UserPassword.Enter += new System.EventHandler(this.tbx_CheckOut_LastName_Enter);
            this.tbx_CheckOut_UserPassword.Leave += new System.EventHandler(this.tbx_CheckOut_LastName_Leave);
            // 
            // tbx_CheckOut_UserUniqueID
            // 
            this.tbx_CheckOut_UserUniqueID.Location = new System.Drawing.Point(149, 373);
            this.tbx_CheckOut_UserUniqueID.Name = "tbx_CheckOut_UserUniqueID";
            this.tbx_CheckOut_UserUniqueID.Size = new System.Drawing.Size(241, 20);
            this.tbx_CheckOut_UserUniqueID.TabIndex = 7;
            this.tbx_CheckOut_UserUniqueID.Text = "Enter Unique ID";
            this.tbx_CheckOut_UserUniqueID.Enter += new System.EventHandler(this.tbx_CheckOut_FirstName_Enter);
            this.tbx_CheckOut_UserUniqueID.Leave += new System.EventHandler(this.tbx_CheckOut_FirstName_Leave);
            // 
            // btn_CheckOut_Rescan
            // 
            this.btn_CheckOut_Rescan.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CheckOut_Rescan.Location = new System.Drawing.Point(533, 146);
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
            this.lbl_CheckOut_ReadyToScanNFC.Location = new System.Drawing.Point(286, 173);
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
            this.btn_CheckOut_ProcessCheckOut.Click += new System.EventHandler(this.btn_CheckOut_ProcessCheckOut_Click);
            // 
            // tbx_CheckOut_SerialNum
            // 
            this.tbx_CheckOut_SerialNum.Location = new System.Drawing.Point(286, 146);
            this.tbx_CheckOut_SerialNum.Name = "tbx_CheckOut_SerialNum";
            this.tbx_CheckOut_SerialNum.Size = new System.Drawing.Size(241, 20);
            this.tbx_CheckOut_SerialNum.TabIndex = 2;
            this.tbx_CheckOut_SerialNum.Text = "Scan Laptop ID Tag";
            this.tbx_CheckOut_SerialNum.TextChanged += new System.EventHandler(this.tbx_CheckOut_SerialNum_TextChanged);
            this.tbx_CheckOut_SerialNum.Enter += new System.EventHandler(this.tbx_CheckOut_SerialNum_Enter);
            this.tbx_CheckOut_SerialNum.Leave += new System.EventHandler(this.tbx_CheckOut_SerialNum_Leave);
            // 
            // tbx_CheckOut_UserSerialNum
            // 
            this.tbx_CheckOut_UserSerialNum.Location = new System.Drawing.Point(286, 250);
            this.tbx_CheckOut_UserSerialNum.Name = "tbx_CheckOut_UserSerialNum";
            this.tbx_CheckOut_UserSerialNum.Size = new System.Drawing.Size(241, 20);
            this.tbx_CheckOut_UserSerialNum.TabIndex = 1;
            this.tbx_CheckOut_UserSerialNum.Text = "Scan Miami ID";
            this.tbx_CheckOut_UserSerialNum.TextChanged += new System.EventHandler(this.tbxCheckOut_UserSerialNum_TextChanged);
            this.tbx_CheckOut_UserSerialNum.Enter += new System.EventHandler(this.tbxCheckOut_UniqueID_Enter);
            this.tbx_CheckOut_UserSerialNum.Leave += new System.EventHandler(this.tbxCheckOut_UniqueID_Leave);
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
            this.AddLaptopPanel.Controls.Add(this.tbx_AddLaptop_SerialNum);
            this.AddLaptopPanel.Controls.Add(this.btn_AddLaptop_Rescan);
            this.AddLaptopPanel.Controls.Add(this.lbl_AddLaptop_ScanStatus);
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
            this.AddLaptopPanel.Controls.Add(this.tbx_AddLaptop_LaptopID);
            this.AddLaptopPanel.Controls.Add(this.btn_AddLaptop_Back);
            this.AddLaptopPanel.Controls.Add(this.lbl_AddLaptop_Title);
            this.AddLaptopPanel.Location = new System.Drawing.Point(0, 0);
            this.AddLaptopPanel.Name = "AddLaptopPanel";
            this.AddLaptopPanel.Size = new System.Drawing.Size(841, 617);
            this.AddLaptopPanel.TabIndex = 6;
            this.AddLaptopPanel.Visible = false;
            // 
            // tbx_AddLaptop_SerialNum
            // 
            this.tbx_AddLaptop_SerialNum.Location = new System.Drawing.Point(153, 212);
            this.tbx_AddLaptop_SerialNum.Name = "tbx_AddLaptop_SerialNum";
            this.tbx_AddLaptop_SerialNum.Size = new System.Drawing.Size(246, 20);
            this.tbx_AddLaptop_SerialNum.TabIndex = 6;
            this.tbx_AddLaptop_SerialNum.Text = "Laptop Serial Number";
            this.tbx_AddLaptop_SerialNum.Enter += new System.EventHandler(this.tbx_AddLaptop_SerialNum_Enter);
            this.tbx_AddLaptop_SerialNum.Leave += new System.EventHandler(this.tbx_AddLaptop_SerialNum_Leave);
            // 
            // btn_AddLaptop_Rescan
            // 
            this.btn_AddLaptop_Rescan.Location = new System.Drawing.Point(527, 99);
            this.btn_AddLaptop_Rescan.Name = "btn_AddLaptop_Rescan";
            this.btn_AddLaptop_Rescan.Size = new System.Drawing.Size(75, 20);
            this.btn_AddLaptop_Rescan.TabIndex = 21;
            this.btn_AddLaptop_Rescan.Text = "Rescan";
            this.btn_AddLaptop_Rescan.UseVisualStyleBackColor = true;
            this.btn_AddLaptop_Rescan.Click += new System.EventHandler(this.btn_AddLaptop_Rescan_Click);
            // 
            // lbl_AddLaptop_ScanStatus
            // 
            this.lbl_AddLaptop_ScanStatus.AutoSize = true;
            this.lbl_AddLaptop_ScanStatus.ForeColor = System.Drawing.Color.Red;
            this.lbl_AddLaptop_ScanStatus.Location = new System.Drawing.Point(320, 126);
            this.lbl_AddLaptop_ScanStatus.Name = "lbl_AddLaptop_ScanStatus";
            this.lbl_AddLaptop_ScanStatus.Size = new System.Drawing.Size(126, 13);
            this.lbl_AddLaptop_ScanStatus.TabIndex = 20;
            this.lbl_AddLaptop_ScanStatus.Text = "Ready to Scan NFC Chip";
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
            this.btn_AddLaptop_SubmitButton.TabIndex = 16;
            this.btn_AddLaptop_SubmitButton.Text = "Add Laptop";
            this.btn_AddLaptop_SubmitButton.UseVisualStyleBackColor = false;
            this.btn_AddLaptop_SubmitButton.Click += new System.EventHandler(this.btn_AddLaptop_SubmitButton_Click);
            // 
            // dtp_AddLaptop_DateAdded
            // 
            this.dtp_AddLaptop_DateAdded.Location = new System.Drawing.Point(439, 350);
            this.dtp_AddLaptop_DateAdded.Name = "dtp_AddLaptop_DateAdded";
            this.dtp_AddLaptop_DateAdded.Size = new System.Drawing.Size(246, 20);
            this.dtp_AddLaptop_DateAdded.TabIndex = 14;
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
            // lbl_AddLaptop_InServiceLabel
            // 
            this.lbl_AddLaptop_InServiceLabel.AutoSize = true;
            this.lbl_AddLaptop_InServiceLabel.Location = new System.Drawing.Point(-3, 9);
            this.lbl_AddLaptop_InServiceLabel.Name = "lbl_AddLaptop_InServiceLabel";
            this.lbl_AddLaptop_InServiceLabel.Size = new System.Drawing.Size(97, 13);
            this.lbl_AddLaptop_InServiceLabel.TabIndex = 2;
            this.lbl_AddLaptop_InServiceLabel.Text = "Laptop In Service?";
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
            // tbx_AddLaptop_Memory
            // 
            this.tbx_AddLaptop_Memory.Location = new System.Drawing.Point(439, 399);
            this.tbx_AddLaptop_Memory.Name = "tbx_AddLaptop_Memory";
            this.tbx_AddLaptop_Memory.Size = new System.Drawing.Size(246, 20);
            this.tbx_AddLaptop_Memory.TabIndex = 15;
            this.tbx_AddLaptop_Memory.Text = "Laptop Memory";
            this.tbx_AddLaptop_Memory.Enter += new System.EventHandler(this.tbx_AddLaptop_Memory_Enter);
            this.tbx_AddLaptop_Memory.Leave += new System.EventHandler(this.tbx_AddLaptop_Memory_Leave);
            // 
            // tbx_AddLaptop_OSVersion
            // 
            this.tbx_AddLaptop_OSVersion.Location = new System.Drawing.Point(439, 444);
            this.tbx_AddLaptop_OSVersion.Name = "tbx_AddLaptop_OSVersion";
            this.tbx_AddLaptop_OSVersion.Size = new System.Drawing.Size(246, 20);
            this.tbx_AddLaptop_OSVersion.TabIndex = 15;
            this.tbx_AddLaptop_OSVersion.Text = "Laptop OS Version";
            this.tbx_AddLaptop_OSVersion.Enter += new System.EventHandler(this.tbx_AddLaptop_OSVersion_Enter);
            this.tbx_AddLaptop_OSVersion.Leave += new System.EventHandler(this.tbx_AddLaptop_OSVersion_Leave);
            // 
            // tbx_AddLaptop_Size
            // 
            this.tbx_AddLaptop_Size.Location = new System.Drawing.Point(439, 257);
            this.tbx_AddLaptop_Size.Name = "tbx_AddLaptop_Size";
            this.tbx_AddLaptop_Size.Size = new System.Drawing.Size(246, 20);
            this.tbx_AddLaptop_Size.TabIndex = 12;
            this.tbx_AddLaptop_Size.Text = "Laptop Screen Size";
            this.tbx_AddLaptop_Size.Enter += new System.EventHandler(this.tbx_AddLaptop_Size_Enter);
            this.tbx_AddLaptop_Size.Leave += new System.EventHandler(this.tbx_AddLaptop_Size_Leave);
            // 
            // tbx_AddLaptop_Resolution
            // 
            this.tbx_AddLaptop_Resolution.Location = new System.Drawing.Point(439, 212);
            this.tbx_AddLaptop_Resolution.Name = "tbx_AddLaptop_Resolution";
            this.tbx_AddLaptop_Resolution.Size = new System.Drawing.Size(246, 20);
            this.tbx_AddLaptop_Resolution.TabIndex = 11;
            this.tbx_AddLaptop_Resolution.Text = "Laptop Resolution";
            this.tbx_AddLaptop_Resolution.Enter += new System.EventHandler(this.tbx_AddLaptop_Resolution_Enter);
            this.tbx_AddLaptop_Resolution.Leave += new System.EventHandler(this.tbx_AddLaptop_Resolution_Leave);
            // 
            // tbx_AddLaptop_RAM
            // 
            this.tbx_AddLaptop_RAM.Location = new System.Drawing.Point(153, 399);
            this.tbx_AddLaptop_RAM.Name = "tbx_AddLaptop_RAM";
            this.tbx_AddLaptop_RAM.Size = new System.Drawing.Size(246, 20);
            this.tbx_AddLaptop_RAM.TabIndex = 10;
            this.tbx_AddLaptop_RAM.Text = "Laptop RAM";
            this.tbx_AddLaptop_RAM.Enter += new System.EventHandler(this.tbx_AddLaptop_RAM_Enter);
            this.tbx_AddLaptop_RAM.Leave += new System.EventHandler(this.tbx_AddLaptop_RAM_Leave);
            // 
            // tbx_AddLaptop_Processor
            // 
            this.tbx_AddLaptop_Processor.Location = new System.Drawing.Point(153, 350);
            this.tbx_AddLaptop_Processor.Name = "tbx_AddLaptop_Processor";
            this.tbx_AddLaptop_Processor.Size = new System.Drawing.Size(246, 20);
            this.tbx_AddLaptop_Processor.TabIndex = 9;
            this.tbx_AddLaptop_Processor.Text = "Laptop Processor";
            this.tbx_AddLaptop_Processor.Enter += new System.EventHandler(this.tbx_AddLaptop_Processor_Enter);
            this.tbx_AddLaptop_Processor.Leave += new System.EventHandler(this.tbx_AddLaptop_Processor_Leave);
            // 
            // tbx_AddLaptop_Model
            // 
            this.tbx_AddLaptop_Model.Location = new System.Drawing.Point(153, 305);
            this.tbx_AddLaptop_Model.Name = "tbx_AddLaptop_Model";
            this.tbx_AddLaptop_Model.Size = new System.Drawing.Size(246, 20);
            this.tbx_AddLaptop_Model.TabIndex = 8;
            this.tbx_AddLaptop_Model.Text = "Laptop Model";
            this.tbx_AddLaptop_Model.Enter += new System.EventHandler(this.tbx_AddLaptop_Model_Enter);
            this.tbx_AddLaptop_Model.Leave += new System.EventHandler(this.tbx_AddLaptop_Model_Leave);
            // 
            // tbx_AddLaptop_Brand
            // 
            this.tbx_AddLaptop_Brand.Location = new System.Drawing.Point(153, 257);
            this.tbx_AddLaptop_Brand.Name = "tbx_AddLaptop_Brand";
            this.tbx_AddLaptop_Brand.Size = new System.Drawing.Size(246, 20);
            this.tbx_AddLaptop_Brand.TabIndex = 7;
            this.tbx_AddLaptop_Brand.Text = "Laptop Brand";
            this.tbx_AddLaptop_Brand.Enter += new System.EventHandler(this.tbx_AddLaptop_Brand_Enter);
            this.tbx_AddLaptop_Brand.Leave += new System.EventHandler(this.tbx_AddLaptop_Brand_Leave);
            // 
            // tbx_AddLaptop_Condition
            // 
            this.tbx_AddLaptop_Condition.Location = new System.Drawing.Point(439, 305);
            this.tbx_AddLaptop_Condition.Name = "tbx_AddLaptop_Condition";
            this.tbx_AddLaptop_Condition.Size = new System.Drawing.Size(246, 20);
            this.tbx_AddLaptop_Condition.TabIndex = 13;
            this.tbx_AddLaptop_Condition.Text = "Laptop Condition";
            this.tbx_AddLaptop_Condition.Enter += new System.EventHandler(this.tbx_AddLaptop_Condition_Enter);
            this.tbx_AddLaptop_Condition.Leave += new System.EventHandler(this.tbx_AddLaptop_Condition_Leave);
            // 
            // tbx_AddLaptop_LaptopID
            // 
            this.tbx_AddLaptop_LaptopID.Location = new System.Drawing.Point(320, 99);
            this.tbx_AddLaptop_LaptopID.Name = "tbx_AddLaptop_LaptopID";
            this.tbx_AddLaptop_LaptopID.Size = new System.Drawing.Size(201, 20);
            this.tbx_AddLaptop_LaptopID.TabIndex = 5;
            this.tbx_AddLaptop_LaptopID.Text = "Scan Laptop ID";
            this.tbx_AddLaptop_LaptopID.TextChanged += new System.EventHandler(this.tbx_AddLaptop_LaptopID_TextChanged);
            this.tbx_AddLaptop_LaptopID.Enter += new System.EventHandler(this.tbx_AddLaptop_LaptopID_Enter);
            this.tbx_AddLaptop_LaptopID.Leave += new System.EventHandler(this.tbx_AddLaptop_LaptopID_Leave);
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
            // ReturnLaptopPanel
            // 
            this.ReturnLaptopPanel.Controls.Add(this.lbl_Return_ScanStatus);
            this.ReturnLaptopPanel.Controls.Add(this.btn_Return_Rescan);
            this.ReturnLaptopPanel.Controls.Add(this.pnl_ReturnLaptop_RentalInfoDisplayPanel);
            this.ReturnLaptopPanel.Controls.Add(this.tbx_Return_LaptopID);
            this.ReturnLaptopPanel.Controls.Add(this.btn_Return_ProcessReturn);
            this.ReturnLaptopPanel.Controls.Add(this.btn_Return_Back);
            this.ReturnLaptopPanel.Controls.Add(this.lbl_Return_Title);
            this.ReturnLaptopPanel.Location = new System.Drawing.Point(0, 0);
            this.ReturnLaptopPanel.Name = "ReturnLaptopPanel";
            this.ReturnLaptopPanel.Size = new System.Drawing.Size(841, 617);
            this.ReturnLaptopPanel.TabIndex = 6;
            this.ReturnLaptopPanel.Visible = false;
            // 
            // lbl_Return_ScanStatus
            // 
            this.lbl_Return_ScanStatus.AutoSize = true;
            this.lbl_Return_ScanStatus.ForeColor = System.Drawing.Color.Red;
            this.lbl_Return_ScanStatus.Location = new System.Drawing.Point(301, 130);
            this.lbl_Return_ScanStatus.Name = "lbl_Return_ScanStatus";
            this.lbl_Return_ScanStatus.Size = new System.Drawing.Size(124, 13);
            this.lbl_Return_ScanStatus.TabIndex = 12;
            this.lbl_Return_ScanStatus.Text = "Ready to Scan NFC Tag";
            this.lbl_Return_ScanStatus.Visible = false;
            // 
            // btn_Return_Rescan
            // 
            this.btn_Return_Rescan.Location = new System.Drawing.Point(549, 103);
            this.btn_Return_Rescan.Name = "btn_Return_Rescan";
            this.btn_Return_Rescan.Size = new System.Drawing.Size(75, 19);
            this.btn_Return_Rescan.TabIndex = 11;
            this.btn_Return_Rescan.Text = "Rescan";
            this.btn_Return_Rescan.UseVisualStyleBackColor = true;
            this.btn_Return_Rescan.Visible = false;
            this.btn_Return_Rescan.Click += new System.EventHandler(this.btn_Return_Rescan_Click);
            // 
            // pnl_ReturnLaptop_RentalInfoDisplayPanel
            // 
            this.pnl_ReturnLaptop_RentalInfoDisplayPanel.Controls.Add(this.lbl_Return_OverdueText);
            this.pnl_ReturnLaptop_RentalInfoDisplayPanel.Controls.Add(this.lbl_Return_RentalIDText);
            this.pnl_ReturnLaptop_RentalInfoDisplayPanel.Controls.Add(this.lbl_Return_CheckoutText);
            this.pnl_ReturnLaptop_RentalInfoDisplayPanel.Controls.Add(this.lbl_Return_Overdue);
            this.pnl_ReturnLaptop_RentalInfoDisplayPanel.Controls.Add(this.lbl_Return_RentalID);
            this.pnl_ReturnLaptop_RentalInfoDisplayPanel.Controls.Add(this.lbl_Return_Checkout);
            this.pnl_ReturnLaptop_RentalInfoDisplayPanel.Controls.Add(this.lbl_Return_UserText);
            this.pnl_ReturnLaptop_RentalInfoDisplayPanel.Controls.Add(this.lbl_Rental_User);
            this.pnl_ReturnLaptop_RentalInfoDisplayPanel.Controls.Add(this.lbl_RentalInfoTitle);
            this.pnl_ReturnLaptop_RentalInfoDisplayPanel.Location = new System.Drawing.Point(304, 209);
            this.pnl_ReturnLaptop_RentalInfoDisplayPanel.Name = "pnl_ReturnLaptop_RentalInfoDisplayPanel";
            this.pnl_ReturnLaptop_RentalInfoDisplayPanel.Size = new System.Drawing.Size(237, 244);
            this.pnl_ReturnLaptop_RentalInfoDisplayPanel.TabIndex = 10;
            // 
            // lbl_Return_OverdueText
            // 
            this.lbl_Return_OverdueText.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_Return_OverdueText.Location = new System.Drawing.Point(88, 148);
            this.lbl_Return_OverdueText.Name = "lbl_Return_OverdueText";
            this.lbl_Return_OverdueText.Size = new System.Drawing.Size(149, 13);
            this.lbl_Return_OverdueText.TabIndex = 16;
            this.lbl_Return_OverdueText.Text = "[overdue]";
            this.lbl_Return_OverdueText.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbl_Return_RentalIDText
            // 
            this.lbl_Return_RentalIDText.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_Return_RentalIDText.Location = new System.Drawing.Point(88, 115);
            this.lbl_Return_RentalIDText.Name = "lbl_Return_RentalIDText";
            this.lbl_Return_RentalIDText.Size = new System.Drawing.Size(149, 13);
            this.lbl_Return_RentalIDText.TabIndex = 15;
            this.lbl_Return_RentalIDText.Text = "[return date]";
            this.lbl_Return_RentalIDText.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbl_Return_CheckoutText
            // 
            this.lbl_Return_CheckoutText.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_Return_CheckoutText.Location = new System.Drawing.Point(88, 79);
            this.lbl_Return_CheckoutText.Name = "lbl_Return_CheckoutText";
            this.lbl_Return_CheckoutText.Size = new System.Drawing.Size(149, 13);
            this.lbl_Return_CheckoutText.TabIndex = 14;
            this.lbl_Return_CheckoutText.Text = "[checkout]";
            this.lbl_Return_CheckoutText.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbl_Return_Overdue
            // 
            this.lbl_Return_Overdue.AutoSize = true;
            this.lbl_Return_Overdue.Location = new System.Drawing.Point(-3, 148);
            this.lbl_Return_Overdue.Name = "lbl_Return_Overdue";
            this.lbl_Return_Overdue.Size = new System.Drawing.Size(65, 13);
            this.lbl_Return_Overdue.TabIndex = 13;
            this.lbl_Return_Overdue.Text = "Is Overdue?";
            // 
            // lbl_Return_RentalID
            // 
            this.lbl_Return_RentalID.AutoSize = true;
            this.lbl_Return_RentalID.Location = new System.Drawing.Point(-3, 115);
            this.lbl_Return_RentalID.Name = "lbl_Return_RentalID";
            this.lbl_Return_RentalID.Size = new System.Drawing.Size(55, 13);
            this.lbl_Return_RentalID.TabIndex = 12;
            this.lbl_Return_RentalID.Text = "Rental ID:";
            // 
            // lbl_Return_Checkout
            // 
            this.lbl_Return_Checkout.AutoSize = true;
            this.lbl_Return_Checkout.Location = new System.Drawing.Point(-3, 79);
            this.lbl_Return_Checkout.Name = "lbl_Return_Checkout";
            this.lbl_Return_Checkout.Size = new System.Drawing.Size(82, 13);
            this.lbl_Return_Checkout.TabIndex = 11;
            this.lbl_Return_Checkout.Text = "Checkout Date:";
            // 
            // lbl_Return_UserText
            // 
            this.lbl_Return_UserText.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_Return_UserText.Location = new System.Drawing.Point(88, 46);
            this.lbl_Return_UserText.Name = "lbl_Return_UserText";
            this.lbl_Return_UserText.Size = new System.Drawing.Size(149, 13);
            this.lbl_Return_UserText.TabIndex = 10;
            this.lbl_Return_UserText.Text = "[Users name here]";
            this.lbl_Return_UserText.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbl_Rental_User
            // 
            this.lbl_Rental_User.AutoSize = true;
            this.lbl_Rental_User.Location = new System.Drawing.Point(-3, 46);
            this.lbl_Rental_User.Name = "lbl_Rental_User";
            this.lbl_Rental_User.Size = new System.Drawing.Size(68, 13);
            this.lbl_Rental_User.TabIndex = 9;
            this.lbl_Rental_User.Text = "Laptop User:";
            // 
            // lbl_RentalInfoTitle
            // 
            this.lbl_RentalInfoTitle.AutoSize = true;
            this.lbl_RentalInfoTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RentalInfoTitle.Location = new System.Drawing.Point(65, 0);
            this.lbl_RentalInfoTitle.Name = "lbl_RentalInfoTitle";
            this.lbl_RentalInfoTitle.Size = new System.Drawing.Size(104, 25);
            this.lbl_RentalInfoTitle.TabIndex = 8;
            this.lbl_RentalInfoTitle.Text = "Rental Info";
            // 
            // tbx_Return_LaptopID
            // 
            this.tbx_Return_LaptopID.Location = new System.Drawing.Point(301, 103);
            this.tbx_Return_LaptopID.Name = "tbx_Return_LaptopID";
            this.tbx_Return_LaptopID.Size = new System.Drawing.Size(241, 20);
            this.tbx_Return_LaptopID.TabIndex = 7;
            this.tbx_Return_LaptopID.Text = "Scan Laptop ID Tag";
            this.tbx_Return_LaptopID.TextChanged += new System.EventHandler(this.tbx_Return_LaptopID_TextChanged);
            this.tbx_Return_LaptopID.Enter += new System.EventHandler(this.tbx_Return_LaptopID_Enter);
            this.tbx_Return_LaptopID.Leave += new System.EventHandler(this.tbx_Return_LaptopID_Leave);
            // 
            // btn_Return_ProcessReturn
            // 
            this.btn_Return_ProcessReturn.BackColor = System.Drawing.Color.White;
            this.btn_Return_ProcessReturn.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn_Return_ProcessReturn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btn_Return_ProcessReturn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Return_ProcessReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Return_ProcessReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Return_ProcessReturn.Location = new System.Drawing.Point(301, 524);
            this.btn_Return_ProcessReturn.Name = "btn_Return_ProcessReturn";
            this.btn_Return_ProcessReturn.Size = new System.Drawing.Size(241, 55);
            this.btn_Return_ProcessReturn.TabIndex = 6;
            this.btn_Return_ProcessReturn.Text = "Return Laptop";
            this.btn_Return_ProcessReturn.UseVisualStyleBackColor = false;
            this.btn_Return_ProcessReturn.Click += new System.EventHandler(this.btn_Return_ProcessReturn_Click);
            // 
            // btn_Return_Back
            // 
            this.btn_Return_Back.BackColor = System.Drawing.Color.White;
            this.btn_Return_Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Return_Back.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn_Return_Back.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btn_Return_Back.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Return_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Return_Back.Location = new System.Drawing.Point(12, 12);
            this.btn_Return_Back.Name = "btn_Return_Back";
            this.btn_Return_Back.Size = new System.Drawing.Size(75, 29);
            this.btn_Return_Back.TabIndex = 5;
            this.btn_Return_Back.Text = "← Go Back";
            this.btn_Return_Back.UseVisualStyleBackColor = false;
            this.btn_Return_Back.Click += new System.EventHandler(this.btn_Return_Back_Click);
            // 
            // lbl_Return_Title
            // 
            this.lbl_Return_Title.AutoSize = true;
            this.lbl_Return_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Return_Title.Location = new System.Drawing.Point(308, 23);
            this.lbl_Return_Title.Name = "lbl_Return_Title";
            this.lbl_Return_Title.Size = new System.Drawing.Size(232, 39);
            this.lbl_Return_Title.TabIndex = 0;
            this.lbl_Return_Title.Text = "Return Laptop";
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(841, 617);
            this.Controls.Add(this.CheckOutLaptopPanel);
            this.Controls.Add(this.AddLaptopPanel);
            this.Controls.Add(this.ReturnLaptopPanel);
            this.Controls.Add(this.CheckInventoryPanel);
            this.Controls.Add(this.HomePagePanel);
            this.Name = "HomePage";
            this.Text = "FSB NFC Laptop Rental";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.HomePagePanel.ResumeLayout(false);
            this.CheckInventoryPanel.ResumeLayout(false);
            this.CheckInventoryPanel.PerformLayout();
            this.tab_CheckInventory_TabControl.ResumeLayout(false);
            this.tab_CheckInventory_AllLaptops.ResumeLayout(false);
            this.tbl_CheckInventory_AllLaptopsDisplayTable.ResumeLayout(false);
            this.tbl_CheckInventory_AllLaptopsDisplayTable.PerformLayout();
            this.tab_CheckInventory_AvailableLaptops.ResumeLayout(false);
            this.tbl_CheckInventory_AvailableLaptopDisplayTable.ResumeLayout(false);
            this.tbl_CheckInventory_AvailableLaptopDisplayTable.PerformLayout();
            this.tab_CheckInventory_RentedLaptops.ResumeLayout(false);
            this.tbl_CheckInventory_RentedLaptopsDisplayTable.ResumeLayout(false);
            this.tbl_CheckInventory_RentedLaptopsDisplayTable.PerformLayout();
            this.CheckOutLaptopPanel.ResumeLayout(false);
            this.CheckOutLaptopPanel.PerformLayout();
            this.AddLaptopPanel.ResumeLayout(false);
            this.AddLaptopPanel.PerformLayout();
            this.pnl_AddLaptop_InServicePanel.ResumeLayout(false);
            this.pnl_AddLaptop_InServicePanel.PerformLayout();
            this.ReturnLaptopPanel.ResumeLayout(false);
            this.ReturnLaptopPanel.PerformLayout();
            this.pnl_ReturnLaptop_RentalInfoDisplayPanel.ResumeLayout(false);
            this.pnl_ReturnLaptop_RentalInfoDisplayPanel.PerformLayout();
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
        private System.Windows.Forms.TextBox tbx_CheckOut_UserSerialNum;
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
        private System.Windows.Forms.TextBox tbx_AddLaptop_LaptopID;
        private System.Windows.Forms.Button btn_AddLaptop_Rescan;
        private System.Windows.Forms.Label lbl_AddLaptop_ScanStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_AddLaptop_SubmitButton;
        private System.Windows.Forms.TextBox tbx_AddLaptop_SerialNum;
        private System.Windows.Forms.Label lbl_CheckOut_UserInformation;
        private System.Windows.Forms.Button btn_CheckOut_RescanID;
        private System.Windows.Forms.TextBox tbx_CheckOut_UserPassword;
        private System.Windows.Forms.TextBox tbx_CheckOut_UserUniqueID;
        private System.Windows.Forms.Label lbl_CheckOut_UserFound;
        private System.Windows.Forms.Panel ReturnLaptopPanel;
        private System.Windows.Forms.Label lbl_Return_Title;
        private System.Windows.Forms.Button btn_Return_ProcessReturn;
        private System.Windows.Forms.Button btn_Return_Back;
        private System.Windows.Forms.Panel pnl_ReturnLaptop_RentalInfoDisplayPanel;
        private System.Windows.Forms.Label lbl_Return_OverdueText;
        private System.Windows.Forms.Label lbl_Return_RentalIDText;
        private System.Windows.Forms.Label lbl_Return_CheckoutText;
        private System.Windows.Forms.Label lbl_Return_Overdue;
        private System.Windows.Forms.Label lbl_Return_RentalID;
        private System.Windows.Forms.Label lbl_Return_Checkout;
        private System.Windows.Forms.Label lbl_Return_UserText;
        private System.Windows.Forms.Label lbl_Rental_User;
        private System.Windows.Forms.Label lbl_RentalInfoTitle;
        private System.Windows.Forms.TextBox tbx_Return_LaptopID;
        private System.Windows.Forms.Label lbl_Return_ScanStatus;
        private System.Windows.Forms.Button btn_Return_Rescan;
        private System.Windows.Forms.Button btn_CheckOut_UserLogin;
        private System.Windows.Forms.Panel CheckInventoryPanel;
        private System.Windows.Forms.Label lbl_CheckInventory_Title;
        private System.Windows.Forms.Button btn_CheckInventory_Back;
        private System.Windows.Forms.Button btn_CheckOut_RefeshData;
        private System.Windows.Forms.TabControl tab_CheckInventory_TabControl;
        private System.Windows.Forms.TabPage tab_CheckInventory_AvailableLaptops;
        private System.Windows.Forms.TabPage tab_CheckInventory_AllLaptops;
        private System.Windows.Forms.TableLayoutPanel tbl_CheckInventory_AllLaptopsDisplayTable;
        private System.Windows.Forms.Label lbl_CheckInventory_TableHeaders_LaptopSerialNum;
        private System.Windows.Forms.Label lbl_CheckInventory_TableHeaders_OS;
        private System.Windows.Forms.Label lbl_CheckInventory_TableHeaders_RAM;
        private System.Windows.Forms.Label lbl_CheckInventory_TableHeaders_Processor;
        private System.Windows.Forms.TabPage tab_CheckInventory_RentedLaptops;
        private System.Windows.Forms.TableLayoutPanel tbl_CheckInventory_RentedLaptopsDisplayTable;
        private System.Windows.Forms.Label lbl_CheckInventory_TableHeaders_SendReminder;
        private System.Windows.Forms.Label lbl_CheckInventory_TableHeaders_LaptopUser;
        private System.Windows.Forms.Label lbl_CheckInventory_TableHeaders_RentalID;
        private System.Windows.Forms.Label lbl_CheckInventory_TableHeaders_LaptopSerialNumber_RentedLaptops;
        private System.Windows.Forms.Label lbl_CheckInventory_TableHeaders_DeviceType;
        private System.Windows.Forms.TableLayoutPanel tbl_CheckInventory_AvailableLaptopDisplayTable;
        private System.Windows.Forms.Label lbl_CheckInventory_TableHeaders_DeviceType2;
        private System.Windows.Forms.Label lbl_CheckInventory_TableHeaders_LaptopSerialNumber_AvailableLaptops;
        private System.Windows.Forms.Label lbl_CheckInventory_TableHeaders_Processor2;
        private System.Windows.Forms.Label lbl_CheckInventory_TableHeaders_RAM2;
        private System.Windows.Forms.Label lbl_CheckInventory_TableHeaders_OSVersion2;
        private System.Windows.Forms.Label lbl_CheckInventory_AvailableLaptopCount;
        private System.Windows.Forms.Label lbl_CheckInventory_AvailalbeLaptopsTitle;
    }
}

