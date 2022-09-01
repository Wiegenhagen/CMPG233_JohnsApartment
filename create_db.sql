DROP DATABASE IF EXISTS JOHNS;

CREATE DATABASE JOHNS;

CREATE LOGIN johnsSystemLogin   
    WITH PASSWORD = 'password';  
GO 
CREATE USER johnsSystem FOR LOGIN johnsSystemLogin;  
GO  
USE JOHNS
EXEC sp_addrolemember 'db_datareader', johnsSystem