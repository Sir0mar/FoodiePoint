-- ============================================
-- Step 1: Create the FoodiePointDB database
-- ============================================
IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = N'FoodiePointDB')
BEGIN
    CREATE DATABASE FoodiePointDB;
END
GO

USE FoodiePointDB;
GO

-- ============================================
-- Step 2: Create Users table
-- ============================================
IF OBJECT_ID('dbo.Users', 'U') IS NOT NULL
    DROP TABLE dbo.Users;
GO

CREATE TABLE dbo.Users (
    UserID INT PRIMARY KEY IDENTITY(1,1),
    UserName NVARCHAR(50) NOT NULL,
    Email NVARCHAR(100) UNIQUE NOT NULL,
    Password NVARCHAR(255) NOT NULL,  -- ※ Consider hashing passwords in production
    Role NVARCHAR(30) CHECK (Role IN ('Admin', 'Manager', 'Chef', 'Reservation Coordinator', 'Customer')),
    CreatedAt DATETIME DEFAULT GETDATE()
);
GO
    

-- ============================================
-- Step 3: Create Sales table (for sales reports)
-- ============================================
IF OBJECT_ID('dbo.Sales', 'U') IS NOT NULL
    DROP TABLE dbo.Sales;
GO

CREATE TABLE dbo.Sales (
    SaleID INT PRIMARY KEY IDENTITY(1,1),
    SaleDate DATETIME NOT NULL,
    Category NVARCHAR(50) NOT NULL,
    Chef NVARCHAR(50),
    TotalAmount DECIMAL(10,2) NOT NULL
);
GO

-- ============================================
-- Step 4: Create Feedback table (for customer feedback)
-- ============================================
IF OBJECT_ID('dbo.Feedback', 'U') IS NOT NULL
    DROP TABLE dbo.Feedback;
GO

CREATE TABLE dbo.Feedback (
    FeedbackID INT PRIMARY KEY IDENTITY(1,1),
    CustomerName NVARCHAR(100) NOT NULL,
    Comments NVARCHAR(500) NOT NULL,
    Rating INT CHECK (Rating BETWEEN 1 AND 5),
    FeedbackDate DATETIME DEFAULT GETDATE()
);
GO

-- ============================================
-- Step 5: Create Reservations table (for managing reservations)
-- ============================================
IF OBJECT_ID('dbo.Reservations', 'U') IS NOT NULL
    DROP TABLE dbo.Reservations;
GO

CREATE TABLE dbo.Reservations (
    ReservationID INT PRIMARY KEY IDENTITY(1,1),
    CustomerID INT FOREIGN KEY REFERENCES dbo.Users(UserID),
    HallID INT FOREIGN KEY REFERENCES dbo.Halls(HallID),
    EventType NVARCHAR(50) NOT NULL,
    StartDateTime DATETIME NOT NULL,
    EndDateTime DATETIME NOT NULL,
    PartySize INT NOT NULL,
    SpecialRequests NVARCHAR(500),
    Status NVARCHAR(20) DEFAULT 'Pending',
    CreatedDate DATETIME DEFAULT GETDATE(),
    LastUpdated DATETIME DEFAULT GETDATE()
);
GO
GO

-- ============================================
-- Step 6: Create Menu table (for managing restaurant menu)
-- ============================================
IF OBJECT_ID('dbo.Menu', 'U') IS NOT NULL
    DROP TABLE dbo.Menu;
GO

CREATE TABLE dbo.Menu (
    MenuID INT PRIMARY KEY IDENTITY(1,1),
    ItemName NVARCHAR(100) NOT NULL,
    Category NVARCHAR(50) NOT NULL,
    Price DECIMAL(10,2) NOT NULL,
    Availability BIT DEFAULT 1
);
GO

-- ============================================
-- Step 7: Create Orders table (for managing customer orders)
-- ============================================
IF OBJECT_ID('dbo.Orders', 'U') IS NOT NULL
    DROP TABLE dbo.Orders;
GO

CREATE TABLE dbo.Orders (
    OrderID INT PRIMARY KEY IDENTITY(1,1),
    CustomerID INT NOT NULL,  -- Foreign key relationship to Users table (if needed)
    OrderDate DATETIME DEFAULT GETDATE(),
    Status NVARCHAR(50) CHECK (Status IN ('Pending', 'In Progress', 'Completed')),
    TotalPrice DECIMAL(10,2) NULL
);
GO

-- ============================================
-- Step 8: Create OrderDetails table (for storing order details)
-- ============================================
IF OBJECT_ID('dbo.OrderDetails', 'U') IS NOT NULL
    DROP TABLE dbo.OrderDetails;
GO

CREATE TABLE dbo.OrderDetails (
    OrderDetailID INT PRIMARY KEY IDENTITY(1,1),
    OrderID INT NOT NULL,  -- Foreign key to Orders table
    MenuID INT NOT NULL,   -- Foreign key to Menu table
    Quantity INT NOT NULL,
    Subtotal DECIMAL(10,2) NOT NULL,
    CONSTRAINT FK_OrderDetails_Order FOREIGN KEY (OrderID) REFERENCES dbo.Orders(OrderID),
    CONSTRAINT FK_OrderDetails_Menu FOREIGN KEY (MenuID) REFERENCES dbo.Menu(MenuID)
);
GO

-- ============================================
-- Step 9: Create Inventory table (for managing ingredients)
-- ============================================
IF OBJECT_ID('dbo.Inventory', 'U') IS NOT NULL
    DROP TABLE dbo.Inventory;
GO

CREATE TABLE dbo.Inventory (
    IngredientID INT PRIMARY KEY IDENTITY(1,1),
    IngredientName NVARCHAR(100) NOT NULL,
    Quantity INT NOT NULL CHECK (Quantity >= 0),
    Price DECIMAL(10,2) NOT NULL,
    LastUpdated DATETIME DEFAULT GETDATE()
);
GO

-- ============================================
-- Step 10: Insert sample data (Users table)
-- ============================================
INSERT INTO dbo.Users (UserName, Email, Password, Role)
VALUES 
('admin', 'admin@example.com', 'Admin123!', 'Admin'),
('manager', 'manager@example.com', 'Manager123!', 'Manager'),
('chef', 'chef@example.com', 'Chef123!', 'Chef'),
('coordinator', 'coordinator@example.com', 'Coordinator123!', 'Reservation Coordinator'),
('customer', 'customer@example.com', 'Customer123!', 'Customer');
GO

-- ============================================
-- Step 11: Create Halls table
-- ============================================
IF OBJECT_ID('dbo.Halls', 'U') IS NOT NULL
    DROP TABLE dbo.Halls;
GO

CREATE TABLE dbo.Halls (
    HallID INT PRIMARY KEY IDENTITY(1,1),
    HallName NVARCHAR(50) NOT NULL,
    Capacity INT NOT NULL,
    Description NVARCHAR(200),
    Status NVARCHAR(20) DEFAULT 'Available' -- 'Available', 'Under Maintenance'
);
GO


GO

-- ============================================
-- Step 12: Create ReservationMessages table
-- ============================================
IF OBJECT_ID('dbo.ReservationMessages', 'U') IS NOT NULL
    DROP TABLE dbo.ReservationMessages;
GO

CREATE TABLE dbo.ReservationMessages (
    MessageID INT PRIMARY KEY IDENTITY(1,1),
    ReservationID INT FOREIGN KEY REFERENCES dbo.Reservations(ReservationID),
    SenderID INT FOREIGN KEY REFERENCES dbo.Users(UserID),
    MessageText NVARCHAR(500) NOT NULL,
    SentDateTime DATETIME DEFAULT GETDATE(),
    IsRead BIT DEFAULT 0
);
GO
