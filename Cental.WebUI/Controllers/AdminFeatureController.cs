using AutoMapper;
using Cental.BusinessLayer.Abstract;
using Cental.DtoLayer.FeatureDtos;
using Cental.EntityLayer.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Cental.WebUI.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminFeatureController(IFeatureService _featureService,IMapper _mapper) : Controller
    {
        public IActionResult Index()
        {
            var values= _featureService.TGetAll();
            var features=_mapper.Map<List<ResultFeatureDto>>(values);
            return View(features);
        }

        public IActionResult CreateFeature()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateFeature(CreateFeatureDto _createFeatureDto)
        {
            var feature= _mapper.Map<Feature>(_createFeatureDto);
            _featureService.TCreate(feature);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteFeature(int id)
        {
            _featureService.TDelete(id);
            return RedirectToAction("Index");
        }

        public IActionResult UpdateFeature(int id)
        {
            var value= _featureService.TGetById(id);
            var feature=_mapper.Map<UpdateFeatureDto>(value);
            return View(feature);
        }

        [HttpPost]
        public IActionResult UpdateFeature(UpdateFeatureDto _updateFeatureDto)
        {
            var feature=_mapper.Map<Feature>(_updateFeatureDto);
            _featureService.TUpdate(feature);
            return RedirectToAction("Index");
        }

    }
}
