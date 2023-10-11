-- run this query first to create the database
CREATE DATABASE Dictionary;
USE Dictionary;

-- then run these queries to create the tables
CREATE TABLE dictionary (
	word VARCHAR(50) UNIQUE,
	definition VARCHAR(MAX),
	date VARCHAR(50)
	);

CREATE TABLE examples (
	word VARCHAR(50) UNIQUE,
	definition VARCHAR(MAX),
	date VARCHAR(50)
	);