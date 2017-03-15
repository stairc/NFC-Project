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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(173, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(521, 235);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Location = new System.Drawing.Point(297, 237);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(262, 74);
            this.btnCheckOut.TabIndex = 2;
            this.btnCheckOut.Text = "Check Out Laptop";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.Location = new System.Drawing.Point(297, 330);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(262, 74);
            this.btnCheckIn.TabIndex = 3;
            this.btnCheckIn.Text = "Return Laptop";
            this.btnCheckIn.UseVisualStyleBackColor = true;
            // 
            // btnAddLaptop
            // 
            this.btnAddLaptop.Location = new System.Drawing.Point(297, 421);
            this.btnAddLaptop.Name = "btnAddLaptop";
            this.btnAddLaptop.Size = new System.Drawing.Size(262, 74);
            this.btnAddLaptop.TabIndex = 4;
            this.btnAddLaptop.Text = "Add Laptop To System";
            this.btnAddLaptop.UseVisualStyleBackColor = true;
            // 
            // btnInventory
            // 
            this.btnInventory.Location = new System.Drawing.Point(297, 513);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(262, 74);
            this.btnInventory.TabIndex = 5;
            this.btnInventory.Text = "Check Inventory";
            this.btnInventory.UseVisualStyleBackColor = true;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(841, 617);
            this.Controls.Add(this.btnInventory);
            this.Controls.Add(this.btnAddLaptop);
            this.Controls.Add(this.btnCheckIn);
            this.Controls.Add(this.btnCheckOut);
            this.Controls.Add(this.pictureBox1);
            this.Name = "HomePage";
            this.Text = "FSB NFC Laptop Rental";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.Button btnCheckIn;
        private System.Windows.Forms.Button btnAddLaptop;
        private System.Windows.Forms.Button btnInventory;
    }
}

