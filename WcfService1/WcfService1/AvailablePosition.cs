//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WcfService1
{
    using System;
    using System.Collections.Generic;
    
    public partial class AvailablePosition
    {
        public AvailablePosition()
        {
            this.Applications = new HashSet<Application>();
        }
    
        public int availablePosId { get; set; }
        public int storeId { get; set; }
        public int positionId { get; set; }
        public string workingDays { get; set; }
    
        public virtual ICollection<Application> Applications { get; set; }
        public virtual Position Position { get; set; }
        public virtual Store Store { get; set; }
    }
}
