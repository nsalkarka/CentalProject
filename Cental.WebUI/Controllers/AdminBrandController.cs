﻿using Cental.BusinessLayer.Abstract;
using Cental.EntityLayer.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Cental.WebUI.Controllers
{
    public class AdminBrandController(IBrandService _brandService) : Controller
    {
        
        public IActionResult Index()
        {
            var values = _brandService.TGetAll();
            return View(values);
        }

        public IActionResult DeleteBrand(int id) 
        {
            _brandService.TDelete(id);
            return RedirectToAction("Index");
        }

        public IActionResult CreateBrand() 
        { 
            return View();  
        }

        [HttpPost]
        public IActionResult CreateBrand(Brand model) 
        {
            _brandService.TCreate(model);
            return RedirectToAction("Index");
        }
    }
}
