-- run this query first to create the database
CREATE DATABASE LoginPage; --select then execute

--then run these queries to create the tables 
USE LoginPage;
CREATE TABLE accounts (
    id int IDENTITY(1,1) PRIMARY KEY,
    username varchar(50),
    password varchar(50)
);

CREATE TABLE rememberme (
	id int IDENTITY(1,1) PRIMARY KEY, 
	username varchar(50),
	password varchar(50)
);
--this will create an empty row
INSERT INTO rememberme (username, password)
VALUES ('', '');