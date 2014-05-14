using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Domain.Models
{
    public class Request
    {
        public Payload[] payload { get; set; }
        public int skip { get; set; }
        public int take { get; set; }
        public int totalRecords { get; set; }
    }
}