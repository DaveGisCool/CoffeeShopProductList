using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Data.SqlClient;
using Dapper;
using CoffeeShopLab13_2.Models;

namespace CoffeeShopLab13_2.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            IDbConnection db = new SqlConnection("Server=6497Q13\\SQLEXPRESS;Database=CoffeeLab;user id=TestUser;password=password");
            db.Open();

            List<Products> prods = db.Query<Products>("SELECT * FROM Product").AsList<Products>();

            db.Close();
            return View(prods);
        }

        public IActionResult Drink()
        {
            IDbConnection db = new SqlConnection("Server=6497Q13\\SQLEXPRESS;Database=CoffeeLab;user id=TestUser;password=password");
            db.Open();

            List<Products> prods = db.Query<Products>("SELECT * FROM Product").AsList<Products>();

            db.Close();
            return View(prods);
        }

        public IActionResult Products(int ID)
        {
            IDbConnection db = new SqlConnection("Server=6497Q13\\SQLEXPRESS;Database=CoffeeLab;user id=TestUser;password=password");
            db.Open();

            Products prod = db.QuerySingle<Products>($"SELECT * FROM Product WHERE ID = {ID}");

            db.Close();
            return View(prod);
        }

        public IActionResult Results()
        {
            
            return View();
        }
    }
}
