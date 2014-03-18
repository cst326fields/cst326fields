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
        [StringLength(30)]
        public string city { get; set; }
        [Display(Name = "State")]
        [StringLength(2)]
        public string state { get; set; }
        [RegularExpression(@"\d{5}", ErrorMessage = "Invalid zip code. Ex: 45334")]
        [Display(Name = "Zip code")]
        public string zip { get; set; }
        [Display(Name = "Position")]
        public string position { get; set; }
        [Display(Name = "From MM/YYYY")]
        [StringLength(2)]
        [RegularExpression(@"\d{2}", ErrorMessage = "Invalid month")]
        public string from_month { get; set; }
        [StringLength(4)]
        [RegularExpression(@"\d{4}", ErrorMessage = "Invalid year")]
        public string from_year { get; set; }
        [Display(Name = "To MM/YYYY")]
        [StringLength(2)]
        [RegularExpression(@"\d{2}", ErrorMessage = "Invalid month")]
        public string to_month { get; set; }
        [StringLength(4)]
        [RegularExpression(@"\d{4}", ErrorMessage = "Invalid year")]
        public string to_year { get; set; }
        [Display(Name = "Phone")]
        [DataType(DataType.PhoneNumber)]
        public string phone { get; set; }
        [Display(Name = "Supervisor")]
        [StringLength(50)]
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