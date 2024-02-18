SELECT * FROM nomnom;

-- What are the distinct neighborhoods?
SELECT DISTINCT neighborhood
FROM nomnom;

-- what are the distinct cuisine types?
SELECT DISTINCT cuisine
FROM nomnom;

-- Suppose we would like some Chinese takeout.
-- What are our options?
SELECT *
FROM nomnom
WHERE cuisine = 'Chinese';

-- Return all the restaurants with reviews of 4 and above
SELECT *
FROM nomnom
WHERE review >= 4;

-- Suppose Abbi and Ilana want to have a fancy dinner date. 
-- Return all the restaurant that are italian and $$$
SELECT *
FROM nomnom
WHERE cuisine = 'Italian'
  AND price = '$$$';

-- Your coworker Trey can't remember the exact name of a restaurant he went to but he knows it 
-- contains the word 'meatball' in it. 
SELECT *
FROM nomnom
WHERE name LIKE '%meatball%';

-- Let's order delivery to the house!
-- Find all the close by sports in Midtown, Downtown or Chinatown
SELECT *
FROM nomnom
WHERE neighborhood = 'Midtown' OR neighborhood = 'Downtown' OR neighborhood = 'Chinatown';

-- find all the health grade pending restaurants (empty values)
SELECT *
FROM nomnom
WHERE health IS NULL;

-- Create top 10 restaurants ranking based on reviews
SELECT *
FROM nomnom
ORDER BY review DESC
LIMIT 10;

-- Use a CASE statement to change the rating system
SELECT name,
  CASE
    WHEN review > 4.5 THEN 'Extraordinary'
    WHEN review > 4 THEN 'Excellent'
    WHEN review > 3 THEN 'Good'
    WHEN review > 2 THEN 'Fair'
    ELSE 'Fair'
  END as rating_system
FROM nomnom;

