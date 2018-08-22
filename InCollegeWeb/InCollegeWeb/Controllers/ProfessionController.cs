using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using InCollegeWeb.Models;

namespace InCollegeWeb.Controllers
{
    public class ProfessionController : Controller
    {
        ApplicationDbContext context = new ApplicationDbContext();

        [Authorize]
        public ActionResult Index()
        {
            return View(context.Professions.ToList());
        }

        [Authorize]
        [HttpPost]
        public RedirectToRouteResult Delete(Guid Id)
        {
            var _select = GetProf(Id);

            context.Professions.Remove(_select);

            return RedirectToAction("Index");
        }

        [Authorize]
        public Profession GetProf(Guid Id)
        {
            var _selectProf = context.Professions.FirstOrDefault(a => a.Id == Id);

            return _selectProf;
        }

        [Authorize]
        public ActionResult Add()
        {
            return View();
        }

        [Authorize]
        [HttpPost]
        public RedirectToRouteResult AddProfession(Profession model)
        {
            if (ModelState.IsValid)
            {
                Profession prof = new Profession
                {
                    Id = Guid.NewGuid(),
                    Name = model.Name,
                       
                };

                context.Professions.Add(prof);
                context.SaveChanges();
            }

            return RedirectToAction("Add");
        }
    }
}