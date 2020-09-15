using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Data.SqlClient;
using Dapper;
using CoffeeShopLab13_2.Models;

namespace CoffeeShopLab13_2.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            IDbConnection db = new SqlConnection("Server=6497Q13\\SQLEXPRESS;Database=CoffeeLab;user id=TestUser;password=password");
            db.Open();

            List<Products> prods = db.Query<Products>("SELECT * FROM Product").AsList<Products>();

            db.Close();
            return View(prods);
        }

        public IActionResult Edit(long _ID)
        {
            IDbConnection db = new SqlConnection("Server=6497Q13\\SQLEXPRESS;Database=CoffeeLab;user id=TestUser;password=password");
            db.Open();

            

            db.Close();
            return View();
        }

        public IActionResult Create()
        {
            IDbConnection db = new SqlConnection("Server=6497Q13\\SQLEXPRESS;Database=CoffeeLab;user id=TestUser;password=password");
            db.Open();

            

            db.Close();
            return View();
        }
    }
}
