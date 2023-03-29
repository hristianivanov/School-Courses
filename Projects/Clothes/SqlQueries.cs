using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clothes
{
    internal static class SqlQueries
    {
        public const string ShowProductSizes =
            @"SELECT 
                p.[name] AS [product],
                s.[name] AS [size] 
              FROM products AS p 
              JOIN product_categories AS pc 
              ON pc.product_id = p.id 
              JOIN categories AS c 
              ON c.id = pc.category_id 
              JOIN product_sizes AS ps 
              ON ps.product_id = p.id 
              JOIN sizes AS s 
              ON s.id = ps.size_id";
        public const string ShowProductPrice =
            @"SELECT [name], [price] FROM products ORDER BY [name]";
        public const string ShowAllUsers =
            @"SELECT username,email FROM users";
        public const string ResetPrices = 
            @"UPDATE products SET price = 49.99 WHERE id = 1 
              UPDATE products SET price = 15.99 WHERE id = 2
              UPDATE products SET price = 59.99 WHERE id = 3
              UPDATE products SET price = 24.99 WHERE id = 4
              UPDATE products SET price = 39.99 WHERE id = 5
              UPDATE products SET price = 49.99 WHERE id = 6
              UPDATE products SET price = 119.99 WHERE id = 7
              UPDATE products SET price = 14.99 WHERE id = 8
              UPDATE products SET price = 39.99 WHERE id = 9
              UPDATE products SET price = 29.99 WHERE id = 10
              UPDATE products SET price = 34.99 WHERE id = 11
              UPDATE products SET price = 49.99 WHERE id = 12";
        public const string SetSeventyPercentSale =
            @"UPDATE products SET price = price * 0.3";
        public const string SetSixtyPercentSale =
            @"UPDATE products SET price = price * 0.4";
        public const string SetFiftyPercentSale =
            @"UPDATE products SET price = price * 0.5";
        public const string SetTwentyFivePercentSale =
            @"UPDATE products SET price = price * 0.75";
        public const string GetAllProductAndCategory =
            @"SELECT
	                    p.[name] AS [Product],
	                    c.[name] AS [Category]
                FROM products AS p
                LEFT JOIN product_categories AS pc
                ON pc.product_id = p.id
                LEFT JOIN categories AS c
                ON c.id = pc.category_id";

        public const string GetCountOfCloth =
            @"SELECT COUNT(*) AS [Count]
                FROM
                (
                		SELECT
                			p.[name] AS [Product],
                			c.[name] AS [Category]
                		FROM products AS p
                		LEFT JOIN product_categories AS pc
                		ON pc.product_id = p.id
                		LEFT JOIN categories AS c
                		ON c.id = pc.category_id
                ) AS subQuery
                WHERE Category = @cloth";

        public const string ProductPrice =
            @"SELECT 
                	[name],
                	price
                FROM products";

        public const string SetPromotion =
            @"UPDATE products SET price = price * @promotion";
    }
}
