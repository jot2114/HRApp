using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HRportal.Models
{
    public class JobVM
    {
        public Job job { get; set; }
        public List<SelectListItem> jobsList { get; set; }
    }
}