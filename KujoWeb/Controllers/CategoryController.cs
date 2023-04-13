﻿using KujoWeb.Data;
using KujoWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace KujoWeb.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;
        public CategoryController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Category> objCategoryList = _db.Categories;
            
            return View(objCategoryList);
        }
    }
}
