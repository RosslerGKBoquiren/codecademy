-- Create a table named friends with three columns
CREATE TABLE friends (
  id INTEGER,
  name TEXT,
  birthday DATE
);
-- Beneath your current code, add Ororo Munroe to friends.
-- Her birthday is May 30th, 1940.
INSERT INTO friends (id, name, birthday)
VALUES (1, 'Ororo Munroe', 'May 30th, 1940');
SELECT *
FROM friends;
-- Add two of your friends to the table.
-- Insert an id, name, and birthday for each of them
INSERT INTO friends (id, name, birthday)
VALUES (2, 'John Wick', 'June 21th, 1980');
INSERT INTO friends (id, name, birthday)
VALUES (3, 'John Doe', 'July 17th, 1990');
-- Ororo Munroe just realized that she can control the weather and decided to change her name. Her new name is “Storm”.
-- Update her record in friends.
UPDATE friends
SET name = 'Storm'
WHERE id = 1;
-- add a new column named email
ALTER TABLE friends
ADD COLUMN email TEXT;
-- update Storm's email
UPDATE friends
SET email =  'storm@codecademy.com'
WHERE id = 1;
-- Storm is fictional, remove her from friends
DELETE FROM friends
WHERE id = 1;
SELECT *
FROM friends;