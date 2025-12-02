-- Question 1

SELECT customerName, city, country
FROM customers
WHERE country = 'USA'
ORDER BY customerName ASC;


-- Question 2 Display each employees name and email adress in a single formatted string using this pattern "lastname, Firstname (Email: email@domain)". label the column Contactinfo sort the output by lastname and then by Firstname

SELECT
    CONCAT(lastName, ', ', firstName, ' (Email: ', email, ')') AS ContactInfo
FROM employees
ORDER BY lastName ASC, firstName ASC;



-- Qeustion 3 

SELECT
    productCode,
    productName,
    buyPrice,
    MSRP,
    (MSRP - buyPrice) AS profitMargin
FROM products
ORDER BY profitMargin DESC;

-- Question 4 
SELECT
    customerNumber,
    COUNT(paymentDate) AS NumberOfPayments,
    CONCAT('$', FORMAT(SUM(amount), 2)) AS TotalPayments
FROM payments
GROUP BY customerNumber
ORDER BY SUM(amount) DESC;


-- Question 5 

SELECT
    country,
    COUNT(customerNumber) AS CustomerCount
FROM customers
WHERE customerName LIKE '%Gift%'
GROUP BY country
HAVING COUNT(customerNumber) > 2
ORDER BY CustomerCount ASC;


-- Question 6 

SELECT
    status,
    COUNT(orderNumber) AS OrderCount
FROM orders
WHERE YEAR(orderDate) IN (2004, 2005)
GROUP BY status
HAVING COUNT(orderNumber) >= 4
ORDER BY OrderCount DESC;

-- Question 7 

SELECT
    productName,
    quantityInStock,
    buyPrice,
    MSRP,
    CONCAT('$', FORMAT(quantityInStock * buyPrice, 0)) AS InventoryValue,
    CONCAT('$', FORMAT((quantityInStock * buyPrice) * 0.83, 0)) AS DiscountedValue
FROM products
ORDER BY (quantityInStock * buyPrice) DESC;






