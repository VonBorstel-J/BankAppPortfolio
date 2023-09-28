
-- Create Customers Table
CREATE TABLE Customers (
    CustomerID INT PRIMARY KEY,
    FirstName VARCHAR(50),
    LastName VARCHAR(50),
    Email VARCHAR(100)
);

-- Create Interactions Table
CREATE TABLE Interactions (
    InteractionID INT PRIMARY KEY,
    CustomerID INT,
    InteractionDate DATE,
    Notes TEXT,
    FOREIGN KEY (CustomerID) REFERENCES Customers(CustomerID)
);

-- Insert Some Sample Data for Customers
INSERT INTO Customers (CustomerID, FirstName, LastName, Email)
VALUES 
    (1, 'John', 'Doe', 'john.doe@example.com'),
    (2, 'Jane', 'Doe', 'jane.doe@example.com');

-- Insert Some Sample Data for Interactions
INSERT INTO Interactions (InteractionID, CustomerID, InteractionDate, Notes)
VALUES
    (1, 1, '2023-09-28', 'Inquired about loan'),
    (2, 2, '2023-09-29', 'Opened a new account');
