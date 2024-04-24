-- Login:

create Table Login(
	Username Varchar(150) not Null,
	Password Varchar (20) not Null,
);


Insert into Login (Username,Password) Values ('admin','admin');

-- AddNewBook:

create Table AddNewBook(
	BookName Varchar (150) not Null,
	ISBN Varchar (150) not Null Primary Key,
	PublishDate Varchar (150) not Null,
	Category Varchar (150) not Null,
	Quantity Int not Null,
	AuthorName varchar(255),
);

Insert Into AddNewBook (BookName,ISBN,PublishDate,Category,Quantity, AuthorName) Values ('Web Programming','CSCI335','Saturday, October 24, 2020','Computer Science','43','Hadi Saad');

Insert Into AddNewBook (BookName,ISBN,PublishDate,Category,Quantity, AuthorName) Values ('Visual Programming','CSCI370','Wednesday, February 1, 2023','Computer Science','35','Souha Katat');

Insert Into AddNewBook (BookName,ISBN,PublishDate,Category,Quantity, AuthorName) Values ('Data Structures & Algorithms','CSCI378','Tuesday, December 20, 2022','Computer Science','50','Maya Daoud');

Insert Into AddNewBook (BookName,ISBN,PublishDate,Category,Quantity, AuthorName) Values ('Software Engineering','CSCI380','Sunday, January 1, 2023','Computer Science','65','Shadi Khawandi');

Insert Into AddNewBook (BookName,ISBN,PublishDate,Category,Quantity, AuthorName) Values ('Computer Networks','CSCI392','Tuesday, October 13, 2020','Information Technology','75','Basma Hamadeh');

-- AddUser:

create Table AddUser(
	UserName Varchar (150) not Null,
	UserID Varchar (150) not Null Primary Key,
	UserContact Varchar (150) not Null, 
	UserEmail Varchar (150) not Null
);

Insert into AddUser(UserName,UserID,UserContact,UserEmail) values('Jad Rammal','1','71291145','12110192@students.liu.edu.lb')

-- IssueBook:

create Table IssueBook(
	UserID Varchar (150) Foreign Key References AddUser(UserID) Not Null,
	ISBN Varchar (150) Foreign Key References AddNewBook(ISBN) Not Null,
	IssueDate Varchar (150) not Null,
	ReturnDate Varchar (150) not Null,
	IsReturned Bit not Null,
	Fine Int not Null,
	Foreign Key (UserID) References AddUser on Delete Cascade,
	Foreign Key (ISBN) References AddNewBook on Delete Cascade
);



