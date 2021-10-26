using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IntroToFilterAuth.Models
{
    public class SignIn
    {
        [Required]
        [Display(Name="UserName")]
        public string UserName { get; set; }
        
        [Required]
        [Display(Name = "UserPwd")]
        [DataType(DataType.Password)]
        public string UserPwd { get; set; }
    }
}