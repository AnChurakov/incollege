using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using InCollegeWeb.Models;

namespace InCollegeWeb.Models
{
    public class ClaimStudent
    {
        public Guid Id { get; set; }

        //Средний балл
        public string MediumPoints { get; set; }

        //Нужно ли общежитие абитуриенту
        public bool CheckDormitor { get; set; }

        public DateTime? DateCreate { get; set; }

        public Profession Professions { get; set; }

        public ApplicationUser Users { get; set; }
    }
}