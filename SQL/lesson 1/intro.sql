-- Introduction to SQL
SELECT * FROM celebs;

-- Relational Dtabases
-- A relational database is a database that organizes information
-- into one or more tables. 
-- A table is a collection of data organized itno rows and columns. 
-- Here the table is celebs.
-- a column is a set of data values of a particular type. Here, id, name, and age are the columns
-- a row is a single record in a table. 
-- INTEGER is a positive or negative whole number
-- TEXT is a text string
-- DATE is the date formatted as YYYY-MM-DD
-- REAL is a decimal value


-- Statements
-- a statement is text that the database recognizes as a valid command. Statements always end in a semicolon;
-- CREATE TABLE is a clause. Clauses perform specific tasks in SQL
-- table_name refers to the name of the table that the command is applied to.
-- (column_1 data_type, column_2 data_type, column_3 data_type) is a paramter.
-- a parameter is a list of columns, data types, or values that are passed to a clause as an argument


-- CREATE statement allow us to create a new table in the database.
--  confirm that no celebs table exists
 SELECT * FROM celebs;
-- create a new celebs tables
CREATE TABLE celebs (
  id INTEGER,
  name TEXT,
  age INTEGER
);


-- INSERT statement inserts a new row into a table
-- we can use the INSERT statement when you want to add new records. 
--  add a row to the table. 
INSERT INTO celebs (id, name, age)
VALUES (1, 'Justin Bieber', 29);
-- add three more celebrities to the table beneath your previous INSERT statement
INSERT INTO celebs (id, name, age)
VALUES (2, 'Beyonce Knowles', 42);
INSERT INTO celebs (id, name, age)
VALUES (3, 'Jeremy Lin', 35);
INSERT INTO celebs (id, name, age)
VALUES (4, 'Talyor Swift', 33);


-- SELECT
-- SELECT statements are used to fetch data from a database, it returns all data int he name column of the celebs table
-- SELECT name FROM celebs;
-- SELECT is a clause which will be used everytime you query data from a database
-- name specifies the column to the query data from
-- FROM celebs specified the name of the table to query data from


-- Alter 
-- The ALTER TABLE statement adds a new column to a table. 
ALTER TABLE celebs 
ADD COLUMN twitter_handle TEXT;
SELECT * FROM celebs;
-- ALTER TABLE is a clause
-- celebs is the name of the table
-- ADD COLUMN is a clause that lets you add a new column to a table
-- twitter_handle is the name of the new column being added
-- TEXT is the data type for the new column
-- NULL is a special value in SQL that represents missing of uknown data. 
-- add a new column to the table


-- Update
-- UPDATE statement edits a row in a table to change the existing records. 
UPDATE celebs 
SET twitter_handle = '@taylorswift13' 
WHERE id = 4; 
SELECT * FROM celebs;
-- UPDATE is a clause that edits a row in the table.
-- celebs is the name of the table
-- SET is a clause that indiciates the column to edit
-- twitter_handle is the name of the column that is going to be updated
-- @taylorswift13 is the new value that is going to to be insterted into the twitter_handle column
-- WHERE is a clause that indicates which row to update with the new column value


-- DELETE
-- DELETE FROM is a statement that deletes one or more rows from a table. 
DELETE FROM celebs 
WHERE twitter_handle IS NULL;
SELECT * FROM celebs;
-- DELETE FROM is a clause
-- celebs is the name of the table
-- WHERE is the clause that lets you select which rows you want to delete
-- IS NULL is a condition that reutrn true when the value is NULL and false otherwise


-- Constraints
-- Constraints add information about how a column can be used are involed after specifiying the data
-- for a column. They can be used to the tell database to reject inserted data that does not adhere to
-- a certain restrictions
CREATE TABLE celebs (
   id INTEGER PRIMARY KEY, 
   name TEXT UNIQUE,
   date_of_birth TEXT NOT NULL,
   date_of_death TEXT DEFAULT 'Not Applicable'
);
-- PRIMARY KEY columns can be used to uniquely identifiy the row. Attemps to insert a row
-- with identical value to a row already in the table will resuilt in constraint violation which 
-- will not allow you to insert the new row. 
-- UNIQUE columns have a different value for every row. This is similar to PRIMARY KEY except a table can have
-- many different UNIQUE columns. 
-- NOT NULL columns must have a value. Attempts to insert a row without a value for a NOT NULL column 
-- will result in a constraint violation and the new row will not be inserted. 
-- DEFAULT columns take an additional argument that will be the assumed value for an inserted row is the new 
-- row does not specifiy a value 
CREATE TABLE awards (
  id INTEGER PRIMARY KEY,
  recipient TEXT NOT NULL,
  award_name TEXT DEFAULT 'Grammy'
);


-- Congratulations! We’ve learned six commands commonly used to manage data stored in a relational database and how to set constraints on such data. What can we generalize so far?

-- SQL is a programming language designed to manipulate and manage data stored in relational databases.

-- A relational database is a database that organizes information into one or more tables.
-- A table is a collection of data organized into rows and columns.
-- A statement is a string of characters that the database recognizes as a valid command.

-- CREATE TABLE creates a new table.
-- INSERT INTO adds a new row to a table.
-- SELECT queries data from a table.
-- ALTER TABLE changes an existing table.
-- UPDATE edits a row in a table.
-- DELETE FROM deletes rows from a table.
-- Constraints add information about how a column can be used.







