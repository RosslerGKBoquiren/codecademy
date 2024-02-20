--  task 1
--  SELECT title, score
--  FROM hacker_news
--  ORDER BY score DESC
--  LIMIT 5;

--  find the total score fo all the stories: 6366
-- SELECT SUM(score)
-- FROM hacker_news;

-- find the individual users who have gotten combines scores of more than 2000 and
-- their combined scores
-- group by and having are needed
-- SELECT user, SUM(score) AS combined_score
-- FROM hacker_news
-- GROUP BY user
-- HAVING combined_score > 200;

-- add the user's scores together and divide by the total to get the percentage
-- SELECT (1412.0 / NULLIF(SUM(score), 0)) * 100 AS percentage
-- FROM hacker_news;

-- How many times has each offending user posted this link
-- SELECT user, COUNT(url)
-- FROM hacker_news
-- WHERE URL = 'https://www.youtube.com/watch?v=dQw4w9WgXcQ';

-- Which of these sites feed Hacker News the most:
-- GitHub, Medium, or New York Times?
-- SELECT CASE 
--     WHEN url LIKE '%github.io%' THEN 'GitHub'
--     WHEN url LIKE '%medium.com%' THEN 'Medium'
--     WHEN url LIKE '%nytimes.com%' THEN 'New York Times'
--     ELSE 'Other'
--   END AS 'Source',
--   COUNT(*) AS 'Number of Stories'
-- FROM hacker_news
-- WHERE url LIKE '%github.io%' OR url LIKE '%medium.com%' OR url LIKE '%nytimes.com%'
-- GROUP BY Source;

-- task 8 best time to ppost a story on Hacker News
-- SELECT
--   strftime('%H', timestamp) AS post_hour,
--   COUNT(*) AS number_of_stories
-- FROM hacker_news
-- GROUP BY post_hour
-- ORDER BY post_hour;

-- task 9
-- SELECT timestamp,
--    strftime('%H', timestamp)
-- FROM hacker_news
-- GROUP BY 1
-- LIMIT 20;

-- Task 10
-- SELECT
--   strftime('%H', timestamp) AS post_hour,
--   AVG(score) AS average_score,
--   COUNT(*) AS number_of_stories
-- FROM hacker_news
-- GROUP BY post_hour
-- ORDER BY post_hour;

-- task 11
SELECT
  strftime('%H', timestamp) AS post_hour,
  ROUND(AVG(score), 1) AS rounded_average_score,
  COUNT(*) AS number_of_stories
FROM hacker_news
WHERE timestamp IS NOT NULL
GROUP BY post_hour
ORDER BY post_hour;