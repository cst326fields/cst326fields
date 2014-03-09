using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AESApplications.Models
{
    public class EducationModel
    {
        [Display(Name = "Name and address of school")]
        public string name_address { get; set; }
        [Display(Name = "Years attended")]
        public string years_attended { get; set; }
        [Display(Name = "Graduated(y/n)")]
        public string graduated { get; set; }
        [Display(Name = "Degree/Major")]
        public string degree { get; set; }
    }
}