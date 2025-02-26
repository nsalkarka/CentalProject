﻿using AutoMapper;
using Cental.BusinessLayer.Abstract;
using Cental.DtoLayer.BannerDtos;
using Cental.EntityLayer.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Cental.WebUI.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminBannerController(IBannerService _bannerService,IMapper _mapper) : Controller
    {
       // private readonly IBannerService _bannerService;
       // private readonly IMapper _mapper;

        //public AdminBannerController(IBannerService bannerService, IMapper mapper)
        //{
          //  _bannerService = bannerService;
            //_mapper = mapper;
        //}

        public IActionResult Index()
        {
            var values= _bannerService.TGetAll();
            var banners= _mapper.Map<List<ResultBannerDto>>(values);
            return View(banners);
        }

        public IActionResult CreateBanner() 
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateBanner(CreateBannerDto model)
        {
            var banner=_mapper.Map<Banner>(model);
            _bannerService.TCreate(banner);
            return RedirectToAction("Index");
        }
    }
}
