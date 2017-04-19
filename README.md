# NFC-Project

## Set Up Instructions

There are two steps to setting up our application.
  1. Set up the NFC reader and driver
  2. Set up the laptop inventory management system

### Setting up NFC Reader

To set up the NFC reader you must download the NFC reader software that comes with the reader and then set this software to specifically add input to the system in the correct manner.

Steps:

  1. Plug in the NFC GoToTags reader into USB port
  2. Download and install the [GoToTags Windows App](https://gototags.com/windows-app/#toggle-id-1)
  3. Run the GoToTags application
      1. This application must run in the background at all times to read the NFC tags
  4. In the GoToTags appliction click on **Integration**
  5. Select **Auto Paste**
  6. Click the **UID** Option
  7. When a tag is scanned the application will now auto paste the tag's UID into the currently selected textbox
  
### Setting up the Inventory Management App
  
Steps:

  1. Open soultion from github
  2. Install service references that are missing from your device
  3. Add your connection string and username/password to the DBManager.cs
     1. Connection string is located in the variable ConnString
     2. Username and passwords are located in the variables UserName, Password
  4. Run the SQL code to initalize tables in your selected database
     1. Can be found in our Group Folder
  5. Set up email service
     1. In HomePage.cs there is a method called Email_Click()
     2. Change variables in Email_Click() to match your selected email service
     3. All variables to be changed are located at the begining of the method
  6. Run application
  7. Add laptops to the system
  8. Application is now ready for use!
     
     
  

