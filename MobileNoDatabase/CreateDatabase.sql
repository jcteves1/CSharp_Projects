-- run this query first to create the database
CREATE DATABASE MobileNoDatabase; --select then execute

--then run this query to create the table 
USE MobileNoDatabase;
CREATE TABLE person_number (
    id int PRIMARY KEY,
    name varchar(50),
    mobile_no varchar(50)
);