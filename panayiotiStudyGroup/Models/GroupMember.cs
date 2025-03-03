using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace panayiotiStudyGroup.Models
{
	public class GroupMember
	{
        [Display(Name = "Student Number")]
        public string StudentNumber { get; set; }

        [Display(Name = "Name")]
        public string Name { get; set; }

        [Display(Name = "Surname")]
        public string Surname { get; set; }

        [Display(Name = "Email Address")]
        public string EmailAddress { get; set; }
    }
}