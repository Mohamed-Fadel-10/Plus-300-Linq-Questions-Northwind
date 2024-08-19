﻿using Northwind.Entities;
using System.Net.NetworkInformation;
using static Northwind.DataLists;
namespace Northwind
{
    internal class Program
    {
        private static void Main(string[] args)
        {

            #region Easy
            // 1- Retrieve all products with a unit price greater than $50.

            #region 1-Retrieve all products with a unit price greater than $50
            //// 1-Using Query Operator

            //var products = Products
            //    .Where(p => p.UnitPrice > 50);
            //// 2- Using Query Expression 

            //var products = from p in Products
            //           where p.UnitPrice > 50
            //           select p;

            //foreach(var product in products)
            //{
            //    Console.WriteLine(product.ProductName);
            //} 
            #endregion

            //2- List the names of all customers from London.

            #region 2- List the names of all customers from London.
            //1- Using Query Operator 
            //var customers = Customers.Where(c => c.City.Contains("London"))
            //    .Select(c=>c.ContactName);

            //2- Using Query Expression 
            //var customers = from c in Customers
            //                where c.City == "London"
            //                select c.ContactName;
            //foreach (var customer in customers)
            //{
            //   Console.WriteLine($"Customer Name : { customer}");
            //} 
            #endregion

            //3- Find all orders shipped by "Speedy Express".

            #region 3- Find all orders shipped by "Speedy Express
            // 1-Using Query Operator

            //var orders = Orders.Join(Shippers,
            //    o => o.ShipVia,
            //    s => s.ShipperID,
            //    (o, s) => new { Order = o, Shipper = s })
            //    .Where(s => s.Shipper.CompanyName.Contains("Speedy Express"));

            //var orders = Orders.Join(Shippers,
            //                    o => o.ShipVia,
            //                    s => s.ShipperID,
            //                    (o, s) => new { Order = o, Shipper = s })
            //                    .Where(s => s.Shipper.ShipperID==1);

            // 2- Using Query Expression

            //var orders = from s in Shippers
            //             join o in Orders
            //             on s.ShipperID equals o.ShipVia
            //             where s.ShipperID == 1
            //             select o;

            //foreach (var order in orders)
            //{
            //    Console.WriteLine(order.ToString());
            //}

            #endregion

            //4- Get the total number of orders placed by customer "BLAUS".
            #region 4- Get the total number of orders placed by customer "BLAUS"

            //1- Using Query Operator

            //var totalOrdersNum = 
            //    Orders.Join(Customers,
            //    o => o.CustomerID,
            //    c => c.CustomerID,
            //    (o, c) => new { Order = o, Customer = c })
            //    .Where(c => c.Customer.CustomerID.Contains("BLAUS"))
            //    .Count();

            // 2- Using Query Expression

            //var totalOrdersNum = (from o in Orders
            //                      join c in Customers
            //                      on o.CustomerID equals c.CustomerID
            //                      where c.CustomerID == "BLAUS"
            //                      select o).Count();
            //Console.WriteLine(totalOrdersNum);
            #endregion

            //5- List all employees who are managers.
            #region 5- List all employees who are managers

            //1- Using Query Operator

            //var employees = Employees
            //    .Where(employee=>Employees.Any(e=>e.ReportsTo==employee.EmployeeID))
            //    .Select(e=>new {Name=$"{e.FirstName} {e.LastName}" });

            // 2- Using Query Expression
            //var employees = from emp in Employees
            //                where Employees.Any(e => e.ReportsTo == emp.EmployeeID)
            //                select new { Name = $"{emp.FirstName} {emp.LastName}" };

            //foreach (var employee in employees)
            //{
            //    Console.WriteLine(employee);
            //}

            #endregion

            //6-Find products that are discontinued.

            #region 6-Find products that are discontinued.
            //1- Using Query Operator

            //var products = Products.Where(p => p.Discontinued)
            //    .Select(p=>p.ProductName);

            // 2- Using Query Expression

            //var products = from p in Products
            //               where p.Discontinued
            //               select p.ProductName;

            //foreach (var product in products)
            //{
            //    Console.WriteLine($"Product Name : {product}");
            //} 
            #endregion

            //7- Retrieve the names and phone numbers of all suppliers.
            #region 7- Retrieve the names and phone numbers of all suppliers.

            // 1- Using Query Operator
            //var query =
            //    Suppliers.Select(S => new
            //    {
            //        Name=S.ContactName,
            //        Phone=S.Phone
            //    });

            //// 2- Using Query Expression
            //var query =
            //    from S in Suppliers
            //    select new { Name = S.ContactName, Phone = S.Phone };
            //foreach(var item in query)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            //8- Get all orders placed in the year 1998.
            #region 8- Get all orders placed in the year 1998.

            //1 - Using Query Operator
            //var query =
            //    Orders.Where(O => O.OrderDate.Year == 1998);

            //2- Using Query Expression
            //var query =
            //    from O in Orders
            //    where O.OrderDate.Year == 1998
            //    select O;
            //foreach (var item in query)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            //9- Find all customers in the "USA".

            #region 9- Find all customers in the "USA".
            //1- Using Query Operator
            //var query =
            //    Customers.Where(C => C.Country == "USA");
            //2- Using Query Expression
            //var query =
            //    from C in Customers
            //    where C.Country == "USA"
            //    select C;
            //foreach (var item in query)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            //10- List products that belong to category "Beverages".
            #region 10- List products that belong to category "Beverages".
            // 1- Using Query Operator
            //var query =
            //    Products.Join(
            //        Categories,
            //        P => P.CategoryID,
            //        C => C.CategoryID,
            //        (P, C) => new { Product = P, Category = C })
            //    .Where(C => C.Category.CategoryName.Contains("Beverages"))
            //    .Select(P=>P.Product);
            //2- Using Query Expression
            //var query =
            //    from P in Products
            //    join C in Categories
            //    on P.CategoryID equals C.CategoryID
            //    where C.CategoryName.Contains("Beverages")
            //    select P;

            //foreach (var item in query)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            //11- Retrieve orders with a freight cost less than $20.
            #region 11- Retrieve orders with a freight cost less than $20.
            //1- Using Query Operator
            //var query =
            //    Orders.Where(O => O.Freight < 20);

            //2- Using Query Expression

            //var query =
            //    from O in Orders
            //    where O.Freight < 20
            //    select O;
            //foreach (var item in query)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            // Get the names and titles of all employees.

            // Find suppliers from "Germany".

            // List all products with quantities between 10 and 50.

            // Retrieve orders that were shipped but not yet delivered.

            // Get the total number of products in each category.

            // List all orders placed by employee with ID 5.

            // Find the name of the supplier with the highest ID.

            // Retrieve products that have "Box" in their quantity per unit description.

            // List all customers from "Germany".

            // Find all products that have never been ordered.

            // Get all orders with a freight cost greater than $50.

            // Retrieve names of all categories.

            // List all orders where the ship city is "Seattle".

            // Find the employees who have "Sales" in their title.

            // Retrieve orders that were placed in the month of June.

            // Get the names and phone numbers of suppliers from "Italy".

            // List all products with unit prices less than $20.

            // Find orders that were shipped in 1997.

            // Retrieve the names of all customers who have placed more than 5 orders.

            // List products with no quantity on order.

            // Get all categories with more than 10 products.

            // Find the customer with the most recent order.

            // Retrieve employees who work in "Sales".

            // List all products with a reorder level less than 10.

            // Find orders with a ship country of "USA" and a freight cost less than $20.

            // Get the names of suppliers who have a fax number.

            // List all orders placed in the first quarter of 1996.

            // Retrieve products that have a unit price between $20 and $50.

            // Find customers who have a postal code starting with "9".

            // List all employees with their address details.

            // Get all orders where the ship region is "CA".

            // Find all categories with at least one product in stock.

            // Retrieve the names and cities of customers who live in "USA".

            // List products supplied by supplier with ID 10.

            // Find all orders where the ship name contains "Express".

            // Get the details of products with more than 20 units in stock.

            // Retrieve all orders where the order date is in 1995.

            // List all suppliers from "Canada" who have a phone number starting with "416".

            // Find products that have been ordered more than 50 times.

            // Get the names of all employees who are not managers.

            // List orders where the ship country is "Mexico".

            // Retrieve all products with a quantity per unit description containing "bottle".

            // Find the top 5 products with the highest unit price.

            // Get all customers who have a contact title of "Owner".

            // List all employees who have their last name starting with "S".

            // Retrieve orders placed in the month of December.

            // Find products that are neither discontinued nor have a reorder level of 0.

            // Get the names of suppliers who have their country listed as "UK".

            // List all orders with a ship city of "London" and a freight cost greater than $30.

            // Retrieve all employees who were hired in 1997.

            // Find products that have been ordered by more than 10 different customers.

            // Get all categories that do not have any discontinued products.

            // List all customers who have a region specified.

            // Retrieve products where the unit price is greater than the average unit price.

            // Find the supplier with the most products.

            // Get all orders where the order date is after January 1, 1996.

            // List products with a unit price that is a multiple of 5.

            // Retrieve the names of customers who have placed at least 3 orders.

            // Find all orders shipped by "United Package".

            // Get the details of orders that were shipped in "Paris".

            // List products that have been discontinued and have a unit price greater than $30.

            // Retrieve employees who have not shipped any orders.

            // Find customers who have orders with a discount applied.

            // Get the top 3 most expensive products.

            // List all suppliers with a home page.

            // Retrieve orders where the freight cost is between $10 and $50.

            // Find products supplied by a supplier with the name "Exotic Liquids".

            // Get all orders that were required before the order date.

            // List products that have been ordered at least once in each year of the 1990s.

            // Retrieve all orders where the ship city is "Seattle" or "Portland".

            // Find employees who have more than one phone number listed.

            // Get the details of orders placed by the customer "ANATR".

            // List products with a quantity per unit description that includes "can".

            // Retrieve the names of all customers who have their contact name starting with "A".

            // Find all products with a unit price between $15 and $25.

            // Get all orders that were shipped in the year 1997 but required before 1996.

            // List all categories with at least one product that is not discontinued.

            // Retrieve the names of suppliers who do not have a fax number.

            // Find customers who live in cities starting with "S".

            // Get the total number of products for each supplier.

            // List all orders where the freight cost is exactly $15.

            // Retrieve employees who have a title containing "Manager".

            // Find products with a unit price that is not an integer.

            // Get the names of all employees whose last name is "Davies".

            // List all orders shipped by "Federal Shipping".

            // Retrieve products with a unit price less than $25 and greater than $10.

            // Find all customers with the same city as "Berlin".

            // Get the details of orders where the required date is within a week of the order date.

            // List all products that have been ordered but have a quantity per unit of "6 boxes".

            #endregion Easy

            #region Medium
            //1- List all products whose unit price is higher than the average unit price of all products.
            #region 1-List all products whose unit price is higher than the average unit price of all products.

            // 1-Using Query Operator
            //var avg = Products.Average(p => p.UnitPrice);
            //var products=Products.Where(p=>p.UnitPrice > avg);

            // 1-Using Query Expression
            //var products = from p in Products
            //               where p.UnitPrice > Products.Average(p=>p.UnitPrice)
            //               select p;
            //foreach(var product in products)
            //{
            //    Console.WriteLine(product);
            //} 
            #endregion

            //2-Retrieve the top 5 customers who have placed the highest number of orders.
            #region 2-Retrieve the top 5 customers who have placed the highest number of orders.
            // 1- Using Query Operator
            //var topCustomers = Orders
            //  .GroupBy(o => o.CustomerID)
            //  .OrderByDescending(g => g.Count())
            //  .Select(g => new
            //  {
            // CustomerID = g.Key,
            // OrderCount = g.Count()
            // })
            // .Take(5);

            //foreach (var customer in topCustomers)
            //{
            //   Console.WriteLine(customer);
            //} 
            #endregion

            // Find all employees who have processed orders in more than 3 different countries.

            // Get the total number of orders shipped by each shipper.

            // List all products that have been ordered more than the average quantity ordered per product.

            // Retrieve the names of all customers who have ordered products from more than 5 different categories.

            // Find suppliers that have provided products in more than 3 different categories.

            // Get the details of the order with the maximum freight cost.

            // List all employees who have shipped orders to more than 10 different cities.

            // Retrieve all orders that were placed by customers from the same country as the employee who processed them.

            // Find the products that have the highest average discount applied.

            // Get the total number of products supplied by each supplier.

            // List all orders where the total freight cost exceeds the average freight cost of all orders.

            // Retrieve the names and addresses of all customers who have not placed any orders.

            // Find the employee with the most recent hire date.

            // Get all orders that were shipped on the same date they were ordered.

            // List all products with a unit price that is greater than the median unit price.

            // Retrieve the average freight cost for each shipper.

            // Find suppliers that have their contact title starting with "Sales".

            // Get the names of all customers who have ordered products with a unit price greater than $100.

            // List products that have a reorder level higher than the average reorder level of all products.

            // Retrieve the top 3 cities with the most customers.

            // Find orders that have a freight cost below the average freight cost for the year 1997.

            // Get the details of the orders shipped by "Speedy Express" in 1996.

            // List all products with a quantity per unit that contains the word "Pack".

            // Retrieve the names of employees who have processed orders in more than 2 different regions.

            // Find the supplier with the most products that have been ordered more than 50 times.

            // Get the total sales amount for each customer.

            // List all customers who have their postal code starting with "9" and have ordered products from more than 3 different categories.

            // Retrieve the average unit price of products in the "Beverages" category.

            // Find the product with the highest unit price and list its supplier details.

            // Get all orders that were placed by customers who have the same contact name as the employee who processed them.

            // List the names of customers and the number of orders they have placed in the year 1996.

            // Retrieve all products with a unit price greater than $30 and with quantities in stock less than the average.

            // Find all employees who have processed orders with a total freight cost above $100.

            // Get the total number of products in each category and list them in descending order.

            // List all orders where the total freight cost is above the average freight cost for orders shipped by "United Package".

            // Retrieve the names of suppliers who have provided products in the "Seafood" category.

            // Find all products that have been ordered in the last 6 months.

            // Get the names of customers who have ordered products supplied by more than 5 different suppliers.

            // List the total number of orders placed by each customer and sort by descending order count.

            // Retrieve employees who have shipped orders to cities in more than 3 different countries.

            // Find the products that are in stock but have never been ordered.

            // Get the total freight cost for each shipper and list them in ascending order.

            // List all categories that have at least one product with a unit price above the average for its category.

            // Retrieve the names and addresses of suppliers who have shipped products to "Paris".

            // Find the customers with the highest average order amount.

            // Get all products that have a unit price less than the average unit price and have never been discontinued.

            // List all orders where the shipping address is in a country that has more than 3 suppliers.

            // Retrieve the names of employees who have processed orders for products in the "Snacks" category.

            // Find the suppliers that have their company name containing the word "Deluxe".

            // Get the details of orders that were shipped to "Tokyo" and have a freight cost above the average.

            // List the products with the highest quantity ordered for each category.

            // Retrieve the names of customers who have not ordered any products from the "Seafood" category.

            // Find all employees who have shipped orders with a total freight cost of less than $20.

            // Get the total number of orders placed by each customer and filter for those with more than 10 orders.

            // List all products that are supplied by suppliers with the highest ID.

            // Retrieve the names and addresses of customers who have ordered products from more than 3 different categories.

            // Find the product with the lowest unit price and list its supplier details.

            // Get all orders where the order date is before the ship date.

            // List all suppliers who have provided products with a unit price above $50.

            // Retrieve the total freight cost for each order and list in descending order.

            // Find customers who have placed orders in every month of the year 1996.

            // Get the names of employees who have not shipped orders to "New York".

            // List all products with a quantity per unit containing the word "Bottle" or "Can".

            // Retrieve the names of suppliers who have a contact name containing "James".

            // Find all orders that were shipped with a freight cost above the average for orders shipped by "Federal Shipping".

            // Get the total number of products in stock for each category and sort in ascending order.

            // List all products that have a unit price higher than the average for their respective categories.

            // Retrieve the names of employees who have shipped orders to customers with a postal code starting with "9".

            // Find suppliers that have provided products with a unit price less than $25 and more than $50.

            // Get all orders that were placed in the month of July and shipped by "United Package".

            // List the top 5 cities with the highest number of shipped orders.

            // Retrieve the names and contact details of suppliers who have provided products in the "Confections" category.

            // Find all products that are currently out of stock but have been ordered in the past year.

            // Get the total number of products supplied by each supplier and list in descending order.

            // List all customers with a contact title of "Sales Representative" and who have ordered more than 3 products.

            // Retrieve the names of employees who have processed orders for the highest number of products.

            // Find the suppliers that have the same contact title as the employee with the most orders.

            // Get all orders that were shipped with a discount applied.

            // List the products with the highest quantity per unit and their respective suppliers.

            // Retrieve the names and addresses of customers who live in cities where the average order amount is above $200.

            // Find all products that have been ordered more than the average quantity ordered per product in the "Condiments" category.

            // Get the details of the orders that were shipped to "Berlin" and have a freight cost above $50.

            // List all categories with at least 10 products and sort by the total quantity of products in stock.

            // Retrieve the names of suppliers who have the highest number of products in the "Dairy Products" category.

            // Find all orders where the order date is within the first quarter of 1996 and the freight cost is less than $30.

            // Get the total sales amount for each employee and list them in descending order.

            // List all products with a unit price greater than the average price in their category and with a reorder level above 10.

            // Retrieve the names of customers who have placed orders in every month of 1997.

            // Find the products that have the highest quantity ordered and were supplied by suppliers from "Italy".

            // Get all orders where the ship city is "Seattle" and the order amount is greater than $100.

            // List all employees who have shipped products with a quantity greater than the average quantity ordered.

            // Retrieve the names of suppliers who have provided products with a unit price between $20 and $40.

            // Find the top 10 products with the highest total quantity ordered.

            // Get all orders where the required date is before the order date and the freight cost is below $25.

            // List the names and contact titles of suppliers who have shipped products in the "Seafood" category.

            // Retrieve the names of employees who have processed orders for more than 5 different categories.

            // Find all products that have been ordered by customers with a postal code starting with "1" and are in stock.

            // Get the total number of orders placed by customers from each city and list them in descending order.

            #endregion Medium

            #region Hard
            // Retrieve the top 5 customers who have the highest total order amount and list their order count.

            // Find the average discount applied to orders for each product category.

            // Get the names of employees who have shipped orders with a freight cost above the median freight cost of all orders.

            // List all products that are supplied by the supplier with the most products and have been ordered more than the average quantity.

            // Retrieve the top 3 categories with the highest average product unit price.

            // Find the customers who have ordered products from every category at least once.

            // Get the details of the order with the longest time between order date and required date.

            // List all suppliers who have not supplied products to any orders in the year 1996.

            // Retrieve the total number of products ordered for each product and compare it to the total stock quantity.

            // Find all products that have a reorder level equal to the maximum reorder level for their category.

            // Get the names of all customers who have ordered products from suppliers with more than 5 products.

            // List the employees who have processed orders for customers in more than 4 different countries.

            // Retrieve the names of categories where the average unit price of products is greater than the overall average unit price.

            // Find the suppliers who have provided products with a quantity per unit description that includes both "Box" and "Pack".

            // Get all orders where the total order amount is greater than the average order amount for the year 1997.

            // List products that have been ordered in every month of 1996 and have a unit price above $20.

            // Retrieve the names of customers who have placed orders in every year from 1995 to 1997.

            // Find all orders with a freight cost greater than the average freight cost of orders shipped by "Federal Shipping" and "United Package".

            // Get the total number of orders placed by customers who live in cities with more than 3 suppliers.

            // List all products that have been ordered by customers from more than 5 different regions.

            // Retrieve the names of employees who have shipped orders with the maximum discount applied.

            // Find the top 10 products that have been ordered the most in the last 6 months.

            // Get the details of orders where the ship country is the same as the supplier's country.

            // List all categories with products that have never been discontinued and have been ordered more than 10 times.

            // Retrieve the average quantity ordered for each product and compare it to the average stock quantity.

            // Find the customers who have ordered products from suppliers in at least 3 different countries.

            // Get all products that have a unit price within the range of the top 5 % most expensive products in their category.

            // List employees who have processed orders for products in every category.

            // Retrieve the total number of products ordered for each category and sort by descending total quantity.

            // Find the orders that have a ship city different from the customer’s city.

            // Get the details of the top 5 most recent orders and the names of the employees who processed them.

            // List all products with a unit price higher than the average unit price for their supplier.

            // Retrieve the names of suppliers who have a contact title of "Owner" and have provided products in the "Beverages" category.

            // Find the top 5 customers with the highest average order value and the number of orders they have placed.

            // Get all products that have been ordered in the last year and have a reorder level greater than the average reorder level.

            // List the employees who have processed orders for customers with a postal code starting with "9" and "8".

            // Retrieve the total order amount for each category and list them in descending order.

            // Find the suppliers who have not supplied products to any customers with orders in 1997.

            // Get the names of customers who have placed orders with products that have a unit price higher than the average unit price of products in their category.

            // List all products that have been ordered by customers from cities with the top 3 highest order counts.

            // Retrieve the names and contact titles of suppliers who have shipped products to "Paris" and "London".

            // Find all orders with a freight cost that is above the median freight cost and was shipped by "Speedy Express".

            // Get the top 5 products with the highest average discount applied and list their total quantity ordered.

            // List all employees who have shipped orders with a total freight cost above the average for the year 1996.

            // Retrieve the total number of products in stock for each category where the average unit price is above $30.

            // Find the customers who have placed orders with a discount applied and have ordered products from at least 4 different suppliers.

            // Get all products that have a unit price greater than the average for their supplier and have been ordered more than 10 times.

            // List all categories with products that have a reorder level equal to the average reorder level of products in their category.

            // Retrieve the names of suppliers who have provided products in the "Seafood" category and have a fax number.

            // Find the top 5 cities with the highest total order amount and list the number of customers in each city.

            // Get the details of orders where the ship name contains "Express" and the freight cost is above $40.

            // List the top 3 most expensive products in each category and retrieve their supplier details.

            // Retrieve the total number of orders placed by customers with a postal code starting with "1" and "2".

            // Find the products that have a quantity per unit description containing "Can" or "Pack" and have been ordered more than the median quantity.

            // Get the names of customers who have placed orders with products that have the highest total quantity ordered.

            // List all orders where the ship city is different from the customer’s city and the order amount is above the average.

            // Retrieve the names of employees who have shipped orders with a total quantity of products ordered above the average.

            // Find the top 10 products with the highest unit price that have been ordered in the last year.

            // Get the details of orders where the ship country is the same as the supplier’s country and the freight cost is above the average.

            // List all products that have been ordered by customers in cities with a total order amount greater than $1000.

            // Retrieve the names of suppliers who have provided products with a unit price less than $20 and more than $50.

            // Find the categories with products that have never been discontinued and have been ordered in every month of the last year.

            // Get the total number of orders for each category where the average order amount is greater than $200.

            // List all customers who have placed orders in every month of the last year and have a postal code starting with "1".

            // Retrieve the names of employees who have processed orders for the highest number of products and their total order amount.

            // Find the suppliers who have the highest number of products in categories where the average unit price is above $30.

            // Get all products that have a unit price higher than the median unit price in their category and have been ordered more than 20 times.

            // List all orders where the freight cost is above the average for the year 1997 and the order date is before the ship date.

            // Retrieve the top 5 customers with the highest average discount applied and their total order amount.

            // Find the products that have been ordered more than the average quantity ordered for their category and have a unit price above $25.

            // Get the names of suppliers who have provided products with a quantity per unit description containing "Bottle" and "Can".

            // List all employees who have shipped orders with a freight cost above the average and have processed orders for customers in more than 3 different countries.

            // Retrieve the total number of products in stock for each category where the reorder level is above the average for products in their category.

            // Find the customers who have placed orders for products in categories where the average quantity ordered is above 50.

            // Get all orders where the ship city is the same as the customer’s city and the order amount is above the median order amount.

            // List all categories with products that have a reorder level less than the average reorder level for their category and have been ordered more than 5 times.

            // Retrieve the names of suppliers who have provided products with a unit price within the range of the top 5 % most expensive products.

            // Find the top 10 cities with the most customers and list the total order amount for each city.

            // Get the details of orders where the ship country is "USA" and the order amount is greater than the average order amount for the year 1996.

            // List all products with a unit price greater than the average unit price in their category and have been ordered in the last 6 months.

            // Retrieve the names of employees who have shipped orders to customers with postal codes starting with "9" and "8" and have processed more than 20 orders.

            // Find the top 5 suppliers with the highest total quantity of products supplied and list their contact details.

            // Get all orders where the total order amount is greater than the average for orders shipped by "Speedy Express" and "United Package".

            // List all products that have been ordered in every year from 1995 to 1997 and have a reorder level higher than the average for their category.

            // Retrieve the names of suppliers who have provided products with a quantity per unit description containing "Pack" and "Box" and have a contact title starting with "Sales".

            // Find the customers who have placed orders with a discount applied and have ordered products from more than 5 different categories.

            // Get the total number of orders placed by customers who have ordered products in every month of the year 1997.

            // List all products with a unit price that is within the range of the average unit price plus one standard deviation for their category.

            // Retrieve the names of employees who have processed orders with the maximum number of products ordered and their total freight cost.

            // Find the top 3 categories with the highest total quantity of products ordered and list their average unit price.

            // Get all orders where the order amount is above the average for orders shipped by "Federal Shipping" and "Speedy Express".

            // List all suppliers who have shipped products to "London" and "Paris" and have provided products in the "Beverages" category.

            // Retrieve the names of customers who have ordered products from suppliers in more than 5 different countries.

            // Find the products that have been ordered more than the median quantity ordered and have a unit price above $30.

            // Get the total order amount for each employee and list them in descending order of the total amount.

            // List all categories with products that have a unit price higher than the median unit price for their category and have been ordered more than 10 times.

            // Retrieve the names of suppliers who have provided products with a quantity per unit description containing "Bottle" or "Pack" and have a fax number.

            // Find the top 5 products with the highest quantity ordered in the last year and their total order amount.

            // Get all orders where the ship country is "USA" and the order date is within the first quarter of 1997.

            // List all products that have a unit price within the range of the top 10 % most expensive products and have been ordered in every month of the last year.


            #endregion Hard
        }
    }
}