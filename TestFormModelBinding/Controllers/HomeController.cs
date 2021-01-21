using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestFormModelBinding.Models;

namespace TestFormModelBinding.Controllers
{
    public class HomeController : Controller
    {
        public static BulkEditViewModel CreateBulkEditViewModel()
        {
            BulkEditViewModel bulkEditViewModel = new BulkEditViewModel();
            bulkEditViewModel.PersonModels.Add(new PersonModel()
            {
                Id = 1,
                Name = "Christian"
            });
            bulkEditViewModel.PersonModels.Add(new PersonModel()
            {
                Id = 2,
                Name = "Tobias"
            });
            bulkEditViewModel.PersonModels.Add(new PersonModel()
            {
                Id = 3,
                Name = "Tina"
            });
            bulkEditViewModel.PersonModels.Add(new PersonModel()
            {
                Id = 4,
                Name = "Michael"
            });
            bulkEditViewModel.PersonModels.Add(new PersonModel()
            {
                Id = 5,
                Name = "Nina"
            });
            bulkEditViewModel.PersonModels.Add(new PersonModel()
            {
                Id = 6,
                Name = "Jens"
            });
            return bulkEditViewModel;
        }
        
        public ActionResult Index()
        {
            return View(CreateBulkEditViewModel());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Start(BulkEditViewModel bulkEditViewModel)
        {
            var bulkEditViewModelWithout3 = bulkEditViewModel.PersonModels.Where(p => p.Id != 3).ToList();
            return View("Index",new BulkEditViewModel()
            {
                PersonModels = bulkEditViewModelWithout3
            });
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            return View();
        }
    }
}