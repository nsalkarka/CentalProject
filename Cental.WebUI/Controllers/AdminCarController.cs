﻿using AutoMapper;
using Cental.BusinessLayer.Abstract;
using Cental.DtoLayer.CarDtos;
using Cental.DtoLayer.Enums;
using Cental.EntityLayer.Entities;
using Cental.WebUI.Extensions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Cental.WebUI.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminCarController(ICarService _carService,IMapper _mapper, IBrandService _brandService): Controller
    {
        private void GetValuesinDropDown()
        {
            ViewBag.gasTypes = GetEnumValues.GetEnums<GasTypes>();
            ViewBag.gearTypes = GetEnumValues.GetEnums<GearTypes>();
            ViewBag.transmissions = GetEnumValues.GetEnums<Transmissions>();
            ViewBag.brands = (from x in _brandService.TGetAll()
                              select new SelectListItem
                              {
                                  Text = x.BrandName,
                                  Value = x.BrandId.ToString()
                              }).ToList();
        }

        public IActionResult Index()
        {
            var values=_carService.TGetAll();
            return View(values);
        }

        public IActionResult CreateCar()
        {
            GetValuesinDropDown();

            return View();
        }

        [HttpPost]
        public IActionResult CreateCar(CreateCarDto model) 
        {
            GetValuesinDropDown();
            var newCar=_mapper.Map<Car>(model);
            _carService.TCreate(newCar);
            return RedirectToAction("Index");   
        
        }

        public IActionResult DeleteCar(int id)
        {
            _carService.TDelete(id);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult UpdateCar(int id)
        {
            GetValuesinDropDown();
            var value=_carService.TGetById(id);
           var car= _mapper.Map<UpdateCarDto>(value);
            return View(car);

        }

        [HttpPost]
        public IActionResult UpdateCar(UpdateCarDto updateCarDto)
        {
            GetValuesinDropDown();
            var cars= _mapper.Map<Car>(updateCarDto);
            _carService.TUpdate(cars);
            return RedirectToAction(nameof(Index));
        }

    }
}
