-- Student Management System Database Schema
-- Connection String: Data Source=DESKTOP-CF5UPHT\SQLEXPRESS;Initial Catalog=Student;Integrated Security=True;Encrypt=False

-- 1. Create database
CREATE DATABASE Student;
GO

-- Switch to the new database
USE Student;
GO

-- 2. If tables already exist, remove them first
-- Note: DROP TABLE IF EXISTS works on SQL Server 2016 and newer.
DROP TABLE IF EXISTS Logins;
DROP TABLE IF EXISTS Registration;
GO

-- 3. Create Registration table
CREATE TABLE Registration
(
    regNo       INT         IDENTITY(1,1) PRIMARY KEY, -- regNo as integer auto-increment
    firstName   VARCHAR(50) NOT NULL,
    lastName    VARCHAR(50) NOT NULL,
    dateOfBirth DATETIME    NULL,
    gender      VARCHAR(50) NULL,
    address     VARCHAR(50) NULL,
    email       VARCHAR(50) NULL,
    mobilePhone INT         NULL,
    homePhone   INT         NULL,
    parentName  VARCHAR(50) NULL,
    nic         VARCHAR(50) NULL,
    contactNo   INT         NULL
);
GO

-- 4. Create Logins table
CREATE TABLE Logins
(
    loginId  INT         IDENTITY(1,1) PRIMARY KEY,
    username VARCHAR(50) NOT NULL UNIQUE,
    password VARCHAR(100) NOT NULL,  -- plain text for learning; hash in real apps
    role     VARCHAR(20)  NOT NULL DEFAULT 'User'
);
GO

-- 5. Example rows (for testing)
INSERT INTO Logins (username, password, role)
VALUES ('Admin', 'Skills@123', 'Admin');
GO

INSERT INTO Registration (firstName, lastName, dateOfBirth, gender, address, email, mobilePhone, homePhone, parentName, nic, contactNo)
VALUES ('John', 'Doe', '2005-05-10', 'Male', '12 Main St', 'john@example.com', 771234567, 112345678, 'Jane Doe', '987654321V', 771765432);
GO

-- 6. Example simple queries you'll use from C#
-- Get all students
SELECT * FROM Registration;
GO

-- Get one student by regNo (replace 1 with the actual regNo)
SELECT * FROM Registration WHERE regNo = 1;
GO

-- Simple login check
SELECT loginId, username, role
FROM Logins
WHERE username = 'Admin'
  AND password = 'Skills@123';
GO