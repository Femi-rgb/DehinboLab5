-- List all fields from the Orders table for all orders that do not have a 1 within the order number field.
SELECT *
FROM Orders
WHERE OrderNum NOT LIKE '%1%';

 
-- List all fields from the part table that have a ‘v’ in the second character of the part number or the characters ‘washer’ anywhere in the description. Sort by class ascending then price descending.
SELECT *
FROM Part
WHERE PartNum LIKE '_v%'      -- 'v' in the second character
   OR Description LIKE '%washer%'  -- 'washer' in the description
ORDER BY Class ASC, Price DESC;

 
-- List the rep name (formatted as last name comma space first name with column title Name), commission, rate and bonus. The Bonus is the commission multiplied by the rate and formatted with $ and no decimal places. Show the commission with commas and 2 decimal places and the rate formatted as a percentage (0.05 will display as 5%). Fix all column titles so no functions are shown.
SELECT 
    CONCAT(LastName, ', ', FirstName) AS Name,
    FORMAT(Commission, 2) AS Commission,
    CONCAT(FORMAT(Rate * 100, 0), '%') AS Rate,
    CONCAT('$', FORMAT(Commission * Rate, 0)) AS Bonus
FROM Rep;


 
-- Show the customer name (first 10 characters only), Remaining (credit limit minus the balance formatted with $ commas and 2 decimals) only for customers whose zip code is not null and their balance is more than 5000. Sort by Remaining in descending order.
SELECT 
    LEFT(CustomerName, 10) AS Customer,
    CONCAT('$', FORMAT(CreditLimit - Balance, 2)) AS Remaining
FROM Customer
WHERE Zip IS NOT NULL
  AND Balance > 5000
ORDER BY (CreditLimit - Balance) DESC;
 
 
 
-- List the different order dates only from the orders table. Sort by order date with the most recent at the top.
SELECT DISTINCT OrderDate
FROM Orders
ORDER BY OrderDate DESC;


 
-- Show all fields from the orders table and the payment date (payments are due 15 days after the order date). Format the payment date as mm/dd/yyyy with leading zeroes with a column title Payment Due Date (with spaces).
SELECT 
    OrderNum,
    OrderDate,
    CustomerNum,
    DATE_FORMAT(DATE_ADD(OrderDate, INTERVAL 15 DAY), '%m/%d/%Y') AS `Payment Due Date`
FROM Orders;


 
-- List how many orders had exactly 4 items ordered (4 in the numordered field). Do not list the records, list the number using an aggregate function.
SELECT COUNT(*) AS OrdersWith4Items
FROM OrderLine
WHERE NumOrdered = 4;


 
-- Calculate the average, minimum and maximum price for all parts. Format all dollar amounts as $99,999.99 and rename the columns Average, Minimum, and Maximum.
SELECT 
    CONCAT('$', FORMAT(AVG(Price), 2)) AS Average,
    CONCAT('$', FORMAT(MIN(Price), 2)) AS Minimum,
    CONCAT('$', FORMAT(MAX(Price), 2)) AS Maximum
FROM Part;


 
-- Use the orders table to create a list of all customers by number with their total number of orders. Show only the customers who have two orders. 
SELECT 
    CustomerNum,
    COUNT(*) AS TotalOrders
FROM Orders
GROUP BY CustomerNum
HAVING COUNT(*) = 2;


 
-- From the orderline table, list the order number, sum of the number ordered (titled Items) and sum of the total amount (number ordered multiplied by quoted price) titled Total Amount. Include the grand total in the result set (super-aggregate). Group by order number. Format the Total Amount with $ and 2 decimals.
SELECT 
    COALESCE(OrderNum, 'Grand Total') AS OrderNum,
    SUM(NumOrdered) AS Items,
    CONCAT('$', FORMAT(SUM(NumOrdered * QuotedPrice), 2)) AS `Total Amount`
FROM OrderLine
GROUP BY OrderNum WITH ROLLUP;


 
-- Redo the last command and only show records that have a Total Amount between $800 and $3,000. Do not include the grand total (super-aggregate).
SELECT 
    OrderNum,
    SUM(NumOrdered) AS Items,
    CONCAT('$', FORMAT(SUM(NumOrdered * QuotedPrice), 2)) AS `Total Amount`
FROM OrderLine
GROUP BY OrderNum
HAVING SUM(NumOrdered * QuotedPrice) BETWEEN 800 AND 3000;
 
 
 
-- From the customer table, for each city, show how many customers, their average balance and average creditlimit. Select only customers that have rep numbers 20 or 35. Title the columns Number, Avg Balance and Avg Credit Limit. Format the averages with no decimal places.
SELECT 
    City,
    COUNT(*) AS Number,
    FORMAT(AVG(Balance), 0) AS `Avg Balance`,
    FORMAT(AVG(CreditLimit), 0) AS `Avg Credit Limit`
FROM Customer
WHERE RepNum IN ('20', '35')
GROUP BY City;