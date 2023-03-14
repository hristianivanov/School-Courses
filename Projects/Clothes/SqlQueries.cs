using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clothes
{
    internal static class SqlQueries
    {
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
