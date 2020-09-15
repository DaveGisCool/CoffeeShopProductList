using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Dapper.Contrib.Extensions;

namespace CoffeeShopLab13_2.Models
{
    [Table("Product")]

    public class Products
    {
        [Key]
        public long ID { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }


        public static Products Create(string _name, Decimal _price)
        {
            // CREATE the new Product instance
            Products prod = new Products() { Name = _name, Price = _price };

            // SAVE the instance to the database
            IDbConnection db = new SqlConnection("Server=6497Q13\\SQLEXPRESS;Database=CoffeeLab;user id=TestUser;password=password");
            long _ID = db.Insert<Products>(prod);

            // SET the id column of the instance
            prod.ID = _ID;

            // RETURN the instance
            return prod;
        }

        public static void Delete(long _ID)
        {
            IDbConnection db = new SqlConnection("Server=6497Q13\\SQLEXPRESS;Database=CoffeeLab;user id=TestUser;password=password");
            db.Delete(new Products() { ID = _ID });
        }
    }
}
