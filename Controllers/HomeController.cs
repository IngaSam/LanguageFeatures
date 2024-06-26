﻿using LanguageFeatures.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
namespace LanguageFeatures.Controllers
{
    public class HomeController: Controller
    {
        public ViewResult Index()
        {
            ShoppingCart cart = new ShoppingCart
            {
                Products = Product.GetProducts()
            };
            decimal cartTotal = cart.TotalPrices();
            return View("Index", new string[] {$"Total: {cartTotal:C2}"});
        }
    }
}