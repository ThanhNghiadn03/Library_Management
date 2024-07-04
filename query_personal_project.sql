create database library_management;
use library_management;


-- T?o b?ng Authors
CREATE TABLE Authors (
    authorID INT PRIMARY KEY IDENTITY(1,1),
    authName NVARCHAR(255) NOT NULL,
);

-- T?o b?ng Categories
CREATE TABLE Categories (
    categoryID INT PRIMARY KEY IDENTITY(1,1),
    categoryName NVARCHAR(255) NOT NULL
);

-- T?o b?ng Books
CREATE TABLE Books (
    bookID INT PRIMARY KEY IDENTITY(1,1),
    title NVARCHAR(255) NOT NULL,
    authorID INT,
    categoryID INT,
    publishedYear INT,
    quantity INT NOT NULL,
    availableQuantity INT NOT NULL,
    FOREIGN KEY (AuthorID) REFERENCES Authors(AuthorID),
    FOREIGN KEY (CategoryID) REFERENCES Categories(CategoryID),
);

-- T?o b?ng Users
CREATE TABLE Users (
    userID INT PRIMARY KEY IDENTITY(1,1),
    username NVARCHAR(255) NOT NULL UNIQUE,
    pass_word NVARCHAR(255) NOT NULL
);

-- T?o b?ng BorrowRecords
CREATE TABLE BorrowRecords (
    recordID INT PRIMARY KEY IDENTITY(1,1),
    userID INT,
    bookID INT,
    borrowDate DATE NOT NULL,
    returnDate DATE,
    dueDate DATE NOT NULL,
    FOREIGN KEY (UserID) REFERENCES Users(UserID),
    FOREIGN KEY (BookID) REFERENCES Books(BookID)
);