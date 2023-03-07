using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations; // Add to project

namespace ObakengStudyGroup.Models
{
    public class PeopleClass
    {
        [Display(Name = "STUDENT NUMBER")] //Add as decorator
        public string StudentNumber { get; set; }

        [Display(Name = "NAME")] //Add as decorator
        public string Name { get; set; }

        [Display(Name = "SURNAME ")] //Add as decorator
        public string Surname { get; set; }

        [Display(Name = "EMAIL ADDRESS")] //Add as decorator
        public string EmailAddress { get; set; }
      

    }
}