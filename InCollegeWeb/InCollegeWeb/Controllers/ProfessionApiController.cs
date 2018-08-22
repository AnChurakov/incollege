using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using InCollegeWeb.Models;

namespace InCollegeWeb.Controllers
{
    public class ProfessionApiController : ApiController
    {
        ApplicationDbContext context = new ApplicationDbContext();
       
        public IEnumerable<Profession> GetAllProfessions()
        {
            return context.Professions;
        }
    }
}
