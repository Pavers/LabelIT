# Instructions on how to run the application

- This application is a Windows Forms Application, with the target framework being .NET 3.5. Your environment should be configured to be able to run this type of application.

- Create the folder C:\helpers and copy the Microsoft.Sqlhelper.dll into this folder
- Open the solution file in bin\LabelIt.sln
- Build the solution using Visual Studio
- Click save on the setup screen without changing any of the details
- Build the solution again
- Once the form opens, click the Labels menu > Print Labels
- In the barcode field, enter 00001234 and click Search/press enter
- Data should load underneath the barcode box
- Click the Add button
- Click the Print button - normally at this stage, the data will be sent to printer
- Click Ok to close the dialog
- In the barcode field, enter P216 and click Search/press enter
- A lookup product dialog should open. Double click in the dark blue column to select a specific colour/size
- Click the Add button
- The data should load beneath the first item
- You can repeat this process and add as many items as you wish
