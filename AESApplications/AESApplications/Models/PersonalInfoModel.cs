using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace AESApplications.Models
{
    public class PersonalInfoModel
    {
        [Required]
        [Display(Name = "First Name")]
        public string name_first { get; set; }

        [Required]
        [Display(Name = "Middle Initial")]
        public string name_middle { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string name_last { get; set; }

        [Display(Name = "Alternate Name (Optional)")]
        public string name_alt { get; set; }

        [Required]
        [Display(Name = "Street Address")]
        public string street { get; set; }

        [Required]
        [Display(Name = "City")]
        public string city { get; set; }

        [Required]
        [Display(Name = "State")]
        public string state { get; set; }

        [Required]
        [Display(Name = "Zipcode")]
        [DataType(DataType.PostalCode)]
        public int zip { get; set; }

        [Required]
        [Display(Name = "Phone")]
        [DataType(DataType.PhoneNumber)]
        public int phone_num { get; set; }

        [Required]
        [Display(Name = "SSN#")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:###-##-####}")]
        public int ssn { get; set; }
    }
}