# Student Management System

A Windows Forms application built with .NET 8 for managing student records.

## Database Setup

1. **Prerequisites**: SQL Server Express or SQL Server installed
2. **Connection String**: `Data Source=YOUR_SERVER;Initial Catalog=Student;Integrated Security=True;Encrypt=False`
3. **Setup Database**: 
   - Open SQL Server Management Studio (SSMS)
   - Run the script from `database-schema.sql`
   - This will create the `Student` database with required tables

## Default Login Credentials

- **Username**: Admin
- **Password**: Skills@123

## Getting Started

1. Clone this repository
2. Set up the database using `database-schema.sql`
3. Update the connection string in the code if needed
4. Build and run the application