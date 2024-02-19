-- 1. How many columns are there? 10
-- SELECT *
-- FROM startups;

-- 2. Calculate the total number of companies. 70
-- SELECT COUNT(*)
-- FROM startup;

-- 3. Total value of all companies. 974455790000
-- SELECT SUM(valuation)
-- FROM startups;

-- 4. Maximum amount of money raised 11500000000
-- SELECT MAX(raised)
-- FROM startups;

-- 5. Maximum amount of money raised 'Seed' 1800000
-- SELECT MAX(raised)
-- FROM startups
-- WHERE stage = 'Raised';

-- 6. Oldest company 1994
-- SELECT MIN(founded)
-- FROM startups;

-- 7. Average valuation 15974685081.9672
-- SELECT AVG(valuation)
-- FROM startups

-- 8. return average valuation in each category
-- SELECT category, AVG(valuation)
-- FROM startups
-- GROUP BY category;

-- 9. return average valuation in each category round to 2
-- SELECT category, ROUND(AVG(valuation), 2)
-- FROM startups
-- GROUP BY category;

-- 10. Return average valuation, each category, round 2, order desc
-- SELECT category, ROUND(AVG(valuation), 2)
-- FROM startups
-- GROUP BY 1
-- ORDER BY 2 DESC;

-- 11. return the name of each category with total number of companies
-- SELECT category, COUNT(*)
-- FROM startups
-- GROUP BY category;

-- 12. filter the result to only include categories that have
-- more than 3 companies in them
-- SELECT category, COUNT(*)
-- FROM startups
-- GROUP BY category
-- HAVING COUNT(*) > 3;

-- 13. What is the average size of a startup in each location?
-- SELECT location, AVG(employees)
-- FROM startups
-- GROUP BY location;

-- 14. What is the average size of a startup in each location, 
-- with average sizes above 500
SELECT location, AVG(employees)
FROM startups
GROUP BY location
HAVING AVG(employees) > 500;
