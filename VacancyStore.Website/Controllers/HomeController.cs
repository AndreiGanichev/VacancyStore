using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VacancyStore.DataAccess.Repositories;

namespace VacancyStore.Website.Controllers
{
    public class HomeController : Controller
    {
        private IVacancyRepository _vacancyRepository;

        public HomeController(IVacancyRepository vacancyRepository) : base()
        {
            _vacancyRepository = vacancyRepository;
        }

        public ActionResult Index()
        {
            var vacancies = _vacancyRepository.Get();
            return View(vacancies.ToList());
        }
    }
}