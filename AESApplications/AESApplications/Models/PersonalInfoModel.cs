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
        [StringLength(60)]
        [Display(Name = "First Name")]
        public string name_first { get; set; }

        [Required]
        [StringLength(1)]
        [Display(Name = "Middle Initial")]
        public string name_middle { get; set; }

        [Required]
        [StringLength(60)]
        [Display(Name = "Last Name")]
        public string name_last { get; set; }
        
        [StringLength(60)]
        [Display(Name = "Alternate Name (Optional)")]
        public string name_alt { get; set; }

        [Required]
        [RegularExpression(@"\d{1,6}( *\s[a-zA-Z.]{2,30})*", ErrorMessage = "Address must begin with a number followed by street")]
        [Display(Name = "Street Address")]
        public string street { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "City")]
        public string city { get; set; }

        [Required]
        [StringLength(2)]
        [Display(Name = "State")]
        public string state { get; set; }

        [Required]
        [RegularExpression(@"\d{5}", ErrorMessage = "Invalid zip code. Ex: 45334")]
        [Display(Name = "Zipcode")]
        [DataType(DataType.PostalCode)]
        public string zip { get; set; }

        [Required]
        [Display(Name = "Phone")]
        [RegularExpression(@"^(\d{1})?-?(\d{3})?-?\d{3}-\d{4}$", ErrorMessage = "Invalid phone number Ex: 123-456-7890")]
        [DataType(DataType.PhoneNumber)]
        public string phone_num { get; set; }

        [Required]
        [Display(Name = "SSN#")]
        [RegularExpression(@"^\d{3}-\d{2}-\d{4}$", ErrorMessage = "Invalid SSN, must match form XXX-XX-XXXX")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:###-##-####}")]
        public string ssn { get; set; }
    }
}