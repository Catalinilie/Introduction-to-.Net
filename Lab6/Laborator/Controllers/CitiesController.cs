using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Laborator.Business;
using Laborator.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace Laborator.Controllers
{
    public class CitiesController : Controller
    {
        private readonly IRepository _repository;

        public CitiesController(IRepository rep)
        {
            _repository = rep;
        }
        public IActionResult Index()
        {
            var cities = _repository.GetCity();
            var citiesVM = new List<CityViewModel>();
            foreach (var t in cities)
            {
                citiesVM.Add(new CityViewModel
                {
                    Description =t.Description,
                    Name=t.Name
                });
            }
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
        public IActionResult Edit()
        {
            return View();
        }
        public IActionResult Delete()
        {
            return View();
        }
    }
}