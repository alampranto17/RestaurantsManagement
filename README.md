Restaurant Management Desktop Application (C#)
📜 Overview
This desktop-based application is designed to manage restaurant operations efficiently. Built with C# and Windows Forms, the system supports order management, sales tracking, waiter attendance, and cash-only payment processing. Admin and manager roles are implemented for effective access control and restaurant management.

🚀 Key Features
Admin/Owner Role: Full control of restaurant management functions.
Manager Role: Limited access for handling daily operations and reports.
Order Management: Seamlessly add and manage customer orders.
Sales Tracking: Track daily sales with relevant information for analysis.
Waiter Attendance Management: Record and manage attendance of wait staff.
Expense Tracking: Maintain records of restaurant expenses.
Menu Management: Add, edit, and manage food items in the menu.
Cash Payment Only: Simplified cash-only payment process.
PDF Invoice Generation: Generate detailed invoices in PDF format.
User-Friendly Dashboards: Separate dashboards for Admin and Manager roles.
🛠️ Technology Stack
Programming Language: C# (.NET Framework)
UI Framework: Windows Forms
Database: SQL Server / SQLite
📦 Project Structure
DataAccess.cs: Manages database queries and CRUD operations.
FormAdminDashboard.cs: Admin dashboard interface for full control.
FormManagerDashboard.cs: Manager dashboard for daily operations.
FormSales.cs: Sales management form.
FormAddUser.cs & FormEditUser.cs: User management forms.
FormAttendance.cs: Waiter attendance management.
FormInvoices.cs: Generates PDF invoices.
FormLogin.cs: Handles user authentication.
⚙️ Installation Guide
Prerequisites:
Visual Studio (2019 or later)
SQL Server or SQLite
.NET Framework
Steps to Set Up:
Clone the Repository:

bash
Copy
Edit
git clone <your-repo-url>
cd <your-repo-folder>
Open the Project:
Open the .sln file in Visual Studio.

Configure the Database:
Update the connection string in app.config:

xml
Copy
Edit
<connectionStrings>
  <add name="RestaurantDB" 
       connectionString="Data Source=YourServerName;Initial Catalog=RestaurantDB;Integrated Security=True;" 
       providerName="System.Data.SqlClient" />
</connectionStrings>
Build and Run:

Click Build > Build Solution (Ctrl + Shift + B)
Click Start (F5) to run the application
📝 Usage Instructions
Login:
Admin or Manager can log in using their credentials.

Admin Dashboard:

Manage users, menu items, expenses, and generate reports.
Manager Dashboard:

Monitor sales, waiter attendance, and generate PDF invoices.
Order and Sales Management:

Add orders, view sales records, and print invoices.
📊 Future Improvements
Enhanced reporting features for analytics
Integration of inventory management
Multi-payment support
🤝 Contributions
Contributions are welcome! Feel free to fork this repository, make improvements, and submit a pull request.

📜 License
This project is licensed under the MIT License.
