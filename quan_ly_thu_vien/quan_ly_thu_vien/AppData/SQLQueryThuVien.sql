
-- Tạo bảng Authors
CREATE TABLE Authors (
    authorID INT PRIMARY KEY IDENTITY(1,1),
    authName NVARCHAR(255) NOT NULL,
);

-- Tạo bảng Categories
CREATE TABLE Categories (
    categoryID INT PRIMARY KEY IDENTITY(1,1),
    categoryName NVARCHAR(255) NOT NULL
);

-- Tạo bảng Books
CREATE TABLE Books (
    bookID INT PRIMARY KEY IDENTITY(1,1),
    title NVARCHAR(255) NOT NULL,
    authorID INT,
    categoryID INT,
    publishedYear INT,
    quantity INT NOT NULL,
    availableQuantity INT NOT NULL,
	imageBook nvarchar(255),
    FOREIGN KEY (authorID) REFERENCES Authors(authorID),
    FOREIGN KEY (categoryID) REFERENCES Categories(categoryID),
);

-- Tạo bảng Librarians

CREATE TABLE Librarians (
	libraID int primary key identity(1,1),
	libFullName nvarchar(255) not null,
	username NVARCHAR(255) NOT NULL UNIQUE,
    pass_word NVARCHAR(255) NOT NULL
);

-- Tạo bảng Users
CREATE TABLE Readers (
    readerID INT PRIMARY KEY IDENTITY(1,1),
    fullName NVARCHAR(255) NOT NULL UNIQUE,
    addressReader NVARCHAR(255) NOT NULL,
	birthDate DateTime NOT NULL,
	workplace nvarchar(255)
);

-- Tạo bảng BorrowRecords
CREATE TABLE BorrowRecords (
    recordID INT PRIMARY KEY IDENTITY(1,1),
    readerID INT,
    bookID INT,
    borrowDate DATE NOT NULL,
    returnDate DATE,
    dueDate DATE NOT NULL,
    FOREIGN KEY (readerID) REFERENCES Readers(readerID),
    FOREIGN KEY (bookID) REFERENCES Books(bookID)
);

drop table BorrowRecords;
drop table Books;
drop table Readers;
drop table Librarians;
drop table Categories;
drop table Authors;

select * from Librarians;


insert into Librarians (libFullName,username,pass_word) values (N'Trần Thanh Nghĩa', 'ttn216','1234');
insert into Librarians (libFullName,username,pass_word) values (N'Phạm Phú Khương', 'ppk','1234');
insert into Librarians (libFullName,username,pass_word) values (N'Lê Nguyễn Thuỳ Dung', 'lntd','1234');

select count(*) from Librarians where username = 'ttn216' and pass_word = '12345';