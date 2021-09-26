# WebApplication10
Write a .NET core web application which populates a table in a database with the numbers 1 to 100 but substitutes some numbers as per the rules below:
•	Where any number is a multiple of 3, replace the number with the word "Fizz". 
•	Where any number is a multiple of 5, replace the number with the word "Buzz". 
•	For numbers which are multiples of both 3 and 5, replace with the word "FizzBuzz". 
The database table should be created on start-up if it does not already exist. The contents of the database table should be output to a webpage, using a UI framework and data access method of your own choice.
 
The application should contain suitable unit tests and you are welcome to add any extra features or functionality that you think would be appropriate or useful.
 
Please deliver your solution by sharing a link to a git repo and include instructions for how you might deploy your app to an Azure virtual machine.


Deploying asp.net web application from visual studio to azure

In the Solution Explorer, right click on the web application project and click on Publish 

Select Azure and click Next

Select Azure App Service and click Next

Click on the + sign

•	Provide a Name for the App Service. This is the name that will be used to access the web application. Quotes is the name I used, so to access the application I use the following URL in the browser.
•	Select your Subscription and Resource Group.
•	Finally hosting plan. We want to use a free hosting plan. Click on the New link.
•	Provide a name, location and the size for the Hosting Plan. It is the size that determines what you pay and what features you get. I selected the Free pricing tier.
•	create the (App Service and App Service Plan) from within visual studio instead of going through the azure portal.
•	Click OK and the Finish. 
You will then be back on the following Publish screen. In the dropdownlist, your App Service is selected. Click on the Publish button.
In a few minutes your app will deployed to azure and you can access it using the URL.
Now you can open the azure portal and  click the Home>resource group
1.	You can see your resource group under that you can see the app service and service plan
2.	Navigate the service plan and click on the apps you can see the Quotes app deployed in the azure portal
Deploy web application with SQL database 

 Go to the Publish page in Visual Studio. To do this, right click on the web application project in Visual Studio and select Publish from the context menu.
Under Service Dependencies, click the Add button to add SQL Server dependency.
Select Azure SQL Database and click Next
Select your azure subscription from the Subscription dropdownlist and then click on the + sign to create a new SQL Database in Azure.
Before we can create a database, we need to create a database server. So, click on the New link, next to Database server dropdownlist.

Fill the following details and click OK
1.	Database server name
2.	Location (Azure Region) where you want the server to be created
3.	Administrator username and password

You will be back on Azure SQL Database window. Click Create. This creates both - Database server and the database itself.
Both the database server and the database are now created in azure. Click Next.
Specify the Database connection string, user name and password. This connection will be used by the web application to connect to the sql server database in azure. Click Next.
The connection string will be stored in Azure App Settings.
Finally click Finish and then Close.
Create the database objects and seed data
The final step is to create the database tables and populate them with initial data for the app. Again, there are 2 ways to do this. Either you can use SQL Server Management Studio on your local machine or the built-in Query Editor in azure portal.
Configure azure sql server to allow remote connections
1.	Navigate to your SQL Server instance in Azure.
2.	Click on Firewalls and virtual networks under Security section.
3.	Your device IP address will be displayed.  The device I am using to connect to azure sql server starts with 192.129.
4.	Click Add client IP link at the top and Save.
With this firewall rule in place, you should be able to connect to azure sql server using SQL Server Management studio from you local machine. Now add the queries. Your web application with sql server are deployed to Azure and you should be able to access your application.




