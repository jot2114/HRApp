using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRportal.Models
{
    public class Job
    {
        public string JobId { get; set; }
        public string JobPosition { get; set; }
        public string JobDescription { get; set; }
        public string JobRequirements { get; set; }
        public List<string> jobsList { get; set; }
    }
}
