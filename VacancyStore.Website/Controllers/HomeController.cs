using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VacancyStore.DataAccess.Common.Models;
using VacancyStore.DataAccess.Repositories;
using VacancyStore.Website.Models;

namespace VacancyStore.Website.Controllers
{
    public class HomeController : Controller
    {
        private IVacancyRepository _vacancyRepository;
        private int _itemsPerPage = Int32.Parse(ConfigurationManager.AppSettings["ItemsPerPage"]);

        public HomeController(IVacancyRepository vacancyRepository) : base()
        {
            _vacancyRepository = vacancyRepository;
        }

        public ActionResult Index(int page = 1)
        {
            long totalItemsCount;
            var vacancies = _vacancyRepository.Get(out totalItemsCount, true, page, _itemsPerPage);
            var pageInfo = new PageInfo<Vacancy>(vacancies, page, _itemsPerPage, totalItemsCount);
            return View(pageInfo);
        }
    }
}