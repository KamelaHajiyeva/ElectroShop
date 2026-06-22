PROJECT NAME: ElectroShop
TECHNOLOGY: ASP.NET Core MVC

---

PROJECT DESCRIPTION:
ElectroShop is a web-based e-commerce application developed using ASP.NET Core MVC.
The system allows users to browse products, view categories, and interact with the platform.

---

FEATURES:

* Product listing
* Category-based filtering
* Product images display
* User authentication (Login / Register)
* Cart system
* Order management
* Admin and client roles
* Database integration with SQL Server

---

REQUIREMENTS:

* Visual Studio 2022 or later
* SQL Server (Express or Full)

---

INSTALLATION & RUNNING INSTRUCTIONS:

1. Open the project in Visual Studio

2. Go to SQL Server Management Studio (SSMS)

3. Open the file: ElectroShopDb.sql

4. Execute the script to create and seed the database

5. Open appsettings.json and check connection string:

   Server=.;Database=ElectroShopDb;Trusted_Connection=True;

6. Run the project (F5)

---

IMPORTANT NOTES:

* Images are stored in the folder:
  wwwroot/images

* If images do not appear, check the image path in the database.

* Make sure static files are enabled in Program.cs:
  app.UseStaticFiles();

---

AUTHOR:
[Your Name]

---
