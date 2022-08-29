using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace webapp.Models
{
    public class Formulario
    {
        [Display(Name = "First Name",Prompt = "enter first name")]
        public string? FirstName {get; set; }
        [Display(Name = "Last Name", Prompt = "enter last name")]
        public string? LastName {get; set; }
        [Display(Name = "Job Title", Prompt = "enter your job title")]
        public string? JobTitle {get; set; }
       
        [Display(Name = "Highest level of education")]
        public int? HighestLevelOfEducation {get; set; }
        [Display(Name = "Sex")]
        public int? Sex {get; set; }
        [Display(Name = "Experience")]
        public int? Experience {get; set; }
         [Display(Name = "Date")]
        public string? Date {get; set; }
    }
}