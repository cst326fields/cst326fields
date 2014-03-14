using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AESApplications.Models
{
    public class JobModel
    {
        public int jobId { get; set; }
        public string location { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string hours { get; set; }
        public string education { get; set; }
        public string requirements { get; set; }
    }
}