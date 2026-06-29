CREATE TABLE tbl_Users (
    UserID INT IDENTITY(1,1) PRIMARY KEY,     -- លេខសម្គាល់ស្វ័យប្រវត្ត (1, 2, 3...)
    Username NVARCHAR(50) NOT NULL UNIQUE,     -- ឈ្មោះគណនី (មិនឱ្យជាន់គ្នា និងមិនឱ្យទទេ)
    Password NVARCHAR(50) NOT NULL,            -- លេខកូដសម្ងាត់
    EmployeeName NVARCHAR(100),                -- ឈ្មោះពិតរបស់បុគ្គលិក
    UserRole NVARCHAR(30) NOT NULL,            -- សិទ្ធិប្រើប្រាស់ (Master, Customer_Staff, Loan_Staff)
    Status NVARCHAR(20) DEFAULT 'Active'       -- ស្ថានភាពគណនី (Active / Inactive)
);
INSERT INTO tbl_Users (Username, Password, EmployeeName, UserRole, Status)
VALUES ('admin', 'admin123', 'ONE', 'Master', 'Active');

SELECT * From tbl_Users;

-- ១. លុបតារាង Loan ចាស់ចោលសិនដើម្បីកុំឱ្យជាន់គ្នា
DROP TABLE IF EXISTS Loan;

-- ២. បង្កើតតារាង Loan ថ្មីឱ្យត្រូវតាម Form (ផ្ទាំង Loan Design ថ្មី)
CREATE TABLE Loan (
    LoanID INT IDENTITY(1,1) PRIMARY KEY,
    CustomerID VARCHAR(50) NOT NULL,          -- ត្រូវនឹងប្រអប់ ID : (ComboBox)
    LoanAmount DECIMAL(18, 2) NOT NULL,       -- ត្រូវនឹងប្រអប់ Amount :
    InterestRate DECIMAL(5, 2) NOT NULL,      -- ត្រូវនឹងប្រអប់ Interest : (% ការប្រាក់)
    TermMonths INT NOT NULL,                  -- ត្រូវនឹងប្រអប់ Term : (ចំនួនខែ)
    LoanDate DATE NOT NULL DEFAULT GETDATE(), -- ថ្ងៃខែដែលបង្កើតកម្ចី (យកថ្ងៃបច្ចុប្បន្នអូតូ)
    Status VARCHAR(50) DEFAULT 'Active'       -- ស្ថានភាពកម្ចី
);

-- ៣. បញ្ចូលទិន្នន័យគំរូសាកល្បង (Insert Data) ឱ្យត្រូវតាមលក្ខខណ្ឌថ្មី
INSERT INTO Loan (CustomerID, LoanAmount, InterestRate, TermMonths, Status)
VALUES
('CUST001', 5000.00, 1.50, 12, 'Active'),
('CUST002', 12000.00, 2.00, 24, 'Active'),
('CUST003', 2500.00, 1.20, 6, 'Closed');

-- ៤. មើលទិន្នន័យក្នុងតារាង Loan ឡើងវិញ
SELECT * FROM Loan;

ALTER TABLE tbl_Users ADD 
    CanCustomer BIT DEFAULT 0,
    CanLoan BIT DEFAULT 0,
    CanPenalty BIT DEFAULT 0,
    CanRepayment BIT DEFAULT 0,
    CanReport BIT DEFAULT 0,
    CanSetting BIT DEFAULT 0,
    CanSearch BIT DEFAULT 0;
    
    SELECT TABLE_NAME
FROM INFORMATION_SCHEMA.TABLES
WHERE TABLE_TYPE = 'BASE TABLE';

