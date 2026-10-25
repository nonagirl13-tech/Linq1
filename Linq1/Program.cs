using LINQ.DataSources;

namespace Linq1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            /* var result = Source.ProductList
            .Where(p => p.Category == "Seafood");

             foreach (var product in result)
             {
                 Console.WriteLine($"{product.ProductName} - {product.UnitPrice}");
             }*/

            #endregion
            #region Q2
            /*var result = Source.ProductList
            .Select(p => p.ProductName);

            foreach (var name in result)
            {
                Console.WriteLine(name);
            }*/
            #endregion
            #region Q3
            /* var result3 = Source.ProductList
             .OrderBy(p => p.UnitPrice);

             foreach (var product in result3)
             {
                 Console.WriteLine($"{product.ProductName} - {product.UnitPrice}");
             }*/
            #endregion
            #region Q4
            /*var result4 = Source.ProductList
            .Where(p => p.UnitPrice >= 10 && p.UnitPrice <= 30);

            foreach (var product in result4)
            {
                Console.WriteLine($"{product.ProductName} - {product.UnitPrice}");
            }*/


            #endregion
            #region Q5

            /* var result5 = Source.ProductList
             .Where(p => p.UnitsInStock > 0 &&
                  p.Category == "Spices & Condiments");

             foreach (var product in result5)
             {
                 Console.WriteLine(
                     $"{product.ProductName} - Stock: {product.UnitsInStock}");
             }*/
            #endregion
            #region Q6
            /* var result6 = Source.ProductList.Select(p => new
             {
                 Name = p.ProductName,
                 Price = p.UnitPrice,
                 StockStatus = p.UnitsInStock > 0 ? "Available" : "Out of Stock"
             });

             foreach (var product in result6)
             {
                 Console.WriteLine($"{product.Name} - Price: {product.Price} - {product.StockStatus}");
             }
            */
            #endregion
            #region Q7
            /*var result7 = Source.ProductList
            .Select((p, index) => new
             {
             Position = index + 1,
             Name = p.ProductName
              });

            foreach (var product in result7)
            {
                Console.WriteLine($"{product.Position}. {product.Name}");
            }*/
            #endregion
            #region Q8
            /* var result8 = Source.ProductList
             .OrderBy(p => p.Category)
             .ThenByDescending(p => p.UnitPrice);

             foreach (var product in result8)
             {
                 Console.WriteLine($"{product.Category} - {product.ProductName} - {product.UnitPrice}");
             }*/
            #endregion
            #region Q9
            /* var result9 = Source.ProductList
            .Where(p => p.Category == "Beverages")
            .OrderByDescending(p => p.UnitsInStock);

             foreach (var product in result9)
             {
                 Console.WriteLine($"{product.ProductName} - Stock: {product.UnitsInStock}");
             }*/
            #endregion
            #region Q10
            /* var result10 =
             from customer in Source.CustomerList
             from order in customer.Orders
             where order.OrderDate >= new DateTime(1997, 1, 1)
             select new
              {
              customer.CustomerID,
              order.OrderDate
              };

             foreach (var order in result10)
             {
                 Console.WriteLine($"{order.CustomerID} - {order.OrderDate:yyyy-MM-dd}");
             }*/
            #endregion
            #region Q11
            /* var result11 = Source.ProductList
             .Select((p, index) => new
              {
              Position = index + 1,
              ProductName = p.ProductName
              });

             foreach (var product in result11)
             {
                 Console.WriteLine($"{product.Position} - {product.ProductName}");
             }*/
            #endregion
            #region Q12
            /*string[] arr12 = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            var result12 = arr12
                .OrderBy(word => word.Length)
                .ThenBy(word => word, StringComparer.OrdinalIgnoreCase);

            foreach (var word in result12)
            {
                Console.WriteLine(word);
            }*/
            #endregion
            #region Q13
            string[] arr13 = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            var result13 = arr13
                .Where(word => word.Length > 1 &&
                               char.ToLower(word[1]) == 'i')
                .Reverse()
                .ToList();

            foreach (var word in result13)
            {
                Console.WriteLine(word);
            }

            #endregion



        }
    }
}
