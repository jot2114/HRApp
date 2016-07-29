using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRportal.Models
{
    public class Resume
    {
        [Required(ErrorMessage = "Please enter your Name")]

        [DataType(DataType.Text)]
        [Display(Name = "Name*")]

        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter your Address")]
        public Address Address { get; set; }

        [Required(ErrorMessage = "Please enter your Phone number")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Please enter your Email-id")]
        public string EmailId { get; set; }

        [DisplayFormat(DataFormatString = "{0:d}")]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Please enter your DOB")]
        public DateTime Dob { get; set; }

        [Required(ErrorMessage = "Please enter your Education")]
        public Education education { get; set; }

        [Required(ErrorMessage = "Please enter your WorkHistory")]
        public WorkEx workHistory { get; set; }

        [Required(ErrorMessage = "Please enter the job that you are applying for")]
        public Job JobApplyingFor { get; set; }

        public Resume()
        {
            this.JobApplyingFor = new Job();
        }
    }
}
