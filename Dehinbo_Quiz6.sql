-- JOINS
-- 1. 
SELECT 
    orders.orderNumber,
    orders.orderDate,
    customers.customerName
FROM orders
JOIN customers
    ON orders.customerNumber = customers.customerNumber;
    
    
-- 2. 
SELECT 
    od.orderNumber,
    p.productName,
    od.quantityOrdered
FROM orderdetails od
JOIN products p
    ON od.productCode = p.productCode
WHERE od.orderNumber BETWEEN 10123 AND 10126;


-- 3
SELECT 
    c.customerName,
    o.phone AS officePhone,
    e.extension AS salesRepExtension
FROM customers c
JOIN employees e
    ON c.salesRepEmployeeNumber = e.employeeNumber
JOIN offices o
    ON e.officeCode = o.officeCode;
    
    
    -----------------------------------------------------------------------------------------
    
    
-- SUBQUERIES
-- 1. 
SELECT 
    cust.customerName,
    cust.city,
    cust.creditLimit,
    SUM(det.priceEach * det.quantityOrdered) AS totalSpent
FROM customers AS cust
INNER JOIN orders AS ord
    ON cust.customerNumber = ord.customerNumber
INNER JOIN orderdetails AS det
    ON ord.orderNumber = det.orderNumber
GROUP BY 
    cust.customerNumber
ORDER BY 
    totalSpent DESC
LIMIT 1;



-- 2. 
SELECT 
    p.productCode,
    p.productName
FROM products p
WHERE NOT EXISTS (
    SELECT 1
    FROM orderdetails d
    WHERE d.productCode = p.productCode
);


-- 3. 
SELECT 
    c.customerName
FROM customers c
JOIN orders o
    ON c.customerNumber = o.customerNumber
GROUP BY 
    c.customerNumber, c.customerName
HAVING 
    COUNT(o.orderNumber) >
    (
        SELECT COUNT(*)
        FROM orders
        WHERE customerNumber =
          (
             SELECT customerNumber
             FROM customers
             WHERE customerName = 'Atelier graphique'
          )
    );
    

-- 4. 
SELECT 
    pl.productLine,
    AVG(p.buyPrice) AS avgLineBuyPrice
FROM productlines pl
JOIN products p
    ON pl.productLine = p.productLine
GROUP BY 
    pl.productLine
HAVING 
    AVG(p.buyPrice) >
    (
        SELECT AVG(buyPrice)
        FROM products
    );