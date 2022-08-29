CREATE TABLE ADMINISTRATOR (
	Administrator_ID 	int				IDENTITY(1, 1) PRIMARY KEY, 
	Username  			varchar(30), 
	Password 	 		varchar(100),		
);

CREATE TABLE BANK (
	Bank_ID 		int 		 IDENTITY(1, 1) PRIMARY KEY, 
	Bank_Name 		varchar(100), 

);

CREATE TABLE RESIDENT (
	Resident_ID 		int 		 IDENTITY(1, 1) PRIMARY KEY,  
	Bank_ID 			int 	FOREIGN KEY REFERENCES BANK(Bank_ID), 
	First_Name 			varchar(100),
	Last_Name			varchar(100),
	Cell_Number			varchar(20),
	ID_Number			varchar(13),
	Branch_Code			varchar(50),
	Account_Number		varchar(50),
	Acknowlegde_Contract bit, 
);

CREATE TABLE APARTMENT (
	Apartment_ID 		int 		 IDENTITY(1, 1) PRIMARY KEY,  
	Resident_ID			int 	FOREIGN KEY REFERENCES RESIDENT(Resident_ID), 
	Occupation_Date 	Date,
	Furnished			bit,
	Apartment_Number	int,
);

