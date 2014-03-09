using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AESApplications.Models
{
    public class JobHistoryModel
    {
        [Display(Name = "Employer")]
        public string employer { get; set; }
        [Display(Name = "Street address")]
        public string street { get; set; }
        [Display(Name = "City")]
        public string city { get; set; }
        [Display(Name = "State")]
        public string state { get; set; }
        [Display(Name = "Zip code")]
        public string zip { get; set; }
        [Display(Name = "Position")]
        public string position { get; set; }
        [Display(Name = "From mo/yr")]
        public string from_month { get; set; }
        public string from_year { get; set; }
        [Display(Name = "To mo/yr")]
        public string to_month { get; set; }
        public string to_year { get; set; }
        [Display(Name = "Phone")]
        public string phone { get; set; }
        [Display(Name = "Supervisor")]
        public string supervisor { get; set; }
        [Display(Name = "Starting salary")]
        public string salary_start { get; set; }
        [Display(Name = "Ending salary")]
        public string salary_end { get; set; }
        [Display(Name = "Reason for leaving")]
        public string reason_for_leaving { get; set; }
        [Display(Name = "Describe your responsibilities")]
        public string responsibilities { get; set; }

    }
}