//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IAppServiceLib
{
    using System;
    using System.Collections.Generic;
    
    public partial class PersonalInfo
    {
        public PersonalInfo()
        {
            this.Applications = new HashSet<Application>();
        }
    
        public int applicantId { get; set; }
        public string firstName { get; set; }
        public string middleName { get; set; }
        public string lastName { get; set; }
        public string socialNum { get; set; }
        public string address { get; set; }
        public string Phone { get; set; }
        public string alias { get; set; }
    
        public virtual ICollection<Application> Applications { get; set; }
        public virtual Education Education { get; set; }
        public virtual ElectronicSig ElectronicSig { get; set; }
        public virtual JobHistory JobHistory { get; set; }
        public virtual Reference Reference { get; set; }
    }
}