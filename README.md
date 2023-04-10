1. Setting up work environment
 - .NET 6 SDK
 - Visual Studio 2022 (can use community version)
 - Microsoft SQL Server (Version 13.0.4001.0 was used)
 - Sql Server Management Studio (v18.7.1 was used)
 
2. Initialisation
 - Run the script  car-sales-app/Initialisation/database_initialisation_script.sql
 - In car-sales-app/CarSales/CarSales.UI/Program.cs, modify the connection string

3. Running the app
 - Open the car-sales-app/CarSales/CarSales.sln in VS 2022
 - Set the project CarSales.UI as the startup project
 - Run the app
 - Once the app start, a login window is shown
 - Two credentials are available: 
	username: Tabrez
	password: employee1
	
	username: sadio
	password: employee2
	
 - Other employees can also be registered

4. Additional notes
 - The folders CarSales and Car images should be in the same directory
 - When using the app and inserting new images, do not use large sized image files
 

 