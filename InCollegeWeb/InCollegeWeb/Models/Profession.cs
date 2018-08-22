using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using InCollegeWeb.Models;

namespace InCollegeWeb.Models
{
    public class Profession
    {

        public Guid Id { get; set; }

        [Required(ErrorMessage = "Это обязательное поле")]
        public string Name { get; set; }

        public IEnumerable<ClaimStudent> ClaimStudents { get; set; }
        
    }
}