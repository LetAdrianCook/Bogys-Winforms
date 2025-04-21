CREATE TABLE Users (
	id INT NOT NULL PRIMARY KEY IDENTITY,
    UserName VARCHAR(100) NOT NULL,
	UserPass VARCHAR(100) NOT NULL,
	UserType VARCHAR(100) NOT NULL,
	FirstName VARCHAR(100) NOT NULL,
	LastName VARCHAR(100) NOT NULL,
	UserBirth DATE NOT NULL,
	UserAddress VARCHAR(100) NOT NULL,
	CreatedAt DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP
);

INSERT INTO Users (UserName, UserPassword, UserType, FirstName, 
LastName, UserBirth, UserAddress)
VALUES 
('Admin','adrianAdrian123','ADMIN','Adrian','Villasis','08-25-2003'),
('John25','johnJOHN123','CLIENT','John','Doe','02-15-2000');
