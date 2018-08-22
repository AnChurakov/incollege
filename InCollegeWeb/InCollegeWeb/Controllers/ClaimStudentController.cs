using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using InCollegeWeb.Models;

namespace InCollegeWeb.Controllers
{
    public class ClaimStudentController : Controller
    {
        ApplicationDbContext context = new ApplicationDbContext();

        [Authorize]
        public ActionResult Index()
        {
            return View(context.ClaimStudents.ToList());
        }

        [Authorize]
        public ClaimStudent GetClaimStudent(Guid Id)
        {
            var select = context.ClaimStudents.FirstOrDefault(a => a.Id == Id);

            return select;
        }

        [Authorize]
        public ActionResult SelectSingleClaim(Guid Id)
        {
            var select = GetClaimStudent(Id);

            return View(select);
        }
    }
}